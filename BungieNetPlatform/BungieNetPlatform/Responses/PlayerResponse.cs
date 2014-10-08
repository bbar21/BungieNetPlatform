using System.Collections.Generic;
using BungieNetPlatform.Destiny;
using Extensions;
using Newtonsoft.Json.Linq;

namespace BungieNetPlatform.Responses
{
    public class PlayerResponse : Response {

        public ICollection<Player> DestinyPlayers;

        public PlayerResponse(JObject j) : base(j)
        {
            DestinyPlayers = new List<Player>();

            if (j["Response"] != null)
            {
                j["Response"].ForEach(u => DestinyPlayers.Add(
                    new Player
                    {
                        IconPath = u["iconPath"].Value<string>(),
                        MembershipType = u["membershipType"].Value<int>(),
                        MembershipId = u["membershipId"].Value<string>(),
                        DisplayName = u["displayName"].Value<string>()
                        
                    }));
            }
        }
    }
}