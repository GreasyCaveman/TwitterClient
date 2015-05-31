namespace TwitterWebservice.DataObjects
{
    public class Tweet
    {
        public string UserName { get; set;}
        public string UserScreenName { get; set; }
        public string UserProfileImage { get; set; }
        public string TweetContent { get; set; }
        public int NumberOfTimesRetweeted { get; set; }
    }
}
