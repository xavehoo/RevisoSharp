using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class AccountCategoryCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<AccountCategory> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AccountCategory : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accountCategoryType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string AccountCategoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("parent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AccountCategory Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("useInvertedAccountCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? UseInvertedAccountCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accountCategoryNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AccountCategoryNumber { get; set; }
    }

}
