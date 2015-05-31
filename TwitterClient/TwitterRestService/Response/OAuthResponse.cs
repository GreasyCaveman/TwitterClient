using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Twitter.RestService.Response
{
    public interface IOAuthResponse
    {
        string token_type { get; set; }
        string access_token { get; set; }
    }
    
    public class OAuthResponse : RestResponse, IOAuthResponse
    {
        public string token_type { get; set; }

        public string access_token { get; set; }

        public OAuthResponse()
        {
            token_type = string.Empty;
            access_token = string.Empty;
        }
    }
}
