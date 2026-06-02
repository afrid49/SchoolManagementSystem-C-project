using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    partial class ManageMedicalCenter
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnBack;

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
            lblTitle = new Label();
            btnBack = new Button();
            label1 = new Label();
            btnAddStudent = new Button();
            btnDelete = new Button();
            btnEditStudent = new Button();
            dataGridViewStudents = new DataGridView();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightSeaGreen;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(901, 55);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Medical Center";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(798, 570);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(879, 40);
            label1.TabIndex = 2;
            label1.Text = "List of Medical Records";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(0, 101);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(107, 37);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(776, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditStudent.Location = new Point(657, 101);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(110, 37);
            btnEditStudent.TabIndex = 5;
            btnEditStudent.Text = "Edit";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEdit_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(0, 144);
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersVisible = false;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(901, 420);
            dataGridViewStudents.TabIndex = 6;
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;
            // 
            // ManageMedicalCenter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 622);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnEditStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(panelHeader);
            Name = "ManageMedicalCenter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Medical Center";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        private Label label1;
        private Button btnAddStudent;
        private Button btnDelete;
        private Button btnEditStudent;
        private DataGridView dataGridViewStudents;
    }
}