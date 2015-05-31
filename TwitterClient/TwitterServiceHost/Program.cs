using System;
using System.Threading;
using TwitteClient.Host.WcfServiceHost;
using TwitterClient.Presentation;

namespace TwitterServiceHost
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Thread wcfServiceThread = new Thread(WcfServiceHost.Init);
            wcfServiceThread.Start();
            TwitterClientPresentation.Init();
            
           

        }
    }
}
