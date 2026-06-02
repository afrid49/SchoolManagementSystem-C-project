namespace SchoolManagementSystem
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private DataGridView dataGridViewStudent;
        private Panel panel2;
        private Button btnLogOut;
        private Label label1;
        private Label lblTitle;

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
            panel1 = new Panel();
            dataGridViewStudent = new DataGridView();
            lblTitle = new Label();
            panel2 = new Panel();
            btnLogOut = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridViewStudent);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 479);
            panel1.TabIndex = 0;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(20, 70);
            dataGridViewStudent.MultiSelect = false;
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent.Size = new Size(840, 380);
            dataGridViewStudent.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Marks / Results";
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
            panel2.Size = new Size(882, 53);
            panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Turquoise;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(778, 9);
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
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 532);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }
    }
}