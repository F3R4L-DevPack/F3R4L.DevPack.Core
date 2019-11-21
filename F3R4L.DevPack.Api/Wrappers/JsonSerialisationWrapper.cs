using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace F3R4L.DevPack.Api.Wrappers
{
    [ExcludeFromCodeCoverage]
    public class JsonSerialisationWrapper : IJsonSerialisationWrapper
    {
        public string Serialise<T>(T source)
        {
            return JsonConvert.SerializeObject(source);
        }

        public T Deserialise<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}
