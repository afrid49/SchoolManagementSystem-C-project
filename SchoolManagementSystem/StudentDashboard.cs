using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentDashboard : Form
    {
        int studentId;

        public StudentDashboard(int loggedStudentId)
        {
            InitializeComponent();

            studentId = loggedStudentId;
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        s.StudentID,
                        s.FullName,
                        s.Class,
                        s.Gender,
                        ISNULL(m.Subject, 'No Marks Added') AS Subject,
                        ISNULL(CAST(m.Mid AS NVARCHAR(20)), '-') AS Mid,
                        ISNULL(CAST(m.Final AS NVARCHAR(20)), '-') AS Final,
                        ISNULL(CAST(m.Overall AS NVARCHAR(20)), '-') AS Overall
                    FROM Students s
                    LEFT JOIN Marks m 
                        ON s.StudentID = m.StudentID
                    WHERE s.StudentID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridViewStudent.DataSource = dt;
                    }
                }

                SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student dashboard load korte problem hocche:\n" + ex.Message);
            }
        }

        private void SetupGrid()
        {
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent.MultiSelect = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}