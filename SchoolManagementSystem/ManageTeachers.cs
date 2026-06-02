using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class ManageTeachers : Form
    {
        int selectedTeacherId = -1;

        public ManageTeachers()
        {
            InitializeComponent();

            SetupGrid();
            LoadTeachers();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void SetupGrid()
        {
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeachers.MultiSelect = false;
            dataGridViewTeachers.ReadOnly = true;
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.AllowUserToDeleteRows = false;
        }

        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        TeacherID,
                        UserID,
                        FullName,
                        Email,
                        Phone,
                        Gender,
                        DateOfBirth,
                        Subject,
                        Degree,
                        Experience
                    FROM Teachers
                    ORDER BY TeacherID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewTeachers.DataSource = dt;

                    if (dataGridViewTeachers.Columns["UserID"] != null)
                    {
                        dataGridViewTeachers.Columns["UserID"].Visible = false;
                    }
                }

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teachers load korte problem hocche:\n" + ex.Message);
            }
        }

        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewTeachers.Rows[e.RowIndex];

            selectedTeacherId = Convert.ToInt32(row.Cells["TeacherID"].Value);

            txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            cmbGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
            cmbSubject.Text = row.Cells["Subject"].Value?.ToString() ?? "";
            cmbDegree.Text = row.Cells["Degree"].Value?.ToString() ?? "";
            cmbExperience.Text = row.Cells["Experience"].Value?.ToString() ?? "";

            if (row.Cells["DateOfBirth"].Value != null &&
                row.Cells["DateOfBirth"].Value != DBNull.Value)
            {
                dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            }

            LoadTeacherClasses();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void LoadTeacherClasses()
        {
            for (int i = 0; i < chkAssignedClass.Items.Count; i++)
            {
                chkAssignedClass.SetItemChecked(i, false);
            }

            if (selectedTeacherId == -1)
            {
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT ClassName FROM TeacherClassAssignments WHERE TeacherID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedTeacherId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string className = reader["ClassName"].ToString();

                                for (int i = 0; i < chkAssignedClass.Items.Count; i++)
                                {
                                    if (chkAssignedClass.Items[i].ToString() == className)
                                    {
                                        chkAssignedClass.SetItemChecked(i, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher classes load korte problem hocche:\n" + ex.Message);
            }
        }

        private bool ValidateFields()
        {
            if (selectedTeacherId == -1)
            {
                MessageBox.Show("Please select a teacher first!");
                return false;
            }

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name!");
                txtFullName.Focus();
                return false;
            }

            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone!");
                txtPhone.Focus();
                return false;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter email!");
                txtEmail.Focus();
                return false;
            }

            if (cmbGender.Text.Trim() == "")
            {
                MessageBox.Show("Please select gender!");
                cmbGender.Focus();
                return false;
            }

            if (cmbSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please select subject!");
                cmbSubject.Focus();
                return false;
            }

            if (cmbDegree.Text.Trim() == "")
            {
                MessageBox.Show("Please select degree!");
                cmbDegree.Focus();
                return false;
            }

            if (cmbExperience.Text.Trim() == "")
            {
                MessageBox.Show("Please select experience!");
                cmbExperience.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId == -1)
            {
                MessageBox.Show("Please select a teacher first!");
                return;
            }

            if (chkAssignedClass.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one class!");
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    foreach (var item in chkAssignedClass.CheckedItems)
                    {
                        string className = item.ToString();

                        string checkQuery = @"
                        SELECT COUNT(*) 
                        FROM TeacherClassAssignments 
                        WHERE TeacherID = @teacherId AND ClassName = @className";

                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                            checkCmd.Parameters.AddWithValue("@className", className);

                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (count == 0)
                            {
                                string insertQuery = @"
                                INSERT INTO TeacherClassAssignments (TeacherID, ClassName)
                                VALUES (@teacherId, @className)";

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                                    insertCmd.Parameters.AddWithValue("@className", className);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Classes assigned successfully!");
                LoadTeacherClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class assign korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                        string updateTeacherQuery = @"
                        UPDATE Teachers
                        SET 
                            FullName = @fullName,
                            Email = @email,
                            Phone = @phone,
                            Gender = @gender,
                            DateOfBirth = @dateOfBirth,
                            Subject = @subject,
                            Degree = @degree,
                            Experience = @experience
                        WHERE TeacherID = @teacherId";

                        using (SqlCommand cmd = new SqlCommand(updateTeacherQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", cmbGender.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value.Date);
                            cmd.Parameters.AddWithValue("@subject", cmbSubject.Text.Trim());
                            cmd.Parameters.AddWithValue("@degree", cmbDegree.Text.Trim());
                            cmd.Parameters.AddWithValue("@experience", cmbExperience.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);

                            cmd.ExecuteNonQuery();
                        }

                        string deleteClassesQuery = "DELETE FROM TeacherClassAssignments WHERE TeacherID = @teacherId";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteClassesQuery, con, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                            deleteCmd.ExecuteNonQuery();
                        }

                        foreach (var item in chkAssignedClass.CheckedItems)
                        {
                            string className = item.ToString();

                            string insertClassQuery = @"
                            INSERT INTO TeacherClassAssignments (TeacherID, ClassName)
                            VALUES (@teacherId, @className)";

                            using (SqlCommand insertCmd = new SqlCommand(insertClassQuery, con, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                                insertCmd.Parameters.AddWithValue("@className", className);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show("Teacher updated successfully!");

                        LoadTeachers();
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
            if (selectedTeacherId == -1)
            {
                MessageBox.Show("Please select a teacher first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this teacher?",
                "Delete Teacher",
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
                        string deleteClassesQuery = "DELETE FROM TeacherClassAssignments WHERE TeacherID = @teacherId";

                        using (SqlCommand cmd = new SqlCommand(deleteClassesQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteCoursesQuery = "DELETE FROM Courses WHERE TeacherID = @teacherId";

                        using (SqlCommand cmd = new SqlCommand(deleteCoursesQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteTeacherQuery = "DELETE FROM Teachers WHERE TeacherID = @teacherId";

                        using (SqlCommand cmd = new SqlCommand(deleteTeacherQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@teacherId", selectedTeacherId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Teacher deleted successfully!");

                        LoadTeachers();
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
            selectedTeacherId = -1;

            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSearch.Clear();

            cmbGender.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbDegree.SelectedIndex = -1;
            cmbExperience.SelectedIndex = -1;

            dtpDateOfBirth.Value = DateTime.Now;

            for (int i = 0; i < chkAssignedClass.Items.Count; i++)
            {
                chkAssignedClass.SetItemChecked(i, false);
            }

            dataGridViewTeachers.ClearSelection();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
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

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim() == "")
                {
                    LoadTeachers();
                    return;
                }

                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        TeacherID,
                        UserID,
                        FullName,
                        Email,
                        Phone,
                        Gender,
                        DateOfBirth,
                        Subject,
                        Degree,
                        Experience
                    FROM Teachers
                    WHERE FullName LIKE @keyword
                       OR Subject LIKE @keyword
                       OR Phone LIKE @keyword
                       OR Email LIKE @keyword
                    ORDER BY TeacherID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text.Trim() + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewTeachers.DataSource = dt;

                    if (dataGridViewTeachers.Columns["UserID"] != null)
                    {
                        dataGridViewTeachers.Columns["UserID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search korte problem hocche:\n" + ex.Message);
            }
        }
    }
}