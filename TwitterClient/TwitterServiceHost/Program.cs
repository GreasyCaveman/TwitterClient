using System;
using System.Threading;
using TwitteClient.Host.WcfServiceHost;
using TwitterClient.Presentation;

namespace TwitterServiceHost
{
    public static class Program
    {
        public static bool isRunning { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            isRunning = true;
            Thread wcfServiceThread = new Thread(WcfServiceHost.Init);
            wcfServiceThread.Start();
            TwitterClientPresentation.Init();
        }
    }
}
