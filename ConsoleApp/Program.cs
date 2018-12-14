using DBLibrary;
using System.Data.SqlClient;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Server=(local)\SQLEXPRESS;Database=FSharpCSharpDB;Trusted_Connection=True";
            using (var con = new SqlConnection(conStr))
            using (var cmd = new SqlCommand(Sqls.SELECT_CUSTOMERS, con))
            {
                con.Open();
                cmd.Parameters.Add("CustomerId", 1);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
            }
        }
    }
}
