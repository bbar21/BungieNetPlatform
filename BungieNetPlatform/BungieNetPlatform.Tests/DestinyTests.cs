using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BungieNetPlatform.Destiny;
using BungieNetPlatform.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BungieNetPlatform.Tests
{
    [TestClass]
    public class DestinyTests
    {
        private static IPlatform platform;
        
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            platform = new Platform();
        }

        [TestMethod]
        public void GetDestinyPlayer()
        {
            Task<PlayerResponse> response = platform.SearchDestinyPlayer(2, "GameCompanion");
            var message = response.Result.Message;
            ICollection<Player> players = response.Result.DestinyPlayers.ToList();
            Assert.IsTrue(players.Count > 0);
        }
    }
}
