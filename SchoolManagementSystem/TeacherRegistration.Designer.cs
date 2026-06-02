namespace SchoolManagementSystem
{
    partial class TeacherRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherRegistration));
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
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
            panel2 = new Panel();
            btnBack = new Button();
            label1 = new Label();
            btnSignUp = new Button();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            txtUsername = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            cmbDegree = new ComboBox();
            label15 = new Label();
            cmbExperience = new ComboBox();
            label14 = new Label();
            cmbSubject = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(378, 10);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 9;
            label7.Text = "AbcLearning ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(359, 74);
            label4.Name = "label4";
            label4.Size = new Size(183, 28);
            label4.TabIndex = 8;
            label4.Text = "Registration Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFullName);
            panel1.Location = new Point(0, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 172);
            panel1.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(682, 30);
            label17.Name = "label17";
            label17.Size = new Size(71, 23);
            label17.TabIndex = 28;
            label17.Text = "GENDER";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(381, 30);
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
            cmbGender.Location = new Point(682, 55);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(98, 28);
            cmbGender.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(381, 56);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(261, 27);
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
            label9.Location = new Point(74, 98);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 22;
            label9.Text = "PHONE";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(74, 124);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(381, 98);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 16;
            label5.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(381, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 30);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "FULL NAME";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(74, 56);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 27);
            txtFullName.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 92);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 71);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 58, 92);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(774, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(96, 36);
            btnBack.TabIndex = 22;
            btnBack.Text = "<-Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(345, 38);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(26, 58, 92);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(310, 588);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(292, 53);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(623, 56);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 30);
            label3.Name = "label3";
            label3.Size = new Size(168, 23);
            label3.TabIndex = 2;
            label3.Text = "CONFIRM PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(381, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(381, 30);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 18;
            label6.Text = "PASSWORD";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtConfirmPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(882, 113);
            panel3.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(76, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 27);
            txtUsername.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(76, 30);
            label11.Name = "label11";
            label11.Size = new Size(93, 23);
            label11.TabIndex = 20;
            label11.Text = "USERNAME";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(153, 20);
            label10.TabIndex = 0;
            label10.Text = "🔒 Login Credentials";
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
            panel4.Location = new Point(0, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(882, 142);
            panel4.TabIndex = 21;
            // 
            // cmbDegree
            // 
            cmbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegree.FormattingEnabled = true;
            cmbDegree.Items.AddRange(new object[] { "MA", "BA", "PHD", "DR." });
            cmbDegree.Location = new Point(381, 68);
            cmbDegree.Name = "cmbDegree";
            cmbDegree.Size = new Size(200, 28);
            cmbDegree.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(381, 34);
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
            cmbExperience.Location = new Point(623, 68);
            cmbExperience.Name = "cmbExperience";
            cmbExperience.Size = new Size(200, 28);
            cmbExperience.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(623, 34);
            label14.Name = "label14";
            label14.Size = new Size(89, 23);
            label14.TabIndex = 6;
            label14.Text = "Experience";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Bangla", "English", "Math", "Social Science", "Higher Math", "General Knowladge" });
            cmbSubject.Location = new Point(83, 68);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(252, 28);
            cmbSubject.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(74, 34);
            label13.Name = "label13";
            label13.Size = new Size(73, 23);
            label13.TabIndex = 4;
            label13.Text = "SUBJECT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1, 0);
            label12.Name = "label12";
            label12.Size = new Size(203, 20);
            label12.TabIndex = 0;
            label12.Text = "🏫 Professional Information";
            // 
            // TeacherRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(882, 653);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(btnSignUp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeacherRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Label label4;
        private Panel panel1;
        private Label label8;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label1;
        private CheckBox checkBox1;
        private Button btnSignUp;
        private Label label9;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private TextBox txtConfirmPassword;
        private TextBox txtFullName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbGender;
        private Panel panel3;
        private TextBox txtUsername;
        private Label label11;
        private Label label10;
        private Panel panel4;
        private Label label12;
        private Label label13;
        private ComboBox cmbExperience;
        private Label label14;
        private ComboBox cmbSubject;
        private Button button1;
        private Button btnBack;
        private Label label17;
        private Label label16;
        private ComboBox comboBox4;
        private Label label15;
        private ComboBox cmbDegree;
    }
}