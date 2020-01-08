using F3R4L.DevPack.Api.Services;
using System.Linq;

namespace F3R4L.DevPack.ESI.Services
{
    public abstract class ESIBaseService
    {
        protected readonly IApiService _apiService;

        public ESIBaseService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public void AddOrReplaceToken(string token)
        {
            if (_apiService.Headers.Contains("authorization"))
            {
                _apiService.Headers.Remove("authorization");
            }
            _apiService.Headers.Add("authorization", string.Concat("Bearer ", token));
        }
    }
}
