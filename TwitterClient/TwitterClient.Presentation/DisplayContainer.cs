using System;
using System.Windows.Forms;

//Windows form for TwitterClient UI. Note: Using Webkit.net for more functionality built in webbrowser control uses IE.
namespace TwitterClient.Presentation
{
    public partial class DisplayContainer : Form
    {
        public const string HtmlPageLocationProperty = "HtmlFileLocation";
        public DisplayContainer()
        {
            InitializeComponent();
            //set location of frontent HTML File Currently Relative from running app location
            TwitterClientBrowser.Url = new Uri(string.Format("file:{0}", AppDomain.CurrentDomain.BaseDirectory + @"Frontend\Html\TwitterClientUi.html"));
        }
    }
}
