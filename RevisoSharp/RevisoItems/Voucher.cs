using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public class VoucherCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Voucher> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Voucher : RevisoBaseObject
    {
        public Voucher() { }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lines")]
        public List<VoucherLine> Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("attachment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri Attachment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("dueDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numberSeries")]
        public NumberSerie NumberSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("remainder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Remainder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("remainderInDefaultCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? RemainderInDefaultCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("invoice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("totalAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("version2Draft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Version2Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("booked")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Booked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voucherType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string VoucherType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("date")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voucherId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? VoucherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voucherNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VoucherNumber VoucherNumber { get; set; }

    }



    /// <summary>
    /// 
    /// </summary>
    public class VoucherLine : RevisoBaseObject
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
        [JsonPropertyName("contraAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account ContraAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("contraVatAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatAccount ContraVatAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("contraVatAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? ContraVatAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("contraVatAmountInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? ContraVatAmountInBaseCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("amountInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? AmountInBaseCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("booked")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Booked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entryNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? EntryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("exchangeRate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("invoiceNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? InvoiceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("productDetails")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ProductDetail ProductDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Supplier Supplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("supplierInvoiceNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SupplierInvoiceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("systemGeneratedVatLine")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SystemGeneratedVatLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isGainOrLossEntry")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsGainOrLossEntry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatAccount VatAccount { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? VatDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customer")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Customer Customer { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class VoucherNumber : RevisoBaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("displayVoucherNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DisplayNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prefix")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voucherNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Number { get; set; }
    }
}
