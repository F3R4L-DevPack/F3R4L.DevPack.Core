using F3R4L.DevPack.Api.Endpoints;

namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests.Models
{
    public class TestAuditableGetEndpoints : AuditableGetEndpoint<MockServerResponse>
    {
        public TestAuditableGetEndpoints(string hostName, string endpoint) : base(hostName, endpoint)
        {
        }
    }
}
