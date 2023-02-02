using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    public class PaymentTermCollection : RevisoBaseCollection
    {
        public PaymentTermCollection() { }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentTerm> Collection { get; set; }

    }

    public class PaymentTerm : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("daysOfCredit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DaysOfCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTermsType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PaymentTermsType { get; set; }

        /// <summary>
        /// 
        /// Default value = 6 ("Rimessa Diretta"). Cannot be 0;
        /// </summary>
        [JsonPropertyName("paymentTermsNumber")]
        public int PaymentTermsNumber { get; set; } = 6;

    }

}
