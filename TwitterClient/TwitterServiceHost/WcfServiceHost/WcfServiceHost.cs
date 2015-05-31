using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TwitterClient.Webservice.Services;

namespace TwitteClient.Host.WcfServiceHost
{
    public class WcfServiceHost
    {
        public static void Init()
        {

            var selfHost = new WebServiceHost(typeof (TwitterService));
            
                try
                {
                    // Step 2 Start the service.
                    selfHost.Open();
                }
                catch (CommunicationException ce)
                {
                    Console.WriteLine("An exception occurred: {0}", ce.Message);
                    selfHost.Abort();
                }
                       
        }
    }
}
