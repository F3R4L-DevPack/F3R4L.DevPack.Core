using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.SSO.Endpoints;
using F3R4L.DevPack.SSO.Models;
using F3R4L.DevPack.SSO.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.SSO.Web
{
    public class SingleSignOnService : ISingleSignOnService
    {
        private readonly IApiService _apiService;

        public SingleSignOnService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public string GetRefreshTokenFromReturnUri(Uri requestUri)
        {
            return requestUri.Query.Split(new string[] { "=" }, StringSplitOptions.None).Last();
        }

        public async Task<TokenResponse> GetTokensFromRefreshTokenAsync(string clientId, string applicationKey, string token, string tokenRefreshUrl, string hostName)
        {
            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat(clientId, ":", applicationKey)));

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri(tokenRefreshUrl),
                Method = HttpMethod.Post
            };
            requestMessage.Headers.Add("Authorization", string.Concat("Basic ", encoded));
            requestMessage.Headers.Add("host", hostName);
            requestMessage.Content = new StringContent(string.Concat("grant_type=authorization_code&code=", token));
            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            return await _apiService.SendAsync<TokenResponse>(requestMessage);
        }

        public string SignOnRedirectUrl(string redirectURI, string clientId, IEnumerable<string> scopes, string urlFormat)
        {
            return string.Concat(string.Format(urlFormat,
               UrlResources.Authorise),
               UrlResources.Question,
               UrlResources.ResponseTypeModifier,
               UrlResources.Ampersand,
               string.Format(UrlResources.RedirectURIFormat, redirectURI),
               UrlResources.Ampersand,
               string.Format(UrlResources.ClientIdFormat, clientId),
               UrlResources.Ampersand,
               ScopeBuilder.Build(scopes),
               UrlResources.Ampersand,
               Guid.NewGuid().ToString()
           );
        }
    }
}
