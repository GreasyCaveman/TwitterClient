using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using RestSharp;
using Twitter.RestService.DataObjects;
using Twitter.RestService.Response;
using Twitter.RestService.Security;

namespace TwitterRestService
{

    //the service that interacts with the rest api.
    public class TwitterRestServiceClient
    {
        //get the bearer auth token for app auth (restricted get calls)
        public string GetOAuthAuthenticationString()
        {
            var client = new RestClient("https://api.twitter.com");
            //decrypt encrypted consumer key and secret
            var enkey = StringEncryptorDecryptor.Decrypt("aIg+gvSYRmymViw8VEES75BWPN5Nm13MKMXi5VJZIfM=");
            var ensecret = StringEncryptorDecryptor.Decrypt("KNz7lXiS3kEaGLrqRkzSxHtoH8ZzzMa0AScHSFSskhqMTFdOupZif+jTj/ke+RabU4qy80bygdHobKuRPQhPYQ==");
            //encode key and secret as per twitter best practices
            var customerInfo = Convert.ToBase64String(new UTF8Encoding()
                              .GetBytes(enkey + ":" + ensecret));
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
            //get authentication token for request
            var accesstoken = GetOAuthAuthenticationString();
            var request = new RestRequest("/statuses/user_timeline", Method.GET);
            request.AddHeader("Authorization", "bearer " + accesstoken);
            request.AddQueryParameter("screen_name", screenName);
            request.AddQueryParameter("count", count.ToString());
            //get tweets
            var response = client.Execute<List<Tweet>>(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                
            }
            var result = response != null && response.Data != null ? response.Data : new List<Tweet>();

            return result;
        }
    }
}
