using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.RestService.DataObjects
{
    //user object used for json response deserilization
    public class User
    {
        public string name { get; set; }
        public string screen_name { get; set; }        
        public string profile_image_url { get; set; }
    }
}
