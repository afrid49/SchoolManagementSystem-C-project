using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    internal class Database
    {
        public static string ConnString =
            @"Data Source=(localdb)\ProjectModels;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnString);
        }
    }
}