namespace Twitter.RestService.DataObjects
{
    //tweet object used for json response deserilization 
    public class Tweet
    {
        public User user { get; set; }
        public string text { get; set; }
        public int retweet_count { get; set; }
    }
}
