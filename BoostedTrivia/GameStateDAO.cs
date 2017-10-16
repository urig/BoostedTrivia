using System.Collections;
using System.Data.SqlClient;

namespace BoostedTrivia
{
    public class GameStateDAO
    {
        public GameStateDAO()
        {
            var connectionString = "Server=localhost:3306;Database=mydb;User Id=myuser;Password=mypassword;";
            var conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public void save(ArrayList players, int[] places, int[] purses, bool[] inPenaltyBox)
        {
        }
    }
}
