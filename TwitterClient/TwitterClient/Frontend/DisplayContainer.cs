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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
