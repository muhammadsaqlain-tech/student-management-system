namespace StudentManagementSystem
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel        pnlHeader;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Panel        pnlSearch;
        private System.Windows.Forms.Label        lblSelectLbl;
        private System.Windows.Forms.ComboBox     cboStudent;
        private System.Windows.Forms.Button       btnGenerate;
        private System.Windows.Forms.Button       btnPrint;
        private System.Windows.Forms.Button       btnClear;
        private System.Windows.Forms.Panel        pnlResult;
        private System.Windows.Forms.Label        lblStudentName;
        private System.Windows.Forms.Label        lblStudentID;
        private System.Windows.Forms.Label        lblDept;
        private System.Windows.Forms.Label        lblFather;
        private System.Windows.Forms.Label        lblCourseCount;
        private System.Windows.Forms.Label        lblAvg;
        private System.Windows.Forms.Label        lblGPA;
        private System.Windows.Forms.Label        lblOverall;
        private System.Windows.Forms.Panel        pnlGrid;
        private System.Windows.Forms.DataGridView dgvResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblTitle     = new System.Windows.Forms.Label();
            this.pnlSearch    = new System.Windows.Forms.Panel();
            this.lblSelectLbl = new System.Windows.Forms.Label();
            this.cboStudent   = new System.Windows.Forms.ComboBox();
            this.btnGenerate  = new System.Windows.Forms.Button();
            this.btnPrint     = new System.Windows.Forms.Button();
            this.btnClear     = new System.Windows.Forms.Button();
            this.pnlResult    = new System.Windows.Forms.Panel();
            this.lblStudentName= new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblDept      = new System.Windows.Forms.Label();
            this.lblFather    = new System.Windows.Forms.Label();
            this.lblCourseCount=new System.Windows.Forms.Label();
            this.lblAvg       = new System.Windows.Forms.Label();
            this.lblGPA       = new System.Windows.Forms.Label();
            this.lblOverall   = new System.Windows.Forms.Label();
            this.pnlGrid      = new System.Windows.Forms.Panel();
            this.dgvResult    = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            this.Text          = "Student Result Report";
            this.Size          = new System.Drawing.Size(820, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5f);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(200, 45, 55);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 65;
            this.lblTitle.Text       = "Student Result Report Generator";
            this.lblTitle.Font       = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor  = System.Drawing.Color.White;
            this.lblTitle.AutoSize   = true;
            this.lblTitle.Location   = new System.Drawing.Point(20, 18);

            // SEARCH PANEL
            this.pnlSearch.BackColor   = System.Drawing.Color.White;
            this.pnlSearch.Location    = new System.Drawing.Point(15, 80);
            this.pnlSearch.Size        = new System.Drawing.Size(778, 65);
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var stripe = new System.Windows.Forms.Panel();
            stripe.BackColor = System.Drawing.Color.FromArgb(200, 45, 55);
            stripe.Location  = new System.Drawing.Point(0, 0);
            stripe.Size      = new System.Drawing.Size(778, 5);

            this.lblSelectLbl.Text     = "Select Student:";
            this.lblSelectLbl.Font     = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblSelectLbl.ForeColor= System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblSelectLbl.Location = new System.Drawing.Point(12, 22);
            this.lblSelectLbl.AutoSize = true;

            this.cboStudent.Location      = new System.Drawing.Point(140, 18);
            this.cboStudent.Size          = new System.Drawing.Size(290, 30);
            this.cboStudent.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);

            // btnGenerate
            this.btnGenerate.Text      = "Generate Result";
            this.btnGenerate.Location  = new System.Drawing.Point(445, 16);
            this.btnGenerate.Size      = new System.Drawing.Size(150, 34);
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(200, 45, 55);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Click    += new System.EventHandler(this.btnGenerate_Click);

            // btnPrint
            this.btnPrint.Text      = "Print / Preview";
            this.btnPrint.Location  = new System.Drawing.Point(608, 16);
            this.btnPrint.Size      = new System.Drawing.Size(90, 34);
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(25, 100, 210);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnPrint.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Click    += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.Enabled   = false;

            this.pnlSearch.Controls.Add(stripe);
            this.pnlSearch.Controls.Add(this.lblSelectLbl);
            this.pnlSearch.Controls.Add(this.cboStudent);
            this.pnlSearch.Controls.Add(this.btnGenerate);
            this.pnlSearch.Controls.Add(this.btnPrint);

            // RESULT INFO PANEL
            this.pnlResult.BackColor   = System.Drawing.Color.White;
            this.pnlResult.Location    = new System.Drawing.Point(15, 158);
            this.pnlResult.Size        = new System.Drawing.Size(778, 110);
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Visible     = false;

            var stripe2 = new System.Windows.Forms.Panel();
            stripe2.BackColor = System.Drawing.Color.FromArgb(200, 45, 55);
            stripe2.Location  = new System.Drawing.Point(0, 0);
            stripe2.Size      = new System.Drawing.Size(778, 5);

            // Row 1 labels
            this.lblStudentName.Text      = "Name: -";
            this.lblStudentName.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(20, 40, 90);
            this.lblStudentName.Location  = new System.Drawing.Point(15, 18);
            this.lblStudentName.AutoSize  = true;

            this.lblStudentID.Text      = "ID: -";
            this.lblStudentID.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(20, 40, 90);
            this.lblStudentID.Location  = new System.Drawing.Point(280, 18);
            this.lblStudentID.AutoSize  = true;

            this.lblDept.Text      = "Dept: -";
            this.lblDept.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Regular);
            this.lblDept.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            this.lblDept.Location  = new System.Drawing.Point(490, 18);
            this.lblDept.AutoSize  = true;

            // Row 2
            this.lblFather.Text      = "Father: -";
            this.lblFather.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Regular);
            this.lblFather.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            this.lblFather.Location  = new System.Drawing.Point(15, 45);
            this.lblFather.AutoSize  = true;

            this.lblCourseCount.Text      = "Courses: 0";
            this.lblCourseCount.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Regular);
            this.lblCourseCount.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            this.lblCourseCount.Location  = new System.Drawing.Point(280, 45);
            this.lblCourseCount.AutoSize  = true;

            // Row 3
            this.lblAvg.Text      = "Average: -";
            this.lblAvg.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvg.ForeColor = System.Drawing.Color.FromArgb(22, 145, 72);
            this.lblAvg.Location  = new System.Drawing.Point(15, 75);
            this.lblAvg.AutoSize  = true;

            this.lblGPA.Text      = "GPA: -";
            this.lblGPA.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblGPA.ForeColor = System.Drawing.Color.FromArgb(22, 145, 72);
            this.lblGPA.Location  = new System.Drawing.Point(240, 75);
            this.lblGPA.AutoSize  = true;

            this.lblOverall.Text      = "Grade: -";
            this.lblOverall.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblOverall.ForeColor = System.Drawing.Color.FromArgb(22, 145, 72);
            this.lblOverall.Location  = new System.Drawing.Point(420, 75);
            this.lblOverall.AutoSize  = true;

            this.pnlResult.Controls.Add(stripe2);
            this.pnlResult.Controls.Add(this.lblStudentName);
            this.pnlResult.Controls.Add(this.lblStudentID);
            this.pnlResult.Controls.Add(this.lblDept);
            this.pnlResult.Controls.Add(this.lblFather);
            this.pnlResult.Controls.Add(this.lblCourseCount);
            this.pnlResult.Controls.Add(this.lblAvg);
            this.pnlResult.Controls.Add(this.lblGPA);
            this.pnlResult.Controls.Add(this.lblOverall);

            // GRID PANEL
            this.pnlGrid.BackColor   = System.Drawing.Color.White;
            this.pnlGrid.Location    = new System.Drawing.Point(15, 280);
            this.pnlGrid.Size        = new System.Drawing.Size(778, 330);
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvResult.Location            = new System.Drawing.Point(0, 0);
            this.dgvResult.Size                = new System.Drawing.Size(776, 328);
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.ReadOnly            = true;
            this.dgvResult.AllowUserToAddRows  = false;
            this.dgvResult.BackgroundColor     = System.Drawing.Color.White;
            this.dgvResult.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.RowHeadersWidth     = 25;
            this.dgvResult.Font                = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvResult.GridColor           = System.Drawing.Color.FromArgb(220, 225, 235);
            this.dgvResult.RowTemplate.Height  = 28;
            this.dgvResult.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            this.dgvResult.ColumnHeadersDefaultCellStyle.BackColor   = System.Drawing.Color.FromArgb(200, 45, 55);
            this.dgvResult.ColumnHeadersDefaultCellStyle.ForeColor   = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersDefaultCellStyle.Font        = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvResult.ColumnHeadersHeight  = 32;
            this.dgvResult.EnableHeadersVisualStyles = false;

            this.pnlGrid.Controls.Add(this.dgvResult);

            // CLEAR BUTTON
            this.btnClear.Text      = "Clear / New Search";
            this.btnClear.Location  = new System.Drawing.Point(15, 620);
            this.btnClear.Size      = new System.Drawing.Size(200, 38);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            // ASSEMBLE
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.btnClear);

            this.pnlHeader.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
