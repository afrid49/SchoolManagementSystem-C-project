using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class AllStudents : Form
    {
        int teacherId;
        int selectedStudentId = -1;

        public AllStudents(int id)
        {
            InitializeComponent();

            teacherId = id;

            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;

            LoadStudents();
        }

        private void LoadStudents()
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
                    s.DateOfBirth,
                    s.GuardianName,
                    s.GuardianPhone,
                    m.Subject,
                    ISNULL(m.Mid, 0) AS Mid,
                    ISNULL(m.Final, 0) AS Final,
                    ISNULL(m.Overall, 0) AS Overall
                FROM Students s
                LEFT JOIN Marks m 
                    ON s.StudentID = m.StudentID
                WHERE s.Class IN (
                    SELECT ClassName 
                    FROM TeacherClassAssignments 
                    WHERE TeacherID = @tid
                )
                ORDER BY s.StudentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@tid", teacherId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewStudents.DataSource = dt;
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                LoadStudents();
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT 
                    s.StudentID,
                    s.FullName,
                    s.Class,
                    s.Gender,
                    s.DateOfBirth,
                    s.GuardianName,
                    s.GuardianPhone,
                    m.Subject,
                    ISNULL(m.Mid, 0) AS Mid,
                    ISNULL(m.Final, 0) AS Final,
                    ISNULL(m.Overall, 0) AS Overall
                FROM Students s
                LEFT JOIN Marks m 
                    ON s.StudentID = m.StudentID
                WHERE s.Class IN (
                    SELECT ClassName 
                    FROM TeacherClassAssignments 
                    WHERE TeacherID = @tid
                )
                AND s.FullName LIKE @name
                ORDER BY s.StudentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@tid", teacherId);
                da.SelectCommand.Parameters.AddWithValue("@name", "%" + txtSearch.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewStudents.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new TeacherDashboard(teacherId).Show();
            this.Hide();
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
                new Login().Show();
                this.Hide();
            }
        }
    }
}