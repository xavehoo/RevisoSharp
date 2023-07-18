using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class InvoiceCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Invoice> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Invoice : Document
    {
        public Invoice() { }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatDate")]
        public DateTimeOffset VatDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bookedInvoiceNumber")]
        public int? BookedInvoiceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("displayInvoiceNumber")]
        public string DisplayInvoiceNumber { get; set; }

        ///// <summary>
        ///// Empty
        ///// </summary>
        //[JsonPropertyName("electronicInvoiceFiles")]
        //public List<ElectronicInvoiceFile> ElectronicInvoiceFiles { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("layout")]
        //public Layout Layout { get; set; }

        ///// <summary>
        ///// Da completare più avanti
        ///// </summary>
        //[JsonPropertyName("tenderContract")]
        //public TenderContract TenderContract { get; set; }

        ///// <summary>
        ///// Only if necessary
        ///// </summary>
        //[JsonPropertyName("priceList")]
        //public PriceList PriceList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voucher")]
        public Voucher Voucher { get; set; }

    }
}
