(function ($) {
    app = {
        init: function () {
            app.TwitterHandler.init();
        }
    };
    $(document).ready(function () {
        app.init();
    });
})(jQuery);


(function (app, $) {
    app.TwitterHandler = {
       
        getTweetsSuccess: function (data) {
            var $data = $(data);
            var $twitterFeedContainer = $('#twitterFeedContainer');
            if ($data && $data.length > 0 && $twitterFeedContainer.length > 0) {
                $data.each(function() {
                    $twitterFeedContainer.append('<div class="tweet"><img src="' + this.user.profile_image_url + '" /><span class="username">' + this.user.name + '</span><span class="screenname">' + this.user.screen_name + '</span><span class="retweetcount">' + this.retweet_count + '</span><p class="tweetcontent">' + this.text + '</p></div>');
                });
            }
        },
        getTweetsFail: function () {
            var $twitterFeedContainer = $('#twitterFeedContainer');
            if ($twitterFeedContainer.length > 0) {
                $twitterFeedContainer.append('<div class="error"><span class="errormessage">Couldn\'t get tweets</span></div>');
            }
        },
        getTweets: function() {
            var $twitterFeedContainer = $('#twitterFeedContainer');
            var ajaxData = $twitterFeedContainer ? { 'count': $twitterFeedContainer.data('count'), 'screenname': $twitterFeedContainer.data('screenname') } : {}
            $.ajax({
                method: "GET",
                url: "http://localhost:8080/TwitterService/twitter/gettweets",
                success: this.getTweetsSuccess,
                fail: this.getTweetsFail,
                data: ajaxData
            });
        },
        searchTweets: function() {
            var $twitterFeedContainer = $('#twitterFeedContainer'),
            searchInputVal = $('#searchbox') ? $('#searchbox').val() : ""; 
            if ($twitterFeedContainer.length > 0 && searchInputVal !== "") {
                
                var $tweets = $($twitterFeedContainer.find('.tweet'));
                if ($tweets.length > 0) {
                    $tweets.each(function() {
                        var $tweet = $(this);
                        var searchableVal = $tweet.find(".tweetcontent").text();
                        if (searchableVal.substr(searchInputVal) > -1) {
                            $tweet.append('<span class="match"></span>');
                        }
                    });
                }
            }
        },
        init: function () {
            this.getTweets();
            $(window).on('click', '#submitSearch', function() { this.getTweets() });
        }
        

    }
})(app || {}, jQuery);