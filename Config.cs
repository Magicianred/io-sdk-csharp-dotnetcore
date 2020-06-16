using System;
using System.Text.Json;
using System.Collections.Generic;
using io_sdk_csharp_dotnetcore.Models;

namespace io_sdk_csharp_dotnetcore
{
    public static class Config
    {
        public static Form getData() {
            var data = new Form();
            data.Fields = new List<Field>() {
                new Field() { 
                    Type = "message",
                    Name = "note",
                    Description = "Connect to SQLServer db to import messages"
                },            
                new Field() { 
                    Type = "string",
                    Name = "ConnectionString",
                    Description = "Connection string to SQLServer db",
                    Required = true,
                }
            };
            return data;
        }

        public static string getJson() {
            var data = Config.getData();

            var jsonString = JsonSerializer.Serialize(data.Fields);
            jsonString = "{ \"form\": "+ jsonString +" } ";
            Console.WriteLine(jsonString);
            return jsonString;
        }
        

        // private static string GetFromFile()
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