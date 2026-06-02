using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageCourses : Form
    {
        int selectedCourseID = 0;
        bool isLoading = false;

        public ManageCourses()
        {
            InitializeComponent();

            SetupGrid();

            LoadClasses();
            LoadSubjects();
            LoadCourses();

            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            cmbSubject.SelectedIndexChanged += cmbSubject_SelectedIndexChanged;
            dataGridViewCourses.CellClick += dataGridViewCourses_CellClick;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void SetupGrid()
        {
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.MultiSelect = false;
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
        }

        private void LoadClasses()
        {
            cmbClass.Items.Clear();
            cmbClass.Items.AddRange(new string[]
            {
                "Class 1", "Class 2", "Class 3", "Class 4", "Class 5",
                "Class 6", "Class 7", "Class 8", "Class 9", "Class 10"
            });
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT DISTINCT Subject
                    FROM Teachers
                    WHERE Subject IS NOT NULL AND Subject <> ''
                    ORDER BY Subject";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbSubject.DataSource = dt;
                    cmbSubject.DisplayMember = "Subject";
                    cmbSubject.ValueMember = "Subject";
                    cmbSubject.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Subjects load korte problem hocche:\n" + ex.Message);
            }
        }

        private void LoadTeachers()
        {
            if (isLoading)
            {
                return;
            }

            if (cmbClass.Text.Trim() == "" || cmbSubject.Text.Trim() == "")
            {
                cmbTeacher.DataSource = null;
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT DISTINCT 
                        t.TeacherID,
                        t.FullName
                    FROM Teachers t
                    INNER JOIN TeacherClassAssignments a 
                        ON t.TeacherID = a.TeacherID
                    WHERE a.ClassName = @class
                      AND t.Subject = @subject
                    ORDER BY t.FullName";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@class", cmbClass.Text.Trim());
                    da.SelectCommand.Parameters.AddWithValue("@subject", cmbSubject.Text.Trim());

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTeacher.DataSource = dt;
                    cmbTeacher.DisplayMember = "FullName";
                    cmbTeacher.ValueMember = "TeacherID";
                    cmbTeacher.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teachers load korte problem hocche:\n" + ex.Message);
            }
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        c.CourseID,
                        c.Class,
                        c.Subject,
                        t.FullName AS Teacher,
                        c.TimeSlot
                    FROM Courses c
                    INNER JOIN Teachers t 
                        ON c.TeacherID = t.TeacherID
                    ORDER BY c.CourseID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCourses.DataSource = dt;

                    if (dataGridViewCourses.Columns["CourseID"] != null)
                    {
                        dataGridViewCourses.Columns["CourseID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Courses load korte problem hocche:\n" + ex.Message);
            }
        }

        private bool ValidateFields()
        {
            if (cmbSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please select subject!");
                cmbSubject.Focus();
                return false;
            }

            if (cmbClass.Text.Trim() == "")
            {
                MessageBox.Show("Please select class!");
                cmbClass.Focus();
                return false;
            }

            if (cmbTeacher.Text.Trim() == "" || cmbTeacher.SelectedValue == null)
            {
                MessageBox.Show("Please select teacher!");
                cmbTeacher.Focus();
                return false;
            }

            if (cmbTime.Text.Trim() == "")
            {
                MessageBox.Show("Please select time!");
                cmbTime.Focus();
                return false;
            }

            return true;
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            isLoading = true;

            DataGridViewRow row = dataGridViewCourses.Rows[e.RowIndex];

            selectedCourseID = Convert.ToInt32(row.Cells["CourseID"].Value);

            cmbClass.Text = row.Cells["Class"].Value?.ToString() ?? "";
            cmbSubject.Text = row.Cells["Subject"].Value?.ToString() ?? "";
            cmbTime.Text = row.Cells["TimeSlot"].Value?.ToString() ?? "";

            isLoading = false;

            LoadTeachers();

            cmbTeacher.Text = row.Cells["Teacher"].Value?.ToString() ?? "";

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedCourseID != 0)
            {
                MessageBox.Show("Course already selected. Please use Update or Clear first.");
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

                    string query = @"
                    INSERT INTO Courses (Class, Subject, TeacherID, TimeSlot)
                    VALUES (@class, @subject, @teacher, @time)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@class", cmbClass.Text.Trim());
                        cmd.Parameters.AddWithValue("@subject", cmbSubject.Text.Trim());
                        cmd.Parameters.AddWithValue("@teacher", cmbTeacher.SelectedValue);
                        cmd.Parameters.AddWithValue("@time", cmbTime.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course added successfully!");

                LoadCourses();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course add korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course first!");
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

                    string query = @"
                    UPDATE Courses
                    SET 
                        Class = @class,
                        Subject = @subject,
                        TeacherID = @teacher,
                        TimeSlot = @time
                    WHERE CourseID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@class", cmbClass.Text.Trim());
                        cmd.Parameters.AddWithValue("@subject", cmbSubject.Text.Trim());
                        cmd.Parameters.AddWithValue("@teacher", cmbTeacher.SelectedValue);
                        cmd.Parameters.AddWithValue("@time", cmbTime.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedCourseID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course updated successfully!");

                LoadCourses();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course update korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this course?",
                "Delete Course",
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

                    string query = "DELETE FROM Courses WHERE CourseID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedCourseID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course deleted successfully!");

                LoadCourses();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course delete korte problem hocche:\n" + ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim() == "")
                {
                    LoadCourses();
                    return;
                }

                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        c.CourseID,
                        c.Class,
                        c.Subject,
                        t.FullName AS Teacher,
                        c.TimeSlot
                    FROM Courses c
                    INNER JOIN Teachers t 
                        ON c.TeacherID = t.TeacherID
                    WHERE c.Class LIKE @keyword
                       OR c.Subject LIKE @keyword
                       OR t.FullName LIKE @keyword
                       OR c.TimeSlot LIKE @keyword
                    ORDER BY c.CourseID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text.Trim() + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCourses.DataSource = dt;

                    if (dataGridViewCourses.Columns["CourseID"] != null)
                    {
                        dataGridViewCourses.Columns["CourseID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedCourseID = 0;
            isLoading = true;

            cmbClass.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbTeacher.DataSource = null;
            cmbTime.SelectedIndex = -1;
            txtSearch.Clear();

            isLoading = false;

            dataGridViewCourses.ClearSelection();

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