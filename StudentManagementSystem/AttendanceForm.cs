using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AttendanceForm : Form
    {
        private DataTable dtAtt;
        private int attCounter = 1;

        public AttendanceForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadCourseCombo();
                LoadAttendance();
            }
        }

        private void LoadCourseCombo()
        {
            DataTable dt = DatabaseHelper.LoadTable(DatabaseHelper.CoursesFile, "Courses");
            cboCourse.Items.Clear();
            cboCourse.Items.Add("-- Select Course --");
            if (dt.Columns.Contains("CourseName"))
                foreach (DataRow row in dt.Rows)
                    cboCourse.Items.Add(row["CourseName"].ToString());
            cboCourse.SelectedIndex = 0;
        }

        private void LoadStudentCombo()
        {
            DataTable dt = DatabaseHelper.LoadTable(DatabaseHelper.StudentsFile, "Students");
            cboStudentID.Items.Clear();
            cboStudentID.Items.Add("-- Select Student --");
            if (dt.Columns.Contains("StudentID"))
                foreach (DataRow row in dt.Rows)
                    cboStudentID.Items.Add(row["StudentID"].ToString() + " - " + row["StudentName"].ToString());
            cboStudentID.SelectedIndex = 0;
        }

        private void LoadAttendance()
        {
            dtAtt = DatabaseHelper.LoadTable(DatabaseHelper.AttendanceFile, "Attendance");
            dgvAtt.DataSource = null;
            dgvAtt.DataSource = dtAtt;
            lblCount.Text = "Total Records: " + dtAtt.Rows.Count;
            if (dtAtt.Rows.Count > 0) attCounter = dtAtt.Rows.Count + 1;
            LoadStudentCombo();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Student!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCourse.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Course!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sid = cboStudentID.Text.Split('-')[0].Trim();

            // Check duplicate attendance for same date/student/course
            string dateStr = dtpDate.Value.ToString("yyyy-MM-dd");
            string course  = cboCourse.Text;
            DataRow[] dup  = dtAtt.Select(
                string.Format("StudentID='{0}' AND CourseID='{1}' AND Date='{2}'", sid, course, dateStr));
            if (dup.Length > 0)
            {
                MessageBox.Show("Attendance already marked for this student on this date!", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row    = dtAtt.NewRow();
            row["AttID"]   = "ATT" + attCounter.ToString("D4");
            row["StudentID"] = sid;
            row["CourseID"]  = cboCourse.Text;
            row["Date"]      = dateStr;
            row["Status"]    = cboStatus.Text;
            dtAtt.Rows.Add(row);
            attCounter++;

            DatabaseHelper.SaveTable(dtAtt, DatabaseHelper.AttendanceFile);
            MessageBox.Show(string.Format("Attendance marked!\nStudent: {0}\nStatus: {1}", sid, cboStatus.Text),
                "Marked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblCount.Text = "Total Records: " + dtAtt.Rows.Count;
            cboStudentID.SelectedIndex = 0;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvAtt.DataSource = dtAtt;
            lblCount.Text = "Total Records: " + dtAtt.Rows.Count;
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex <= 0)
            {
                MessageBox.Show("Select a student to view attendance!", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sid = cboStudentID.Text.Split('-')[0].Trim();
            DataView dv = new DataView(dtAtt);
            dv.RowFilter = "StudentID = '" + sid + "'";
            dgvAtt.DataSource = dv;
            lblCount.Text = "Records for " + sid + ": " + dv.Count;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboStudentID.SelectedIndex = 0;
            cboCourse.SelectedIndex    = 0;
            cboStatus.SelectedIndex    = 0;
            dtpDate.Value = System.DateTime.Now;
            dgvAtt.DataSource = dtAtt;
            lblCount.Text = "Total Records: " + dtAtt.Rows.Count;
        }
    }
}
