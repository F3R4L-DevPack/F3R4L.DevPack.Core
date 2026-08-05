using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.Api.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToQueryString(this object obj)
        {
            if (obj == null)
                return string.Empty;
            var properties = obj.GetType().GetProperties();
            var queryString = new StringBuilder();
            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                if (value != null)
                {
                    if (queryString.Length > 0)
                        queryString.Append("&");
                    queryString.Append(Uri.EscapeDataString(property.Name));
                    queryString.Append("=");
                    queryString.Append(Uri.EscapeDataString(value.ToString()));
                }
            }
            return queryString.ToString();
        }
    }
}
