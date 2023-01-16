using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{
    public class CustomerCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Customer> Collection { get; set; }
    }

    public class Customer
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("city")]
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
        public string UrlContacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("corporateIdentificationNumber")]
        public string CorporateIdentificationNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [JsonPropertyName("countryCode")]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerGroup")]
        public CustomerGroup CustomerGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("italianCustomerType")]
        public string ItalianCustomerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentTerms")]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("paymentType")]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("province")]
        public Province Province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("splitPayment")]
        public bool SplitPayment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("telephoneAndFaxNumber")]
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
        public string VatNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatZone")]
        public VatZone VatZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tags")]
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
        public string Name { get; set; }
    }
}
