from __future__ import annotations

from typing import TYPE_CHECKING, Dict, List, Any

if TYPE_CHECKING:
    from app import App

import tkinter as tk
from tkinter import ttk


class ViewReportsWindow(tk.Toplevel):
    def __init__(self, parent: App) -> None:
        super().__init__(parent)
        self.geometry('500x500')
        self.title('View Reports')

        self.parent = parent

        self.curr_page = 0
        self.available_reports: List[Dict[str, Any]] = []
        self.reports_per_page = 10
        self.report_buttons: List[tk.Button] = []
        self.expanded_report: int = -1

        ttk.Button(self, text="Close", command=self.btn_close_callback) \
            .place(relx=0.5, rely=0.95, anchor="center", relwidth=0.3)
        ttk.Button(self, text=">", command=self.btn_next_callback) \
            .place(relx=0.8, rely=0.95, anchor="center", relwidth=0.1)
        ttk.Button(self, text="<", command=self.btn_prev_callback) \
            .place(relx=0.2, rely=0.95, anchor="center", relwidth=0.1)

        self.retrieve_reports_from_db()
        self.display_reports()

    def btn_close_callback(self):
        self.parent.deiconify()
        self.destroy()

    def btn_next_callback(self):
        self.curr_page += 1
        self.display_reports()

    def btn_prev_callback(self):
        self.curr_page -= 1
        self.display_reports()

    def retrieve_reports_from_db(self):
        # Implement the logic to fetch the reports from the database here
        for i in range(100):
            self.available_reports.append({
                'id': i,
                'exploit': 'Exploit 1',
                'clip': 'path/to/clip'
            })

    def display_reports(self):
        start_index = self.curr_page * self.reports_per_page
        end_index = start_index + self.reports_per_page
        reports_to_display = self.available_reports[start_index:end_index]

        for btn in self.report_buttons:
            btn.destroy()

        self.report_buttons.clear()

        for i, report in enumerate(reports_to_display):
            btn = tk.Button(self, text=f"Report {report['id']} - {report['exploit']}",
                            command=lambda i=i: self.expand_retract_report(i))
            btn.place(relx=0.5, rely=0.1 + i * 0.08, anchor="center", relwidth=0.9, relheight=0.07)
            self.report_buttons.append(btn)

    def expand_retract_report(self, index: int):
        # Implement the logic to expand or retract the report and display the clip
        # You might need to use a library like OpenCV or Pillow to display the video or image
        pass
