using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201130_2
{
    class Program
    {
        static void Main()
        {
            var conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                "Database=proba");

            conn.Open();

            var cmd = new SqlCommand(
                "SELECT Year(szul) AS szulEv FROM emberek", conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine(r["szulEv"]);
            }

            conn.Close();
            Console.ReadKey(true);
        }
    }
}
