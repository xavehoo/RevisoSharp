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
    public class Order : RevisoBaseObject
    {
        public Order(){
            this.PaymentTerms = new PaymentTerm();
            this.Recipient = new Recipient();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lines")]
        public List<OrderLine> Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatCodeGroups")]
        public List<VatCodeGroup> VatCodeGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("costPriceInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? CostPriceInBaseCurrency { get; set; }

        /// <summary>
        /// The ISO 4217 currency code of the sales document.
        /// (REQUIRED)
        /// Default value = "EUR". Cannot be null.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = "EUR";

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deductionInfo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DeductionInfo DeductionInfo { get; set; }

        /// <summary>
        /// (REQUIRED)
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// 
        /// (REQUIRED)
        /// Default value = DateTimeOffset.Now. Cannot be null.
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("delivery")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Delivery Delivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryLocation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DeliveryLocation DeliveryLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("dueDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// 
        /// Default value = 100. Cannot be 0.
        /// </summary>
        [JsonPropertyName("exchangeRate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? ExchangeRate { get; set; } = 100;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("grossAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? GrossAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Id { get; set; }

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

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("layout")]
        //public Layout Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("marginInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? MarginInBaseCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("marginPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? MarginPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("netAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("netAmountInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? NetAmountInBaseCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("notes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Notes Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numberSeries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public NumberSerie NumberSeries { get; set; }

        /// <summary>
        /// 
        /// (REQUIRED)
        /// </summary>
        [JsonPropertyName("paymentTerms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// 
        /// (REQUIRED)
        /// </summary>
        [JsonPropertyName("paymentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentType PaymentType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pdf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Pdf Pdf { get; set; }

        /// <summary>
        /// 
        /// (REQUIRED)
        /// </summary>
        [JsonPropertyName("recipient")]
        public Recipient Recipient { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("references")]
        //public References References { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("roundingAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? RoundingAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatIncluded")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? VatIncluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bankAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account BankAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryDetails")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DeliveryDetail DeliveryDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Number { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("priceList")]
        //public PriceList PriceList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("salesDocumentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SalesDocumentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("invoicingStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string InvoicingStatus { get; set; }

    }



    /// <summary>
    /// 
    /// </summary>
    public class OrderLine : RevisoBaseObject
    {

        /// <summary>
        /// 
        /// Default value = "". Cannot be null.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("discountPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? DiscountPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("lineNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int LineNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("marginInBaseCurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? MarginInBaseCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("marginPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? MarginPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("product")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("sortKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("totalNetAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalNetAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("totalGrossAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalGrossAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("totalVatAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? TotalVatAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("unitCostPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? UnitCostPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonPropertyName("unitNetPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? UnitNetPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveredQuantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? DeliveredQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("manuallyEditedSalesPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManuallyEditedSalesPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vatInfo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VatInfo VatInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("movementChainId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid MovementChainId { get; set; }
    }

}
