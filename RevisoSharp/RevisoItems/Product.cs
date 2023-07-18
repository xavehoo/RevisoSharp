using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class ProductCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Product> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Product : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("barCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string BarCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("barred")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Barred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("costPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? CostPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Description { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("inventory")]
        //public Inventory Inventory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lastUpdated")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("productGroup")]
        //public ProductGroup ProductGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("recommendedPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? RecommendedPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("recommendedCostPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? RecommendedCostPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("salesPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? SalesPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<object> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("productNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ProductNumber { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("metaData")]
        //public MetaData MetaData { get; set; }

    }


    public class ProductDetail
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("product")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("productName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("unitPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? UnitPrice { get; set; }

    }
}
