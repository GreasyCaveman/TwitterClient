using System;
using System.Collections.Generic;
using System.ServiceModel.Web;
using System.Web;
using Twitter.RestService.DataObjects;
using TwitterClient.Managers;

namespace TwitterClient.Webservice.Services
{
    public class TwitterService : ITwitterService
    {
        private readonly string CountKey = "count";
        private readonly string ScreenNameKey = "screenname";

        public List<Tweet> GetTweets()
        {
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            var requestQueryStringParams = System.ServiceModel.Web.WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters;
            var count = string.IsNullOrEmpty(requestQueryStringParams[CountKey]) ? 10 : Convert.ToInt32(requestQueryStringParams[CountKey]);
            var screenname = string.IsNullOrEmpty(requestQueryStringParams[ScreenNameKey]) ? "salesforce" : requestQueryStringParams[ScreenNameKey];
            var manager = new TwitterManager();
            return  manager.GetTweets(count, screenname);
        }
    }
}
