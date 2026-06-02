using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                // Total Teachers
                string teacherQuery = "SELECT COUNT(*) FROM Teachers";
                SqlCommand teacherCmd = new SqlCommand(teacherQuery, con);
                int totalTeachers = (int)teacherCmd.ExecuteScalar();
                lblTotalTeachers.Text = totalTeachers.ToString();

                // Total Students
                string studentQuery = "SELECT COUNT(*) FROM Students";
                SqlCommand studentCmd = new SqlCommand(studentQuery, con);
                int totalStudents = (int)studentCmd.ExecuteScalar();
                lblTotalStudents.Text = totalStudents.ToString();

                // Total Courses
                string courseQuery = "SELECT COUNT(*) FROM Courses";
                SqlCommand courseCmd = new SqlCommand(courseQuery, con);
                int totalCourses = (int)courseCmd.ExecuteScalar();
                lblTotalCourses.Text = totalCourses.ToString();

                // Total Medical Records
                string medicalRecordQuery = "SELECT COUNT(*) FROM MedicalRecords";
                SqlCommand medicalRecordCmd = new SqlCommand(medicalRecordQuery, con);
                int totalMedicalRecords = (int)medicalRecordCmd.ExecuteScalar();
                lblTotalMedicalRecords.Text = totalMedicalRecords.ToString();
            }
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            ManageTeachers tch = new ManageTeachers();
            tch.Show();
            this.Hide();
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            ManageTeachers tch = new ManageTeachers();
            tch.Show();
            this.Hide();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudents sth = new ManageStudents();
            sth.Show();
            this.Hide();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudents sth = new ManageStudents();
            sth.Show();
            this.Hide();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            ManageCourses managecourses = new ManageCourses();
            managecourses.Show();
            this.Hide();
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {
            ManageCourses managecourses = new ManageCourses();
            managecourses.Show();
            this.Hide();
        }

        private void btnManageMedicalCenter_Click(object sender, EventArgs e)
        {
            ManageMedicalCenter medicalCenter = new ManageMedicalCenter();
            medicalCenter.Show();
            this.Hide();
        }

        private void btnManageDoctorNurse_Click(object sender, EventArgs e)
        {
            ManageDoctorNurse manageDoctorNurse = new ManageDoctorNurse();
            manageDoctorNurse.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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