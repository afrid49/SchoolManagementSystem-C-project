using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class CreateEditForm : Form
    {
        string prescriptionText = "";
        int medicalRecordId = 0;
        bool isEditMode = false;
        string currentRole = "Admin";

        DataTable medicineTable = new DataTable();

        public CreateEditForm()
        {
            InitializeComponent();
            SetupMedicineTable();
        }

        public CreateEditForm(string role)
        {
            InitializeComponent();
            currentRole = role;
            SetupMedicineTable();
        }

        public CreateEditForm(int studentId)
        {
            InitializeComponent();
            SetupMedicineTable();
            txtStudentID.Text = studentId.ToString();
        }

        public CreateEditForm(int studentId, string role)
        {
            InitializeComponent();
            currentRole = role;
            SetupMedicineTable();
            txtStudentID.Text = studentId.ToString();
        }

        public CreateEditForm(int recordId, bool editMode)
        {
            InitializeComponent();
            SetupMedicineTable();

            medicalRecordId = recordId;
            isEditMode = editMode;

            if (isEditMode)
            {
                LoadMedicalRecordForEdit();
                btnSave.Text = "Update";
            }
        }

        public CreateEditForm(int recordId, bool editMode, string role)
        {
            InitializeComponent();
            SetupMedicineTable();

            medicalRecordId = recordId;
            isEditMode = editMode;
            currentRole = role;

            if (isEditMode)
            {
                LoadMedicalRecordForEdit();
                btnSave.Text = "Update";
            }
        }

        private void SetupMedicineTable()
        {
            medicineTable.Columns.Clear();
            medicineTable.Columns.Add("MedicineName");
            medicineTable.Columns.Add("Dosage");
            medicineTable.Columns.Add("Instructions");

            dataGridViewMedicines.DataSource = medicineTable;

            dataGridViewMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedicines.MultiSelect = false;
            dataGridViewMedicines.ReadOnly = true;
            dataGridViewMedicines.AllowUserToAddRows = false;
            dataGridViewMedicines.AllowUserToDeleteRows = false;
        }

        private void LoadMedicalRecordForEdit()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        MedicalRecordID,
                        StudentID,
                        Problem,
                        Treatment,
                        VisitDate,
                        DoctorName,
                        Remarks
                    FROM MedicalRecords
                    WHERE MedicalRecordID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", medicalRecordId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtStudentID.Text = reader["StudentID"].ToString();
                                txtProblem.Text = reader["Problem"].ToString();
                                txtTreatment.Text = reader["Treatment"].ToString();

                                if (reader["VisitDate"] != DBNull.Value)
                                {
                                    dtpVisitDate.Value = Convert.ToDateTime(reader["VisitDate"]);
                                }

                                txtDoctorName.Text = reader["DoctorName"].ToString();
                                txtRemarks.Text = reader["Remarks"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Medical record not found!");
                            }
                        }
                    }

                    LoadMedicinesForEdit(con);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record load korte problem hocche:\n" + ex.Message);
            }
        }

        private void LoadMedicinesForEdit(SqlConnection con)
        {
            medicineTable.Rows.Clear();

            string query = @"
            SELECT MedicineName, Dosage, Instructions
            FROM MedicalRecordMedicines
            WHERE MedicalRecordID = @medicalRecordId
            ORDER BY MedicineID ASC";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@medicalRecordId", medicalRecordId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        medicineTable.Rows.Add(
                            reader["MedicineName"].ToString(),
                            reader["Dosage"].ToString(),
                            reader["Instructions"].ToString()
                        );
                    }
                }
            }
        }

        private bool ValidateFields()
        {
            if (txtStudentID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Student ID!");
                txtStudentID.Focus();
                return false;
            }

            if (!int.TryParse(txtStudentID.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Student ID must be a number!");
                txtStudentID.Focus();
                return false;
            }

            if (txtProblem.Text.Trim() == "")
            {
                MessageBox.Show("Please enter problem!");
                txtProblem.Focus();
                return false;
            }

            if (txtTreatment.Text.Trim() == "")
            {
                MessageBox.Show("Please enter treatment!");
                txtTreatment.Focus();
                return false;
            }

            if (medicineTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one medicine!");
                txtMedicineName.Focus();
                return false;
            }

            if (txtDoctorName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter doctor/nurse name!");
                txtDoctorName.Focus();
                return false;
            }

            return true;
        }

        private bool StudentExists(int studentId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @studentId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private string BuildMedicineSummary()
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in medicineTable.Rows)
            {
                sb.AppendLine(row["MedicineName"].ToString());
                sb.AppendLine(row["Dosage"].ToString());

                string instructions = row["Instructions"].ToString();

                if (instructions != "")
                {
                    sb.AppendLine(instructions);
                }

                sb.AppendLine();
            }

            return sb.ToString().Trim();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter medicine name!");
                txtMedicineName.Focus();
                return;
            }

            if (txtDosage.Text.Trim() == "")
            {
                MessageBox.Show("Please enter dosage!");
                txtDosage.Focus();
                return;
            }

            medicineTable.Rows.Add(
                txtMedicineName.Text.Trim(),
                txtDosage.Text.Trim(),
                txtInstructions.Text.Trim()
            );

            txtMedicineName.Clear();
            txtDosage.Clear();
            txtInstructions.Clear();
            txtMedicineName.Focus();
        }

        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a medicine row first!");
                return;
            }

            int rowIndex = dataGridViewMedicines.SelectedRows[0].Index;

            if (rowIndex >= 0 && rowIndex < medicineTable.Rows.Count)
            {
                medicineTable.Rows.RemoveAt(rowIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            int studentId = Convert.ToInt32(txtStudentID.Text.Trim());

            try
            {
                if (!StudentExists(studentId))
                {
                    MessageBox.Show("This Student ID does not exist!");
                    return;
                }

                if (isEditMode)
                {
                    UpdateMedicalRecord(studentId);
                }
                else
                {
                    AddMedicalRecord(studentId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save/Update korte problem hocche:\n" + ex.Message);
            }
        }

        private void AddMedicalRecord(int studentId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string query = @"
                    INSERT INTO MedicalRecords
                    (StudentID, Problem, Treatment, Medicine, VisitDate, DoctorName, Remarks)
                    OUTPUT INSERTED.MedicalRecordID
                    VALUES
                    (@studentId, @problem, @treatment, @medicine, @visitDate, @doctorName, @remarks)";

                    int newMedicalRecordId;

                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@problem", txtProblem.Text.Trim());
                        cmd.Parameters.AddWithValue("@treatment", txtTreatment.Text.Trim());
                        cmd.Parameters.AddWithValue("@medicine", BuildMedicineSummary());
                        cmd.Parameters.AddWithValue("@visitDate", dtpVisitDate.Value.Date);
                        cmd.Parameters.AddWithValue("@doctorName", txtDoctorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());

                        newMedicalRecordId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    SaveMedicines(con, transaction, newMedicalRecordId);

                    transaction.Commit();

                    MessageBox.Show("Medical record saved successfully!");

                    ManageMedicalCenter manageMedicalCenter = new ManageMedicalCenter(currentRole);
                    manageMedicalCenter.Show();
                    this.Hide();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void UpdateMedicalRecord(int studentId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string query = @"
                    UPDATE MedicalRecords
                    SET
                        StudentID = @studentId,
                        Problem = @problem,
                        Treatment = @treatment,
                        Medicine = @medicine,
                        VisitDate = @visitDate,
                        DoctorName = @doctorName,
                        Remarks = @remarks
                    WHERE MedicalRecordID = @medicalRecordId";

                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@medicalRecordId", medicalRecordId);
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@problem", txtProblem.Text.Trim());
                        cmd.Parameters.AddWithValue("@treatment", txtTreatment.Text.Trim());
                        cmd.Parameters.AddWithValue("@medicine", BuildMedicineSummary());
                        cmd.Parameters.AddWithValue("@visitDate", dtpVisitDate.Value.Date);
                        cmd.Parameters.AddWithValue("@doctorName", txtDoctorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    string deleteOldMedicinesQuery = @"
                    DELETE FROM MedicalRecordMedicines
                    WHERE MedicalRecordID = @medicalRecordId";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteOldMedicinesQuery, con, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@medicalRecordId", medicalRecordId);
                        deleteCmd.ExecuteNonQuery();
                    }

                    SaveMedicines(con, transaction, medicalRecordId);

                    transaction.Commit();

                    MessageBox.Show("Medical record updated successfully!");

                    ManageMedicalCenter manageMedicalCenter = new ManageMedicalCenter(currentRole);
                    manageMedicalCenter.Show();
                    this.Hide();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void SaveMedicines(SqlConnection con, SqlTransaction transaction, int recordId)
        {
            foreach (DataRow row in medicineTable.Rows)
            {
                string query = @"
                INSERT INTO MedicalRecordMedicines
                (MedicalRecordID, MedicineName, Dosage, Instructions)
                VALUES
                (@medicalRecordId, @medicineName, @dosage, @instructions)";

                using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@medicalRecordId", recordId);
                    cmd.Parameters.AddWithValue("@medicineName", row["MedicineName"].ToString());
                    cmd.Parameters.AddWithValue("@dosage", row["Dosage"].ToString());
                    cmd.Parameters.AddWithValue("@instructions", row["Instructions"].ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            MessageBox.Show("Fields cleared successfully!");
        }

        private void ClearFields()
        {
            if (!isEditMode)
            {
                txtStudentID.Clear();
            }

            txtProblem.Clear();
            txtTreatment.Clear();
            txtMedicineName.Clear();
            txtDosage.Clear();
            txtInstructions.Clear();
            txtDoctorName.Clear();
            txtRemarks.Clear();

            medicineTable.Rows.Clear();

            dtpVisitDate.Value = DateTime.Now;
        }

        private void btnPrintPrescription_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Student ID first!");
                txtStudentID.Focus();
                return;
            }

            if (txtProblem.Text.Trim() == "")
            {
                MessageBox.Show("Please enter problem first!");
                txtProblem.Focus();
                return;
            }

            if (medicineTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add medicine first!");
                txtMedicineName.Focus();
                return;
            }

            prescriptionText =
                "ABC Learning\n" +
                "School Medical Center Prescription\n" +
                "----------------------------------\n\n" +
                "Student ID: " + txtStudentID.Text.Trim() + "\n" +
                "Problem: " + txtProblem.Text.Trim() + "\n" +
                "Treatment: " + txtTreatment.Text.Trim() + "\n\n" +
                "Medicines:\n" +
                BuildMedicinePrintText() + "\n" +
                "Visit Date: " + dtpVisitDate.Value.ToString("dd/MM/yyyy") + "\n" +
                "Doctor/Nurse: " + txtDoctorName.Text.Trim() + "\n\n" +
                "Remarks:\n" + txtRemarks.Text.Trim() + "\n\n" +
                "----------------------------------\n" +
                "Signature: __________________\n" +
                "Printed Date: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            printPreviewDialogPrescription.Document = printDocumentPrescription;
            printPreviewDialogPrescription.ShowDialog();
        }

        private string BuildMedicinePrintText()
        {
            StringBuilder sb = new StringBuilder();

            int serial = 1;

            foreach (DataRow row in medicineTable.Rows)
            {
                sb.AppendLine(serial + ". " + row["MedicineName"].ToString());
                sb.AppendLine("   Dosage: " + row["Dosage"].ToString());

                string instructions = row["Instructions"].ToString();

                if (instructions != "")
                {
                    sb.AppendLine("   Instructions: " + instructions);
                }

                sb.AppendLine();

                serial++;
            }

            return sb.ToString();
        }

        private void printDocumentPrescription_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font bodyFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular);

            e.Graphics.DrawString(
                prescriptionText,
                bodyFont,
                Brushes.Black,
                new RectangleF(80, 80, e.PageBounds.Width - 160, e.PageBounds.Height - 160)
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageMedicalCenter manageMedicalCenter = new ManageMedicalCenter(currentRole);
            manageMedicalCenter.Show();
            this.Hide();
        }
    }
}