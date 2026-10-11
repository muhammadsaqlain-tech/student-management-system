using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class CourseForm : Form
    {
        private DataTable dtCourses;

        public CourseForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                LoadCourses();
        }

        private void LoadCourses()
        {
            dtCourses = DatabaseHelper.LoadTable(DatabaseHelper.CoursesFile, "Courses");
            dgvCourses.DataSource = null;
            dgvCourses.DataSource = dtCourses;
            lblCount.Text = "Total Courses: " + dtCourses.Rows.Count;
        }

        private void ClearFields()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtSubject.Clear();
            txtCredits.Clear();
            cboDept.SelectedIndex = -1;
            txtCourseID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text) || string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course ID and Course Name are required!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] found = dtCourses.Select("CourseID = '" + txtCourseID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length > 0)
            {
                MessageBox.Show("Course ID already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = dtCourses.NewRow();
            row["CourseID"]    = txtCourseID.Text.Trim();
            row["CourseName"]  = txtCourseName.Text.Trim();
            row["Subject"]     = txtSubject.Text.Trim();
            row["CreditHours"] = txtCredits.Text.Trim();
            row["Department"]  = cboDept.Text;
            dtCourses.Rows.Add(row);

            DatabaseHelper.SaveTable(dtCourses, DatabaseHelper.CoursesFile);
            MessageBox.Show("Course saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblCount.Text = "Total Courses: " + dtCourses.Rows.Count;
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Enter Course ID to update!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] found = dtCourses.Select("CourseID = '" + txtCourseID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length == 0)
            {
                MessageBox.Show("Course ID not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            found[0]["CourseName"]  = txtCourseName.Text.Trim();
            found[0]["Subject"]     = txtSubject.Text.Trim();
            found[0]["CreditHours"] = txtCredits.Text.Trim();
            found[0]["Department"]  = cboDept.Text;

            DatabaseHelper.SaveTable(dtCourses, DatabaseHelper.CoursesFile);
            MessageBox.Show("Course updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Enter Course ID to delete!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete Course: " + txtCourseID.Text.Trim() + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            DataRow[] found = dtCourses.Select("CourseID = '" + txtCourseID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length == 0)
            {
                MessageBox.Show("Course not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            found[0].Delete();
            DatabaseHelper.SaveTable(dtCourses, DatabaseHelper.CoursesFile);
            MessageBox.Show("Course deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCourses();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgvCourses.Rows[e.RowIndex];
                txtCourseID.Text   = row.Cells["CourseID"].Value?.ToString()    ?? "";
                txtCourseName.Text = row.Cells["CourseName"].Value?.ToString()  ?? "";
                txtSubject.Text    = row.Cells["Subject"].Value?.ToString()     ?? "";
                txtCredits.Text    = row.Cells["CreditHours"].Value?.ToString() ?? "";
                int idx = cboDept.Items.IndexOf(row.Cells["Department"].Value?.ToString() ?? "");
                cboDept.SelectedIndex = idx >= 0 ? idx : -1;
            }
            catch { }
        }
    }
}
