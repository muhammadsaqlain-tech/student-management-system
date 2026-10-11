using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentForm : Form
    {
        private DataTable dtStudents;

        public StudentForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                LoadStudents();
        }

        private void LoadStudents()
        {
            dtStudents = DatabaseHelper.LoadTable(DatabaseHelper.StudentsFile, "Students");
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = dtStudents;
            StyleGrid();
            lblCount.Text = "Total Records: " + dtStudents.Rows.Count;
        }

        private void StyleGrid()
        {
            if (dgvStudents.Columns.Count == 0) return;
            foreach (DataGridViewColumn col in dgvStudents.Columns)
                col.MinimumWidth = 90;
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboDept.SelectedIndex = -1;
            txtSearch.Clear();
            dgvStudents.DataSource = dtStudents;
            lblCount.Text = "Total Records: " + dtStudents.Rows.Count;
            txtID.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Student ID is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Student Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataRow[] found = dtStudents.Select("StudentID = '" + txtID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length > 0)
            {
                MessageBox.Show("Student ID already exists! Use Update to modify.", "Duplicate ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row    = dtStudents.NewRow();
            row["StudentID"]   = txtID.Text.Trim();
            row["StudentName"] = txtName.Text.Trim();
            row["FatherName"]  = txtFather.Text.Trim();
            row["Email"]       = txtEmail.Text.Trim();
            row["Phone"]       = txtPhone.Text.Trim();
            row["Address"]     = txtAddress.Text.Trim();
            row["Department"]  = cboDept.Text;
            dtStudents.Rows.Add(row);

            DatabaseHelper.SaveTable(dtStudents, DatabaseHelper.StudentsFile);
            MessageBox.Show("Student saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataRow[] found = dtStudents.Select("StudentID = '" + txtID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length == 0)
            {
                MessageBox.Show("Student ID not found! Save first or check the ID.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            found[0]["StudentName"] = txtName.Text.Trim();
            found[0]["FatherName"]  = txtFather.Text.Trim();
            found[0]["Email"]       = txtEmail.Text.Trim();
            found[0]["Phone"]       = txtPhone.Text.Trim();
            found[0]["Address"]     = txtAddress.Text.Trim();
            found[0]["Department"]  = cboDept.Text;

            DatabaseHelper.SaveTable(dtStudents, DatabaseHelper.StudentsFile);
            MessageBox.Show("Student updated successfully!", "Updated",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter or select a Student ID to delete.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete Student ID: " + txtID.Text.Trim() + "?\nThis action cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            DataRow[] found = dtStudents.Select("StudentID = '" + txtID.Text.Trim().Replace("'", "''") + "'");
            if (found.Length == 0)
            {
                MessageBox.Show("Student ID not found!", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            found[0].Delete();
            DatabaseHelper.SaveTable(dtStudents, DatabaseHelper.StudentsFile);
            MessageBox.Show("Student deleted successfully!", "Deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudents();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();
            MessageBox.Show("Data loaded successfully! Total: " + dtStudents.Rows.Count + " records.",
                "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvStudents.DataSource = dtStudents;
                lblCount.Text = "Total Records: " + dtStudents.Rows.Count;
                return;
            }

            DataView dv = new DataView(dtStudents);
            dv.RowFilter = string.Format(
                "StudentID LIKE '%{0}%' OR StudentName LIKE '%{0}%' OR Department LIKE '%{0}%'",
                keyword);
            dgvStudents.DataSource = dv;
            lblCount.Text = "Search Results: " + dv.Count;

            if (dv.Count == 0)
                MessageBox.Show("No records found for: " + txtSearch.Text.Trim(), "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtID.Text      = row.Cells["StudentID"].Value?.ToString()   ?? "";
                txtName.Text    = row.Cells["StudentName"].Value?.ToString() ?? "";
                txtFather.Text  = row.Cells["FatherName"].Value?.ToString()  ?? "";
                txtEmail.Text   = row.Cells["Email"].Value?.ToString()       ?? "";
                txtPhone.Text   = row.Cells["Phone"].Value?.ToString()       ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString()     ?? "";
                string dept     = row.Cells["Department"].Value?.ToString()  ?? "";
                int idx         = cboDept.Items.IndexOf(dept);
                cboDept.SelectedIndex = idx >= 0 ? idx : -1;
            }
            catch { }
        }
    }
}
