using AutoFixture;
using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.Api.Tests.Models;
using F3R4L.DevPack.Api.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Tests.Services
{
    [TestClass]
    public class ApiServiceTests
    {
        private ApiService _apiService;
        private Fixture _fixture;

        [TestInitialize]
        public void Initialise()
        {
            _apiService = new ApiService(new HttpClientGenerationFactory(),
                new JsonSerialisationWrapper());

            _fixture = new Fixture();
        }

        [TestMethod]
        public async Task BasicGetTest()
        {
            //  Arrange

            //  Act
            var result = await _apiService.GetAsync(
                new ApiEndpoint<ITypeBlank, object>("https://esi.evetech.net/latest/status/?datasource=tranquility"));

            //  Assert
            //var content = result.Content.ToString();
        }

        [TestMethod]
        public async Task BasicPostTest()
        {
            //  Arrange
            var postData = _fixture.Create<LogDataModel>();

            //  Act
            await _apiService.PostAsync(
                new ApiEndpoint<LogDataModel, ITypeBlank>("http://localhost:12958/api/notify"), postData);

            //  Assert
            //var content = result.Content.ToString();
        }
    }
}
