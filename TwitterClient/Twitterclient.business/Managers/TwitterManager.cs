using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.RestService.DataObjects;
using TwitterRestService;

namespace TwitterClient.Managers
{
    public class TwitterManager
    {
        private TwitterRestService.TwitterRestServiceClient _TwitterService { get; set; }

        public TwitterRestService.TwitterRestServiceClient TwitterService
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
           return TwitterService.GetTweets(count,screenName);
        }
    }
}
