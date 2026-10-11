namespace StudentManagementSystem
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel        pnlHeader;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Panel        pnlForm;
        private System.Windows.Forms.Label        lblStudentID;
        private System.Windows.Forms.Label        lblCourse;
        private System.Windows.Forms.Label        lblDate;
        private System.Windows.Forms.Label        lblStatus;
        private System.Windows.Forms.ComboBox     cboStudentID;
        private System.Windows.Forms.ComboBox     cboCourse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox     cboStatus;
        private System.Windows.Forms.Panel        pnlButtons;
        private System.Windows.Forms.Button       btnMark;
        private System.Windows.Forms.Button       btnViewStudent;
        private System.Windows.Forms.Button       btnViewAll;
        private System.Windows.Forms.Button       btnClear;
        private System.Windows.Forms.Panel        pnlGrid;
        private System.Windows.Forms.Label        lblCount;
        private System.Windows.Forms.DataGridView dgvAtt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader     = new System.Windows.Forms.Panel();
            this.lblTitle      = new System.Windows.Forms.Label();
            this.pnlForm       = new System.Windows.Forms.Panel();
            this.lblStudentID  = new System.Windows.Forms.Label();
            this.lblCourse     = new System.Windows.Forms.Label();
            this.lblDate       = new System.Windows.Forms.Label();
            this.lblStatus     = new System.Windows.Forms.Label();
            this.cboStudentID  = new System.Windows.Forms.ComboBox();
            this.cboCourse     = new System.Windows.Forms.ComboBox();
            this.dtpDate       = new System.Windows.Forms.DateTimePicker();
            this.cboStatus     = new System.Windows.Forms.ComboBox();
            this.pnlButtons    = new System.Windows.Forms.Panel();
            this.btnMark       = new System.Windows.Forms.Button();
            this.btnViewStudent= new System.Windows.Forms.Button();
            this.btnViewAll    = new System.Windows.Forms.Button();
            this.btnClear      = new System.Windows.Forms.Button();
            this.pnlGrid       = new System.Windows.Forms.Panel();
            this.lblCount      = new System.Windows.Forms.Label();
            this.dgvAtt        = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            this.Text          = "Record Attendance";
            this.Size          = new System.Drawing.Size(820, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5f);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(195, 95, 15);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 65;
            this.lblTitle.Text       = "Attendance Management";
            this.lblTitle.Font       = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor  = System.Drawing.Color.White;
            this.lblTitle.AutoSize   = true;
            this.lblTitle.Location   = new System.Drawing.Point(20, 18);

            this.pnlForm.BackColor   = System.Drawing.Color.White;
            this.pnlForm.Location    = new System.Drawing.Point(15, 80);
            this.pnlForm.Size        = new System.Drawing.Size(778, 210);
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var stripe = new System.Windows.Forms.Panel();
            stripe.BackColor = System.Drawing.Color.FromArgb(195, 95, 15);
            stripe.Location  = new System.Drawing.Point(0, 0);
            stripe.Size      = new System.Drawing.Size(778, 6);

            var lblFT = new System.Windows.Forms.Label();
            lblFT.Text      = "Mark Attendance";
            lblFT.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            lblFT.ForeColor = System.Drawing.Color.FromArgb(195, 95, 15);
            lblFT.AutoSize  = true;
            lblFT.Location  = new System.Drawing.Point(15, 16);

            this.lblStudentID.Text      = "Select Student :";
            this.lblStudentID.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblStudentID.Location  = new System.Drawing.Point(15, 48);
            this.lblStudentID.AutoSize  = true;
            this.cboStudentID.Location      = new System.Drawing.Point(160, 45);
            this.cboStudentID.Size          = new System.Drawing.Size(215, 30);
            this.cboStudentID.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentID.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);

            this.lblDate.Text      = "Date :";
            this.lblDate.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblDate.Location  = new System.Drawing.Point(405, 48);
            this.lblDate.AutoSize  = true;
            this.dtpDate.Location = new System.Drawing.Point(545, 45);
            this.dtpDate.Size     = new System.Drawing.Size(215, 30);
            this.dtpDate.Font     = new System.Drawing.Font("Segoe UI", 10f);
            this.dtpDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblCourse.Text      = "Select Course :";
            this.lblCourse.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblCourse.Location  = new System.Drawing.Point(15, 90);
            this.lblCourse.AutoSize  = true;
            this.cboCourse.Location      = new System.Drawing.Point(160, 87);
            this.cboCourse.Size          = new System.Drawing.Size(215, 30);
            this.cboCourse.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);

            this.lblStatus.Text      = "Status :";
            this.lblStatus.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblStatus.Location  = new System.Drawing.Point(405, 90);
            this.lblStatus.AutoSize  = true;
            this.cboStatus.Location      = new System.Drawing.Point(545, 87);
            this.cboStatus.Size          = new System.Drawing.Size(215, 30);
            this.cboStatus.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.cboStatus.Items.AddRange(new object[] { "Present", "Absent", "Leave", "Late" });
            this.cboStatus.SelectedIndex = 0;

            this.pnlForm.Controls.Add(stripe);
            this.pnlForm.Controls.Add(lblFT);
            this.pnlForm.Controls.Add(this.lblStudentID);
            this.pnlForm.Controls.Add(this.cboStudentID);
            this.pnlForm.Controls.Add(this.lblDate);
            this.pnlForm.Controls.Add(this.dtpDate);
            this.pnlForm.Controls.Add(this.lblCourse);
            this.pnlForm.Controls.Add(this.cboCourse);
            this.pnlForm.Controls.Add(this.lblStatus);
            this.pnlForm.Controls.Add(this.cboStatus);

            this.pnlButtons.BackColor   = System.Drawing.Color.White;
            this.pnlButtons.Location    = new System.Drawing.Point(15, 305);
            this.pnlButtons.Size        = new System.Drawing.Size(778, 62);
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnMark.Text      = "Mark Attendance";
            this.btnMark.Location  = new System.Drawing.Point(15, 11);
            this.btnMark.Size      = new System.Drawing.Size(175, 40);
            this.btnMark.BackColor = System.Drawing.Color.FromArgb(195, 95, 15);
            this.btnMark.ForeColor = System.Drawing.Color.White;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.FlatAppearance.BorderSize = 0;
            this.btnMark.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnMark.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnMark.Click    += new System.EventHandler(this.btnMark_Click);

            this.btnViewStudent.Text      = "View Student Att.";
            this.btnViewStudent.Location  = new System.Drawing.Point(200, 11);
            this.btnViewStudent.Size      = new System.Drawing.Size(175, 40);
            this.btnViewStudent.BackColor = System.Drawing.Color.FromArgb(25, 100, 210);
            this.btnViewStudent.ForeColor = System.Drawing.Color.White;
            this.btnViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudent.FlatAppearance.BorderSize = 0;
            this.btnViewStudent.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnViewStudent.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnViewStudent.Click    += new System.EventHandler(this.btnViewStudent_Click);

            this.btnViewAll.Text      = "View All Records";
            this.btnViewAll.Location  = new System.Drawing.Point(385, 11);
            this.btnViewAll.Size      = new System.Drawing.Size(175, 40);
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(22, 145, 72);
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnViewAll.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.Click    += new System.EventHandler(this.btnViewAll_Click);

            this.btnClear.Text      = "Clear";
            this.btnClear.Location  = new System.Drawing.Point(570, 11);
            this.btnClear.Size      = new System.Drawing.Size(120, 40);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            this.pnlButtons.Controls.Add(this.btnMark);
            this.pnlButtons.Controls.Add(this.btnViewStudent);
            this.pnlButtons.Controls.Add(this.btnViewAll);
            this.pnlButtons.Controls.Add(this.btnClear);

            this.pnlGrid.BackColor   = System.Drawing.Color.White;
            this.pnlGrid.Location    = new System.Drawing.Point(15, 380);
            this.pnlGrid.Size        = new System.Drawing.Size(778, 200);
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCount.Text      = "Total Records: 0";
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(195, 95, 15);
            this.lblCount.Location  = new System.Drawing.Point(8, 5);
            this.lblCount.AutoSize  = true;

            this.dgvAtt.Location            = new System.Drawing.Point(0, 24);
            this.dgvAtt.Size                = new System.Drawing.Size(776, 174);
            this.dgvAtt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtt.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtt.ReadOnly            = true;
            this.dgvAtt.AllowUserToAddRows  = false;
            this.dgvAtt.BackgroundColor     = System.Drawing.Color.White;
            this.dgvAtt.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvAtt.RowHeadersWidth     = 25;
            this.dgvAtt.Font                = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvAtt.GridColor           = System.Drawing.Color.FromArgb(220, 225, 235);
            this.dgvAtt.RowTemplate.Height  = 26;
            this.dgvAtt.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 247, 240);
            this.dgvAtt.ColumnHeadersDefaultCellStyle.BackColor   = System.Drawing.Color.FromArgb(195, 95, 15);
            this.dgvAtt.ColumnHeadersDefaultCellStyle.ForeColor   = System.Drawing.Color.White;
            this.dgvAtt.ColumnHeadersDefaultCellStyle.Font        = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvAtt.ColumnHeadersHeight  = 30;
            this.dgvAtt.EnableHeadersVisualStyles = false;

            this.pnlGrid.Controls.Add(this.lblCount);
            this.pnlGrid.Controls.Add(this.dgvAtt);

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
