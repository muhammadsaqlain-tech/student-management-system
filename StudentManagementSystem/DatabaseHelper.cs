using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public static class DatabaseHelper
    {
        private static string dataFolder = Application.StartupPath + "\\Data\\";

        public static string StudentsFile   => dataFolder + "students.xml";
        public static string CoursesFile    => dataFolder + "courses.xml";
        public static string AttendanceFile => dataFolder + "attendance.xml";
        public static string MarksFile      => dataFolder + "marks.xml";

        public static void Initialize()
        {
            if (!Directory.Exists(dataFolder))
                Directory.CreateDirectory(dataFolder);

            if (!File.Exists(StudentsFile))
            {
                DataTable dt = CreateStudentsTable();
                SaveTable(dt, StudentsFile);
            }
            if (!File.Exists(CoursesFile))
            {
                DataTable dt = CreateCoursesTable();
                SaveTable(dt, CoursesFile);
            }
            if (!File.Exists(AttendanceFile))
            {
                DataTable dt = CreateAttendanceTable();
                SaveTable(dt, AttendanceFile);
            }
            if (!File.Exists(MarksFile))
            {
                DataTable dt = CreateMarksTable();
                SaveTable(dt, MarksFile);
            }
        }

        public static DataTable CreateStudentsTable()
        {
            DataTable dt = new DataTable("Students");
            dt.Columns.Add("StudentID",   typeof(string));
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("FatherName",  typeof(string));
            dt.Columns.Add("Email",       typeof(string));
            dt.Columns.Add("Phone",       typeof(string));
            dt.Columns.Add("Address",     typeof(string));
            dt.Columns.Add("Department",  typeof(string));
            return dt;
        }

        public static DataTable CreateCoursesTable()
        {
            DataTable dt = new DataTable("Courses");
            dt.Columns.Add("CourseID",    typeof(string));
            dt.Columns.Add("CourseName",  typeof(string));
            dt.Columns.Add("Subject",     typeof(string));
            dt.Columns.Add("CreditHours", typeof(string));
            dt.Columns.Add("Department",  typeof(string));
            return dt;
        }

        public static DataTable CreateAttendanceTable()
        {
            DataTable dt = new DataTable("Attendance");
            dt.Columns.Add("AttID",     typeof(string));
            dt.Columns.Add("StudentID", typeof(string));
            dt.Columns.Add("CourseID",  typeof(string));
            dt.Columns.Add("Date",      typeof(string));
            dt.Columns.Add("Status",    typeof(string));
            return dt;
        }

        public static DataTable CreateMarksTable()
        {
            DataTable dt = new DataTable("Marks");
            dt.Columns.Add("MarkID",     typeof(string));
            dt.Columns.Add("StudentID",  typeof(string));
            dt.Columns.Add("CourseID",   typeof(string));
            dt.Columns.Add("MidMarks",   typeof(string));
            dt.Columns.Add("FinalMarks", typeof(string));
            dt.Columns.Add("Assignment", typeof(string));
            dt.Columns.Add("Total",      typeof(string));
            dt.Columns.Add("Grade",      typeof(string));
            return dt;
        }

        public static DataTable LoadTable(string filePath, string tableName)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    switch (tableName)
                    {
                        case "Students":   return CreateStudentsTable();
                        case "Courses":    return CreateCoursesTable();
                        case "Attendance": return CreateAttendanceTable();
                        case "Marks":      return CreateMarksTable();
                        default:           return new DataTable(tableName);
                    }
                }
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0].Copy();
                    dt.TableName = tableName;
                    return dt;
                }
            }
            catch { }

            switch (tableName)
            {
                case "Students":   return CreateStudentsTable();
                case "Courses":    return CreateCoursesTable();
                case "Attendance": return CreateAttendanceTable();
                case "Marks":      return CreateMarksTable();
                default:           return new DataTable(tableName);
            }
        }

        public static void SaveTable(DataTable table, string filePath)
        {
            try
            {
                string dir = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                DataSet ds = new DataSet("DataSet");
                ds.Tables.Add(table.Copy());
                ds.WriteXml(filePath, XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
