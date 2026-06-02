namespace SchoolManagementSystem
{
    partial class TeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            panel1 = new Panel();
            btnBack = new Button();
            btnSchedules = new Button();
            button5 = new Button();
            btnMarksManagements = new Button();
            btnAllStudent = new Button();
            panel2 = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            panel3 = new Panel();
            lblTotalStudents = new Label();
            lblTotalStudens = new Label();
            panel4 = new Panel();
            lblTotalCourses = new Label();
            Label8 = new Label();
            panel6 = new Panel();
            lblTotalClasses = new Label();
            Label9 = new Label();
            panel7 = new Panel();
            btnAllStudents = new Button();
            label11 = new Label();
            panel8 = new Panel();
            btnMarksManagement = new Button();
            label12 = new Label();
            panel10 = new Panel();
            button10 = new Button();
            label16 = new Label();
            panel11 = new Panel();
            btnClassSchedule = new Button();
            label18 = new Label();
            label20 = new Label();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();

            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSchedules);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnMarksManagements);
            panel1.Controls.Add(btnAllStudent);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 591);
            panel1.TabIndex = 0;

            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Turquoise;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(5, 527);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(218, 53);
            btnBack.TabIndex = 6;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // 
            // btnSchedules
            // 
            btnSchedules.BackColor = Color.Aquamarine;
            btnSchedules.Cursor = Cursors.Hand;
            btnSchedules.FlatStyle = FlatStyle.Flat;
            btnSchedules.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchedules.Location = new Point(-2, 169);
            btnSchedules.Name = "btnSchedules";
            btnSchedules.Size = new Size(229, 51);
            btnSchedules.TabIndex = 5;
            btnSchedules.Text = "🗓️Class Schedule";
            btnSchedules.UseVisualStyleBackColor = false;
            btnSchedules.Click += btnSchedules_Click;

            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(-2, 236);
            button5.Name = "button5";
            button5.Size = new Size(229, 51);
            button5.TabIndex = 4;
            button5.Text = "☑️Attendance Management";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;

            // 
            // btnMarksManagements
            // 
            btnMarksManagements.BackColor = Color.Aquamarine;
            btnMarksManagements.Cursor = Cursors.Hand;
            btnMarksManagements.FlatStyle = FlatStyle.Flat;
            btnMarksManagements.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarksManagements.Location = new Point(-2, 102);
            btnMarksManagements.Name = "btnMarksManagements";
            btnMarksManagements.Size = new Size(229, 51);
            btnMarksManagements.TabIndex = 3;
            btnMarksManagements.Text = "📝Marks Management";
            btnMarksManagements.UseVisualStyleBackColor = false;
            btnMarksManagements.Click += btnMarksManagements_Click;

            // 
            // btnAllStudent
            // 
            btnAllStudent.BackColor = Color.Aquamarine;
            btnAllStudent.Cursor = Cursors.Hand;
            btnAllStudent.FlatStyle = FlatStyle.Flat;
            btnAllStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllStudent.Location = new Point(-2, 35);
            btnAllStudent.Name = "btnAllStudent";
            btnAllStudent.Size = new Size(229, 51);
            btnAllStudent.TabIndex = 1;
            btnAllStudent.Text = "👤All Students";
            btnAllStudent.UseVisualStyleBackColor = false;
            btnAllStudent.Click += btnAllStudent_Click;

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
            panel2.Size = new Size(882, 53);
            panel2.TabIndex = 2;

            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Turquoise;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(772, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(92, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;

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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblTotalStudents);
            panel3.Controls.Add(lblTotalStudens);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(285, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 75);
            panel3.TabIndex = 3;

            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStudents.Location = new Point(70, 29);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(42, 29);
            lblTotalStudents.TabIndex = 1;
            lblTotalStudents.Text = "0";

            // 
            // lblTotalStudens
            // 
            lblTotalStudens.AutoSize = true;
            lblTotalStudens.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudens.ForeColor = Color.DimGray;
            lblTotalStudens.Location = new Point(31, 0);
            lblTotalStudens.Name = "lblTotalStudens";
            lblTotalStudens.Size = new Size(110, 20);
            lblTotalStudens.TabIndex = 0;
            lblTotalStudens.Text = "Total Students";

            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lblTotalCourses);
            panel4.Controls.Add(Label8);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(489, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(176, 75);
            panel4.TabIndex = 4;

            // 
            // lblTotalCourses
            // 
            lblTotalCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCourses.Location = new Point(74, 29);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(45, 29);
            lblTotalCourses.TabIndex = 1;
            lblTotalCourses.Text = "0";

            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.DimGray;
            Label8.Location = new Point(40, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(106, 20);
            Label8.TabIndex = 0;
            Label8.Text = "Total Subjects";

            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(lblTotalClasses);
            panel6.Controls.Add(Label9);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(694, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 75);
            panel6.TabIndex = 6;

            // 
            // lblTotalClasses
            // 
            lblTotalClasses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalClasses.Location = new Point(78, 29);
            lblTotalClasses.Name = "lblTotalClasses";
            lblTotalClasses.Size = new Size(50, 29);
            lblTotalClasses.TabIndex = 1;
            lblTotalClasses.Text = "0";

            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.DimGray;
            Label9.Location = new Point(37, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(98, 20);
            Label9.TabIndex = 0;
            Label9.Text = "Total Classes";

            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(btnAllStudents);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(285, 266);
            panel7.Name = "panel7";
            panel7.Size = new Size(178, 132);
            panel7.TabIndex = 7;

            // 
            // btnAllStudents
            // 
            btnAllStudents.BackColor = Color.DarkBlue;
            btnAllStudents.Dock = DockStyle.Top;
            btnAllStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllStudents.ForeColor = Color.White;
            btnAllStudents.Location = new Point(0, 0);
            btnAllStudents.Name = "btnAllStudents";
            btnAllStudents.Size = new Size(174, 62);
            btnAllStudents.TabIndex = 2;
            btnAllStudents.Text = "👤All Students";
            btnAllStudents.UseVisualStyleBackColor = false;
            btnAllStudents.Click += btnAllStudents_Click;

            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 65);
            label11.Name = "label11";
            label11.Size = new Size(155, 49);
            label11.TabIndex = 1;
            label11.Text = "View Student Details, Search Student";

            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(btnMarksManagement);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(489, 266);
            panel8.Name = "panel8";
            panel8.Size = new Size(178, 132);
            panel8.TabIndex = 8;

            // 
            // btnMarksManagement
            // 
            btnMarksManagement.BackColor = Color.DarkBlue;
            btnMarksManagement.Dock = DockStyle.Top;
            btnMarksManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarksManagement.ForeColor = Color.White;
            btnMarksManagement.Location = new Point(0, 0);
            btnMarksManagement.Name = "btnMarksManagement";
            btnMarksManagement.Size = new Size(174, 62);
            btnMarksManagement.TabIndex = 3;
            btnMarksManagement.Text = "📝Marks Management";
            btnMarksManagement.UseVisualStyleBackColor = false;
            btnMarksManagement.Click += btnMarksManagement_Click;

            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 65);
            label12.Name = "label12";
            label12.Size = new Size(155, 49);
            label12.TabIndex = 1;
            label12.Text = "Add or Update Student Marks- Mid/Final";

            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(button10);
            panel10.Controls.Add(label16);
            panel10.Location = new Point(285, 447);
            panel10.Name = "panel10";
            panel10.Size = new Size(178, 132);
            panel10.TabIndex = 10;

            // 
            // button10
            // 
            button10.BackColor = Color.DarkBlue;
            button10.Dock = DockStyle.Top;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 0);
            button10.Name = "button10";
            button10.Size = new Size(174, 62);
            button10.TabIndex = 3;
            button10.Text = "☑️Attendance Management";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;

            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 65);
            label16.Name = "label16";
            label16.Size = new Size(155, 49);
            label16.TabIndex = 1;
            label16.Text = "Mark Present / Absent";

            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Controls.Add(btnClassSchedule);
            panel11.Controls.Add(label18);
            panel11.Location = new Point(692, 266);
            panel11.Name = "panel11";
            panel11.Size = new Size(178, 132);
            panel11.TabIndex = 11;

            // 
            // btnClassSchedule
            // 
            btnClassSchedule.BackColor = Color.DarkBlue;
            btnClassSchedule.Dock = DockStyle.Top;
            btnClassSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassSchedule.ForeColor = Color.White;
            btnClassSchedule.Location = new Point(0, 0);
            btnClassSchedule.Name = "btnClassSchedule";
            btnClassSchedule.Size = new Size(174, 62);
            btnClassSchedule.TabIndex = 3;
            btnClassSchedule.Text = "🗓️Class Schedule";
            btnClassSchedule.UseVisualStyleBackColor = false;
            btnClassSchedule.Click += btnClassSchedule_Click;

            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 65);
            label18.Name = "label18";
            label18.Size = new Size(155, 49);
            label18.TabIndex = 1;
            label18.Text = "View Class Timings";

            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(235, 82);
            label20.Name = "label20";
            label20.Size = new Size(193, 28);
            label20.TabIndex = 12;
            label20.Text = "Teacher Dashboard";

            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(882, 653);
            Controls.Add(label20);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeacherDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashboard";

            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnBack;
        private Label label1;
        private Panel panel3;
        private Label lblTotalStudents;
        private Label lblTotalStudens;
        private Panel panel4;
        private Label lblTotalCourses;
        private Label Label8;
        private Panel panel6;
        private Label lblTotalClasses;
        private Label Label9;
        private Panel panel7;
        private Label label11;
        private Panel panel8;
        private Label label12;
        private Panel panel10;
        private Label label16;
        private Panel panel11;
        private Label label18;
        private Button btnMarksManagements;
        private Button btnAllStudent;
        private Button btnSchedules;
        private Button button5;
        private Label label20;
        private Button btnAllStudents;
        private Button btnMarksManagement;
        private Button button10;
        private Button btnClassSchedule;
    }
}