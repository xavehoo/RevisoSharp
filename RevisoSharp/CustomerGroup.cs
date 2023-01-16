using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class CustomerGroupCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CustomerGroup> Collection { get; set; }
    }

    public class CustomerGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerGroupNumber")]
        public int CustomerGroupNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customers")]
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("salesInvoiceNumberSerie")]
        public NumberSerie SalesInvoiceNumberSerie { get; set; }
    }
}
