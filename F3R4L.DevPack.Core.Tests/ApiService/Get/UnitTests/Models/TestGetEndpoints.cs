using F3R4L.DevPack.Api.Endpoints;
namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests.Models
{
    public class TestGetEndpoint_Response : GetEndpoint<MockServerResponse>
    {
        public TestGetEndpoint_Response(string hostName, string endpoint) : base(hostName, endpoint)
        {
        }
    }
}
