namespace SchoolManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            label1 = new Label();
            panel1 = new Panel();
            btnLogOut = new Button();
            panel2 = new Panel();
            lblTotalStudents = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblTotalTeachers = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblTotalCourses = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblTotalMedicalRecords = new Label();
            label11 = new Label();
            btnManageTeachers = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnManageStudents = new Button();
            label8 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnManageCourses = new Button();
            label9 = new Label();
            label10 = new Label();
            btnBack = new Button();
            panel5 = new Panel();
            button1 = new Button();
            btnManageMedicalCenter = new Button();
            btnManageCourse = new Button();
            btnManageStudent = new Button();
            btnManageTeacher = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();

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
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 53);
            panel1.TabIndex = 1;

            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Turquoise;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(940, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(92, 38);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;

            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblTotalStudents);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(247, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 92);
            panel2.TabIndex = 2;

            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStudents.Location = new Point(72, 31);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(43, 40);
            lblTotalStudents.TabIndex = 1;
            lblTotalStudents.Text = "0";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(30, 2);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 0;
            label3.Text = "Total Students";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 4;
            label2.Text = "Dashboard";

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(222, 107);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 5;
            label6.Text = "Overview";

            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblTotalTeachers);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(441, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 92);
            panel3.TabIndex = 3;

            // 
            // lblTotalTeachers
            // 
            lblTotalTeachers.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTeachers.Location = new Point(72, 31);
            lblTotalTeachers.Name = "lblTotalTeachers";
            lblTotalTeachers.Size = new Size(40, 40);
            lblTotalTeachers.TabIndex = 12;
            lblTotalTeachers.Text = "0";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(30, 2);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 0;
            label4.Text = "Total Teachers";

            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lblTotalCourses);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(635, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 92);
            panel4.TabIndex = 3;

            // 
            // lblTotalCourses
            // 
            lblTotalCourses.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCourses.Location = new Point(68, 31);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(38, 40);
            lblTotalCourses.TabIndex = 12;
            lblTotalCourses.Text = "0";

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(30, 2);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 0;
            label5.Text = "Total Courses";

            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(lblTotalMedicalRecords);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(829, 170);
            panel6.Name = "panel6";
            panel6.Size = new Size(175, 92);
            panel6.TabIndex = 13;

            // 
            // lblTotalMedicalRecords
            // 
            lblTotalMedicalRecords.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalMedicalRecords.Location = new Point(68, 35);
            lblTotalMedicalRecords.Name = "lblTotalMedicalRecords";
            lblTotalMedicalRecords.Size = new Size(50, 40);
            lblTotalMedicalRecords.TabIndex = 12;
            lblTotalMedicalRecords.Text = "0";

            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.WindowFrame;
            label11.Location = new Point(8, 2);
            label11.Name = "label11";
            label11.Size = new Size(160, 25);
            label11.TabIndex = 0;
            label11.Text = "Total Medical Records";
            label11.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // btnManageTeachers
            // 
            btnManageTeachers.BackColor = Color.White;
            btnManageTeachers.Cursor = Cursors.Hand;
            btnManageTeachers.Dock = DockStyle.Top;
            btnManageTeachers.Location = new Point(3, 3);
            btnManageTeachers.Name = "btnManageTeachers";
            btnManageTeachers.Size = new Size(175, 48);
            btnManageTeachers.TabIndex = 6;
            btnManageTeachers.Text = "Manage Teachers";
            btnManageTeachers.UseVisualStyleBackColor = false;
            btnManageTeachers.Click += btnManageTeachers_Click;

            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(btnManageTeachers);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Location = new Point(247, 363);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(175, 92);
            flowLayoutPanel1.TabIndex = 7;

            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 54);
            label7.Name = "label7";
            label7.Size = new Size(175, 38);
            label7.TabIndex = 7;
            label7.Text = "Add, Edit, Delete";
            label7.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(btnManageStudents);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Location = new Point(446, 363);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(175, 92);
            flowLayoutPanel2.TabIndex = 8;

            // 
            // btnManageStudents
            // 
            btnManageStudents.BackColor = Color.White;
            btnManageStudents.Cursor = Cursors.Hand;
            btnManageStudents.Dock = DockStyle.Top;
            btnManageStudents.Location = new Point(3, 3);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(175, 48);
            btnManageStudents.TabIndex = 6;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = false;
            btnManageStudents.Click += btnManageStudents_Click;

            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 54);
            label8.Name = "label8";
            label8.Size = new Size(175, 38);
            label8.TabIndex = 7;
            label8.Text = "Add, Edit, Delete";
            label8.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel3.Controls.Add(btnManageCourses);
            flowLayoutPanel3.Controls.Add(label9);
            flowLayoutPanel3.Location = new Point(640, 363);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(175, 92);
            flowLayoutPanel3.TabIndex = 8;

            // 
            // btnManageCourses
            // 
            btnManageCourses.BackColor = Color.White;
            btnManageCourses.Cursor = Cursors.Hand;
            btnManageCourses.Dock = DockStyle.Top;
            btnManageCourses.Location = new Point(3, 3);
            btnManageCourses.Name = "btnManageCourses";
            btnManageCourses.Size = new Size(175, 48);
            btnManageCourses.TabIndex = 6;
            btnManageCourses.Text = "Manage Courses";
            btnManageCourses.UseVisualStyleBackColor = false;
            btnManageCourses.Click += btnManageCourses_Click;

            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 54);
            label9.Name = "label9";
            label9.Size = new Size(175, 38);
            label9.TabIndex = 7;
            label9.Text = "Add, Edit, Delete";
            label9.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(227, 311);
            label10.Name = "label10";
            label10.Size = new Size(172, 28);
            label10.TabIndex = 9;
            label10.Text = "Manage Activities";

            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Turquoise;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(-2, 489);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(216, 53);
            btnBack.TabIndex = 10;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btnManageMedicalCenter);
            panel5.Controls.Add(btnManageCourse);
            panel5.Controls.Add(btnBack);
            panel5.Controls.Add(btnManageStudent);
            panel5.Controls.Add(btnManageTeacher);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 549);
            panel5.TabIndex = 11;

            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 302);
            button1.Name = "button1";
            button1.Size = new Size(214, 48);
            button1.TabIndex = 12;
            button1.Text = "Manage Doctor/Nurse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnManageDoctorNurse_Click;

            // 
            // btnManageMedicalCenter
            // 
            btnManageMedicalCenter.BackColor = Color.White;
            btnManageMedicalCenter.Cursor = Cursors.Hand;
            btnManageMedicalCenter.FlatStyle = FlatStyle.Flat;
            btnManageMedicalCenter.Location = new Point(0, 243);
            btnManageMedicalCenter.Name = "btnManageMedicalCenter";
            btnManageMedicalCenter.Size = new Size(214, 48);
            btnManageMedicalCenter.TabIndex = 11;
            btnManageMedicalCenter.Text = "Manage Medical Center";
            btnManageMedicalCenter.UseVisualStyleBackColor = false;
            btnManageMedicalCenter.Click += btnManageMedicalCenter_Click;

            // 
            // btnManageCourse
            // 
            btnManageCourse.BackColor = Color.White;
            btnManageCourse.Cursor = Cursors.Hand;
            btnManageCourse.FlatStyle = FlatStyle.Flat;
            btnManageCourse.Location = new Point(-2, 177);
            btnManageCourse.Name = "btnManageCourse";
            btnManageCourse.Size = new Size(214, 48);
            btnManageCourse.TabIndex = 10;
            btnManageCourse.Text = "Manage Courses";
            btnManageCourse.UseVisualStyleBackColor = false;
            btnManageCourse.Click += btnManageCourse_Click;

            // 
            // btnManageStudent
            // 
            btnManageStudent.BackColor = Color.White;
            btnManageStudent.Cursor = Cursors.Hand;
            btnManageStudent.FlatStyle = FlatStyle.Flat;
            btnManageStudent.Location = new Point(0, 111);
            btnManageStudent.Name = "btnManageStudent";
            btnManageStudent.Size = new Size(214, 48);
            btnManageStudent.TabIndex = 9;
            btnManageStudent.Text = "Manage Students";
            btnManageStudent.UseVisualStyleBackColor = false;
            btnManageStudent.Click += btnManageStudent_Click;

            // 
            // btnManageTeacher
            // 
            btnManageTeacher.BackColor = Color.White;
            btnManageTeacher.Cursor = Cursors.Hand;
            btnManageTeacher.FlatStyle = FlatStyle.Flat;
            btnManageTeacher.Location = new Point(0, 46);
            btnManageTeacher.Name = "btnManageTeacher";
            btnManageTeacher.Size = new Size(214, 48);
            btnManageTeacher.TabIndex = 8;
            btnManageTeacher.Text = "Manage Teachers";
            btnManageTeacher.UseVisualStyleBackColor = false;
            btnManageTeacher.Click += btnManageTeacher_Click;

            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1050, 603);
            Controls.Add(panel5);
            Controls.Add(label10);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnLogOut;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label6;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Panel panel6;
        private Label label11;
        private Button btnManageTeachers;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnManageStudents;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnManageCourses;
        private Label label9;
        private Label label10;
        private Button btnBack;
        private Panel panel5;
        private Button btnManageCourse;
        private Button btnManageStudent;
        private Button btnManageTeacher;
        private Label lblTotalStudents;
        private Label lblTotalTeachers;
        private Label lblTotalCourses;
        private Label lblTotalMedicalRecords;
        private Button btnManageMedicalCenter;
        private Button button1;
    }
}