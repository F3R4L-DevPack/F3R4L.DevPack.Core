﻿using F3R4L.DevPack.Api.Endpoints;
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
                new PublicInformationEndpoint(), characterId);
            result.Id = characterId;
            return result;
        }

        /// <summary>
        /// GET: /characters/{character_id}/agents_research/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>AgentResearch</returns>
        public async Task<AgentResearch> GetAgentResearchAsync(long characterId)
        {
            return new AgentResearch
            {
                CharacterId = characterId,
                ResearchItems = await _apiService.GetAsync(
                    new AgentResearchEndpoint(), characterId
                    )
            };
        }

        /// <summary>
        /// GET: /characters/{character_id}/blueprints/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>BlueprintCollection</returns>
        public async Task<BlueprintCollection> GetBlueprintsAsync(long characterId)
        {
            return new BlueprintCollection
            {
                OwnerId = characterId,
                BlueprintsOwned = await _apiService.GetAsync(
                    new BlueprintsEndpoint(), characterId
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
                    new CorporationHistoryEndpoint(), characterId
                    )
            };
        }

        /// <summary>
        /// POST: /characters/{character_id}/cspa/
        /// </summary>
        /// <param name="characterId">Character Ids</param>
        /// <param name="recipientIds">Ids of all the characters to be included in the calculation</param>
        /// <returns>long</returns>
        public async Task<long> GetCSPAChargeAsync(long characterId, IEnumerable<long> recipientIds)
        {
            return await _apiService.PostAsync(new CspaChargeEndpoint(), characterId, recipientIds);
        }

        /// <summary>
        /// GET: /characters/{character_Id}/fatigue/
        /// </summary>
        /// <param name="characterId">Character Ids</param>
        /// <returns>JumpInformation</returns>
        public async Task<JumpInformation> GetJumpInformationAsync(long characterId)
        {
            var result = await _apiService.GetAsync(new JumpFatigueEndpoint(), characterId);
            result.CharacterId = characterId;
            return result;
        }

        /// <summary>
        /// GET: /characters/{character_id}/medals/
        /// </summary>
        /// <param name="characterId"Character Id</param>
        /// <returns>MedalCollection</returns>
        public async Task<MedalCollection> GetMedalsAsync(long characterId)
        {
            return new MedalCollection
            {
                CharacterId = characterId,
                Medals = await _apiService.GetAsync(new MedalsEndpoint(), characterId)
            };
        }

        /// <summary>
        /// GET: /characters/{character_Id}/notifications/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>NotificationCollection</returns>
        public async Task<NotificationCollection> GetNotificationsAsync(long characterId)
        {
            return new NotificationCollection
            {
                CharacterId = characterId,
                Notifications = await _apiService.GetAsync(new NotificationEndpoint(), characterId)
            };
        }

        /// <summary>
        /// GET: /characters/{character_id}/notifications/contacts/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>ContactNotificationCollection</returns>
        public async Task<ContactNotificationCollection> GetContactListNotificationsAsync(long characterId)
        {
            return new ContactNotificationCollection
            {
                CharacterId = characterId,
                Notifications = await _apiService.GetAsync(new ContactNotificationEndpoint(), characterId)
            };
        }

        /// <summary>
        /// GET: /characters/{character_id}/portrait/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>PortraitInformation</returns>
        public async Task<PortraitInformation> GetPortraitAsync(long characterId)
        {
            var result = await _apiService.GetAsync(new PortraitEndpoint(), characterId);
            result.CharacterId = characterId;

            return result;
        }

        /// <summary>
        /// GET: /characters/{character_id}/roles/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>CorporationRolesCollection</returns>
        public async Task<CorporationRolesCollection> GetCorporationRolesAsync(long characterId)
        {
            var result = await _apiService.GetAsync(new CorporationRolesEndpoint(), characterId);
            result.CharacterId = characterId;

            return result;
        }

        /// <summary>
        /// GET: /characters/{character_id}/standings/
        /// </summary>
        /// <param name="characterId">Character Id</param>
        /// <returns>StandingCollection</returns>
        public async Task<StandingCollection> GetStandingsAsync(long characterId)
        {
            return new StandingCollection
            {
                CharacterId = characterId,
                Standings = await _apiService.GetAsync(new StandingsEndpoint(), characterId)
            };
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
