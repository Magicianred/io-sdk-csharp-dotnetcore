using System;
using System.Text.Json.Serialization;

namespace io_sdk_csharp_dotnetcore.Models
{
    public class Message
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("due_date")]
        public DateTime DueDate { get; set; }

        [JsonPropertyName("fiscal_code")]
        public string FiscalCode { get; set; }

        [JsonPropertyName("invalid_after_due_date")]
        public int InvalidAfterDueDate { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        [JsonPropertyName("notice_number")]
        public int NoticeNumber { get; set; }
        
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    }
}