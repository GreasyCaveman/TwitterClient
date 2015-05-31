using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;
using TwitterWebservice.DataObjects;

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
        Tweet GetTweets();
    }
}
