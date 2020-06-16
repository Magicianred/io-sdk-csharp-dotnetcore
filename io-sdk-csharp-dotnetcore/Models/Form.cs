using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace io_sdk_csharp_dotnetcore.Models
{
    /// Descrittore della Form
    public class Form
    {
        public List<Field> Fields { get; set; }
    }
}