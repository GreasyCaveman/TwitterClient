using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;
using Twitter.RestService.DataObjects;

namespace TwitterClient.Webservice.Services
{
    [ServiceContract]
    public interface ITwitterService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "twitter/gettweets")]
        [Description("get tweets from twitter Rest service")]
        List<Tweet> GetTweets();
    }
}
