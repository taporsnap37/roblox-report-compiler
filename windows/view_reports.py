from __future__ import annotations
from typing import TYPE_CHECKING

if TYPE_CHECKING:
    from app import App

import tkinter as tk
from tkinter import ttk

class ViewReportsWindow(tk.Toplevel):
    def __init__(self, parent: App) -> None:
        super().__init__(parent)

        self.parent = parent

        self.geometry('500x500')
        self.title('View Reports')

        self._reports_frame = tk.Frame(self, background='#505050', width='500', height='400').pack(expand=True, side="top")
        ttk.Button(self, text="Close", command=self.btn_close_callback).place(relx=0.5, rely=0.95, anchor="center", relwidth=0.3)

    def btn_close_callback(self):
        self.parent.deiconify()
        self.destroy()
