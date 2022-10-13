using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoSharp
{
    class Customer
    {
        public string Address { get; set; }
        public long Balance { get; set; }
        public string City { get; set; }
        public CustomerContact Contacts { get; set; }
        public string CorporateIdentificationNumber { get; set; }
        public string Country { get; set; }
        public CountryCode CountryCode { get; set; }
        public string Currency { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
        public string ItalianCustomerType { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public PaymentTerm PaymentTerms { get; set; }
        public PaymentType PaymentType { get; set; }
        public Province Province { get; set; }
        public bool SplitPayment { get; set; }
        public string TelephoneAndFaxNumber { get; set; }
        public Template Templates { get; set; }
        public string VatNumber { get; set; }
        public VatZone VatZone { get; set; }
        public long Zip { get; set; }
        public object[] Tags { get; set; }
        public long CustomerNumber { get; set; }
        public string Name { get; set; }
    }
}
