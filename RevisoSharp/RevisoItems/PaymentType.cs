using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    public class PaymentTypeCollection : RevisoBaseCollection
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentType> Collection { get; set; }

    }

    public class PaymentType : RevisoBaseObject
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// Default value = 21 ("Bank transfer"). Cannot be 0;
        /// </summary>
        [JsonPropertyName("paymentTypeNumber")]
        public int PaymentTypeNumber { get; set; } = 21;

    }



    /// <summary>
    /// 
    /// </summary>
    public class PaymentTypeFieldCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<PaymentTypeField> Collection { get; set; }
    }

    public class PaymentTypeField : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("dataType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("maximumLength")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaximumLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("minimumLength")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinimumLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTypeFieldNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentTypeFieldNumber { get; set; }

    }

}
