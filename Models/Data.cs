using System;
using System.Collections.Generic;

namespace io_sdk_csharp_dotnetcore.Models
{
    public class Data
    {
        public List<Message> Messages { get; set; }
        public string Error { get; set; } = null;
    }
}