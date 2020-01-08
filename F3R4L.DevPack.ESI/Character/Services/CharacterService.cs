using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.ESI.Character.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.ESI.Character.Services
{
    public class CharacterService : ESIBaseService
    {
        public CharacterService(IApiService apiService)
            : base(apiService)
        {
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
        /// GET: /characters/{character_id}/agents_research/
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
        /// GET: /characters/{character_id}/blueprints/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>BlueprintCollection</returns>
        public async Task<BlueprintCollection> GetBlueprints(long characterId)
        {
            return new BlueprintCollection
            {
                OwnerId = characterId,
                BlueprintsOwned = await _apiService.GetAsync(
                    new BlueprintsEndpoint(characterId)
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

        public async Task<long> GetCSPACharge(long characterId, IEnumerable<long> recipientIds)
        {
            return await _apiService.PostAsync();
        }

        /// <summary>
        /// POST: /characters/affiliation/
        /// </summary>
        /// <param name="characterIds">IEnumerable<long></param>
        /// <returns>Affiliations</returns>
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
