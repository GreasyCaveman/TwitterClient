(function ($) {
    app = {
        init: function () {
            app.twitterHandler.init();
        }
    };
    $(document).ready(function () {
        app.init();
    });
})(jQuery);


(function (app, $) {
    app.twitterHandler = {
        getTweetsSuccess: function(data) {
            var $data = $(data),
            generatedHtml;
            var $twitterFeedContainer = $('#twitterFeedContainer');
            if ($data && $data.length > 0 && $twitterFeedContainer.length > 0) {
                $data.each(function () {
                    generatedHtml += '<div class="tweet"><img src="' + this.user.profile_image_url + '" /><span class="username">User Name: ' + this.user.name + '</span><span class="screenname">Screen Name ' + this.user.screen_name + '</span><span class="retweetcount"> RT Count: ' + this.retweet_count + '</span><p class="tweetcontent">' + this.text + '</p></div>';
                });
                $twitterFeedContainer.html(generatedHtml);
                $('#twitterFeedControlsContainer').show();
                $('#refreshing').hide();
            }
        },
        getTweetsFail: function() {
            var $twitterFeedContainer = $('#twitterFeedContainer');
            if ($twitterFeedContainer.length > 0) {
                $twitterFeedContainer.html('<div class="error"><span class="errormessage">Couldn\'t get tweets</span></div>');
            }
        },
        resetMatchedTweets: function() {
            var $twitterFeedContainer = $('#twitterFeedContainer');
            var $tweetsMatched = $twitterFeedContainer.find('.tweet.match');
            $tweetsMatched.each(function() { $(this).removeClass('match'); });
        },
        getTweets: function() {
            var $twitterFeedContainer = $('#twitterFeedContainer');
            var ajaxData = $twitterFeedContainer ? { 'count': $twitterFeedContainer.data('count'), 'screenname': $twitterFeedContainer.data('screenname') } : {}
            $.ajax({
                method: "GET",
                url: "http://localhost:8080/TwitterService/twitter/gettweets",
                success: this.getTweetsSuccess,
                fail: this.getTweetsFail,
                data: ajaxData,
                dataType: 'json'
            });
        },
        searchTweets: function () {
            this.resetMatchedTweets();
            var $twitterFeedContainer = $('#twitterFeedContainer'),
                searchInputVal = $('#searchbox') ? $('#searchbox').val().toLowerCase() : "";
            if ($twitterFeedContainer.length > 0 && searchInputVal !== "") {

                var $tweets = $($twitterFeedContainer.find('.tweet'));
                if ($tweets.length > 0) {
                    $tweets.each(function() {
                        var $tweet = $(this);
                        var searchableVal = $tweet.find(".tweetcontent").text().toLowerCase();
                        if (searchableVal.indexOf(searchInputVal) > -1) {
                            $tweet.addClass('match');
                        }
                    });
                }
            }
        },
        bindEvents: function () {
            $('#submitSearch').click(function () {
                app.twitterHandler.searchTweets();
            });
            this.StartTweetRefresh();
        },
        StartTweetRefresh: function() {
            setInterval(this.getTweets, 60000);
            $('#refreshing').show();
        },
        init: function () {
            this.getTweets();
            this.bindEvents();
        }
        

    }
})(app || {}, jQuery);