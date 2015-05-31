using System.Configuration;

namespace Twitter.RestService.TwitterRestServiceConfiguration
{
    class TwitterRestServiceConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("endpointurl")]
        public string EndpointUrl
        {
            get { return (string) this["endpointurl"]; }
        }

        [ConfigurationProperty("consumerkey")]
        public string ConsumerKey
        {
            get { return (string) this["consumerkey"]; }
        }

        [ConfigurationProperty("consumersecret")]
        public string ConsumerSecret
        {
            get { return (string)this["consumersecret"]; }
        }


        private static TwitterRestServiceConfiguration _instance;

        public static TwitterRestServiceConfiguration Configuration
        {
            get
            {
                return _instance ?? (_instance = ConfigurationManager.GetSection("twitterRestService") as TwitterRestServiceConfiguration);
            }
        }
    }
}
