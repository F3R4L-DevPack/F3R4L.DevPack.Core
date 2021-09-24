using F3R4L.DevPack.SSO.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace F3R4L.DevPack.SSO.Web
{
    public interface ISingleSignOnService
    {
        string GetRefreshTokenFromReturnUri(Uri requestUri);
        Task<TokenResponse> GetTokensAsync(string clientId, string applicationKey, string token, string tokenRefreshUrl, string hostName);
        string SignOnRedirectUrl(string redirectURI, string clientId, IEnumerable<string> scopes, string urlFormat);
    }
}