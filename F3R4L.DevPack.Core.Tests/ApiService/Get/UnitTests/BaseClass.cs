using F3R4L.DevPack.Api.Tests.ApiService;
using F3R4L.DevPack.Api.Wrappers;
using Moq;
using Newtonsoft.Json;
using TestArtifacts = F3R4L.DevPack.Api.Services;

namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests
{
    public class BaseClass
    {
        internal Mock<IHttpClientFactory> _clientFactory;
        internal IJsonSerialisationWrapper _jsonSerialisationWrapper;

        internal MockHttpMessageHandler _messageHandler;

        internal TestArtifacts.ApiService _objectUnderTest;

        internal const string _baseUrl = "https://localhost:5001";

        public BaseClass()
        {
            _messageHandler = new MockHttpMessageHandler();

            _clientFactory = new Mock<IHttpClientFactory>();
            _clientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
                .Returns(new HttpClient(_messageHandler));

            _jsonSerialisationWrapper = new JsonSerialisationWrapper();

            _objectUnderTest = new TestArtifacts.ApiService(_clientFactory.Object, _jsonSerialisationWrapper);
        }

        public HttpResponseMessage OkResponse
            = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("{\"message\":\"Success\"}")
            };
        public HttpResponseMessage InternalServerErrorResponse
            = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("InternalServerError")
            };
        public HttpResponseMessage NotFoundResponse
            = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
            {
                Content = new StringContent("PageNotFound")
            };
    }
}