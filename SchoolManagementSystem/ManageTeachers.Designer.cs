namespace SchoolManagementSystem
{
    partial class ManageTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeachers));
            dataGridViewTeachers = new DataGridView();
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnUpdate = new Button();
            Search = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnLogOut = new Button();
            label1 = new Label();
            panel4 = new Panel();
            cmbDegree = new ComboBox();
            label15 = new Label();
            cmbExperience = new ComboBox();
            label14 = new Label();
            cmbSubject = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            chkAssignedClass = new CheckedListBox();
            label3 = new Label();
            label17 = new Label();
            label16 = new Label();
            cmbGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.BackgroundColor = Color.SlateGray;
            dataGridViewTeachers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Dock = DockStyle.Bottom;
            dataGridViewTeachers.Location = new Point(0, 51);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.RowHeadersWidth = 51;
            dataGridViewTeachers.Size = new Size(978, 245);
            dataGridViewTeachers.TabIndex = 0;
            dataGridViewTeachers.CellContentClick += dataGridViewTeachers_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridViewTeachers);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 300);
            panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(713, 9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 35);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(537, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 35);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(794, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 35);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(886, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 35);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(625, 9);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 35);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Search
            // 
            Search.Cursor = Cursors.Hand;
            Search.Location = new Point(12, 10);
            Search.Name = "Search";
            Search.Size = new Size(111, 33);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 1;
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
            panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Turquoise;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(878, 9);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(cmbDegree);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(cmbExperience);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(cmbSubject);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(0, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(980, 101);
            panel4.TabIndex = 23;
            // 
            // cmbDegree
            // 
            cmbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegree.FormattingEnabled = true;
            cmbDegree.Items.AddRange(new object[] { "BSC", "MSC", "MBA", "BBA", "PHD", "DR." });
            cmbDegree.Location = new Point(369, 55);
            cmbDegree.Name = "cmbDegree";
            cmbDegree.Size = new Size(261, 28);
            cmbDegree.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(369, 29);
            label15.Name = "label15";
            label15.Size = new Size(64, 23);
            label15.TabIndex = 8;
            label15.Text = "Degree";
            // 
            // cmbExperience
            // 
            cmbExperience.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExperience.FormattingEnabled = true;
            cmbExperience.Items.AddRange(new object[] { "1 Years", "2 Years", "3 Years", "4 Years", "5 Years", "6 Years", "7 Years", "8 Years", "9 Years", "10 Years", "11 Years", "12 Years", "13 Years", "14 Years", "15 Years", "16 Years", "17 Years", "18 Years", "19 Years", "20 Years", "21 Years", "22 Years", "23 Years" });
            cmbExperience.Location = new Point(667, 55);
            cmbExperience.Name = "cmbExperience";
            cmbExperience.Size = new Size(200, 28);
            cmbExperience.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(667, 29);
            label14.Name = "label14";
            label14.Size = new Size(89, 23);
            label14.TabIndex = 6;
            label14.Text = "Experience";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Bangla", "English", "Math", "Higher Math", "Physics", "Chemisty", "Biology", "Social Science" });
            cmbSubject.Location = new Point(69, 55);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(261, 28);
            cmbSubject.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(69, 29);
            label13.Name = "label13";
            label13.Size = new Size(73, 23);
            label13.TabIndex = 4;
            label13.Text = "SUBJECT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 1);
            label12.Name = "label12";
            label12.Size = new Size(203, 20);
            label12.TabIndex = 0;
            label12.Text = "🏫 Professional Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(chkAssignedClass);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(cmbGender);
            panel3.Controls.Add(dtpDateOfBirth);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtFullName);
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 176);
            panel3.TabIndex = 22;
            // 
            // chkAssignedClass
            // 
            chkAssignedClass.Cursor = Cursors.Hand;
            chkAssignedClass.FormattingEnabled = true;
            chkAssignedClass.Items.AddRange(new object[] { "Class 1", "Class 2", "Class 3", "Class 4", "Class 5", "Class 6", "Class 7", "Class 8", "Class 9", "Class 10" });
            chkAssignedClass.Location = new Point(806, 57);
            chkAssignedClass.Name = "chkAssignedClass";
            chkAssignedClass.Size = new Size(150, 92);
            chkAssignedClass.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(806, 32);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 30;
            label3.Text = "Assign Class";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(667, 32);
            label17.Name = "label17";
            label17.Size = new Size(71, 23);
            label17.TabIndex = 28;
            label17.Text = "GENDER";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(369, 32);
            label16.Name = "label16";
            label16.Size = new Size(122, 23);
            label16.TabIndex = 27;
            label16.Text = "DATE OF BIRTH";
            // 
            // cmbGender
            // 
            cmbGender.Cursor = Cursors.Hand;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(667, 57);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(98, 28);
            cmbGender.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(369, 58);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(261, 27);
            dtpDateOfBirth.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 24;
            label8.Text = "👤 Personal Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(69, 90);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 22;
            label9.Text = "PHONE";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(69, 116);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(369, 90);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 16;
            label5.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(369, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 32);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "FULL NAME";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(69, 58);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 27);
            txtFullName.TabIndex = 3;
            // 
            // ManageTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 653);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageTeachers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTeachers;
        private Panel panel1;
        private Button Search;
        private TextBox txtSearch;
        private Panel panel2;
        private Button btnLogOut;
        private Label label1;
        private Button btnUpdate;
        private Button btnBack;
        private Panel panel4;
        private ComboBox cmbDegree;
        private Label label15;
        private ComboBox cmbExperience;
        private Label label14;
        private ComboBox cmbSubject;
        private Label label13;
        private Label label12;
        private Panel panel3;
        private Label label17;
        private Label label16;
        private ComboBox cmbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label label8;
        private Label label9;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtFullName;
        private Button btnDelete;
        private Label label3;
        private Button btnAdd;
        private CheckedListBox chkAssignedClass;
        private Button btnClear;
    }
}