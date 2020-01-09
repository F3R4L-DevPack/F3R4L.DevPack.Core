using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class ContactNotificationEndpoint
        : ESIBaseEndpoint<long, IEnumerable<ContactNotificationItem>>
    {
        private const string _endpointFormat = "/characters/{0}/notifications/contacts/";

        public ContactNotificationEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
