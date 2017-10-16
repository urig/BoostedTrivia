using System.Data.SqlClient;

namespace BoostedTrivia
{
    class SystemSettingsDAO
    {
        private int numberOfQuestions;

        public SystemSettingsDAO() {
            var connectionString = "Server=localhost:3306;Database=mydb;User Id=myuser;Password=mypassword;";
            var conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public int getNumberOfQuestions() {
            return numberOfQuestions;
        }
    }
}
