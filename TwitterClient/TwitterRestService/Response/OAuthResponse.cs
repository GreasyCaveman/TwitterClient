using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Twitter.RestService.Response
{
    //"{\"token_type\":\"bearer\",\"access_token\":\"AAAAAAAAAAAAAAAAAAAAAPHPfwAAAAAA7Ch7xVGYVYlscip1CXxFBkfWd6c%3DkbJbjyw7Riq3JAqb3S7T6xi9iPtIfEkcUd0EPpNxXgzfv5mMHw\"}"
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
