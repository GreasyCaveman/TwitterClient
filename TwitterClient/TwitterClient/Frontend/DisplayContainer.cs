using System;
using System.Windows.Forms;

namespace TwitterClient.Presentation.Frontend
{
    public partial class DisplayContainer : Form
    {
        public const string HtmlPageLocationProperty = "HtmlFileLocation";
        public DisplayContainer()
        {
            InitializeComponent();
            TwitterClientBrowser.Url = new Uri(string.Format("file:{0}", (string)Properties.Settings.Default[HtmlPageLocationProperty]));
        }
    }
}
