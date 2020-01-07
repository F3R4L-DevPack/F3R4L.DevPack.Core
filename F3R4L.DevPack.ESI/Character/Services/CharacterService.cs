using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.ESI.Character.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// GET: /characters/{character_id}/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>Models.Character</returns>
        public async Task<Models.Character> GetCharacterAsync (long characterId)
        {
            var result = await _apiService.GetAsync(
                new PublicInformationEndpoint(characterId));
            result.Id = characterId;
            return result;
        }

        /// <summary>
        /// GET: /characters/{0}/agents_research/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>AgentResearch</returns>
        public async Task<AgentResearch> GetAgentResearch(long characterId)
        {
            return new AgentResearch
            {
                CharacterId = characterId,
                ResearchItems = await _apiService.GetAsync(
                    new AgentResearchEndpoint(characterId)
                    )
            };
        }

        /// <summary>
        /// GET: /characters/{character_id}/corporationhistory/
        /// </summary>
        /// <param name="id">Character Id</param>
        /// <returns>Models.CorporationHistory</returns>
        public async Task<CorporationHistory> GetCorporationHistoryAsync(long characterId)
        {
            return new CorporationHistory
            {
                CharacterId = characterId,
                CorporationHistoryItems = await _apiService.GetAsync(
                    new CorporationHistoryEndpoint(characterId)
                    )
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        public async Task<Affiliations> GetAffiliationsAsync(IEnumerable<long> characterIds)
        {
            return new Affiliations
            {
                CharacterAffiliations = await _apiService.PostAsync(new AffiliationEndpoint(),
                    characterIds)
            };
        }
    }
}
