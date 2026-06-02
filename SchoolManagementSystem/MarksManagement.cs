using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class MarksManagement : Form
    {
        int teacherId;
        int selectedStudentId = -1;
        string teacherSubject = "";

        public MarksManagement(int id)
        {
            InitializeComponent();

            teacherId = id;

            dataGridViewMaks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaks.MultiSelect = false;
            dataGridViewMaks.ReadOnly = true;
            dataGridViewMaks.AllowUserToAddRows = false;

            txtFullName.ReadOnly = true;

            dataGridViewMaks.CellClick += dataGridViewMaks_CellClick;

            LoadTeacherInfo();
            LoadStudents();

            btnAddMarks.Enabled = false;
            btnUpdateMarks.Enabled = false;
        }

        private void LoadTeacherInfo()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "SELECT Subject FROM Teachers WHERE TeacherID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", teacherId);

                object result = cmd.ExecuteScalar();
                teacherSubject = result?.ToString() ?? "";
            }
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
                    m.Subject,
                    ISNULL(m.Mid, 0) AS Mid,
                    ISNULL(m.Final, 0) AS Final,
                    ISNULL(m.Overall, 0) AS Overall
                FROM Students s
                LEFT JOIN Marks m 
                    ON s.StudentID = m.StudentID 
                    AND m.TeacherID = @tid
                    AND m.Subject = @sub
                WHERE s.Class IN (
                    SELECT ClassName 
                    FROM TeacherClassAssignments 
                    WHERE TeacherID = @tid
                )";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@tid", teacherId);
                da.SelectCommand.Parameters.AddWithValue("@sub", teacherSubject);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewMaks.DataSource = dt;

                if (dataGridViewMaks.Columns["StudentID"] != null)
                    dataGridViewMaks.Columns["StudentID"].Visible = false;
            }
        }

        private void dataGridViewMaks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewMaks.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);

            txtFullName.Text = row.Cells["FullName"].Value?.ToString();
            txtMidMarks.Text = row.Cells["Mid"].Value?.ToString();
            txtFinalMarks.Text = row.Cells["Final"].Value?.ToString();

            int mid = Convert.ToInt32(row.Cells["Mid"].Value);
            int final = Convert.ToInt32(row.Cells["Final"].Value);

            if (mid > 0 || final > 0)
            {
                btnAddMarks.Enabled = false;
                btnUpdateMarks.Enabled = true;
            }
            else
            {
                btnAddMarks.Enabled = true;
                btnUpdateMarks.Enabled = false;
            }
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            SaveMarks(false);
        }

        private void btnUpdateMarks_Click(object sender, EventArgs e)
        {
            SaveMarks(true);
        }

        private void SaveMarks(bool isUpdate)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Select a student!");
                return;
            }

            int mid, final;

            if (!int.TryParse(txtMidMarks.Text, out mid) ||
                !int.TryParse(txtFinalMarks.Text, out final))
            {
                MessageBox.Show("Enter valid numeric marks!");
                return;
            }

            int overall = mid + final;

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query;

                if (isUpdate)
                {
                    query = @"
                    UPDATE Marks
                    SET Mid=@mid, Final=@final, Overall=@overall
                    WHERE StudentID=@sid 
                    AND TeacherID=@tid 
                    AND Subject=@sub";
                }
                else
                {
                    query = @"
                    INSERT INTO Marks
                    (StudentID, TeacherID, Subject, Mid, Final, Overall)
                    VALUES
                    (@sid, @tid, @sub, @mid, @final, @overall)";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@sid", selectedStudentId);
                cmd.Parameters.AddWithValue("@tid", teacherId);
                cmd.Parameters.AddWithValue("@sub", teacherSubject);
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@final", final);
                cmd.Parameters.AddWithValue("@overall", overall);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(isUpdate ? "Marks updated successfully!" : "Marks added successfully!");

            LoadStudents();
            ClearFields();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtMidMarks.Clear();
            txtFinalMarks.Clear();

            selectedStudentId = -1;

            btnAddMarks.Enabled = false;
            btnUpdateMarks.Enabled = false;
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            ClearFields();
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
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}