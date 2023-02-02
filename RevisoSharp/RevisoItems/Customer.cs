using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class CustomerCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Customer> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Customer : RevisoBaseObject
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
        /// 
        [JsonPropertyName("balance")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("city")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string City { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// 
        //[JsonPropertyName("contacts")]
        //public List<CustomerContact> Contacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("contacts")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string UrlContacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("corporateIdentificationNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string CorporateIdentificationNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
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
        [JsonPropertyName("customerGroup")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CustomerGroup CustomerGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("directDebitMandateDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DirectDebitMandateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("iban")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Iban { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("italianCertifiedEmail")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ItalianCertifiedEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("italianCustomerType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ItalianCustomerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lastUpdated")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("mandateID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string MandateID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTerms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("province")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Province Province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("publicEntryNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PublicEntryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("splitPayment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SplitPayment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("swift")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Swift { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("telephoneAndFaxNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string TelephoneAndFaxNumber { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("templates")]
        //public Template Templates { get; set; }

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
        [JsonPropertyName("webSite")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string WebSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object[] Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public int CustomerNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class DeliveryLocation : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("barred")]
        public bool Barred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryLocationNumber")]
        public int DeliveryLocationNumber { get; set; }

    }

}
