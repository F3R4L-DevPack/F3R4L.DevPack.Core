using System;
using System.Collections.Generic;
using System.Linq;

namespace F3R4L.DevPack.Api.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
                action(item);
        }

        public static string ToUrlParameterString(this IEnumerable<KeyValuePair<string, object>> keyValuePairs)
        {
            return string.Join("&", keyValuePairs.Select(s => string.Concat(s.Key, "=", s.Value)));
        }

        public static string Join(this IEnumerable<string> me, string seperator)
        {
            return string.Join(seperator, me);
        }
    }
}
