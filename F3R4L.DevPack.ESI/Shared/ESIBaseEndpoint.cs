using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Constants;

namespace F3R4L.DevPack.ESI.Shared
{
    public class ESIBaseEndpoint<TIn, TOut>
        : ApiEndpoint<TIn, TOut>
    {
        public ESIBaseEndpoint(string endpointFormat)
            : base(string.Concat(StringConstants._esiBaseUrl, endpointFormat))
        {
        }
    }

    public class ESIBaseEndpoint<TIn1, TIn2, TOut>
        : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public ESIBaseEndpoint(string endpointFormat)
            : base(string.Concat(StringConstants._esiBaseUrl, endpointFormat))
        {
        }
    }
}
