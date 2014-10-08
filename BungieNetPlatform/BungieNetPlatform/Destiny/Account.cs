using System.Runtime.Serialization;

namespace BungieNetPlatform.Destiny
{
    public class Account
    {
        [DataMember]
        public string MembershipId;

        [DataMember]
        public int MembershipType;
    }
}
