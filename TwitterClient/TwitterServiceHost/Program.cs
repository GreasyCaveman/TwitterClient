using System;
using System.Dynamic;
using System.Net.Mime;
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
            //set static isRunning bool for thread
            isRunning = true;
            //create thread so wcf service can be init and not affect UI
            Thread wcfServiceThread = new Thread(WcfServiceHost.Init);
            wcfServiceThread.Start();
            //Start App Ui
            TwitterClientPresentation.Init();
            
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            isRunning = false;
        }
        
    }
}
