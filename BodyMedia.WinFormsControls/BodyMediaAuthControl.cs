using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BodyMedia.CoreClient;
using System.Configuration;

namespace BodyMedia.WinFormsControls
{
    public partial class BodyMediaAuthControl : UserControl
    { 
        public BodyMediaAuthControl()
        {
            InitializeComponent();

            this.webBrowser1.Navigated += OnNavigated;
        }

        public OAuthManager Manager { get; private set; }
        public string Token { get; private set; }
        public string TokenSecret { get; private set; }
        public EventHandler OnAuthenticated = delegate { };

        public void Initialize()
        {
            string consumerKey = ConfigurationManager.AppSettings["consumer_key"];
            string consumerSecret = ConfigurationManager.AppSettings["consumer_secret"];

            if (string.IsNullOrEmpty(consumerKey))
                throw new ApplicationException("A body media consumer key needs to either be passed in to Initialize() directy or via an appSetting called \"consumer_key\".");
            if (string.IsNullOrEmpty(consumerSecret))
                throw new ApplicationException("A body media consumer secret needs to either be passed in to Initialize() directy or via an appSetting called \"consumer_secret\".");

            Initialize(consumerKey, consumerSecret);
        }
        public void Initialize(string consumerKey, string consumerSecret)
        {
            if (string.IsNullOrEmpty(consumerKey))
                throw new ArgumentNullException("consumerKey", "A body media consumer key needs to either be passed in to Initialize() directy or via an appSetting called \"consumer_key\".");
            if (string.IsNullOrEmpty(consumerSecret))
                throw new ArgumentNullException("consumerSecret", "A body media consumer secret needs to either be passed in to Initialize() directy or via an appSetting called \"consumer_secret\".");

            Manager = Manager ?? new OAuthManager();
            Manager["consumer_key"] = consumerKey;
            Manager["consumer_secret"] = consumerSecret;
            Manager["api_key"] = Manager["consumer_key"];

            var requestToken = Manager.AcquireRequestToken("https://api.bodymedia.com/oauth/request_token", "GET");
            string urlAuthorize = "https://api.bodymedia.com/oauth/authorize?oauth_token=" + Manager["token"] + "&api_key=" + Manager["api_key"];

            this.webBrowser1.Url = new Uri(urlAuthorize);
        }

        void OnNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Token) && !string.IsNullOrEmpty(TokenSecret))
                return;

            if (e.Url.ToString() != "https://api.bodymedia.com/oauth/doLogin")
                return;

            if(!string.IsNullOrEmpty(webBrowser1.DocumentText) && webBrowser1.DocumentText.Contains("You have successfully allowed"))
            {
                string pin = string.Empty;
                OAuthResponse accessToken = Manager.AcquireAccessToken("https://api.bodymedia.com/oauth/access_token", "POST", pin);

                Token = Manager["token"];
                TokenSecret = Manager["token_secret"];
                OnAuthenticated(this, EventArgs.Empty);
            }
        }
    }
}
