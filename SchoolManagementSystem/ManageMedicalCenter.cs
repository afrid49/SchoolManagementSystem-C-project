using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageMedicalCenter : Form
    {
        int selectedMedicalRecordId = 0;
        string currentRole = "Admin";

        public ManageMedicalCenter()
        {
            InitializeComponent();
            SetupGrid();
            LoadMedicalRecords();
        }

        public ManageMedicalCenter(string role)
        {
            InitializeComponent();

            currentRole = role;

            SetupGrid();
            LoadMedicalRecords();
        }

        private void SetupGrid()
        {
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
        }

        private void LoadMedicalRecords()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT
                        mr.MedicalRecordID,
                        mr.StudentID,
                        s.FullName AS StudentName,
                        s.Class,
                        mr.Problem,
                        mr.Treatment,
                        mr.Medicine,
                        mr.VisitDate,
                        mr.DoctorName,
                        mr.Remarks
                    FROM MedicalRecords mr
                    INNER JOIN Students s
                        ON mr.StudentID = s.StudentID
                    ORDER BY mr.MedicalRecordID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Medical records load korte problem hocche:\n" + ex.Message);
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];

            selectedMedicalRecordId = Convert.ToInt32(row.Cells["MedicalRecordID"].Value);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm(currentRole);
            createEditForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMedicalRecordId == 0)
            {
                MessageBox.Show("Please select a medical record first!");
                return;
            }

            CreateEditForm createEditForm = new CreateEditForm(selectedMedicalRecordId, true, currentRole);
            createEditForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMedicalRecordId == 0)
            {
                MessageBox.Show("Please select a medical record first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this medical record?",
                "Delete Medical Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM MedicalRecords WHERE MedicalRecordID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedMedicalRecordId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Medical record deleted successfully!");

                selectedMedicalRecordId = 0;
                LoadMedicalRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentRole == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                Login login = new Login();
                login.Show();
            }

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Nothing needed
        }
    }
}