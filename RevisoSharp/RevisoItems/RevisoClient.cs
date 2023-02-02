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
        public async Task<Order> GetOrderAsync(string customerNumber)
        {
            var response = await _client.GetJsonAsync<Order>($"orders/{customerNumber}");
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
