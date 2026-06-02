using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageDoctorNurse : Form
    {
        int selectedStaffId = 0;
        int selectedUserId = 0;

        public ManageDoctorNurse()
        {
            InitializeComponent();

            SetupGrid();

            cmbStaffType.Items.Clear();
            cmbStaffType.Items.Add("Doctor");
            cmbStaffType.Items.Add("Nurse");

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            LoadStaff();
        }

        private void SetupGrid()
        {
            dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.MultiSelect = false;
            dataGridViewStaff.ReadOnly = true;
            dataGridViewStaff.AllowUserToAddRows = false;
            dataGridViewStaff.AllowUserToDeleteRows = false;
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

        private void LoadStaff()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        ms.StaffID,
                        ms.UserID,
                        ms.FullName,
                        ms.StaffType,
                        ms.Phone,
                        ms.Email,
                        ms.Username,
                        u.Role
                    FROM MedicalStaff ms
                    INNER JOIN Users u ON ms.UserID = u.UserID
                    ORDER BY ms.StaffID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewStaff.DataSource = dt;

                    if (dataGridViewStaff.Columns["UserID"] != null)
                    {
                        dataGridViewStaff.Columns["UserID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doctor/Nurse load korte problem hocche:\n" + ex.Message);
            }
        }

        private bool ValidateFields()
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name!");
                txtFullName.Focus();
                return false;
            }

            if (cmbStaffType.Text.Trim() == "")
            {
                MessageBox.Show("Please select Doctor/Nurse type!");
                cmbStaffType.Focus();
                return false;
            }

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username!");
                txtUsername.Focus();
                return false;
            }

            if (selectedStaffId == 0 && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password!");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string hashedPassword = HashPassword(txtPassword.Text.Trim());

                        string userQuery = @"
                        INSERT INTO Users (Username, Password, Role)
                        OUTPUT INSERTED.UserID
                        VALUES (@username, @password, 'MedicalStaff')";

                        int userId;

                        using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                            userCmd.Parameters.AddWithValue("@password", hashedPassword);

                            userId = Convert.ToInt32(userCmd.ExecuteScalar());
                        }

                        string staffQuery = @"
                        INSERT INTO MedicalStaff
                        (FullName, StaffType, Phone, Email, Username, UserID)
                        VALUES
                        (@fullName, @staffType, @phone, @email, @username, @userId)";

                        using (SqlCommand staffCmd = new SqlCommand(staffQuery, con, transaction))
                        {
                            staffCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@staffType", cmbStaffType.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@userId", userId);

                            staffCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Doctor/Nurse added successfully!");

                        LoadStaff();
                        ClearFields();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add korte problem hocche:\n" + ex.Message);
            }
        }

        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewStaff.Rows[e.RowIndex];

            selectedStaffId = Convert.ToInt32(row.Cells["StaffID"].Value);
            selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);

            txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
            cmbStaffType.Text = row.Cells["StaffType"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
            txtPassword.Clear();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Please select a doctor/nurse first!");
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string userQuery;

                        if (txtPassword.Text.Trim() == "")
                        {
                            userQuery = "UPDATE Users SET Username=@username WHERE UserID=@userId";
                        }
                        else
                        {
                            userQuery = "UPDATE Users SET Username=@username, Password=@password WHERE UserID=@userId";
                        }

                        using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                            userCmd.Parameters.AddWithValue("@userId", selectedUserId);

                            if (txtPassword.Text.Trim() != "")
                            {
                                userCmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text.Trim()));
                            }

                            userCmd.ExecuteNonQuery();
                        }

                        string staffQuery = @"
                        UPDATE MedicalStaff
                        SET
                            FullName=@fullName,
                            StaffType=@staffType,
                            Phone=@phone,
                            Email=@email,
                            Username=@username
                        WHERE StaffID=@staffId";

                        using (SqlCommand staffCmd = new SqlCommand(staffQuery, con, transaction))
                        {
                            staffCmd.Parameters.AddWithValue("@staffId", selectedStaffId);
                            staffCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@staffType", cmbStaffType.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            staffCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());

                            staffCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Doctor/Nurse updated successfully!");

                        LoadStaff();
                        ClearFields();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Please select a doctor/nurse first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this doctor/nurse?",
                "Delete",
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

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string staffQuery = "DELETE FROM MedicalStaff WHERE StaffID=@staffId";

                        using (SqlCommand staffCmd = new SqlCommand(staffQuery, con, transaction))
                        {
                            staffCmd.Parameters.AddWithValue("@staffId", selectedStaffId);
                            staffCmd.ExecuteNonQuery();
                        }

                        string userQuery = "DELETE FROM Users WHERE UserID=@userId";

                        using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@userId", selectedUserId);
                            userCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Doctor/Nurse deleted successfully!");

                        LoadStaff();
                        ClearFields();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedStaffId = 0;
            selectedUserId = 0;

            txtFullName.Clear();
            cmbStaffType.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageDoctorNurse_Load(object sender, EventArgs e)
        {

        }
    }
}