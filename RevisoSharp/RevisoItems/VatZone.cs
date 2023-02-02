using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class VatZoneCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<VatZone> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class VatZone : RevisoBaseObject
    {
        public VatZone()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("enabledForCustomer")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnabledForCustomer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("enabledForSupplier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnabledForSupplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isDomestic")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsDomestic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isExemptVatZone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsExemptVatZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isProjectAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsProjectAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("textId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string TextId { get; set; }

        /// <summary>
        /// 
        /// Default value = 1 ("domestic"). Cannot be 0.
        /// </summary>
        [JsonPropertyName("vatZoneNumber")]
        public int VatZoneNumber { get; set; } = 1;

    }

}
