using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class ProvinceCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Province> Collection { get; set; }
    }

    public class Province
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("coutryCode")]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("provinceNumber")]
        public int ProvinceNumber { get; set; }

    }
}
