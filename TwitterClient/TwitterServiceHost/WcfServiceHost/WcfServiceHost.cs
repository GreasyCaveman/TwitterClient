using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using TwitterClient.Webservice.Services;
using TwitterServiceHost;

//WCF service host. This code is for twitterservice self host used for ajax calls.
namespace TwitteClient.Host.WcfServiceHost
{
    public class WcfServiceHost
    {
        public static void Init()
        {

            var selfHost = new WebServiceHost(typeof (TwitterService));
            
                try
                {
                    //Host wcfService
                    selfHost.Open();
                    //trap thread while program is running
                    while (Program.isRunning)
                    {
                    }
                    //close service
                    selfHost.Close();
                }
                catch (CommunicationException ce)
                {
                    Console.WriteLine("An exception occurred: {0}", ce.Message);
                    selfHost.Abort();
                }
                       
        }
    }
}
