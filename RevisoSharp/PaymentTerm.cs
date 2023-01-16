using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class PaymentTermCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentTerm> Collection { get; set; }
    }

    public class PaymentTerm
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("daysOfCredit")]
        public int DaysOfCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTermsType")]
        public string PaymentTermsType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTermsNumber")]
        public int PaymentTermsNumber { get; set; }

    }
}
