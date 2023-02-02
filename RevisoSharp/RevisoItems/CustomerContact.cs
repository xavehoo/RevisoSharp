using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class CustomerContactCollection : RevisoBaseCollection 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CustomerContact> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CustomerContact : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customer")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Customer Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerContactNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerContactNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("eInvoice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string EInvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("notes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Phone { get; set; }

    }

}
