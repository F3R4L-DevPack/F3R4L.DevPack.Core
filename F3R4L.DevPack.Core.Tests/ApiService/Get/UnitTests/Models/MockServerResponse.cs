using Newtonsoft.Json;

namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests.Models
{
    public class MockServerResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
