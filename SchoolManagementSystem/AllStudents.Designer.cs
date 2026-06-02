namespace SchoolManagementSystem
{
    partial class AllStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStudents));
            panel1 = new Panel();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridViewStudents = new DataGridView();
            panel2 = new Panel();
            btnLogOut = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridViewStudents);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 599);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(889, 519);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 35);
            btnBack.TabIndex = 37;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(12, 524);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 527);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 27);
            txtSearch.TabIndex = 35;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Dock = DockStyle.Top;
            dataGridViewStudents.Location = new Point(0, 0);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(978, 513);
            dataGridViewStudents.TabIndex = 0;
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
            panel2.TabIndex = 30;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Turquoise;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(876, 8);
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
            // AllStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AllStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllStudents";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewStudents;
        private Panel panel2;
        private Button btnLogOut;
        private Label label1;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}