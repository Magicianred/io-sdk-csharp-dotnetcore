using System;
using System.Collections.Generic;

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
                    Description = "Connect to SQLServer db to import messages",
                    Required = true,
                }
            };
            return data;
        }
    }
}