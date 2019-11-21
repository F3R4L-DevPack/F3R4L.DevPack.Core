namespace F3R4L.DevPack.Api.Wrappers
{
    public interface IJsonSerialisationWrapper
    {
        T Deserialise<T>(string source);
        string Serialise<T>(T source);
    }
}