using WebKit;

namespace TwitterClient.Presentation.Frontend
{
    partial class DisplayContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TwitterClientBrowser = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // TwitterClientBrowser
            // 
            this.TwitterClientBrowser.AllowDownloads = false;
            this.TwitterClientBrowser.AllowNavigation = false;
            this.TwitterClientBrowser.AllowNewWindows = false;
            this.TwitterClientBrowser.BackColor = System.Drawing.Color.White;
            this.TwitterClientBrowser.IsWebBrowserContextMenuEnabled = false;
            this.TwitterClientBrowser.Location = new System.Drawing.Point(-1, 0);
            this.TwitterClientBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.TwitterClientBrowser.Name = "TwitterClientBrowser";
            this.TwitterClientBrowser.Size = new System.Drawing.Size(618, 538);
            this.TwitterClientBrowser.TabIndex = 0;
            this.TwitterClientBrowser.Url = null;
            // 
            // DisplayContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 537);
            this.Controls.Add(this.TwitterClientBrowser);
            this.Name = "DisplayContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayContainer";
            this.ResumeLayout(false);

        }

        #endregion

        private WebKitBrowser TwitterClientBrowser;

    }
}

