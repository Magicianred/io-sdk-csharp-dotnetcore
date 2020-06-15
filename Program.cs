using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace io_sdk_csharp_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Config.getData();
            string connectionString = (args != null && args.Length > 0) ? args[0] : null;
            if (!String.IsNullOrWhiteSpace(connectionString)) {
                try 
                { 
                    // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                    // builder.DataSource = "<your_server.database.windows.net>"; 
                    // builder.UserID = "<your_username>";            
                    // builder.Password = "<your_password>";     
                    // builder.InitialCatalog = "<your_database>";
                    // connectionString = builder.ConnectionString;
            
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();       
                        StringBuilder sb = new StringBuilder();
                        sb.Append("SELECT 0 AS amount, ");
                        sb.Append("scadenza AS due_date, ");
                        sb.Append("destinatario AS fiscal_code, ");
                        sb.Append("false AS invalid_after_due_date, ");
                        sb.Append("testo AS markdown, ");
                        sb.Append("1 AS notice_number, ");
                        sb.Append("titolo AS subject ");
                        sb.Append("FROM messages ");
                        String sql = sb.ToString();

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                }
                            }
                        }                    
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            } else {
                Console.WriteLine("\nNo param ConnectionString");
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine(); 
        }

        // private static string GetConfig()
        // {
        //     var builder = new ConfigurationBuilder()
        //                         .SetBasePath(Directory.GetCurrentDirectory())
        //                         .AddJsonFile("config.json", optional: true, reloadOnChange: true);
 
        //     var form = builder.Build().GetSection("form");
        //     foreach(var element in form.AsEnumerable()) {
        //         var key = element.Key;
        //         var val = element.Value;
        //         Console.WriteLine($"The values of parameters are: {key} and {val}");
        //     }
        //     return "0";
        // }
    }
}
