using System;
using System.Collections.Generic;

namespace io_sdk_csharp_dotnetcore
{
    /// Descrittore della Form
    public class Field
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; } = false;
    }
}