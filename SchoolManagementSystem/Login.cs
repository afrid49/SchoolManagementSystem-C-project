using Microsoft.Data.SqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private int GetTeacherId(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "SELECT TeacherID FROM Teachers WHERE UserID = @uid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }

        private int GetStudentId(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = "SELECT StudentID FROM Students WHERE UserID = @uid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return 0;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username!");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password!");
                txtPassword.Focus();
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string hashedPassword = HashPassword(txtPassword.Text.Trim());

                string query = @"
                SELECT UserID, Role
                FROM Users
                WHERE Username = @u AND Password = @p";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", hashedPassword);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserID"]);
                            string role = reader["Role"]?.ToString() ?? "";

                            reader.Close();

                            if (role == "Admin")
                            {
                                new AdminDashboard().Show();
                            }
                            else if (role == "Teacher")
                            {
                                int teacherId = GetTeacherId(userId);
                                new TeacherDashboard(teacherId).Show();
                            }
                            else if (role == "Student")
                            {
                                int studentId = GetStudentId(userId);
                                new StudentDashboard(studentId).Show();
                            }
                            else if (role == "MedicalStaff")
                            {
                                new ManageMedicalCenter("MedicalStaff").Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid user role!");
                                return;
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!");
                        }
                    }
                }
            }
        }

        private void lblTeacherRegistration_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherregistration = new TeacherRegistration();
            teacherregistration.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}