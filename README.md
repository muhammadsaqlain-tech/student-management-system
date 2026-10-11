# Student Management System

A Windows desktop application for managing student records, built with C# and .NET Framework 4.8 (WinForms).

## Features

- Login with role-based access (demo: `admin` / `admin123`)
- Dashboard with navigation
- Student records (add, edit, delete, search)
- Course management and enrolment
- Marks entry and result reports
- Attendance tracking
- Tabular reports

## Storage

XML-based file storage (no database server required). Data files are created automatically in a `Data` folder next to the executable on first run.

## Requirements

- Windows
- .NET Framework 4.8
- Visual Studio (to build)

## How to run

1. Open `StudentManagementSystem.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run (F5)
4. Login with `admin` / `admin123`

## Project structure

- `LoginForm` — authentication
- `DashboardForm` — main navigation
- `StudentForm` — student CRUD
- `CourseForm` — course management
- `MarksForm` — marks entry
- `AttendanceForm` — attendance tracking
- `ResultForm` — result reports
- `DatabaseHelper` — XML data layer
