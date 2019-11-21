using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.ESI.Character.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.ESI.Character.Services
{
    public class CharacterService
    {
        private readonly IApiService _apiService;

        public CharacterService(IApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// /characters/{character_id}/
        /// </summary>
        /// <param name="id">Character Id</param>
        /// <returns>Models.Character</returns>
        public async Task<Models.Character> GetCharacterAsync (long id)
        {
            var result = await _apiService.GetAsync(
                new PublicInformationEndpoint<ITypeBlank, Models.Character>(id));
            result.Id = id;
            return result;
        }

        /// <summary>
        /// /characters/{character_id}/corporationhistory/
        /// </summary>
        /// <param name="id">Character Id</param>
        /// <returns>Models.CorporationHistory</returns>
        public async Task<CorporationHistory> GetCorporationHistoryAsync(long id)
        {
            return new CorporationHistory()
            {
                CharacterId = id,
                CorporationHistoryItems = await _apiService.GetAsync(
                    new CorporationHistoryEndpoint<ITypeBlank, IEnumerable<CorporationHistoryItem>>(id)
                    )
            };
        }
    }
}
