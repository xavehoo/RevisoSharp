using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class PaymentTypeCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentType> Collection { get; set; }
    }

    public class PaymentType
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fields")]
        public List<PaymentTypeField> Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTypeNumber")]
        public int PaymentTypeNumber { get; set; }

    }



    public class PaymentTypeFieldCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentTypeField> Collection { get; set; }
    }

    public class PaymentTypeField
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("maximumLength")]
        public int? MaximumLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("minimumLength")]
        public int? MinimumLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTypeFieldNumber")]
        public int PaymentTypeFieldNumber { get; set; }

    }
}
