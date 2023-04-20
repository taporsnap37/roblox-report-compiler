import tkinter as tk

import asyncpg

load_dotenv(".env")
DB_IP = os.getenv("DB_IP")
DB_USER = os.getenv("DB_USER")
DB_PWD = os.getenv("DB_PWD")


class Database(commands.Cog):
    """
    fuzzy matching postgresql query:

    SELECT * FROM {self.table} WHERE $1 % ANY(STRING_TO_ARRAY(name,'')) LIMIT 25

    When do you use fuzzy matching:
        I want shit that matches this but not exactly

    normal:
        if you want an exact thing.
    """

    pool: asyncpg.pool.Pool = None

    def __init__(self, app: tk.App):
        self.app: tk.App = app
        self.json_keys = ["welcome_settings", "goodbye_settings", "extra_entries"]
        self.cached_guild_settings = {}

    @staticmethod
    async def get_pool():
        kwargs = {
            "host": DB_IP,
            "port": 5432,
            "user": DB_USER,
            "password": DB_PWD,
            "min_size": 3,
            "max_size": 10,
            "command_timeout": 60,
            "loop": asyncio.get_event_loop()
        }
        return await asyncpg.create_pool(**kwargs)

    async def cog_load(self):
        self.app.logger.info('Initializing database connection...')
        Database.pool = await self.get_pool()
        self.app.logger.info('Database connection initialized.')

    async def cog_unload(self):
        await Database.pool.close()
        self.app.logger.info('Database connection closed.')

    def format_json(self, record: asyncpg.Record) -> dict:
        if record is None:
            return None
        return {key: (json.loads(value) if key in self.json_keys else value) for (key, value) in dict(record).items()}
