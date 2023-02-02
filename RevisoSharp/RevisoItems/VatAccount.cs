using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    public class VatAccountCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<VatAccount> Collection { get; set; }
    }

    public class VatAccount : RevisoBaseObject
    {
        public VatAccount()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("barred")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Barred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isTotalVatAccountIncluded")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsTotalVatAccountIncluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ratePercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? RatePercentage { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("vatReportSetup")]
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        //public VatReportSetup VatReportSetup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatType VatType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("includesStampDuty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IncludesStampDuty { get; set; }

        /// <summary>
        /// 
        /// Default value = "V022". Cannot be null.
        /// </summary>
        [JsonPropertyName("vatCode")]
        public string VatCode { get; set; } = "V022";


    }



    public class VatTypeCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<VatType> Collection { get; set; }
    }

    public class VatType : RevisoBaseObject
    {
        public VatType() { }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// Possible values : 1 (Sales VAT), 2 (Purchases VAT), 3 (International and reverse charge). Default value = 1. Cannot be null.
        /// </summary>
        [JsonPropertyName("vatTypeNumber")]
        public int VatTypeNumber { get; set; } = 1;

    }



    public class VatCodeGroupCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<VatCodeGroup> Collection { get; set; }
    }

    public class VatCodeGroup : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatAccount VatAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatRate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? VatRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("totalNetAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalNetAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("totalVatAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalVatAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("totalGrossAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalGrossAmount { get; set; }
    }

}
