namespace SchoolManagementSystem
{
    partial class CreateEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnRemoveMedicine;
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintPrescription;
        private System.Drawing.Printing.PrintDocument printDocumentPrescription;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPrescription;

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
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            lblStudentID = new System.Windows.Forms.Label();
            txtStudentID = new System.Windows.Forms.TextBox();
            lblProblem = new System.Windows.Forms.Label();
            txtProblem = new System.Windows.Forms.TextBox();
            lblTreatment = new System.Windows.Forms.Label();
            txtTreatment = new System.Windows.Forms.TextBox();
            lblMedicineName = new System.Windows.Forms.Label();
            txtMedicineName = new System.Windows.Forms.TextBox();
            lblDosage = new System.Windows.Forms.Label();
            txtDosage = new System.Windows.Forms.TextBox();
            lblInstructions = new System.Windows.Forms.Label();
            txtInstructions = new System.Windows.Forms.TextBox();
            btnAddMedicine = new System.Windows.Forms.Button();
            btnRemoveMedicine = new System.Windows.Forms.Button();
            dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            lblVisitDate = new System.Windows.Forms.Label();
            dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            lblDoctorName = new System.Windows.Forms.Label();
            txtDoctorName = new System.Windows.Forms.TextBox();
            lblRemarks = new System.Windows.Forms.Label();
            txtRemarks = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnPrintPrescription = new System.Windows.Forms.Button();
            printDocumentPrescription = new System.Drawing.Printing.PrintDocument();
            printPreviewDialogPrescription = new System.Windows.Forms.PrintPreviewDialog();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).BeginInit();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(900, 60);
            panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(340, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create / Edit Medical Record";

            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new System.Drawing.Point(60, 85);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new System.Drawing.Size(79, 20);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID";

            // 
            // txtStudentID
            // 
            txtStudentID.Location = new System.Drawing.Point(190, 81);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new System.Drawing.Size(220, 27);
            txtStudentID.TabIndex = 2;

            // 
            // lblProblem
            // 
            lblProblem.AutoSize = true;
            lblProblem.Location = new System.Drawing.Point(60, 125);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new System.Drawing.Size(65, 20);
            lblProblem.TabIndex = 3;
            lblProblem.Text = "Problem";

            // 
            // txtProblem
            // 
            txtProblem.Location = new System.Drawing.Point(190, 121);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new System.Drawing.Size(620, 27);
            txtProblem.TabIndex = 4;

            // 
            // lblTreatment
            // 
            lblTreatment.AutoSize = true;
            lblTreatment.Location = new System.Drawing.Point(60, 165);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new System.Drawing.Size(76, 20);
            lblTreatment.TabIndex = 5;
            lblTreatment.Text = "Treatment";

            // 
            // txtTreatment
            // 
            txtTreatment.Location = new System.Drawing.Point(190, 161);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.Size = new System.Drawing.Size(620, 27);
            txtTreatment.TabIndex = 6;

            // 
            // lblMedicineName
            // 
            lblMedicineName.AutoSize = true;
            lblMedicineName.Location = new System.Drawing.Point(60, 210);
            lblMedicineName.Name = "lblMedicineName";
            lblMedicineName.Size = new System.Drawing.Size(113, 20);
            lblMedicineName.TabIndex = 7;
            lblMedicineName.Text = "Medicine Name";

            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new System.Drawing.Point(190, 206);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new System.Drawing.Size(220, 27);
            txtMedicineName.TabIndex = 8;

            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new System.Drawing.Point(430, 210);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new System.Drawing.Size(57, 20);
            lblDosage.TabIndex = 9;
            lblDosage.Text = "Dosage";

            // 
            // txtDosage
            // 
            txtDosage.Location = new System.Drawing.Point(495, 206);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new System.Drawing.Size(150, 27);
            txtDosage.TabIndex = 10;

            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new System.Drawing.Point(60, 250);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new System.Drawing.Size(86, 20);
            lblInstructions.TabIndex = 11;
            lblInstructions.Text = "Instructions";

            // 
            // txtInstructions
            // 
            txtInstructions.Location = new System.Drawing.Point(190, 246);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new System.Drawing.Size(455, 27);
            txtInstructions.TabIndex = 12;

            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new System.Drawing.Point(660, 204);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new System.Drawing.Size(150, 32);
            btnAddMedicine.TabIndex = 13;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;

            // 
            // btnRemoveMedicine
            // 
            btnRemoveMedicine.Location = new System.Drawing.Point(660, 244);
            btnRemoveMedicine.Name = "btnRemoveMedicine";
            btnRemoveMedicine.Size = new System.Drawing.Size(150, 32);
            btnRemoveMedicine.TabIndex = 14;
            btnRemoveMedicine.Text = "Remove Medicine";
            btnRemoveMedicine.UseVisualStyleBackColor = true;
            btnRemoveMedicine.Click += btnRemoveMedicine_Click;

            // 
            // dataGridViewMedicines
            // 
            dataGridViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicines.Location = new System.Drawing.Point(190, 290);
            dataGridViewMedicines.Name = "dataGridViewMedicines";
            dataGridViewMedicines.RowHeadersWidth = 51;
            dataGridViewMedicines.Size = new System.Drawing.Size(620, 130);
            dataGridViewMedicines.TabIndex = 15;

            // 
            // lblVisitDate
            // 
            lblVisitDate.AutoSize = true;
            lblVisitDate.Location = new System.Drawing.Point(60, 440);
            lblVisitDate.Name = "lblVisitDate";
            lblVisitDate.Size = new System.Drawing.Size(73, 20);
            lblVisitDate.TabIndex = 16;
            lblVisitDate.Text = "Visit Date";

            // 
            // dtpVisitDate
            // 
            dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpVisitDate.Location = new System.Drawing.Point(190, 436);
            dtpVisitDate.Name = "dtpVisitDate";
            dtpVisitDate.Size = new System.Drawing.Size(220, 27);
            dtpVisitDate.TabIndex = 17;

            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new System.Drawing.Point(430, 440);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new System.Drawing.Size(143, 20);
            lblDoctorName.TabIndex = 18;
            lblDoctorName.Text = "Doctor/Nurse Name";

            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new System.Drawing.Point(585, 436);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new System.Drawing.Size(225, 27);
            txtDoctorName.TabIndex = 19;

            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new System.Drawing.Point(60, 485);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new System.Drawing.Size(65, 20);
            lblRemarks.TabIndex = 20;
            lblRemarks.Text = "Remarks";

            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(190, 481);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new System.Drawing.Size(620, 27);
            txtRemarks.TabIndex = 21;

            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(190, 535);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(300, 535);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(100, 35);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // 
            // btnPrintPrescription
            // 
            btnPrintPrescription.Location = new System.Drawing.Point(410, 535);
            btnPrintPrescription.Name = "btnPrintPrescription";
            btnPrintPrescription.Size = new System.Drawing.Size(100, 35);
            btnPrintPrescription.TabIndex = 24;
            btnPrintPrescription.Text = "Print";
            btnPrintPrescription.UseVisualStyleBackColor = true;
            btnPrintPrescription.Click += btnPrintPrescription_Click;

            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(520, 535);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(100, 35);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // 
            // printDocumentPrescription
            // 
            printDocumentPrescription.PrintPage += printDocumentPrescription_PrintPage;

            // 
            // printPreviewDialogPrescription
            // 
            printPreviewDialogPrescription.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialogPrescription.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialogPrescription.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialogPrescription.Enabled = true;
            printPreviewDialogPrescription.Name = "printPreviewDialogPrescription";
            printPreviewDialogPrescription.Visible = false;

            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 620);
            Controls.Add(panelHeader);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(lblProblem);
            Controls.Add(txtProblem);
            Controls.Add(lblTreatment);
            Controls.Add(txtTreatment);
            Controls.Add(lblMedicineName);
            Controls.Add(txtMedicineName);
            Controls.Add(lblDosage);
            Controls.Add(txtDosage);
            Controls.Add(lblInstructions);
            Controls.Add(txtInstructions);
            Controls.Add(btnAddMedicine);
            Controls.Add(btnRemoveMedicine);
            Controls.Add(dataGridViewMedicines);
            Controls.Add(lblVisitDate);
            Controls.Add(dtpVisitDate);
            Controls.Add(lblDoctorName);
            Controls.Add(txtDoctorName);
            Controls.Add(lblRemarks);
            Controls.Add(txtRemarks);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnPrintPrescription);
            Controls.Add(btnBack);
            Name = "CreateEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create / Edit Medical Record";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}