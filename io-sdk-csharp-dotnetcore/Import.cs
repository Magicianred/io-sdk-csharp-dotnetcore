using System;
using System.Text.Json;
using io_sdk_csharp_dotnetcore.Models;

namespace io_sdk_csharp_dotnetcore
{
    public static class Import
    {
        public static string Process(string connectionString) {
            string jsonString = String.Empty;

            var config = Config.getData();

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
            return jsonString;
        }
    }
}