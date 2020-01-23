namespace F3R4L.DevPack.SSO.Models
{
    internal class UrlResources
    {
        internal const string Question = "?";
        internal const string Plus = "+";
        internal const string Ampersand = "&";

        internal const string Authorise = "authorize";

        internal const string AuthorisationUrlFormat = "https://login.eveonline.com/oauth/{0}";

        internal const string ResponseTypeModifier = "response_type=code";
        internal const string RedirectURIFormat = "redirect_uri={0}";
        internal const string ClientIdFormat = "client_id={0}";
        internal const string ScopeFormat = "scope={0}";
    }
}
