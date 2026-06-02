using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ClassSchedule : Form
    {
        int teacherId;

        public ClassSchedule(int id)
        {
            InitializeComponent();

            teacherId = id;

            dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSchedule.ReadOnly = true;
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.AllowUserToDeleteRows = false;

            LoadSchedule();
        }
        private void LoadSchedule()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                string query = @"
                SELECT
                t.FullName AS TeacherName,
                c.Subject,
                c.Class,
                c.TimeSlot
                FROM Courses c
                JOIN Teachers t
                ON c.TeacherID = t.TeacherID
                WHERE c.TeacherID = @id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@id", teacherId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSchedule.DataSource = dt;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherDashboard dashboard = new TeacherDashboard(teacherId);
            dashboard.Show();
            this.Hide();
        }
    }
}