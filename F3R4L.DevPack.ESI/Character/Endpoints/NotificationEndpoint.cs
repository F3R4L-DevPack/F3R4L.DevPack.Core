using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class NotificationEndpoint
        : ESIBaseEndpoint<long, IEnumerable<NotificationItem>>
    {
        private const string _endpointFormat = "/characters/{0}/notifications/?datasource=tranquility";

        public NotificationEndpoint() 
            : base(_endpointFormat)
        {
        }
    }
}
