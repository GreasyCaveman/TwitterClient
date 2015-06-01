using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwitterRestService;

namespace TwitterClientUnitTests
{
    [TestClass]
    public class TwitterClientTests
    {
        [TestMethod]
        public void GetTweetsTest()
        {
             var client = new TwitterRestServiceClient();
             var tweets = client.GetTweets(10, "salesforce");
             Assert.IsTrue(tweets.Any(), "tweets.Any() = false");
             Assert.IsTrue(tweets.Count <= 10, "number of tweets exceeds 10");
        }

        [TestMethod]
        public void GetAuthToken()
        {
            var client = new TwitterRestServiceClient();
            var oAuthToken = client.GetOAuthAuthenticationString();
            Assert.IsTrue(!string.IsNullOrEmpty(oAuthToken), "oAuth token is null or empty");
        }

    }
}
