using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ResultForm : Form
    {
        private DataTable dtResult;

        public ResultForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                LoadStudentCombo();
        }

        private void LoadStudentCombo()
        {
            DataTable dt = DatabaseHelper.LoadTable(DatabaseHelper.StudentsFile, "Students");
            cboStudent.Items.Clear();
            cboStudent.Items.Add("-- Select Student --");
            if (dt.Columns.Contains("StudentID"))
                foreach (DataRow row in dt.Rows)
                    cboStudent.Items.Add(row["StudentID"].ToString() + " - " + row["StudentName"].ToString());
            cboStudent.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cboStudent.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Student!", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sid = cboStudent.Text.Split('-')[0].Trim();

            // Load marks
            DataTable dtMarks = DatabaseHelper.LoadTable(DatabaseHelper.MarksFile, "Marks");
            DataView dv = new DataView(dtMarks);
            dv.RowFilter = "StudentID = '" + sid + "'";

            dtResult = dv.ToTable();
            dgvResult.DataSource = dtResult;

            // Load student info
            DataTable dtStud  = DatabaseHelper.LoadTable(DatabaseHelper.StudentsFile, "Students");
            DataRow[] srows   = dtStud.Select("StudentID = '" + sid + "'");
            string name       = srows.Length > 0 ? srows[0]["StudentName"]?.ToString() : "Unknown";
            string dept       = srows.Length > 0 ? srows[0]["Department"]?.ToString()  : "-";
            string father     = srows.Length > 0 ? srows[0]["FatherName"]?.ToString()  : "-";

            // Calculate GPA
            double totalSum = 0; int count = 0;
            foreach (DataRow row in dtResult.Rows)
            {
                double t = 0;
                double.TryParse(row["Total"]?.ToString(), out t);
                totalSum += t; count++;
            }
            double avg = count > 0 ? totalSum / count : 0;
            double gpa = Math.Round(avg / 25.0, 2);
            if (gpa > 4.0) gpa = 4.0;

            // Update UI labels
            lblStudentName.Text  = "Name:  " + name;
            lblStudentID.Text    = "ID:      " + sid;
            lblDept.Text         = "Dept:  " + dept;
            lblFather.Text       = "Father: " + father;
            lblCourseCount.Text  = "Courses Taken: " + count;
            lblAvg.Text          = string.Format("Average: {0:F1}%", avg);
            lblGPA.Text          = string.Format("GPA: {0:F2} / 4.0", gpa);
            lblOverall.Text      = "Grade: " + GetOverallGrade(avg);

            // Color coding
            Color gradeColor = avg >= 70
                ? Color.FromArgb(22, 145, 72)
                : avg >= 50
                    ? Color.FromArgb(195, 140, 10)
                    : Color.FromArgb(210, 45, 45);
            lblGPA.ForeColor     = gradeColor;
            lblOverall.ForeColor = gradeColor;
            lblAvg.ForeColor     = gradeColor;

            pnlResult.Visible = true;
            btnPrint.Enabled  = true;
        }

        private string GetOverallGrade(double avg)
        {
            if (avg >= 90) return "A+  (Outstanding)";
            if (avg >= 85) return "A   (Excellent)";
            if (avg >= 80) return "A-  (Very Good)";
            if (avg >= 75) return "B+  (Good)";
            if (avg >= 70) return "B   (Above Average)";
            if (avg >= 65) return "B-  (Average)";
            if (avg >= 60) return "C+  (Below Average)";
            if (avg >= 55) return "C   (Pass)";
            if (avg >= 50) return "D   (Marginal Pass)";
            return "F   (Fail)";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboStudent.SelectedIndex = 0;
            dgvResult.DataSource     = null;
            pnlResult.Visible        = false;
            btnPrint.Enabled         = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtResult == null || dtResult.Rows.Count == 0)
            {
                MessageBox.Show("Generate a result first!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.Width    = 850;
            ppd.Height   = 650;
            ppd.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont  = new Font("Segoe UI", 16f, FontStyle.Bold);
            Font headFont   = new Font("Segoe UI", 10f, FontStyle.Bold);
            Font bodyFont   = new Font("Segoe UI", 9.5f);
            Brush darkBlue  = new SolidBrush(Color.FromArgb(13, 47, 105));
            Brush black     = Brushes.Black;
            Brush gray      = new SolidBrush(Color.FromArgb(90, 100, 120));

            int x = 40, y = 30;

            // Title
            g.DrawString("STUDENT RESULT REPORT", titleFont, darkBlue, x, y); y += 35;
            g.DrawLine(new Pen(Color.FromArgb(13, 47, 105), 2), x, y, 740, y); y += 15;

            // Student info
            g.DrawString("Student: " + lblStudentName.Text.Replace("Name:  ", ""), headFont, black, x, y);
            g.DrawString(lblStudentID.Text, headFont, black, 400, y); y += 22;
            g.DrawString(lblDept.Text, bodyFont, gray, x, y);
            g.DrawString("Courses: " + lblCourseCount.Text.Replace("Courses Taken: ", ""), bodyFont, gray, 400, y); y += 30;

            g.DrawLine(Pens.LightGray, x, y, 740, y); y += 10;

            // Grid header
            int[] colWidths = { 80, 160, 60, 60, 65, 55, 55 };
            string[] headers = { "MarkID", "Course", "Mid", "Final", "Assign", "Total", "Grade" };
            int cx = x;
            for (int i = 0; i < headers.Length; i++)
            {
                g.FillRectangle(darkBlue, cx, y, colWidths[i], 24);
                g.DrawString(headers[i], headFont, Brushes.White, cx + 3, y + 4);
                cx += colWidths[i];
            }
            y += 24;

            // Grid rows
            bool alt = false;
            foreach (DataRow row in dtResult.Rows)
            {
                cx = x;
                Brush bg = alt ? new SolidBrush(Color.FromArgb(245, 248, 255)) : Brushes.White;
                g.FillRectangle(bg, cx, y, 535, 22);
                string[] vals = {
                    row["MarkID"]?.ToString()     ?? "",
                    row["CourseID"]?.ToString()   ?? "",
                    row["MidMarks"]?.ToString()   ?? "",
                    row["FinalMarks"]?.ToString() ?? "",
                    row["Assignment"]?.ToString() ?? "",
                    row["Total"]?.ToString()      ?? "",
                    row["Grade"]?.ToString()      ?? ""
                };
                for (int i = 0; i < vals.Length; i++)
                {
                    g.DrawString(vals[i], bodyFont, black, cx + 3, y + 3);
                    cx += colWidths[i];
                }
                g.DrawLine(Pens.LightGray, x, y + 22, x + 535, y + 22);
                y += 22; alt = !alt;
            }

            y += 20;
            g.DrawLine(new Pen(Color.FromArgb(13, 47, 105), 1.5f), x, y, 740, y); y += 15;

            // Summary
            g.DrawString(lblAvg.Text,     headFont, darkBlue, x,       y);
            g.DrawString(lblGPA.Text,     headFont, darkBlue, x + 200, y);
            g.DrawString(lblOverall.Text, headFont, darkBlue, x + 380, y); y += 30;

            g.DrawString("Printed: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"),
                new Font("Segoe UI", 8f), gray, x, y);
        }
    }
}
