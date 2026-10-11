namespace StudentManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Panel pnlMarks;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Label lblStudDesc;
        private System.Windows.Forms.Label lblCourDesc;
        private System.Windows.Forms.Label lblAttDesc;
        private System.Windows.Forms.Label lblMarkDesc;
        private System.Windows.Forms.Label lblResDesc;
        private System.Windows.Forms.Label lblLogDesc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.stripe1 = new System.Windows.Forms.Panel();
            this.btnStudents = new System.Windows.Forms.Button();
            this.lblStudDesc = new System.Windows.Forms.Label();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.stripe2 = new System.Windows.Forms.Panel();
            this.btnCourses = new System.Windows.Forms.Button();
            this.lblCourDesc = new System.Windows.Forms.Label();
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.stripe3 = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.lblAttDesc = new System.Windows.Forms.Label();
            this.pnlMarks = new System.Windows.Forms.Panel();
            this.stripe4 = new System.Windows.Forms.Panel();
            this.btnMarks = new System.Windows.Forms.Button();
            this.lblMarkDesc = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.stripe5 = new System.Windows.Forms.Panel();
            this.btnResults = new System.Windows.Forms.Button();
            this.lblResDesc = new System.Windows.Forms.Label();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.stripe6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogDesc = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            this.pnlAttendance.SuspendLayout();
            this.pnlMarks.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(838, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(581, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Management System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.lblWelcome.Location = new System.Drawing.Point(27, 52);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(330, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Admin  |  Main Dashboard";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.lblMenuTitle);
            this.pnlContent.Controls.Add(this.pnlStudents);
            this.pnlContent.Controls.Add(this.pnlCourses);
            this.pnlContent.Controls.Add(this.pnlAttendance);
            this.pnlContent.Controls.Add(this.pnlMarks);
            this.pnlContent.Controls.Add(this.pnlResults);
            this.pnlContent.Controls.Add(this.pnlLogout);
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(860, 580);
            this.pnlContent.TabIndex = 1;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(35, 22);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(172, 25);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "SELECT A MODULE";
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.White;
            this.pnlStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudents.Controls.Add(this.stripe1);
            this.pnlStudents.Controls.Add(this.btnStudents);
            this.pnlStudents.Controls.Add(this.lblStudDesc);
            this.pnlStudents.Location = new System.Drawing.Point(35, 50);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(240, 130);
            this.pnlStudents.TabIndex = 1;
            // 
            // stripe1
            // 
            this.stripe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.stripe1.Location = new System.Drawing.Point(0, 0);
            this.stripe1.Name = "stripe1";
            this.stripe1.Size = new System.Drawing.Size(240, 8);
            this.stripe1.TabIndex = 0;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.White;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnStudents.Location = new System.Drawing.Point(0, 8);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(238, 72);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // lblStudDesc
            // 
            this.lblStudDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStudDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblStudDesc.Location = new System.Drawing.Point(15, 88);
            this.lblStudDesc.Name = "lblStudDesc";
            this.lblStudDesc.Size = new System.Drawing.Size(220, 30);
            this.lblStudDesc.TabIndex = 2;
            this.lblStudDesc.Text = "Add, edit, delete & search students";
            // 
            // pnlCourses
            // 
            this.pnlCourses.BackColor = System.Drawing.Color.White;
            this.pnlCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCourses.Controls.Add(this.stripe2);
            this.pnlCourses.Controls.Add(this.btnCourses);
            this.pnlCourses.Controls.Add(this.lblCourDesc);
            this.pnlCourses.Location = new System.Drawing.Point(305, 50);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(240, 130);
            this.pnlCourses.TabIndex = 2;
            // 
            // stripe2
            // 
            this.stripe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.stripe2.Location = new System.Drawing.Point(0, 0);
            this.stripe2.Name = "stripe2";
            this.stripe2.Size = new System.Drawing.Size(240, 8);
            this.stripe2.TabIndex = 0;
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.White;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.btnCourses.Location = new System.Drawing.Point(0, 8);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(238, 72);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // lblCourDesc
            // 
            this.lblCourDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCourDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblCourDesc.Location = new System.Drawing.Point(15, 88);
            this.lblCourDesc.Name = "lblCourDesc";
            this.lblCourDesc.Size = new System.Drawing.Size(220, 30);
            this.lblCourDesc.TabIndex = 2;
            this.lblCourDesc.Text = "Add courses, subjects & credit hours";
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.BackColor = System.Drawing.Color.White;
            this.pnlAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAttendance.Controls.Add(this.stripe3);
            this.pnlAttendance.Controls.Add(this.btnAttendance);
            this.pnlAttendance.Controls.Add(this.lblAttDesc);
            this.pnlAttendance.Location = new System.Drawing.Point(575, 50);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(240, 130);
            this.pnlAttendance.TabIndex = 3;
            // 
            // stripe3
            // 
            this.stripe3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(95)))), ((int)(((byte)(15)))));
            this.stripe3.Location = new System.Drawing.Point(0, 0);
            this.stripe3.Name = "stripe3";
            this.stripe3.Size = new System.Drawing.Size(240, 8);
            this.stripe3.TabIndex = 0;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.White;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(95)))), ((int)(((byte)(15)))));
            this.btnAttendance.Location = new System.Drawing.Point(0, 8);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(238, 72);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // lblAttDesc
            // 
            this.lblAttDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAttDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblAttDesc.Location = new System.Drawing.Point(15, 88);
            this.lblAttDesc.Name = "lblAttDesc";
            this.lblAttDesc.Size = new System.Drawing.Size(220, 30);
            this.lblAttDesc.TabIndex = 2;
            this.lblAttDesc.Text = "Record daily student attendance";
            // 
            // pnlMarks
            // 
            this.pnlMarks.BackColor = System.Drawing.Color.White;
            this.pnlMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarks.Controls.Add(this.stripe4);
            this.pnlMarks.Controls.Add(this.btnMarks);
            this.pnlMarks.Controls.Add(this.lblMarkDesc);
            this.pnlMarks.Location = new System.Drawing.Point(35, 205);
            this.pnlMarks.Name = "pnlMarks";
            this.pnlMarks.Size = new System.Drawing.Size(240, 130);
            this.pnlMarks.TabIndex = 4;
            // 
            // stripe4
            // 
            this.stripe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(175)))));
            this.stripe4.Location = new System.Drawing.Point(0, 0);
            this.stripe4.Name = "stripe4";
            this.stripe4.Size = new System.Drawing.Size(240, 8);
            this.stripe4.TabIndex = 0;
            // 
            // btnMarks
            // 
            this.btnMarks.BackColor = System.Drawing.Color.White;
            this.btnMarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarks.FlatAppearance.BorderSize = 0;
            this.btnMarks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(175)))));
            this.btnMarks.Location = new System.Drawing.Point(0, 8);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMarks.Size = new System.Drawing.Size(238, 72);
            this.btnMarks.TabIndex = 1;
            this.btnMarks.Text = "Enter Marks";
            this.btnMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarks.UseVisualStyleBackColor = false;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // lblMarkDesc
            // 
            this.lblMarkDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMarkDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblMarkDesc.Location = new System.Drawing.Point(15, 88);
            this.lblMarkDesc.Name = "lblMarkDesc";
            this.lblMarkDesc.Size = new System.Drawing.Size(220, 30);
            this.lblMarkDesc.TabIndex = 2;
            this.lblMarkDesc.Text = "Enter mid, final & assignment marks";
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.White;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.stripe5);
            this.pnlResults.Controls.Add(this.btnResults);
            this.pnlResults.Controls.Add(this.lblResDesc);
            this.pnlResults.Location = new System.Drawing.Point(305, 205);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(240, 130);
            this.pnlResults.TabIndex = 5;
            // 
            // stripe5
            // 
            this.stripe5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.stripe5.Location = new System.Drawing.Point(0, 0);
            this.stripe5.Name = "stripe5";
            this.stripe5.Size = new System.Drawing.Size(240, 8);
            this.stripe5.TabIndex = 0;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.White;
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnResults.Location = new System.Drawing.Point(0, 8);
            this.btnResults.Name = "btnResults";
            this.btnResults.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnResults.Size = new System.Drawing.Size(238, 72);
            this.btnResults.TabIndex = 1;
            this.btnResults.Text = "Generate Results";
            this.btnResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lblResDesc
            // 
            this.lblResDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblResDesc.Location = new System.Drawing.Point(15, 88);
            this.lblResDesc.Name = "lblResDesc";
            this.lblResDesc.Size = new System.Drawing.Size(220, 30);
            this.lblResDesc.TabIndex = 2;
            this.lblResDesc.Text = "View & print student result reports";
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.White;
            this.pnlLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogout.Controls.Add(this.stripe6);
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Controls.Add(this.lblLogDesc);
            this.pnlLogout.Location = new System.Drawing.Point(575, 205);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(240, 130);
            this.pnlLogout.TabIndex = 6;
            // 
            // stripe6
            // 
            this.stripe6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.stripe6.Location = new System.Drawing.Point(0, 0);
            this.stripe6.Name = "stripe6";
            this.stripe6.Size = new System.Drawing.Size(240, 8);
            this.stripe6.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(238, 72);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogDesc
            // 
            this.lblLogDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLogDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.lblLogDesc.Location = new System.Drawing.Point(15, 88);
            this.lblLogDesc.Name = "lblLogDesc";
            this.lblLogDesc.Size = new System.Drawing.Size(220, 30);
            this.lblLogDesc.TabIndex = 2;
            this.lblLogDesc.Text = "Sign out from the system securely";
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(838, 604);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(860, 660);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System – Dashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlCourses.ResumeLayout(false);
            this.pnlAttendance.ResumeLayout(false);
            this.pnlMarks.ResumeLayout(false);
            this.pnlResults.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel stripe1;
        private System.Windows.Forms.Panel stripe2;
        private System.Windows.Forms.Panel stripe3;
        private System.Windows.Forms.Panel stripe4;
        private System.Windows.Forms.Panel stripe5;
        private System.Windows.Forms.Panel stripe6;
    }
}
