using TwitterClient.Managers;
using TwitterWebservice.DataObjects;

namespace TwitterClient.Webservice.Services
{
    public class TwitterService : ITwitterService
    {
        public Tweet GetTweets()
        {
            var manager = new TwitterManager();
            manager.GetTweets();
            return new Tweet();
        }
    }
}
