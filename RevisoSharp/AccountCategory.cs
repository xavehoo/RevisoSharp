using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class AccountCategoryCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<AccountCategory> Collection { get; set; }
    }
    public class AccountCategory
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accountCategoryType")]
        public string AccountCategoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("useInvertedAccountCategory")]
        public bool UseInvertedAccountCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accountCategoryNumber")]
        public int AccountCategoryNumber { get; set; }
    }
}
