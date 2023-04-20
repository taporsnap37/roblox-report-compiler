from __future__ import annotations

from typing import TYPE_CHECKING

if TYPE_CHECKING:
    from app import App

import tkinter as tk
from tkinter import ttk


class CreateReportWindow(tk.Toplevel):
    def __init__(self, parent: App) -> None:
        super().__init__(parent)

        self.parent = parent

        self.geometry('500x500')
        self.title('Create Report')

        ttk.Button(self, text="Close", command=self.btn_close_callback).pack(expand=True)

        ttk.Label(self, text="ID:").pack(expand=True)
        ttk.Entry(self).pack(expand=True)
        ttk.Label(self, text="Exploits:").pack(expand=True)
        ttk.Entry(self).pack(expand=True)
        ttk.Label(self, text="Clip:").pack(expand=True)
        ttk.Entry(self).pack(expand=True)

        # labels:
        # ID: - The user ID (use regex to grab from the URL which will be provided)
        # Exploits: - This will be a custom text that is entered by user
        # Clip: - This will most likely be a file (video)

    def btn_close_callback(self):
        self.parent.deiconify()
        self.destroy()
