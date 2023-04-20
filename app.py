import tkinter as tk
from tkinter import ttk

from windows import create_report, view_reports

class App(tk.Tk):
    def __init__(self, debug: bool = False) -> None:
        super().__init__()

        self._debug = debug
        self.title('Main Window')
        self.geometry("350x250")

        ttk.Button(self, text="View Reports", command=self.view_reports_btn_callback).place(relx=0.2, rely=0.6, anchor="center", relwidth=0.3)
        ttk.Button(self, text="Close", command=self.destroy).place(relx=0.5, rely=0.6, anchor="center", relwidth=0.2)
        ttk.Button(self, text="Create Report", command=self.create_report_btn_callback).place(relx=0.8, rely=0.6, anchor="center", relwidth=0.3)

        ttk.Label(self, text="Welcome!", font=('Helvetica', 25)).place(relx=0.5, rely=0.3, anchor="center")

        if self._debug:
            self.display_all_windows()

    def view_reports_btn_callback(self) -> None:
        window = view_reports.ViewReportsWindow(self)
        self.withdraw()
        window.grab_set()

    def create_report_btn_callback(self) -> None:
        window = create_report.CreateReportWindow(self)
        self.withdraw()
        window.grab_set()

    def display_all_windows(self):
        view_reports.ViewReportsWindow(self)
        create_report.CreateReportWindow(self)