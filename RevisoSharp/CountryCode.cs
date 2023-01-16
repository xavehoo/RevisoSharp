using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class CountryCodeCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CountryCode> Collection { get; set; }
    }

    public class CountryCode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ossMember")]
        public bool OssMember { get; set; }
    }
}
