using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{
    public class EntrySubtypeCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<EntrySubtype> Collection { get; set; }
    }

    public class EntrySubtype
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entrySubtypeNumber")]
        public int EntrySubtypeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entryType")]
        public string EntryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("hideInUni")]
        public bool HideInUi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isNumberSeriesCreationAllowed")]
        public bool IsNumberSeriesCreationAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isVoucherCreationAllowed")]
        public bool IsVoucherCreationAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isAcrossAccountingYears")]
        public bool IsAcrossAccountingYears { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
