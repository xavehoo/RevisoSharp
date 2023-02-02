using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class ProvinceCollection : RevisoBaseCollection
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Province> Collection { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class Province : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("countryCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// 
        /// Default value = 9 (""). Cannot be 0;
        /// </summary>
        [JsonPropertyName("provinceNumber")]
        public int ProvinceNumber { get; set; } = 999;
    }

}
