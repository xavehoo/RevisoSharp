using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class NumberSerieCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<NumberSerie> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class NumberSerie : RevisoBaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prefix")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("allowGaps")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AllowGaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entrySubtype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public EntrySubtype EntrySubtype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entryType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string EntryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SystemGenerated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isOrdered")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsOrdered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sequenceType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SequenceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numberSeriesNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? NumberSeriesNumber { get; set; }
    }

}
