using System.Data.SqlClient;

namespace CPUFramework
{
    public class DataUtility
    {
        private static string connstring = "";
        public static string SetConnectionString(string servername, string databasename, string username, string password)
        {
            connstring = "Server=tcp:" + servername +
                ";Initial Catalog=" + databasename +
                ";Persist Security Info=False;User ID=" + username +
                ";Password=" + password +
                ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
            }
            return connstring;
        }
        public static string ConnectionString
        {
            get => connstring;
            set => connstring = value;
        }
    }
}
