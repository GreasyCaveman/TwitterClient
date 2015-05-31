namespace Twitter.RestService.DataObjects
{
    public class Tweet
    {
        public User user { get; set; }
        public string text { get; set; }
        public int retweet_count { get; set; }
    }
}
