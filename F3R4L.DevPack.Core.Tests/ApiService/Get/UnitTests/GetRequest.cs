using F3R4L.DevPack.Api.Exceptions;
using F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests.Models;
using Shouldly;

namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests
{
    public class GetRequest : BaseClass
    {
        [Fact]
        public async Task Request_ResponseOnly_OkResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestGetEndpoint_Response(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(OkResponse);
            };

            //  Act
            var response = await _objectUnderTest.GetAsync(endpoint);

            //  Assert
            response.GetType().ShouldBe(typeof(MockServerResponse));
            response.Message.ShouldBe("Success");
        }

        [Fact]
        public void Request_ResponseOnly_InternalServerErrorResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestGetEndpoint_Response(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(InternalServerErrorResponse);
            };

            //  Act
            var act = () => _objectUnderTest.GetAsync(endpoint);

            //  Assert
            var ex = act.ShouldThrow<ApiCallException>();
            ex.Uri.ShouldBe("https://localhost:5001/get");
            ex.HttpMethod.ShouldBe("GET");
            ex.StatusCode.ShouldBe(500);
            ex.Message.ShouldBe("The GET call to https://localhost:5001/get failed with status code 500. Please check the inner exception for details.");
            ex.InnerException?.Message.ShouldBe("Internal Server Error");
        }

        [Fact]
        public void Request_ResponseOnly_NotFoundResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestGetEndpoint_Response(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(NotFoundResponse);
            };

            //  Act
            var act = () => _objectUnderTest.GetAsync(endpoint);

            //  Assert
            var ex = act.ShouldThrow<ApiCallException>();
            ex.Uri.ShouldBe("https://localhost:5001/get");
            ex.HttpMethod.ShouldBe("GET");
            ex.StatusCode.ShouldBe(404);
            ex.Message.ShouldBe("The GET call to https://localhost:5001/get failed with status code 404. Please check the inner exception for details.");
            ex.InnerException?.Message.ShouldBe("Not Found");
        }
    }
}
