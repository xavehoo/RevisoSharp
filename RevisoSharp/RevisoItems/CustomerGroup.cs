using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class CustomerGroupCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CustomerGroup> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CustomerGroup : RevisoBaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerGroupNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? CustomerGroupNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customers")]
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("salesInvoiceNumberSerie")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public NumberSerie SalesInvoiceNumberSerie { get; set; }
    }

}
