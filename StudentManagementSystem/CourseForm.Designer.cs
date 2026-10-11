namespace StudentManagementSystem
{
    partial class CourseForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel       pnlHeader;
        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.Panel       pnlForm;
        private System.Windows.Forms.Label       lblCourseID;
        private System.Windows.Forms.Label       lblCourseName;
        private System.Windows.Forms.Label       lblSubject;
        private System.Windows.Forms.Label       lblCredits;
        private System.Windows.Forms.Label       lblDept;
        private System.Windows.Forms.TextBox     txtCourseID;
        private System.Windows.Forms.TextBox     txtCourseName;
        private System.Windows.Forms.TextBox     txtSubject;
        private System.Windows.Forms.TextBox     txtCredits;
        private System.Windows.Forms.ComboBox    cboDept;
        private System.Windows.Forms.Panel       pnlButtons;
        private System.Windows.Forms.Button      btnSave;
        private System.Windows.Forms.Button      btnUpdate;
        private System.Windows.Forms.Button      btnDelete;
        private System.Windows.Forms.Button      btnClear;
        private System.Windows.Forms.Panel       pnlGrid;
        private System.Windows.Forms.Label       lblCount;
        private System.Windows.Forms.DataGridView dgvCourses;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblTitle     = new System.Windows.Forms.Label();
            this.pnlForm      = new System.Windows.Forms.Panel();
            this.lblCourseID  = new System.Windows.Forms.Label();
            this.lblCourseName= new System.Windows.Forms.Label();
            this.lblSubject   = new System.Windows.Forms.Label();
            this.lblCredits   = new System.Windows.Forms.Label();
            this.lblDept      = new System.Windows.Forms.Label();
            this.txtCourseID  = new System.Windows.Forms.TextBox();
            this.txtCourseName= new System.Windows.Forms.TextBox();
            this.txtSubject   = new System.Windows.Forms.TextBox();
            this.txtCredits   = new System.Windows.Forms.TextBox();
            this.cboDept      = new System.Windows.Forms.ComboBox();
            this.pnlButtons   = new System.Windows.Forms.Panel();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnUpdate    = new System.Windows.Forms.Button();
            this.btnDelete    = new System.Windows.Forms.Button();
            this.btnClear     = new System.Windows.Forms.Button();
            this.pnlGrid      = new System.Windows.Forms.Panel();
            this.lblCount     = new System.Windows.Forms.Label();
            this.dgvCourses   = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            this.Text          = "Manage Courses & Subjects";
            this.Size          = new System.Drawing.Size(820, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5f);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(18, 140, 95);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 65;
            this.lblTitle.Text       = "Course & Subject Management";
            this.lblTitle.Font       = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor  = System.Drawing.Color.White;
            this.lblTitle.AutoSize   = true;
            this.lblTitle.Location   = new System.Drawing.Point(20, 18);

            this.pnlForm.BackColor   = System.Drawing.Color.White;
            this.pnlForm.Location    = new System.Drawing.Point(15, 80);
            this.pnlForm.Size        = new System.Drawing.Size(778, 230);
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var stripe = new System.Windows.Forms.Panel();
            stripe.BackColor = System.Drawing.Color.FromArgb(18, 140, 95);
            stripe.Location  = new System.Drawing.Point(0, 0);
            stripe.Size      = new System.Drawing.Size(778, 6);

            var lblFT = new System.Windows.Forms.Label();
            lblFT.Text      = "Course Information";
            lblFT.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            lblFT.ForeColor = System.Drawing.Color.FromArgb(18, 140, 95);
            lblFT.AutoSize  = true;
            lblFT.Location  = new System.Drawing.Point(15, 16);

            // Row 1
            this.lblCourseID.Text      = "Course ID :";
            this.lblCourseID.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblCourseID.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblCourseID.Location  = new System.Drawing.Point(15, 48);
            this.lblCourseID.AutoSize  = true;
            this.txtCourseID.Location    = new System.Drawing.Point(145, 45);
            this.txtCourseID.Size        = new System.Drawing.Size(200, 30);
            this.txtCourseID.Font        = new System.Drawing.Font("Segoe UI", 10f);
            this.txtCourseID.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtCourseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCourseName.Text      = "Course Name :";
            this.lblCourseName.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblCourseName.Location  = new System.Drawing.Point(405, 48);
            this.lblCourseName.AutoSize  = true;
            this.txtCourseName.Location    = new System.Drawing.Point(545, 45);
            this.txtCourseName.Size        = new System.Drawing.Size(200, 30);
            this.txtCourseName.Font        = new System.Drawing.Font("Segoe UI", 10f);
            this.txtCourseName.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Row 2
            this.lblSubject.Text      = "Subject :";
            this.lblSubject.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblSubject.Location  = new System.Drawing.Point(15, 90);
            this.lblSubject.AutoSize  = true;
            this.txtSubject.Location    = new System.Drawing.Point(145, 87);
            this.txtSubject.Size        = new System.Drawing.Size(200, 30);
            this.txtSubject.Font        = new System.Drawing.Font("Segoe UI", 10f);
            this.txtSubject.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCredits.Text      = "Credit Hours :";
            this.lblCredits.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblCredits.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblCredits.Location  = new System.Drawing.Point(405, 90);
            this.lblCredits.AutoSize  = true;
            this.txtCredits.Location    = new System.Drawing.Point(545, 87);
            this.txtCredits.Size        = new System.Drawing.Size(200, 30);
            this.txtCredits.Font        = new System.Drawing.Font("Segoe UI", 10f);
            this.txtCredits.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Row 3
            this.lblDept.Text      = "Department :";
            this.lblDept.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblDept.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblDept.Location  = new System.Drawing.Point(15, 132);
            this.lblDept.AutoSize  = true;
            this.cboDept.Location      = new System.Drawing.Point(145, 129);
            this.cboDept.Size          = new System.Drawing.Size(200, 30);
            this.cboDept.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.cboDept.Items.AddRange(new object[] {
                "Computer Science", "Information Technology", "Software Engineering",
                "Electrical Engineering", "Mechanical Engineering", "Business Administration",
                "Mathematics", "Physics"
            });

            this.pnlForm.Controls.Add(stripe);
            this.pnlForm.Controls.Add(lblFT);
            this.pnlForm.Controls.Add(this.lblCourseID);   this.pnlForm.Controls.Add(this.txtCourseID);
            this.pnlForm.Controls.Add(this.lblCourseName); this.pnlForm.Controls.Add(this.txtCourseName);
            this.pnlForm.Controls.Add(this.lblSubject);    this.pnlForm.Controls.Add(this.txtSubject);
            this.pnlForm.Controls.Add(this.lblCredits);    this.pnlForm.Controls.Add(this.txtCredits);
            this.pnlForm.Controls.Add(this.lblDept);       this.pnlForm.Controls.Add(this.cboDept);

            // BUTTONS
            this.pnlButtons.BackColor   = System.Drawing.Color.White;
            this.pnlButtons.Location    = new System.Drawing.Point(15, 325);
            this.pnlButtons.Size        = new System.Drawing.Size(778, 62);
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnSave.Text      = "Save";
            this.btnSave.Location  = new System.Drawing.Point(15, 11);
            this.btnSave.Size      = new System.Drawing.Size(170, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(22, 145, 72);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click    += new System.EventHandler(this.btnSave_Click);

            this.btnUpdate.Text      = "Update";
            this.btnUpdate.Location  = new System.Drawing.Point(195, 11);
            this.btnUpdate.Size      = new System.Drawing.Size(170, 40);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(25, 100, 210);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click    += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text      = "Delete";
            this.btnDelete.Location  = new System.Drawing.Point(375, 11);
            this.btnDelete.Size      = new System.Drawing.Size(170, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(210, 45, 45);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnDelete.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click    += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text      = "Clear";
            this.btnClear.Location  = new System.Drawing.Point(555, 11);
            this.btnClear.Size      = new System.Drawing.Size(170, 40);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClear);

            // GRID
            this.pnlGrid.BackColor   = System.Drawing.Color.White;
            this.pnlGrid.Location    = new System.Drawing.Point(15, 400);
            this.pnlGrid.Size        = new System.Drawing.Size(778, 178);
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCount.Text      = "Total Courses: 0";
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(18, 140, 95);
            this.lblCount.Location  = new System.Drawing.Point(8, 5);
            this.lblCount.AutoSize  = true;

            this.dgvCourses.Location            = new System.Drawing.Point(0, 24);
            this.dgvCourses.Size                = new System.Drawing.Size(776, 152);
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.ReadOnly            = true;
            this.dgvCourses.AllowUserToAddRows  = false;
            this.dgvCourses.BackgroundColor     = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.RowHeadersWidth     = 25;
            this.dgvCourses.Font                = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvCourses.GridColor           = System.Drawing.Color.FromArgb(220, 225, 235);
            this.dgvCourses.RowTemplate.Height  = 26;
            this.dgvCourses.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 250, 245);
            this.dgvCourses.ColumnHeadersDefaultCellStyle.BackColor   = System.Drawing.Color.FromArgb(18, 140, 95);
            this.dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor   = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersDefaultCellStyle.Font        = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvCourses.ColumnHeadersHeight                       = 30;
            this.dgvCourses.EnableHeadersVisualStyles                 = false;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);

            this.pnlGrid.Controls.Add(this.lblCount);
            this.pnlGrid.Controls.Add(this.dgvCourses);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlGrid);

            this.pnlHeader.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
