using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using static RevisoSharp.RevisoClient;

namespace RevisoSharp
{
    public interface IRevisoClient
    {
        Task<CustomerCollection> GetCustomer(int pageSize);
        Task<Customer> GetCustomer(string customerNumber);
        Task<VatZoneCollection> GetVatZone(int pageSize);
        Task<VatZone> GetVatZone(string vatZoneNumber);

    }

    public class RevisoClient : IRevisoClient, IDisposable
    {
        private RestClient _client;

        public RevisoClient(string agreementGrantToken, string appSecretToken)
        {
            //var client = new RestClient(new RestClientOptions("https://rest.reviso.com") { ThrowOnAnyError = true, FailOnDeserializationError = true, ThrowOnDeserializationError = true });
            //var request = new RestRequest($"https://rest.reviso.com/vat-zones/1");
            var options = new RestClientOptions("https://rest.reviso.com") {
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
            _client.AddDefaultHeader("X-AgreementGrantToken", agreementGrantToken);
            _client.AddDefaultHeader("X-AppSecretToken", appSecretToken);
        }



        public async Task<CustomerCollection> GetCustomer(int pageSize)
        {
            var args = new
            {
                pageSize
            };
            var response = await _client.GetJsonAsync<CustomerCollection>($"customers", args);
            return response;
        }
        public async Task<Customer> GetCustomer(string customerNumber)
        {
            var response = await _client.GetJsonAsync<Customer>($"customers/{customerNumber}");
            return response;
        }

        public async Task<VatZoneCollection> GetVatZone(int pageSize)
        {
            var args = new
            {
                pageSize
            };
            var response = await _client.GetJsonAsync<VatZoneCollection>($"vat-zones", args);
            return response;
        }
        public async Task<VatZone> GetVatZone(string vatZoneNumber)
        {

            var response = await _client.GetJsonAsync<VatZone>($"vat-zones/{vatZoneNumber}");
            return response;
            //return response != null ? response.Data : null;
        }

        public class RevisoSingleObject<T>
        {
            public RevisoSingleObject() {}
            public T Data { get; set; }
        }

        public class RevisoCollection<T>
        {
            public RevisoCollection() { }
            public T[] Data { get; set; }
        }

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
