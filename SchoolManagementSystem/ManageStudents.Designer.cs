namespace SchoolManagementSystem
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            btnDelete = new Button();
            label16 = new Label();
            cmbGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label15 = new Label();
            cmbRelationship = new ComboBox();
            label14 = new Label();
            label17 = new Label();
            panel3 = new Panel();
            cmbClass = new ComboBox();
            txtGuardianPhone = new TextBox();
            txtGuardianName = new TextBox();
            label13 = new Label();
            txtFullName = new TextBox();
            panel4 = new Panel();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label12 = new Label();
            btnUpdate = new Button();
            btnLogOut = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            dataGridViewStudents = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(801, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 35);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(289, 33);
            label16.Name = "label16";
            label16.Size = new Size(122, 23);
            label16.TabIndex = 27;
            label16.Text = "DATE OF BIRTH";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(606, 58);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(131, 28);
            cmbGender.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(289, 59);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(277, 27);
            dtpDateOfBirth.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 24;
            label8.Text = "👤 Personal Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(76, 30);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 22;
            label9.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(76, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(203, 27);
            txtUsername.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(774, 33);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 16;
            label5.Text = "Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "FULL NAME";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(289, 92);
            label15.Name = "label15";
            label15.Size = new Size(125, 23);
            label15.TabIndex = 8;
            label15.Text = "Guardian Phone";
            // 
            // cmbRelationship
            // 
            cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRelationship.FormattingEnabled = true;
            cmbRelationship.Items.AddRange(new object[] { "Father", "Mother", "Brother", "Sister", "GrandFather", "GrandMother" });
            cmbRelationship.Location = new Point(536, 127);
            cmbRelationship.Name = "cmbRelationship";
            cmbRelationship.Size = new Size(213, 28);
            cmbRelationship.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(536, 93);
            label14.Name = "label14";
            label14.Size = new Size(95, 23);
            label14.TabIndex = 6;
            label14.Text = "Relationship";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(606, 33);
            label17.Name = "label17";
            label17.Size = new Size(71, 23);
            label17.TabIndex = 28;
            label17.Text = "GENDER";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(cmbClass);
            panel3.Controls.Add(cmbRelationship);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtGuardianPhone);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtGuardianName);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cmbGender);
            panel3.Controls.Add(dtpDateOfBirth);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtFullName);
            panel3.Location = new Point(-1, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 172);
            panel3.TabIndex = 28;
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "Class 1", "Class 2", "Class 3", "Class 4", "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10" });
            cmbClass.Location = new Point(774, 58);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(129, 28);
            cmbClass.TabIndex = 29;
            // 
            // txtGuardianPhone
            // 
            txtGuardianPhone.BorderStyle = BorderStyle.FixedSingle;
            txtGuardianPhone.Location = new Point(289, 127);
            txtGuardianPhone.Name = "txtGuardianPhone";
            txtGuardianPhone.Size = new Size(213, 27);
            txtGuardianPhone.TabIndex = 11;
            // 
            // txtGuardianName
            // 
            txtGuardianName.BorderStyle = BorderStyle.FixedSingle;
            txtGuardianName.Location = new Point(46, 127);
            txtGuardianName.Name = "txtGuardianName";
            txtGuardianName.Size = new Size(213, 27);
            txtGuardianName.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(46, 101);
            label13.Name = "label13";
            label13.Size = new Size(122, 23);
            label13.TabIndex = 4;
            label13.Text = "Guardian Name";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(46, 59);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(213, 27);
            txtFullName.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txtConfirmPassword);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(txtUsername);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(1, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(979, 100);
            panel4.TabIndex = 29;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(561, 56);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(203, 27);
            txtConfirmPassword.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 30);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 26;
            label4.Text = "CONFIRM PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(319, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(203, 27);
            txtPassword.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 30);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 24;
            label3.Text = "PASSWORD";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 0);
            label12.Name = "label12";
            label12.Size = new Size(158, 20);
            label12.TabIndex = 0;
            label12.Text = "🏫 Login Information";
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(632, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 35);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Turquoise;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(878, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(92, 38);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 53);
            panel2.TabIndex = 26;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(889, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 35);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(10, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 27);
            txtSearch.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(dataGridViewStudents);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 316);
            panel1.TabIndex = 25;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(720, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 35);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(548, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 35);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.BackgroundColor = Color.SlateGray;
            dataGridViewStudents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Dock = DockStyle.Bottom;
            dataGridViewStudents.Location = new Point(0, 44);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(978, 268);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;
            // 
            // ManageStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageStudents";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Label label16;
        private ComboBox cmbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label label8;
        private Label label9;
        private TextBox txtUsername;
        private Label label5;
        private Label label2;
        private Label label15;
        private ComboBox cmbRelationship;
        private Label label14;
        private Label label17;
        private Panel panel3;
        private TextBox txtFullName;
        private Label label13;
        private Panel panel4;
        private Label label12;
        private Button btnUpdate;
        private Button btnLogOut;
        private Label label1;
        private Panel panel2;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel1;
        private DataGridView dataGridViewStudents;
        private TextBox txtGuardianName;
        private TextBox txtGuardianPhone;
        private ComboBox cmbClass;
        private TextBox txtConfirmPassword;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private Button btnAdd;
        private Button btnClear;
    }
}