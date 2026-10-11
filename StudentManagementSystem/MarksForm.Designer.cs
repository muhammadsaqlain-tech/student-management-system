namespace StudentManagementSystem
{
    partial class MarksForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel        pnlHeader;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Panel        pnlForm;
        private System.Windows.Forms.Label        lblStudentLbl;
        private System.Windows.Forms.Label        lblCourseLbl;
        private System.Windows.Forms.Label        lblMidLbl;
        private System.Windows.Forms.Label        lblFinalLbl;
        private System.Windows.Forms.Label        lblAssignLbl;
        private System.Windows.Forms.Label        lblTotal;
        private System.Windows.Forms.Label        lblGrade;
        private System.Windows.Forms.ComboBox     cboStudent;
        private System.Windows.Forms.ComboBox     cboCourse;
        private System.Windows.Forms.TextBox      txtMid;
        private System.Windows.Forms.TextBox      txtFinal;
        private System.Windows.Forms.TextBox      txtAssign;
        private System.Windows.Forms.Panel        pnlButtons;
        private System.Windows.Forms.Button       btnSave;
        private System.Windows.Forms.Button       btnDelete;
        private System.Windows.Forms.Button       btnClear;
        private System.Windows.Forms.Panel        pnlGrid;
        private System.Windows.Forms.Label        lblCount;
        private System.Windows.Forms.DataGridView dgvMarks;

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
            this.lblStudentLbl= new System.Windows.Forms.Label();
            this.lblCourseLbl = new System.Windows.Forms.Label();
            this.lblMidLbl    = new System.Windows.Forms.Label();
            this.lblFinalLbl  = new System.Windows.Forms.Label();
            this.lblAssignLbl = new System.Windows.Forms.Label();
            this.lblTotal     = new System.Windows.Forms.Label();
            this.lblGrade     = new System.Windows.Forms.Label();
            this.cboStudent   = new System.Windows.Forms.ComboBox();
            this.cboCourse    = new System.Windows.Forms.ComboBox();
            this.txtMid       = new System.Windows.Forms.TextBox();
            this.txtFinal     = new System.Windows.Forms.TextBox();
            this.txtAssign    = new System.Windows.Forms.TextBox();
            this.pnlButtons   = new System.Windows.Forms.Panel();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnDelete    = new System.Windows.Forms.Button();
            this.btnClear     = new System.Windows.Forms.Button();
            this.pnlGrid      = new System.Windows.Forms.Panel();
            this.lblCount     = new System.Windows.Forms.Label();
            this.dgvMarks     = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            this.Text          = "Enter Student Marks";
            this.Size          = new System.Drawing.Size(820, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5f);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(120, 35, 175);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 65;
            this.lblTitle.Text       = "Marks Entry System";
            this.lblTitle.Font       = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor  = System.Drawing.Color.White;
            this.lblTitle.AutoSize   = true;
            this.lblTitle.Location   = new System.Drawing.Point(20, 18);

            this.pnlForm.BackColor   = System.Drawing.Color.White;
            this.pnlForm.Location    = new System.Drawing.Point(15, 80);
            this.pnlForm.Size        = new System.Drawing.Size(778, 255);
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var stripe = new System.Windows.Forms.Panel();
            stripe.BackColor = System.Drawing.Color.FromArgb(120, 35, 175);
            stripe.Location  = new System.Drawing.Point(0, 0);
            stripe.Size      = new System.Drawing.Size(778, 6);

            var lblFT = new System.Windows.Forms.Label();
            lblFT.Text      = "Enter Marks  (Mid: 30 pts  |  Final: 50 pts  |  Assignment: 20 pts  |  Total: 100 pts)";
            lblFT.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            lblFT.ForeColor = System.Drawing.Color.FromArgb(120, 35, 175);
            lblFT.AutoSize  = true;
            lblFT.Location  = new System.Drawing.Point(15, 15);

            this.lblStudentLbl.Text      = "Select Student :";
            this.lblStudentLbl.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStudentLbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblStudentLbl.Location  = new System.Drawing.Point(15, 48);
            this.lblStudentLbl.AutoSize  = true;
            this.cboStudent.Location      = new System.Drawing.Point(160, 45);
            this.cboStudent.Size          = new System.Drawing.Size(205, 30);
            this.cboStudent.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);

            this.lblCourseLbl.Text      = "Select Course :";
            this.lblCourseLbl.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblCourseLbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblCourseLbl.Location  = new System.Drawing.Point(405, 48);
            this.lblCourseLbl.AutoSize  = true;
            this.cboCourse.Location      = new System.Drawing.Point(545, 45);
            this.cboCourse.Size          = new System.Drawing.Size(205, 30);
            this.cboCourse.Font          = new System.Drawing.Font("Segoe UI", 10f);
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.BackColor     = System.Drawing.Color.FromArgb(245, 247, 252);

            this.lblMidLbl.Text      = "Mid Marks (0-30) :";
            this.lblMidLbl.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblMidLbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblMidLbl.Location  = new System.Drawing.Point(15, 90);
            this.lblMidLbl.AutoSize  = true;
            this.txtMid.Location    = new System.Drawing.Point(160, 87);
            this.txtMid.Size        = new System.Drawing.Size(205, 30);
            this.txtMid.Font        = new System.Drawing.Font("Segoe UI", 11f);
            this.txtMid.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMid.TextChanged += new System.EventHandler(this.txtMid_TextChanged);

            this.lblFinalLbl.Text      = "Final Marks (0-50) :";
            this.lblFinalLbl.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblFinalLbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFinalLbl.Location  = new System.Drawing.Point(405, 90);
            this.lblFinalLbl.AutoSize  = true;
            this.txtFinal.Location    = new System.Drawing.Point(545, 87);
            this.txtFinal.Size        = new System.Drawing.Size(205, 30);
            this.txtFinal.Font        = new System.Drawing.Font("Segoe UI", 11f);
            this.txtFinal.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal.TextChanged += new System.EventHandler(this.txtFinal_TextChanged);

            this.lblAssignLbl.Text      = "Assignment (0-20) :";
            this.lblAssignLbl.Font      = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblAssignLbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblAssignLbl.Location  = new System.Drawing.Point(15, 132);
            this.lblAssignLbl.AutoSize  = true;
            this.txtAssign.Location    = new System.Drawing.Point(160, 129);
            this.txtAssign.Size        = new System.Drawing.Size(205, 30);
            this.txtAssign.Font        = new System.Drawing.Font("Segoe UI", 11f);
            this.txtAssign.BackColor   = System.Drawing.Color.FromArgb(245, 247, 252);
            this.txtAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssign.TextChanged += new System.EventHandler(this.txtAssign_TextChanged);

            this.lblTotal.Text      = "Total: 0 / 100";
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            this.lblTotal.Location  = new System.Drawing.Point(15, 176);
            this.lblTotal.AutoSize  = true;

            this.lblGrade.Text      = "Grade: -";
            this.lblGrade.Font      = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(80, 95, 120);
            this.lblGrade.Location  = new System.Drawing.Point(405, 176);
            this.lblGrade.AutoSize  = true;

            this.pnlForm.Controls.Add(stripe);
            this.pnlForm.Controls.Add(lblFT);
            this.pnlForm.Controls.Add(this.lblStudentLbl); this.pnlForm.Controls.Add(this.cboStudent);
            this.pnlForm.Controls.Add(this.lblCourseLbl);  this.pnlForm.Controls.Add(this.cboCourse);
            this.pnlForm.Controls.Add(this.lblMidLbl);     this.pnlForm.Controls.Add(this.txtMid);
            this.pnlForm.Controls.Add(this.lblFinalLbl);   this.pnlForm.Controls.Add(this.txtFinal);
            this.pnlForm.Controls.Add(this.lblAssignLbl);  this.pnlForm.Controls.Add(this.txtAssign);
            this.pnlForm.Controls.Add(this.lblTotal);
            this.pnlForm.Controls.Add(this.lblGrade);

            this.pnlButtons.BackColor   = System.Drawing.Color.White;
            this.pnlButtons.Location    = new System.Drawing.Point(15, 348);
            this.pnlButtons.Size        = new System.Drawing.Size(778, 62);
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnSave.Text      = "Save Marks";
            this.btnSave.Location  = new System.Drawing.Point(15, 11);
            this.btnSave.Size      = new System.Drawing.Size(220, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(120, 35, 175);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click    += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Text      = "Delete Selected";
            this.btnDelete.Location  = new System.Drawing.Point(245, 11);
            this.btnDelete.Size      = new System.Drawing.Size(220, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(210, 45, 45);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnDelete.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click    += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text      = "Clear";
            this.btnClear.Location  = new System.Drawing.Point(475, 11);
            this.btnClear.Size      = new System.Drawing.Size(140, 40);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClear);

            this.pnlGrid.BackColor   = System.Drawing.Color.White;
            this.pnlGrid.Location    = new System.Drawing.Point(15, 423);
            this.pnlGrid.Size        = new System.Drawing.Size(778, 178);
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCount.Text      = "Total Records: 0";
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(120, 35, 175);
            this.lblCount.Location  = new System.Drawing.Point(8, 5);
            this.lblCount.AutoSize  = true;

            this.dgvMarks.Location            = new System.Drawing.Point(0, 24);
            this.dgvMarks.Size                = new System.Drawing.Size(776, 152);
            this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarks.ReadOnly            = true;
            this.dgvMarks.AllowUserToAddRows  = false;
            this.dgvMarks.BackgroundColor     = System.Drawing.Color.White;
            this.dgvMarks.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.dgvMarks.RowHeadersWidth     = 25;
            this.dgvMarks.Font                = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvMarks.GridColor           = System.Drawing.Color.FromArgb(220, 225, 235);
            this.dgvMarks.RowTemplate.Height  = 26;
            this.dgvMarks.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 242, 255);
            this.dgvMarks.ColumnHeadersDefaultCellStyle.BackColor   = System.Drawing.Color.FromArgb(120, 35, 175);
            this.dgvMarks.ColumnHeadersDefaultCellStyle.ForeColor   = System.Drawing.Color.White;
            this.dgvMarks.ColumnHeadersDefaultCellStyle.Font        = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvMarks.ColumnHeadersHeight  = 30;
            this.dgvMarks.EnableHeadersVisualStyles = false;

            this.pnlGrid.Controls.Add(this.lblCount);
            this.pnlGrid.Controls.Add(this.dgvMarks);

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
