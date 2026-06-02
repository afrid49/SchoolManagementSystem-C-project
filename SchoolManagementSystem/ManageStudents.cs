using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SchoolManagementSystem
{
    public partial class ManageStudents : Form
    {
        int selectedStudentID = 0;
        int selectedUserID = 0;

        public ManageStudents()
        {
            InitializeComponent();

            dataGridViewStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridViewStudents.MultiSelect = false;

            dataGridViewStudents.ReadOnly = true;

            dataGridViewStudents.AllowUserToAddRows = false;

            dataGridViewStudents.CellClick +=
                dataGridViewStudents_CellClick;

            LoadStudents();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes =
                    sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
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
                    s.UserID,
                    s.FullName,
                    u.Username,
                    s.DateOfBirth,
                    s.Gender,
                    s.Class,
                    s.GuardianName,
                    s.GuardianPhone,
                    s.Relationship
                FROM Students s
                INNER JOIN Users u
                ON s.UserID = u.UserID";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewStudents.DataSource = dt;

                if (dataGridViewStudents.Columns["StudentID"] != null)
                    dataGridViewStudents.Columns["StudentID"].Visible = false;

                if (dataGridViewStudents.Columns["UserID"] != null)
                    dataGridViewStudents.Columns["UserID"].Visible = false;

                dataGridViewStudents.ClearSelection();
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dataGridViewStudents.ClearSelection();

            dataGridViewStudents.Rows[e.RowIndex].Selected = true;

            DataGridViewRow row =
                dataGridViewStudents.Rows[e.RowIndex];

            selectedStudentID =
                Convert.ToInt32(
                    row.Cells["StudentID"].Value
                );

            selectedUserID =
                Convert.ToInt32(
                    row.Cells["UserID"].Value
                );

            txtFullName.Text =
                row.Cells["FullName"].Value.ToString();

            txtUsername.Text =
                row.Cells["Username"].Value.ToString();

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            dtpDateOfBirth.Value =
                Convert.ToDateTime(
                    row.Cells["DateOfBirth"].Value
                );

            cmbGender.Text =
                row.Cells["Gender"].Value.ToString();

            cmbClass.Text =
                row.Cells["Class"].Value.ToString();

            txtGuardianName.Text =
                row.Cells["GuardianName"].Value.ToString();

            txtGuardianPhone.Text =
                row.Cells["GuardianPhone"].Value.ToString();

            cmbRelationship.Text =
                row.Cells["Relationship"].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtGuardianName.Clear();
            txtGuardianPhone.Clear();

            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRelationship.SelectedIndex = -1;

            selectedStudentID = 0;
            selectedUserID = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dataGridViewStudents.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all required fields!");
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

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string checkQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username=@u";

                    SqlCommand checkCmd =
                        new SqlCommand(checkQuery, con, transaction);

                    checkCmd.Parameters.AddWithValue(
                        "@u",
                        txtUsername.Text
                    );

                    int exists =
                        Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already taken!");
                        transaction.Rollback();
                        return;
                    }

                    string hashedPassword =
                        HashPassword(txtPassword.Text);

                    string userQuery = @"
                    INSERT INTO Users
                    (Username, Password, Role)
                    OUTPUT INSERTED.UserID
                    VALUES
                    (@u, @p, 'Student')";

                    SqlCommand userCmd =
                        new SqlCommand(userQuery, con, transaction);

                    userCmd.Parameters.AddWithValue(
                        "@u",
                        txtUsername.Text
                    );

                    userCmd.Parameters.AddWithValue(
                        "@p",
                        hashedPassword
                    );

                    int newUserID =
                        Convert.ToInt32(userCmd.ExecuteScalar());

                    string studentQuery = @"
                    INSERT INTO Students
                    (
                        FullName,
                        DateOfBirth,
                        Gender,
                        Class,
                        GuardianName,
                        GuardianPhone,
                        Relationship,
                        UserID
                    )
                    VALUES
                    (
                        @name,
                        @dob,
                        @gender,
                        @class,
                        @guardian,
                        @gphone,
                        @relation,
                        @uid
                    )";

                    SqlCommand studentCmd =
                        new SqlCommand(studentQuery, con, transaction);

                    studentCmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    studentCmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
                    studentCmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    studentCmd.Parameters.AddWithValue("@class", cmbClass.Text);
                    studentCmd.Parameters.AddWithValue("@guardian", txtGuardianName.Text);
                    studentCmd.Parameters.AddWithValue("@gphone", txtGuardianPhone.Text);
                    studentCmd.Parameters.AddWithValue("@relation", cmbRelationship.Text);
                    studentCmd.Parameters.AddWithValue("@uid", newUserID);

                    studentCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Student added successfully!");

                    LoadStudents();

                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student first!");
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string studentQuery = @"
                    UPDATE Students SET
                        FullName=@name,
                        DateOfBirth=@dob,
                        Gender=@gender,
                        Class=@class,
                        GuardianName=@guardian,
                        GuardianPhone=@gphone,
                        Relationship=@relation
                    WHERE StudentID=@id";

                    SqlCommand studentCmd =
                        new SqlCommand(studentQuery, con, transaction);

                    studentCmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    studentCmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
                    studentCmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    studentCmd.Parameters.AddWithValue("@class", cmbClass.Text);
                    studentCmd.Parameters.AddWithValue("@guardian", txtGuardianName.Text);
                    studentCmd.Parameters.AddWithValue("@gphone", txtGuardianPhone.Text);
                    studentCmd.Parameters.AddWithValue("@relation", cmbRelationship.Text);
                    studentCmd.Parameters.AddWithValue("@id", selectedStudentID);

                    studentCmd.ExecuteNonQuery();

                    string userQuery;

                    if (txtPassword.Text.Trim() == "")
                    {
                        userQuery = @"
                        UPDATE Users SET
                            Username=@username
                        WHERE UserID=@uid";
                    }
                    else
                    {
                        string hashedPassword =
                            HashPassword(txtPassword.Text);

                        userQuery = @"
                        UPDATE Users SET
                            Username=@username,
                            Password=@password
                        WHERE UserID=@uid";

                        SqlCommand userCmd =
                            new SqlCommand(userQuery, con, transaction);

                        userCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        userCmd.Parameters.AddWithValue("@password", hashedPassword);
                        userCmd.Parameters.AddWithValue("@uid", selectedUserID);

                        userCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Student updated successfully!");

                        LoadStudents();

                        ClearFields();

                        return;
                    }

                    SqlCommand cmd =
                        new SqlCommand(userQuery, con, transaction);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@uid", selectedUserID);

                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Student updated successfully!");

                    LoadStudents();

                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string deleteMarks =
                        "DELETE FROM Marks WHERE StudentID=@id";

                    SqlCommand cmd0 =
                        new SqlCommand(deleteMarks, con, transaction);

                    cmd0.Parameters.AddWithValue("@id", selectedStudentID);

                    cmd0.ExecuteNonQuery();

                    string deleteStudent =
                        "DELETE FROM Students WHERE StudentID=@id";

                    SqlCommand cmd1 =
                        new SqlCommand(deleteStudent, con, transaction);

                    cmd1.Parameters.AddWithValue("@id", selectedStudentID);

                    cmd1.ExecuteNonQuery();

                    string deleteUser =
                        "DELETE FROM Users WHERE UserID=@uid";

                    SqlCommand cmd2 =
                        new SqlCommand(deleteUser, con, transaction);

                    cmd2.Parameters.AddWithValue("@uid", selectedUserID);

                    cmd2.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Student deleted successfully!");

                    LoadStudents();

                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT
                    s.StudentID,
                    s.UserID,
                    s.FullName,
                    u.Username,
                    s.DateOfBirth,
                    s.Gender,
                    s.Class,
                    s.GuardianName,
                    s.GuardianPhone,
                    s.Relationship
                FROM Students s
                INNER JOIN Users u
                ON s.UserID = u.UserID
                WHERE s.FullName LIKE @s
                OR s.Class LIKE @s";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@s",
                    "%" + search + "%"
                );

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewStudents.DataSource = dt;

                if (dataGridViewStudents.Columns["StudentID"] != null)
                    dataGridViewStudents.Columns["StudentID"].Visible = false;

                if (dataGridViewStudents.Columns["UserID"] != null)
                    dataGridViewStudents.Columns["UserID"].Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();

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