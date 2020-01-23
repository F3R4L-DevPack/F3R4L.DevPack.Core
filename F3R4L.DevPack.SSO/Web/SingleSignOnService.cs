using F3R4L.DevPack.SSO.Models;
using F3R4L.DevPack.SSO.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace F3R4L.DevPack.SSO.Web
{
    public class SingleSignOnService : ISingleSignOnService
    {
        public string GetAuthorisationCode(Uri requesturi)
        {
            throw new NotImplementedException();
        }

        public long GetCharacterIdForToken(string token)
        {
            throw new NotImplementedException();
        }

        public TokenResponse GetTokensFromAuthenticationToken(string clientId, string applicationKey, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<TokenResponse> GetTokensAsync(string clientId, string applicationKey, string token)
        {
            throw new NotImplementedException();
        }

        public string SignOnRedirectUrl(string redirectURI, string clientId, IEnumerable<string> scopes)
        {
            return string.Concat(string.Format(UrlResources.AuthorisationUrlFormat,
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
