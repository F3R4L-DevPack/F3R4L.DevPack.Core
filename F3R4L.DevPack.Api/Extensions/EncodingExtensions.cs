using System.Text;

namespace F3R4L.DevPack.Api.Extensions
{
    public static class EncodingExtensions
    {
        public static string ToUTF8String(this string content)
        {
            return content.ToBytes().ToUTF8String();
        }

        public static string ToUTF8String(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        public static byte[] ToBytes(this string content)
        {
            return Encoding.ASCII.GetBytes(content);
        }
    }
}