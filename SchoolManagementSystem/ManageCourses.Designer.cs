namespace SchoolManagementSystem
{
    partial class ManageCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnLogout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourses));
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewCourses = new DataGridView();
            btnBack = new Button();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            Search = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            cmbClass = new ComboBox();
            label5 = new Label();
            cmbTime = new ComboBox();
            label3 = new Label();
            cmbTeacher = new ComboBox();
            label2 = new Label();
            cmbSubject = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();

            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Turquoise;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(876, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(92, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;

            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dataGridViewCourses);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(Search);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 453);
            panel1.TabIndex = 0;

            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(638, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 36);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(554, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(806, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 35);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCourses.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Dock = DockStyle.Bottom;
            dataGridViewCourses.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewCourses.Location = new Point(0, 46);
            dataGridViewCourses.MultiSelect = false;
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.Size = new Size(978, 403);
            dataGridViewCourses.TabIndex = 0;
            dataGridViewCourses.CellClick += dataGridViewCourses_CellClick;

            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(890, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 35);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(130, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 31;

            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(722, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 35);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

            // 
            // Search
            // 
            Search.Cursor = Cursors.Hand;
            Search.Location = new Point(13, 4);
            Search.Name = "Search";
            Search.Size = new Size(111, 33);
            Search.TabIndex = 32;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;

            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 53);
            panel2.TabIndex = 3;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 0;
            label1.Text = "Abc Learning";

            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(cmbClass);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cmbTime);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbTeacher);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cmbSubject);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(980, 118);
            panel4.TabIndex = 30;

            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[]
            {
                "Class 1",
                "Class 2",
                "Class 3",
                "Class 4",
                "Class 5",
                "Class 6",
                "Class 7",
                "Class 8",
                "Class 9",
                "Class 10"
            });
            cmbClass.Location = new Point(289, 60);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(132, 28);
            cmbClass.TabIndex = 38;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 35);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 37;
            label5.Text = "Class";

            // 
            // cmbTime
            // 
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.FormattingEnabled = true;
            cmbTime.Items.AddRange(new object[]
            {
                "8Am-10Am",
                "10Am-12Pm",
                "12Pm-2Pm",
                "2Pm-4Pm"
            });
            cmbTime.Location = new Point(734, 60);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(211, 28);
            cmbTime.TabIndex = 36;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(734, 34);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 35;
            label3.Text = "Time";

            // 
            // cmbTeacher
            // 
            cmbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(467, 60);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(216, 28);
            cmbTeacher.TabIndex = 34;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 34);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 33;
            label2.Text = "Teacher";

            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[]
            {
                "Bangla",
                "English",
                "Math",
                "Higher Math",
                "Physics",
                "Chemisty",
                "Biology",
                "Social Science"
            });
            cmbSubject.Location = new Point(29, 60);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(216, 28);
            cmbSubject.TabIndex = 32;

            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 34);
            label13.Name = "label13";
            label13.Size = new Size(73, 23);
            label13.TabIndex = 31;
            label13.Text = "SUBJECT";

            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1, 0);
            label12.Name = "label12";
            label12.Size = new Size(167, 20);
            label12.TabIndex = 0;
            label12.Text = "🏫 Course Information";

            // 
            // ManageCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageCourses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCourses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Label label12;
        private ComboBox cmbTime;
        private Label label3;
        private ComboBox cmbTeacher;
        private Label label2;
        private ComboBox cmbSubject;
        private Label label13;
        private DataGridView dataGridViewCourses;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button Search;
        private ComboBox cmbClass;
        private Label label5;
        private Button btnClear;
    }
}