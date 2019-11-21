using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.Api.Wrappers;
using F3R4L.DevPack.ESI.Character.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using System.Linq;

namespace F3R4L.DevPack.ESI.Tests.Character
{
    [TestClass]
    public class CharacterServiceIntegrationTests
    {
        CharacterService _objectUnderTest;

        [TestInitialize]
        public void Initialise()
        {
            _objectUnderTest = new CharacterService(new ApiService(new HttpClientGenerationFactory(),
                new JsonSerialisationWrapper()));
        }

        [TestMethod]
        public async Task GetCharacter()
        {
            //  Arrange
            var characterId = (long)93902200;

            //  Act
            var result = await _objectUnderTest.GetCharacterAsync(characterId);

            //  Assert
            result.Name.Should().BeEquivalentTo("Clyde en Marland");
        }

        [TestMethod]
        public async Task GetCorporationHistory()
        {
            //  Arrange
            var characterId = (long)93902200;

            //  Act
            var result = await _objectUnderTest.GetCorporationHistoryAsync(characterId);

            //  Assert
            result.CorporationHistoryItems.ToList().Last()
                .CorporationId
                .Should().Be(1000168);
        }
    }
}
