using System;
using System.Text.Json;

namespace io_sdk_csharp_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;

            var config = Config.getData();
            string connectionString = (args != null && args.Length > 0) ? args[0] : null;

            if (!String.IsNullOrWhiteSpace(connectionString)) {
                var data = Repository.GetMessages(connectionString);

                if (String.IsNullOrWhiteSpace(data.Error)) {
                    jsonString = JsonSerializer.Serialize(data.Messages);
                } else {
                    jsonString = JsonSerializer.Serialize(data.Error);
                }
                jsonString = "{ \"body\": { \"data\": "+ jsonString +" } } ";
                
            } else {
                jsonString = Config.getJson();
            }
            Console.WriteLine(jsonString);
        }
    }
}
