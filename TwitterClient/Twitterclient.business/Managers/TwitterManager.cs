using System.Collections.Generic;
using Twitter.RestService.DataObjects;
using TwitterRestService;

namespace TwitterClient.Business.Managers
{
    public class TwitterManager
    {
        //singleton instance of twitter rest service client
        private TwitterRestServiceClient _TwitterService { get; set; }
        public TwitterRestServiceClient TwitterService
        {
            get { return _TwitterService ?? new TwitterRestServiceClient(); }
            private set { _TwitterService = value; }
        }

        public TwitterManager()
        {
            TwitterService = new TwitterRestServiceClient();
        }

        public List<Tweet> GetTweets(int count, string screenName)
        {
           //get list of tweets from twitter rest service
           return TwitterService.GetTweets(count,screenName);
        }
    }
}
