using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class NumberSerieCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<NumberSerie> Collection { get; set; }
    }

    public class NumberSerie
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("allowGaps")]
        public bool AllowGaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entrySubtype")]
        public EntrySubtype EntrySubtype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entryType")]
        public string EntryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("peeks")]
        //public Array<AccountingYearsPeek> Peeks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("systemGenerated")]
        public bool SystemGenerated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isOrdered")]
        public bool IsOrdered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sequenceType")]
        public string SequenceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numberSeriesNumber")]
        public int NumberSeriesNumber { get; set; }
    }
}
