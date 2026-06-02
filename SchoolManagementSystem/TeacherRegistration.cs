using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace SchoolManagementSystem
{
    public partial class TeacherRegistration : Form
    {
        public TeacherRegistration()
        {
            InitializeComponent();

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{11}$");
        }

        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            if (cmbGender.SelectedIndex == -1 ||
                cmbSubject.SelectedIndex == -1 ||
                cmbDegree.SelectedIndex == -1 ||
                cmbExperience.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all dropdown fields!");
                return;
            }
            if (!IsValidName(txtFullName.Text))
            {
                MessageBox.Show("Name must contain only letters!");
                return;
            }
            if (!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone must be number and exactly 11 digits!");
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@u", txtUsername.Text);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("Username already taken!");
                    return;
                }
                string hashedPassword = HashPassword(txtPassword.Text);
                string userQuery = @"
                INSERT INTO Users (Username, Password, Role)
                VALUES (@u, @p, 'Teacher');
                SELECT SCOPE_IDENTITY();";

                SqlCommand userCmd = new SqlCommand(userQuery, con);
                userCmd.Parameters.AddWithValue("@u", txtUsername.Text);
                userCmd.Parameters.AddWithValue("@p", hashedPassword);

                int newUserID = Convert.ToInt32(userCmd.ExecuteScalar());

                string teacherQuery = @"
                INSERT INTO Teachers
                (FullName, Email, Phone, Gender, DateOfBirth,
                 Subject, Degree, Experience, UserID)
                VALUES
                (@name, @email, @phone, @gender, @dob,
                 @subject, @degree, @experience, @uid)";

                SqlCommand teacherCmd = new SqlCommand(teacherQuery, con);

                teacherCmd.Parameters.AddWithValue("@name", txtFullName.Text);
                teacherCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                teacherCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                teacherCmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                teacherCmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
                teacherCmd.Parameters.AddWithValue("@subject", cmbSubject.Text);
                teacherCmd.Parameters.AddWithValue("@degree", cmbDegree.Text);
                teacherCmd.Parameters.AddWithValue("@experience", cmbExperience.Text);
                teacherCmd.Parameters.AddWithValue("@uid", newUserID);

                teacherCmd.ExecuteNonQuery();

                MessageBox.Show("Teacher Registered Successfully!");

                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Hide();
        }
    }
}