using System;
using System.Collections.Generic;
using System.ServiceModel.Web;
using Twitter.RestService.DataObjects;
using TwitterClient.Business.Managers;
//This is a self hosted wcf service used for ajax calls. This service interacts with the twitter client business logic which interacts with twitters rest service,
namespace TwitterClient.Webservice.Services
{
    public class TwitterService : ITwitterService
    {
        private const string _CountKey = "count";
        private const string _ScreenNameKey = "screenname";


        public List<Tweet> GetTweets()
        {
            //allows calls from any origin
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            //get count and screenname query string params
            var requestQueryStringParams = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters;
            var count = string.IsNullOrEmpty(requestQueryStringParams[_CountKey]) ? 10 : Convert.ToInt32(requestQueryStringParams[_CountKey]);
            var screenname = string.IsNullOrEmpty(requestQueryStringParams[_ScreenNameKey]) ? "salesforce" : requestQueryStringParams[_ScreenNameKey];
            //init business manager
            var manager = new TwitterManager();
            return  manager.GetTweets(count, screenname);
        }
    }
}
