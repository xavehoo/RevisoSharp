using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using static RevisoSharp.RevisoItems.RevisoClient;

namespace RevisoSharp.RevisoItems
{
    public interface IRevisoClient
    {
        Task<CustomerCollection> GetCustomerAsync(int pageSize, int skipPages);
        Task<Customer> GetCustomerAsync(string customerNumber);
        Task<VatZoneCollection> GetVatZoneAsync(int pageSize, int skipPages);
        Task<VatZone> GetVatZoneAsync(string vatZoneNumber);

    }

    public class RevisoClient : IRevisoClient, IDisposable
    {
        private readonly RestClient _client;
        readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions() { WriteIndented = true };


        public RevisoClient(string agreementGrantToken, string appSecretToken)
        {
            //var client = new RestClient(new RestClientOptions("https://rest.reviso.com") { ThrowOnAnyError = true, FailOnDeserializationError = true, ThrowOnDeserializationError = true });
            //var request = new RestRequest($"https://rest.reviso.com/vat-zones/1");
            var options = new RestClientOptions("https://rest.reviso.com")
            {
                ThrowOnAnyError = true,
                FailOnDeserializationError = true,
                ThrowOnDeserializationError = true
            };

            //_client = new RestClient(options)
            //{
            //    Authenticator = new RevisoAuthenticator("https://rest.reviso.com", agreementGrantToken, appSecretToken)
            //};
            _client = new RestClient(options);
            _client.AddDefaultHeader("Accept", "application/json");
            _client.AddDefaultHeader("ContentType", "application/json");
            _client.AddDefaultHeader("X-AgreementGrantToken", agreementGrantToken ?? "");
            _client.AddDefaultHeader("X-AppSecretToken", appSecretToken ?? "");
        }


        #region ACCOUNT APIs

        public AccountCollection GetAccount(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<AccountCollection>($"accounts", args);
            return response;
        }
        public async Task<AccountCollection> GetAccountAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<AccountCollection>($"accounts", args);
            return response;
        }
        public Account GetAccount(string accountNumber)
        {
            var response = _client.GetJson<Account>($"accounts/{accountNumber}");
            return response;
        }
        public async Task<Account> GetAccountAsync(string accountNumber)
        {
            var response = await _client.GetJsonAsync<Account>($"accounts/{accountNumber}");
            return response;
        }

        #endregion

        #region ACCOUNT CATEGORY APIs

