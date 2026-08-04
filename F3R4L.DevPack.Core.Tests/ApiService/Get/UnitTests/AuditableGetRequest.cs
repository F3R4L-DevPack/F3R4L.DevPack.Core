using F3R4L.DevPack.Api.Exceptions;
using F3R4L.DevPack.Api.Models;
using F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests.Models;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Tests.ApiService.Get.UnitTests
{
    public class AuditableGetRequest : BaseClass
    {
        [Fact]
        public async Task Request_ResponseOnly_OkResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestAuditableGetEndpoints(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(OkResponse);
            };

            //  Act
            var response = await _objectUnderTest.GetAsync(endpoint);

            //  Assert
            response.GetType().ShouldBe(typeof(ResponseOnlyAuditContainer<MockServerResponse>));
            response.Url.ShouldBe("https://localhost:5001/get");
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Response.Json.ShouldBe("{\"message\":\"Success\"}");
            response.Response.Object.Message.ShouldBe("Success");
            response.ResponseMessage.ShouldBeNull();
            response.ErrorMessage.ShouldBeNull();
        }

        [Fact]
        public async Task Request_ResponseOnly_InternalServerErrorResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestAuditableGetEndpoints(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(InternalServerErrorResponse);
            };

            //  Act
            var response = await _objectUnderTest.GetAsync(endpoint);

            //  Assert
            response.GetType().ShouldBe(typeof(ResponseOnlyAuditContainer<MockServerResponse>));
            response.Url.ShouldBe("https://localhost:5001/get");
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.InternalServerError);
            response.Response.ShouldBeNull();
            response.ResponseMessage.ShouldBe("InternalServerError");
            response.ErrorMessage.ShouldNotBeNull();
        }

        [Fact]
        public async Task Request_ResponseOnly_NotFoundResult_ReturnsExpected()
        {
            //  Arrange
            var endpoint = new TestAuditableGetEndpoints(_baseUrl, "/get");
            _messageHandler.SendAsyncFunction = (request, cancellationToken) =>
            {
                return Task.FromResult(NotFoundResponse);
            };

            //  Act
            var response = await _objectUnderTest.GetAsync(endpoint);

            //  Assert
            response.GetType().ShouldBe(typeof(ResponseOnlyAuditContainer<MockServerResponse>));
            response.Url.ShouldBe("https://localhost:5001/get");
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NotFound);
            response.Response.ShouldBeNull();
            response.ResponseMessage.ShouldBe("PageNotFound");
            response.ErrorMessage.ShouldNotBeNull();
        }
    }
}
