using F3R4L.DevPack.SSO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F3R4L.DevPack.SSO.Shared
{
    public class ScopeBuilder
    {
        public static string Build(IEnumerable<string> scopes)
        {
            var stringBuilder = new StringBuilder();

            if (scopes.Count() > 0)
            {
                stringBuilder.Append(string.Format(UrlResources.ScopeFormat,
                    string.Join(UrlResources.Plus, scopes)
                    ));
            }

            return stringBuilder.ToString();
        }
    }
}
