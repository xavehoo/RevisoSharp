using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class VatZoneCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<VatZone> Collection { get; set; }
    }
    public class VatZone
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("enabledForCustomer")]
        public bool EnabledForCustomer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("enabledForSupplier")]
        public bool EnabledForSupplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isDomestic")]
        public bool IsDomestic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isExemptVatZone")]
        public bool IsExemptVatZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isProjectAccount")]
        public bool IsProjectAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("textId")]
        public string TextId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatZoneNumber")]
        public int VatZoneNumber { get; set; }

    }
}
