using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class MarksForm : Form
    {
        private DataTable dtMarks;
        private int markCounter = 1;

        public MarksForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadCourseCombo();
                LoadStudentCombo();
                LoadMarks();
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
            cboStudent.Items.Clear();
            cboStudent.Items.Add("-- Select Student --");
            if (dt.Columns.Contains("StudentID"))
                foreach (DataRow row in dt.Rows)
                    cboStudent.Items.Add(row["StudentID"].ToString() + " - " + row["StudentName"].ToString());
            cboStudent.SelectedIndex = 0;
        }

        private void LoadMarks()
        {
            dtMarks = DatabaseHelper.LoadTable(DatabaseHelper.MarksFile, "Marks");
            dgvMarks.DataSource = null;
            dgvMarks.DataSource = dtMarks;
            lblCount.Text = "Total Records: " + dtMarks.Rows.Count;
            if (dtMarks.Rows.Count > 0) markCounter = dtMarks.Rows.Count + 1;
        }

        private string CalculateGrade(double total)
        {
            if (total >= 90) return "A+";
            if (total >= 85) return "A";
            if (total >= 80) return "A-";
            if (total >= 75) return "B+";
            if (total >= 70) return "B";
            if (total >= 65) return "B-";
            if (total >= 60) return "C+";
            if (total >= 55) return "C";
            if (total >= 50) return "D";
            return "F";
        }

        private void txtMid_TextChanged(object sender, EventArgs e)   { UpdateTotal(); }
        private void txtFinal_TextChanged(object sender, EventArgs e) { UpdateTotal(); }
        private void txtAssign_TextChanged(object sender, EventArgs e){ UpdateTotal(); }

        private void UpdateTotal()
        {
            double mid = 0, final = 0, assign = 0;
            double.TryParse(txtMid.Text,    out mid);
            double.TryParse(txtFinal.Text,  out final);
            double.TryParse(txtAssign.Text, out assign);
            double total = mid + final + assign;
            lblTotal.Text = "Total: " + total.ToString("F1") + " / 100";
            lblGrade.Text = "Grade: " + CalculateGrade(total);

            System.Drawing.Color gc = total >= 70
                ? System.Drawing.Color.FromArgb(22, 145, 72)
                : total >= 50
                    ? System.Drawing.Color.FromArgb(195, 140, 10)
                    : System.Drawing.Color.FromArgb(210, 45, 45);
            lblGrade.ForeColor = gc;
            lblTotal.ForeColor = gc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudent.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Student!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCourse.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Course!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double mid = 0, final = 0, assign = 0;
            if (!double.TryParse(txtMid.Text, out mid) || mid < 0 || mid > 30)
            { MessageBox.Show("Mid Marks must be between 0 and 30!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!double.TryParse(txtFinal.Text, out final) || final < 0 || final > 50)
            { MessageBox.Show("Final Marks must be between 0 and 50!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!double.TryParse(txtAssign.Text, out assign) || assign < 0 || assign > 20)
            { MessageBox.Show("Assignment marks must be between 0 and 20!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string sid   = cboStudent.Text.Split('-')[0].Trim();
            double total = mid + final + assign;
            string grade = CalculateGrade(total);

            DataRow row     = dtMarks.NewRow();
            row["MarkID"]   = "MRK" + markCounter.ToString("D4");
            row["StudentID"]= sid;
            row["CourseID"] = cboCourse.Text;
            row["MidMarks"] = mid.ToString();
            row["FinalMarks"] = final.ToString();
            row["Assignment"] = assign.ToString();
            row["Total"]    = total.ToString("F1");
            row["Grade"]    = grade;
            dtMarks.Rows.Add(row);
            markCounter++;

            DatabaseHelper.SaveTable(dtMarks, DatabaseHelper.MarksFile);
            MessageBox.Show(string.Format("Marks saved!\nStudent: {0}\nTotal: {1}/100\nGrade: {2}",
                sid, total, grade), "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblCount.Text = "Total Records: " + dtMarks.Rows.Count;
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMarks.CurrentRow == null || dgvMarks.CurrentRow.Index < 0) return;
            if (MessageBox.Show("Delete selected marks record?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            string mid2 = dgvMarks.CurrentRow.Cells["MarkID"].Value?.ToString() ?? "";
            DataRow[] found = dtMarks.Select("MarkID = '" + mid2 + "'");
            if (found.Length > 0)
            {
                found[0].Delete();
                DatabaseHelper.SaveTable(dtMarks, DatabaseHelper.MarksFile);
                LoadMarks();
                MessageBox.Show("Record deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void ClearFields()
        {
            cboStudent.SelectedIndex = 0;
            cboCourse.SelectedIndex  = 0;
            txtMid.Clear();
            txtFinal.Clear();
            txtAssign.Clear();
            lblTotal.Text = "Total: 0 / 100";
            lblGrade.Text = "Grade: -";
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            lblGrade.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
        }
    }
}
