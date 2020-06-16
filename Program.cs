using System;
using System.Text.Json;

namespace io_sdk_csharp_dotnetcore
{
    class Program
    {
        static string Main(string[] args)
        {
            string jsonString = String.Empty;

            var config = Config.getData();
            string connectionString = (args != null && args.Length > 0) ? args[0] : null;

            if (!String.IsNullOrWhiteSpace(connectionString)) {
                var messages = Repository.GetMessages(connectionString);

                jsonString = JsonSerializer.Serialize(messages);
                jsonString = "{ \"body\": { \"data\": "+ jsonString +" } } ";
                
            } else {
                jsonString = Config.getJson();
            }
            return jsonString;
        }
    }
}
