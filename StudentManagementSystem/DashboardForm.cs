using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm f = new StudentForm();
            f.MdiParent = null;
            f.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm f = new CourseForm();
            f.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm f = new AttendanceForm();
            f.Show();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            MarksForm f = new MarksForm();
            f.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultForm f = new ResultForm();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}
