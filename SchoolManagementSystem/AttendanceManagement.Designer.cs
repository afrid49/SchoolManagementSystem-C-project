namespace SchoolManagementSystem
{
    partial class AttendanceManagement
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Button btnLogout;
        private Label labelTitle;
        private Panel panelTop;
        private Label labelClass;
        private ComboBox cmbClass;
        private Label labelDate;
        private DateTimePicker dtpAttendanceDate;
        private Label labelStudentName;
        private TextBox txtStudentName;
        private Label labelStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnMarkAllPresent;
        private Button btnClear;
        private Button btnBack;
        private DataGridView dataGridViewAttendance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnLogout = new Button();
            labelTitle = new Label();
            panelTop = new Panel();
            btnBack = new Button();
            btnClear = new Button();
            btnMarkAllPresent = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            labelStatus = new Label();
            txtStudentName = new TextBox();
            labelStudentName = new Label();
            dtpAttendanceDate = new DateTimePicker();
            labelDate = new Label();
            cmbClass = new ComboBox();
            labelClass = new Label();
            dataGridViewAttendance = new DataGridView();
            panelHeader.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightSeaGreen;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 60);
            panelHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Turquoise;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(890, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(92, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(303, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Attendance Management";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.Fixed3D;
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(btnClear);
            panelTop.Controls.Add(btnMarkAllPresent);
            panelTop.Controls.Add(btnSave);
            panelTop.Controls.Add(cmbStatus);
            panelTop.Controls.Add(labelStatus);
            panelTop.Controls.Add(txtStudentName);
            panelTop.Controls.Add(labelStudentName);
            panelTop.Controls.Add(dtpAttendanceDate);
            panelTop.Controls.Add(labelDate);
            panelTop.Controls.Add(cmbClass);
            panelTop.Controls.Add(labelClass);
            panelTop.Location = new Point(0, 66);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 150);
            panelTop.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(850, 101);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 32);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(850, 63);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Cursor = Cursors.Hand;
            btnMarkAllPresent.Location = new Point(690, 101);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.Size = new Size(140, 32);
            btnMarkAllPresent.TabIndex = 11;
            btnMarkAllPresent.Text = "Mark All Present";
            btnMarkAllPresent.UseVisualStyleBackColor = true;
            btnMarkAllPresent.Click += btnMarkAllPresent_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(690, 63);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 32);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save/Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(500, 76);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 28);
            cmbStatus.TabIndex = 7;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(430, 80);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Status";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(140, 76);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(260, 27);
            txtStudentName.TabIndex = 5;
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Location = new Point(35, 80);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(104, 20);
            labelStudentName.TabIndex = 4;
            labelStudentName.Text = "Student Name";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(500, 21);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(250, 27);
            dtpAttendanceDate.TabIndex = 3;
            dtpAttendanceDate.ValueChanged += dtpAttendanceDate_ValueChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(430, 25);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(140, 21);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(220, 28);
            cmbClass.TabIndex = 1;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(35, 25);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(42, 20);
            labelClass.TabIndex = 0;
            labelClass.Text = "Class";
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(0, 230);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(1000, 420);
            dataGridViewAttendance.TabIndex = 2;
            dataGridViewAttendance.CellClick += dataGridViewAttendance_CellClick;
            // 
            // AttendanceManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1000, 660);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(panelTop);
            Controls.Add(panelHeader);
            Name = "AttendanceManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
        }
    }
}