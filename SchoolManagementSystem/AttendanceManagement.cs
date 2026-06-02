using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AttendanceManagement : Form
    {
        int teacherId;
        int selectedStudentId = 0;

        public AttendanceManagement(int loggedTeacherId)
        {
            InitializeComponent();

            teacherId = loggedTeacherId;

            SetupGrid();
            LoadAssignedClasses();

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
            cmbStatus.Items.Add("Late");
            cmbStatus.SelectedIndex = 0;

            dtpAttendanceDate.Value = DateTime.Now;
        }

        private void SetupGrid()
        {
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAttendance.MultiSelect = false;
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
        }

        private void LoadAssignedClasses()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT ClassName
                    FROM TeacherClassAssignments
                    WHERE TeacherID = @teacherId
                    ORDER BY ClassName";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@teacherId", teacherId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbClass.DataSource = dt;
                    cmbClass.DisplayMember = "ClassName";
                    cmbClass.ValueMember = "ClassName";
                    cmbClass.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Classes load korte problem hocche:\n" + ex.Message);
            }
        }

        private void LoadStudents()
        {
            if (cmbClass.Text.Trim() == "")
            {
                return;
            }

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
                        ISNULL(a.Status, '') AS Status
                    FROM Students s
                    LEFT JOIN Attendance a
                        ON s.StudentID = a.StudentID
                        AND a.TeacherID = @teacherId
                        AND a.AttendanceDate = @date
                    WHERE s.Class = @class
                    ORDER BY s.StudentID ASC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@teacherId", teacherId);
                    da.SelectCommand.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@class", cmbClass.Text.Trim());

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewAttendance.DataSource = dt;
                }

                ClearSelectionOnly();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Students load korte problem hocche:\n" + ex.Message);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dataGridViewAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewAttendance.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
            txtStudentName.Text = row.Cells["FullName"].Value?.ToString() ?? "";

            string status = row.Cells["Status"].Value?.ToString() ?? "";

            if (status == "")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.Text = status;
            }
        }

        private bool ValidateFields()
        {
            if (cmbClass.Text.Trim() == "")
            {
                MessageBox.Show("Please select class!");
                cmbClass.Focus();
                return false;
            }

            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student first!");
                return false;
            }

            if (cmbStatus.Text.Trim() == "")
            {
                MessageBox.Show("Please select attendance status!");
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private bool AttendanceExists(SqlConnection con, int studentId)
        {
            string query = @"
            SELECT COUNT(*)
            FROM Attendance
            WHERE TeacherID = @teacherId
              AND StudentID = @studentId
              AND AttendanceDate = @date";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    if (AttendanceExists(con, selectedStudentId))
                    {
                        string updateQuery = @"
                        UPDATE Attendance
                        SET Status = @status,
                            Remarks = ''
                        WHERE TeacherID = @teacherId
                          AND StudentID = @studentId
                          AND AttendanceDate = @date";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@teacherId", teacherId);
                            cmd.Parameters.AddWithValue("@studentId", selectedStudentId);
                            cmd.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);
                            cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Attendance updated successfully!");
                    }
                    else
                    {
                        string insertQuery = @"
                        INSERT INTO Attendance
                        (TeacherID, StudentID, AttendanceDate, Status, Remarks)
                        VALUES
                        (@teacherId, @studentId, @date, @status, '')";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@teacherId", teacherId);
                            cmd.Parameters.AddWithValue("@studentId", selectedStudentId);
                            cmd.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);
                            cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Attendance saved successfully!");
                    }
                }

                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance save/update korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnMarkAllPresent_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text.Trim() == "")
            {
                MessageBox.Show("Please select class first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to mark all students Present?",
                "Mark All Present",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
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

                    foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
                    {
                        int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                        if (AttendanceExists(con, studentId))
                        {
                            string updateQuery = @"
                            UPDATE Attendance
                            SET Status = 'Present',
                                Remarks = ''
                            WHERE TeacherID = @teacherId
                              AND StudentID = @studentId
                              AND AttendanceDate = @date";

                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                                cmd.Parameters.AddWithValue("@studentId", studentId);
                                cmd.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"
                            INSERT INTO Attendance
                            (TeacherID, StudentID, AttendanceDate, Status, Remarks)
                            VALUES
                            (@teacherId, @studentId, @date, 'Present', '')";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                                cmd.Parameters.AddWithValue("@studentId", studentId);
                                cmd.Parameters.AddWithValue("@date", dtpAttendanceDate.Value.Date);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("All students marked Present successfully!");
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mark all present korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelectionOnly();
        }

        private void ClearSelectionOnly()
        {
            selectedStudentId = 0;
            txtStudentName.Clear();

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            dataGridViewAttendance.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherDashboard teacherDashboard = new TeacherDashboard(teacherId);
            teacherDashboard.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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