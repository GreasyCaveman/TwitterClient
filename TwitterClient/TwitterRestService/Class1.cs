using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Twitter.RestService.TwitterRestServiceConfiguration;
using TweetSharp;
using Twitter.RestService.DataObjects;
using Twitter.RestService.Response;

namespace TwitterRestService
{
    public class Class1
    {

        public string GetOAuthAuthenticationString()
        {
            var client = new RestClient("https://api.twitter.com");
            var customerInfo = Convert.ToBase64String(new UTF8Encoding()
                              .GetBytes("cYMYEFjVgIJFEHxrC12klFqi7" + ":" + "9lodYZAZqFD630VyvAzWoSMDVgmEbiXR9SOi1IHqiqJ4EhhsyC"));
            var request = new RestRequest("/oauth2/token", Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddHeader("Authorization", "Basic " + customerInfo);
            var response = client.Execute<OAuthResponse>(request);
            var result = response != null && response.Data != null ? response.Data : new OAuthResponse();
            return result.access_token;
        }

        public List<Tweet> GetTweets(int count, string screenName)
        {
            var client = new RestClient("https://api.twitter.com/1.1");
            var accesstoken = GetOAuthAuthenticationString();
            var request = new RestRequest("/statuses/user_timeline", Method.GET);
            request.AddHeader("Authorization", "bearer " + accesstoken);
            request.AddQueryParameter("screen_name", screenName);
            request.AddQueryParameter("count", count);
            var response = client.Execute<List<Tweet>>(request);
            var result = response != null && response.Data != null ? response.Data : new List<Tweet>();

            return result;
        }
    }
}
