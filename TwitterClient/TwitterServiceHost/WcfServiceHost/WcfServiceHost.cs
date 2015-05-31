using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TwitterClient.Webservice.Services;
using TwitterServiceHost;

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
                    while (Program.isRunning)
                    {
                    }
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
