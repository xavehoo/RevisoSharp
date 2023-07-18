using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class OrderCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Order> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Order : Document
    {
        public Order(){ }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("lines")]
        //public List<DocumentLine> Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isArchived")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isSent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsSent { get; set; }

    }


}
