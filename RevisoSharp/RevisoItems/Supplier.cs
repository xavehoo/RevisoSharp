using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class SupplierCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Supplier> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Supplier : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("city")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("contacts")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri Contacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("corporateIdentificationNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string CorporateIdentificationNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("costAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account CostAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("countryCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Email { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("layout")]
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        //public Layout Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTerms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("province")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Province Province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("remittanceAdvice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RemittanceAdvice RemittanceAdvice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplierGroup")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SupplierGroup SupplierGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string VatNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatZone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatZone VatZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplierNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SupplierNumber { get; set; }

    }




    /// <summary>
    /// 
    /// </summary>
    public class SupplierGroupCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<SupplierGroup> Collection { get; set; }
    }



    public class SupplierGroup
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account Account { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("hasInventoryWithdrawal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? HasInventoryWithdrawal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplierGroupType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SupplierGroupType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplierGroupNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SupplierGroupNumber { get; set; }

    }



    /// <summary>
    /// 
    /// </summary>
    public partial class RemittanceAdvice
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fieldValues")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object[] FieldValues { get; set; }

    }


}
