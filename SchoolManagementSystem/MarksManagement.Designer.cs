namespace SchoolManagementSystem
{
    partial class MarksManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksManagement));
            btnLogOut = new Button();
            label1 = new Label();
            dataGridViewMaks = new DataGridView();
            panel1 = new Panel();
            btnClearField = new Button();
            btnAddMarks = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnUpdateMarks = new Button();
            panel2 = new Panel();
            txtMidMarks = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label13 = new Label();
            txtFinalMarks = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaks).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            // dataGridViewMaks
            // 
            dataGridViewMaks.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewMaks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaks.Dock = DockStyle.Bottom;
            dataGridViewMaks.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewMaks.Location = new Point(0, 44);
            dataGridViewMaks.Name = "dataGridViewMaks";
            dataGridViewMaks.RowHeadersWidth = 51;
            dataGridViewMaks.Size = new Size(978, 389);
            dataGridViewMaks.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClearField);
            panel1.Controls.Add(btnAddMarks);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnUpdateMarks);
            panel1.Controls.Add(dataGridViewMaks);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 437);
            panel1.TabIndex = 31;
            // 
            // btnClearField
            // 
            btnClearField.Cursor = Cursors.Hand;
            btnClearField.Location = new Point(808, 3);
            btnClearField.Name = "btnClearField";
            btnClearField.Size = new Size(75, 35);
            btnClearField.TabIndex = 38;
            btnClearField.Text = "Clear";
            btnClearField.UseVisualStyleBackColor = true;
            btnClearField.Click += btnClearField_Click;
            // 
            // btnAddMarks
            // 
            btnAddMarks.Cursor = Cursors.Hand;
            btnAddMarks.Location = new Point(637, 3);
            btnAddMarks.Name = "btnAddMarks";
            btnAddMarks.Size = new Size(78, 35);
            btnAddMarks.TabIndex = 36;
            btnAddMarks.Text = "Add";
            btnAddMarks.UseVisualStyleBackColor = true;
            btnAddMarks.Click += btnAddMarks_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(889, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 35);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(12, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 33);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 27);
            txtSearch.TabIndex = 32;
            // 
            // btnUpdateMarks
            // 
            btnUpdateMarks.Cursor = Cursors.Hand;
            btnUpdateMarks.Location = new Point(721, 3);
            btnUpdateMarks.Name = "btnUpdateMarks";
            btnUpdateMarks.Size = new Size(82, 35);
            btnUpdateMarks.TabIndex = 35;
            btnUpdateMarks.Text = "Update";
            btnUpdateMarks.UseVisualStyleBackColor = true;
            btnUpdateMarks.Click += btnUpdateMarks_Click;
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
            panel2.TabIndex = 33;
            // 
            // txtMidMarks
            // 
            txtMidMarks.BorderStyle = BorderStyle.FixedSingle;
            txtMidMarks.Location = new Point(398, 70);
            txtMidMarks.Name = "txtMidMarks";
            txtMidMarks.Size = new Size(209, 27);
            txtMidMarks.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(398, 44);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Mid Marks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 11);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 24;
            label8.Text = "👤 Add Marks";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(652, 44);
            label13.Name = "label13";
            label13.Size = new Size(89, 23);
            label13.TabIndex = 4;
            label13.Text = "Final Marks";
            // 
            // txtFinalMarks
            // 
            txtFinalMarks.BorderStyle = BorderStyle.FixedSingle;
            txtFinalMarks.Location = new Point(652, 70);
            txtFinalMarks.Name = "txtFinalMarks";
            txtFinalMarks.Size = new Size(213, 27);
            txtFinalMarks.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(78, 70);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(262, 27);
            txtFullName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 44);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 25;
            label3.Text = "FULL NAME";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(txtFinalMarks);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtMidMarks);
            panel3.Location = new Point(2, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 132);
            panel3.TabIndex = 32;
            // 
            // MarksManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MarksManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarksManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogOut;
        private Label label1;
        private DataGridView dataGridViewMaks;
        private Panel panel1;
        private Panel panel2;
        private Button btnClearField;
        private Button btnAddMarks;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnUpdateMarks;
        private TextBox txtMidMarks;
        private Label label2;
        private Label label8;
        private Label label13;
        private TextBox txtFinalMarks;
        private TextBox txtFullName;
        private Label label3;
        private Panel panel3;
    }
}