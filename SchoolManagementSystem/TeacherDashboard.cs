using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TeacherDashboard : Form
    {
        int teacherId;

        public TeacherDashboard(int loggedTeacherId)
        {
            InitializeComponent();

            teacherId = loggedTeacherId;
            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    // Total Classes assigned to this teacher
                    string classQuery = @"
                    SELECT COUNT(*) 
                    FROM TeacherClassAssignments 
                    WHERE TeacherID = @id";

                    using (SqlCommand classCmd = new SqlCommand(classQuery, con))
                    {
                        classCmd.Parameters.AddWithValue("@id", teacherId);

                        int totalClasses = Convert.ToInt32(classCmd.ExecuteScalar());
                        lblTotalClasses.Text = totalClasses.ToString();
                    }

                    // Total Students from teacher assigned classes
                    string studentQuery = @"
                    SELECT COUNT(*) 
                    FROM Students
                    WHERE Class IN (
                        SELECT ClassName 
                        FROM TeacherClassAssignments 
                        WHERE TeacherID = @id
                    )";

                    using (SqlCommand studentCmd = new SqlCommand(studentQuery, con))
                    {
                        studentCmd.Parameters.AddWithValue("@id", teacherId);

                        int totalStudents = Convert.ToInt32(studentCmd.ExecuteScalar());
                        lblTotalStudents.Text = totalStudents.ToString();
                    }

                    // Total subjects/courses of this teacher
                    string subjectQuery = @"
                    SELECT COUNT(DISTINCT Subject)
                    FROM Courses
                    WHERE TeacherID = @id";

                    using (SqlCommand subjectCmd = new SqlCommand(subjectQuery, con))
                    {
                        subjectCmd.Parameters.AddWithValue("@id", teacherId);

                        int totalSubjects = Convert.ToInt32(subjectCmd.ExecuteScalar());
                        lblTotalCourses.Text = totalSubjects.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard count load korte problem hocche:\n" + ex.Message);
            }
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            AllStudents allstudents = new AllStudents(teacherId);
            allstudents.Show();
            this.Hide();
        }

        private void btnAllStudent_Click(object sender, EventArgs e)
        {
            AllStudents allstudents = new AllStudents(teacherId);
            allstudents.Show();
            this.Hide();
        }

        private void btnMarksManagement_Click(object sender, EventArgs e)
        {
            MarksManagement marksmanagement = new MarksManagement(teacherId);
            marksmanagement.Show();
            this.Hide();
        }

        private void btnMarksManagements_Click(object sender, EventArgs e)
        {
            MarksManagement marksmanagement = new MarksManagement(teacherId);
            marksmanagement.Show();
            this.Hide();
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            ClassSchedule classschedule = new ClassSchedule(teacherId);
            classschedule.Show();
            this.Hide();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            ClassSchedule classschedule = new ClassSchedule(teacherId);
            classschedule.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AttendanceManagement attendanceManagement = new AttendanceManagement(teacherId);
            attendanceManagement.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AttendanceManagement attendanceManagement = new AttendanceManagement(teacherId);
            attendanceManagement.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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