using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class CustomerContactCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CustomerContact> Collection { get; set; }
    }

    public class CustomerContact
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerContactNumber")]
        public string CustomerContactNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("eInvoice")]
        public string EInvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("emailNotifications")]
        //public EmailNotification EmailNotifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

    }
}
