using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    #region Response Classes

    /// <summary>
    /// 
    /// </summary>
    public class RevisoBaseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("developerHint")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DeveloperHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errors")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ResponseError> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("httpStatusCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public HttpStatusCode? HttpStatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("logId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid LogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("logTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("message")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("details")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ResponseDetail Details { get; set; }

    }



    /// <summary>
    /// 
    /// </summary>
    public class RevisoBaseObject : RevisoBaseResponse
    {

    }



    /// <summary>
    /// 
    /// </summary>
    public class RevisoBaseCollection : RevisoBaseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pagination")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Pagination Pagination { get; set; }

    }


    /// <summary>
    /// 
    /// </summary>
    public partial class ResponseError
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("developerHint")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DeveloperHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("logTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("message")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("details")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ErrorDetail Details { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public partial class ResponseDetail
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entity")]
        public List<int> Entity { get; set; }
    }



    /// <summary>
    ///  
    /// </summary>
    public partial class ErrorDetail
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("property")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Property { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("index")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("path")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Path { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Pagination
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("maxPageSizeAllowed")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxPageSizeAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pageSize")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("skipPages")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SkipPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("resultsWithoutFilter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ResultsWithoutFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("firstPage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri FirstPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("lastPage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri LastPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nextPage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri NextPage { get; set; }
    }

    #endregion



    /// <summary>
    /// 
    /// </summary>
    public class CarrierInfo
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("identificationNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string IdentificationNumber { get; set; }

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
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("notes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Notes { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class CountryCodeCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<CountryCode> Collection { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class CountryCode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ossMember")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OssMember { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class DeductionInfo
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deductionAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? DeductionAmount { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    public class Delivery
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
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryTerms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DeliveryTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Zip { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class DeliveryDetail
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numberOfPackages")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? NumberOfPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryNoteNumberSeries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public NumberSerie DeliveryNoteNumberSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("descriptionOfPackages")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DescriptionOfPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("deliveryStartDateTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DeliveryStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("reasonForDelivery")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ReasonForDelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("carrierInfo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CarrierInfo CarrierInfo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Notes
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("heading")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Heading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("text1")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("text2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text2 { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class Pdf
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("download")]
        public string Download { get; set; }
    }



    /// <summary>
    /// 
    /// </summary>
    public class Recipient
    {
        public Recipient()
        {
            this.VatZone = new VatZone();
        }

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
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("province")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Province Province { get; set; }

        /// <summary>
        /// 
        /// Default value = "". Cannot be null.
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; } = "";

        /// <summary>
        /// 
        /// (REQUIRED)
        /// </summary>
        [JsonPropertyName("vatZone")]
        public VatZone VatZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Zip { get; set; }
    }



    public class UnitCollection : RevisoBaseCollection
    {
        public UnitCollection() { }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Unit> Collection { get; set; }

    }



    /// <summary>
    /// 
    /// </summary>
    public class Unit
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("products")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Uri Products { get; set; }

        /// <summary>
        /// 
        /// Default value = 1 ("N."). Cannot be 0;
        /// </summary>
        [JsonPropertyName("unitNumber")]
        public int UnitNumber { get; set; } = 1;
    }



    /// <summary>
    /// 
    /// </summary>
    public class VatInfo
    {
        public VatInfo() { }

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

    }

}