        public AccountCategoryCollection GetAccountCategory(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<AccountCategoryCollection>($"account-categories", args);
            return response;
        }
        public async Task<AccountCategoryCollection> GetAccountCategoryAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<AccountCategoryCollection>($"account-categories", args);
            return response;
        }
        public async Task<AccountCategory> GetAccountCategoryAsync(string accountCategoryNumber)
        {
            var response = await _client.GetJsonAsync<AccountCategory>($"account-categories/{accountCategoryNumber}");
            return response;
        }

        #endregion

        #region CUSTOMER APIs

        public CustomerCollection GetCustomer(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<CustomerCollection>($"customers", args);
            return response;
        }
        public async Task<CustomerCollection> GetCustomerAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<CustomerCollection>($"customers", args);
            return response;
        }
        public async Task<Customer> GetCustomerAsync(string customerNumber)
        {
            var response = await _client.GetJsonAsync<Customer>($"customers/{customerNumber}");
            return response;
        }
        public async Task<Customer> PostCustomerAsync(Customer customer)
        {
            //var request = customer.
            var response = await _client.PostJsonAsync<Customer, Customer>($"customers", null);
            return response;
        }

        #endregion

        #region SUPPLIER APIs

        public SupplierCollection GetSupplier(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<SupplierCollection>($"suppliers", args);
            return response;
        }
        public async Task<SupplierCollection> GetSupplierAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<SupplierCollection>($"suppliers", args);
            return response;
        }
        public async Task<Supplier> GetSupplierAsync(string supplierNumber)
        {
            var response = await _client.GetJsonAsync<Supplier>($"suppliers/{supplierNumber}");
            return response;
        }
        public async Task<Supplier> PostSupplierAsync(Supplier supplier)
        {
            //var request = supplier.
            var response = await _client.PostJsonAsync<Supplier, Supplier>($"suppliers", null);
            return response;
        }

        #endregion

        #region SUPPLIER GROUP APIs

        public SupplierGroupCollection GetSupplierGroup(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<SupplierGroupCollection>($"supplier-groups", args);
            return response;
        }
        public async Task<SupplierGroupCollection> GetSupplierGroupAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<SupplierGroupCollection>($"supplier-groups", args);
            return response;
        }
        public async Task<SupplierGroup> GetSupplierGroupAsync(string supplierGroupNumber)
        {
            var response = await _client.GetJsonAsync<SupplierGroup>($"supplier-groups/{supplierGroupNumber}");
            return response;
        }
        public async Task<SupplierGroup> PostSupplierGroupAsync(SupplierGroup supplierGroup)
        {
            //var request = supplier.
            var response = await _client.PostJsonAsync<SupplierGroup, SupplierGroup>($"supplier-groups", null);
            return response;
        }

        #endregion

        #region INVOICE APIs

        public InvoiceCollection GetBookedInvoice(int pageSize, int skipPages)
        {
            var args = new { pageSize = pageSize, skipPages = skipPages, filter = "date$gte:2015-01-01$and:date$lte:2030-12-31" };
            //var response = _client.GetJson<InvoiceCollection>($"v2/invoices/booked", args);
            var response = _client.GetJson<InvoiceCollection>($"v2/invoices/booked", args);
            return response;
        }
        public async Task<InvoiceCollection> GetBookedInvoiceAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<InvoiceCollection>($"v2/invoices/booked", args);
            return response;
        }
        public InvoiceCollection GetBookedInvoiceFiltered(int pageSize, int skipPages, string filter)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<InvoiceCollection>($"v2/invoices/booked?filter={filter}", args);
            return response;
        }
        public Invoice GetBookedInvoice(string invoiceId)
        {
            var response = _client.GetJson<Invoice>($"v2/invoices/booked/{invoiceId}");
            return response;
        }
        public async Task<Invoice> GetBookedInvoiceAsync(string invoiceId)
        {
            var response = await _client.GetJsonAsync<Invoice>($"v2/invoices/booked/{invoiceId}");
            return response;
        }

        public InvoiceCollection GetDraftInvoice(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<InvoiceCollection>($"v2/invoices/drafts", args);
            return response;
        }
        public async Task<InvoiceCollection> GetDraftInvoiceAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<InvoiceCollection>($"v2/invoices/drafts", args);
            return response;
        }
        public Invoice GetDraftInvoice(string invoiceId)
        {
            var response = _client.GetJson<Invoice>($"v2/invoices/drafts/{invoiceId}");
            return response;
        }
        public async Task<Invoice> GetDraftInvoiceAsync(string invoiceId)
        {
            var response = await _client.GetJsonAsync<Invoice>($"v2/invoices/drafts/{invoiceId}");
            return response;
        }

        #endregion


        #region ORDER APIs

        public OrderCollection GetOrder(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<OrderCollection>($"orders", args);
            return response;
        }
        public async Task<OrderCollection> GetOrderAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<OrderCollection>($"orders", args);
            return response;
        }
        public async Task<Order> GetOrderAsync(string orderNumber)
        {
            var response = await _client.GetJsonAsync<Order>($"orders/{orderNumber}");
            return response;
        }
        public Order CreateOrder(Order order)
        {
            var request = JsonSerializer.Serialize(order, _jsonOptions);
            var response = _client.PostJson<string, Order>($"orders", request);
            return response;
        }
        public async Task<Order> CreateOrderAsync(Order order)
        {
            var request = JsonSerializer.Serialize(order, _jsonOptions);
            var response = await _client.PostJsonAsync<string, Order>($"orders", request);
            return response;
        }

        #endregion

        #region PAYMENT TERM APIs

        public PaymentTermCollection GetPaymentTerm(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<PaymentTermCollection>($"payment-terms", args);
            return response;
        }
        public async Task<PaymentTermCollection> GetPaymentTermAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<PaymentTermCollection>($"payment-terms", args);
            return response;
        }
        public async Task<PaymentTerm> GetPaymentTermAsync(int paymentTermsNumber)
        {
            var response = await _client.GetJsonAsync<PaymentTerm>($"payment-terms/{paymentTermsNumber}");
            return response;
        }

        #endregion

        #region PAYMENT TYPE APIs

        public PaymentTypeCollection GetPaymentType(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<PaymentTypeCollection>($"payment-types", args);
            return response;
        }
        public async Task<PaymentTypeCollection> GetPaymentTypeAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<PaymentTypeCollection>($"payment-types", args);
            return response;
        }
        public async Task<PaymentType> GetPaymentTypeAsync(int paymentTypeNumber)
        {
            var response = await _client.GetJsonAsync<PaymentType>($"payment-types/{paymentTypeNumber}");
            return response;
        }

        #endregion

        #region PRODUCT APIs

        public ProductCollection GetProduct(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<ProductCollection>($"products", args);
            return response;
        }
        public async Task<ProductCollection> GetProductAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<ProductCollection>($"products", args);
            return response;
        }
        public async Task<Product> GetProductAsync(string productNumber)
        {
            var response = await _client.GetJsonAsync<Product>($"product/{productNumber}");
            return response;
        }

        #endregion

        #region PROVINCE APIs

        public ProvinceCollection GetProvince(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<ProvinceCollection>($"provinces", args);
            return response;
        }
        public async Task<ProvinceCollection> GetProvinceAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<ProvinceCollection>($"provinces", args);
            return response;
        }
        public async Task<Province> GetProvinceAsync(string provinceNumber)
        {
            var response = await _client.GetJsonAsync<Province>($"provinces/{provinceNumber}");
            return response;
        }

        #endregion

        #region TENDER CONTRACT APIs

        //public TenderContractCollection GetTenderContract(int pageSize, int skipPages)
        //{
        //    var args = new { pageSize, skipPages };
        //    var response = _client.GetJson<TenderContractCollection>($"units", args);
        //    return response;
        //}
        //public async Task<UnitCollection> GetUnitAsync(int pageSize, int skipPages)
        //{
        //    var args = new { pageSize, skipPages };
        //    var response = await _client.GetJsonAsync<UnitCollection>($"units", args);
        //    return response;
        //}
        //public async Task<Unit> GetUnitAsync(string unitNumber)
        //{
        //    var response = await _client.GetJsonAsync<Unit>($"units/{unitNumber}");
        //    return response;
        //    //return response != null ? response.Data : null;
        //}

        #endregion

        #region UNIT APIs

        public UnitCollection GetUnit(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<UnitCollection>($"units", args);
            return response;
        }
        public async Task<UnitCollection> GetUnitAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<UnitCollection>($"units", args);
            return response;
        }
        public async Task<Unit> GetUnitAsync(string unitNumber)
        {
            var response = await _client.GetJsonAsync<Unit>($"units/{unitNumber}");
            return response;
            //return response != null ? response.Data : null;
        }

        #endregion

        #region VAT ACCOUNT APIs

        public VatAccountCollection GetVatAccount(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<VatAccountCollection>($"vat-accounts", args);
            return response;
        }
        public async Task<VatAccountCollection> GetVatAccountAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<VatAccountCollection>($"vat-accounts", args);
            return response;
        }
        public async Task<VatAccount> GetVatAccountAsync(string vatCode)
        {
            var response = await _client.GetJsonAsync<VatAccount>($"vat-accounts/{vatCode}");
            return response;
            //return response != null ? response.Data : null;
        }

        #endregion

        #region VAT INFO APIs

        //public VatInfoCollection GetVatInfo(int pageSize, int skipPages)
        //{
        //    var args = new { pageSize, skipPages };
        //    var response = _client.GetJson<VatInfoCollection>($"vat-zinones", args);
        //    return response;
        //}
        //public async Task<VatInfoCollection> GetVatInfoAsync(int pageSize, int skipPages)
        //{
        //    var args = new { pageSize, skipPages };
        //    var response = await _client.GetJsonAsync<VatZoneCollection>($"vat-zones", args);
        //    return response;
        //}
        //public async Task<VatInfo> GetVatInfoAsync(string vatZoneNumber)
        //{
        //    var response = await _client.GetJsonAsync<VatZone>($"vat-zones/{vatZoneNumber}");
        //    return response;
        //    //return response != null ? response.Data : null;
        //}

        #endregion

        #region VAT ZONE APIs

        public VatZoneCollection GetVatZone(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<VatZoneCollection>($"vat-zones", args);
            return response;
        }
        public async Task<VatZoneCollection> GetVatZoneAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<VatZoneCollection>($"vat-zones", args);
            return response;
        }
        public async Task<VatZone> GetVatZoneAsync(string vatZoneNumber)
        {
            var response = await _client.GetJsonAsync<VatZone>($"vat-zones/{vatZoneNumber}");
            return response;
            //return response != null ? response.Data : null;
        }

        #endregion


        #region VOUCHER APIs

        public VoucherCollection GetVoucher(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<VoucherCollection>($"vouchers", args);
            return response;
        }
        public async Task<VoucherCollection> GetVoucherAsync(int pageSize, int skipPages)
        {
            var args = new { pageSize, skipPages };
            var response = await _client.GetJsonAsync<VoucherCollection>($"vouchers", args);
            return response;
        }
        public VoucherCollection GetVoucherFiltered(int pageSize, int skipPages, string filter)
        {
            var args = new { pageSize, skipPages };
            var response = _client.GetJson<VoucherCollection>($"vouchers?filter={filter}", args);
            return response;
        }
        public async Task<Voucher> GetVoucher(string voucherId)
        {
            var response = await _client.GetJsonAsync<Voucher>($"vouchers/{voucherId}");
            return response;
            //return response != null ? response.Data : null;
        }
        public async Task<Voucher> GetVoucherAsync(string voucherId)
        {
            var response = await _client.GetJsonAsync<Voucher>($"vouchers/{voucherId}");
            return response;
            //return response != null ? response.Data : null;
        }

        #endregion


        //public class RevisoSingleObject<T>
        //{
        //    public RevisoSingleObject() { }
        //    public T Data { get; set; }
        //}

        //public class RevisoCollection<T>
        //{
        //    public RevisoCollection() { }
        //    public T[] Data { get; set; }
        //}

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }

    public class RevisoAuthenticator : AuthenticatorBase
    {
        readonly string _baseUrl;
        readonly string _clientId;
        readonly string _clientSecret;

        public RevisoAuthenticator(string baseUrl, string clientId, string clientSecret) : base("")
        {
            _baseUrl = baseUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            //var token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            //return new HeaderParameter(KnownHeaders.Authorization, token);
            return null;
        }

        //async Task<string> GetToken()
        //{
        //    var options = new RestClientOptions(_baseUrl);

        //    using var client = new RestClient(options)
        //    {
        //        Authenticator = new HttpBasicAuthenticator(_clientId, _clientSecret),
        //    };

        //    var request = new RestRequest("oauth2/token")
        //        .AddParameter("grant_type", "client_credentials");
        //    var response = await client.PostAsync<TokenResponse>(request);
        //    return $"{response!.TokenType} {response!.AccessToken}";
        //}

        //record TokenResponse
        //{
        //    [JsonPropertyName("token_type")]
        //    public string TokenType { get; init; }
        //[JsonPropertyName("access_token")]
        //public string AccessToken { get; init; }
    }
}
