using System.Collections.Generic;
using System.Reflection;
using Stocks.Model.StockPrice;

namespace Stocks.Model.Reddit
{
    public class RedditDdDtoList : ListModelBase<RedditDdDto>
    {
        public List<RedditDdDtoAggregated> Aggregated { get; set; }
    }

    public class RedditDdDtoAggregated
    {
        public string Ticker { get; set; }
        public StockPricesForUi Prices { get; set; }
        public int OneWeekPosts { get; set; }
        public int TwoWeekPosts { get; set; }
        public int ThreeWeekPosts { get; set; }
        public int FourWeekPosts { get; set; }
    }

    public class RedditDdDto
    {
        public int Id { get; set; }
        public StockPricesForUi Prices { get; set; }
        public string Ticker { get; set; }  
        public List<string> PotentialTickers { get; set; }
        public string CreatedString { get; set; }
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public List<Link_Flair_Richtext> link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        public int pwls { get; set; }
        public string link_flair_css_class { get; set; }
        public int downs { get; set; }
        public int? thumbnail_height { get; set; }
        public bool hide_score { get; set; }
        public string name { get; set; }
        public bool quarantine { get; set; }
        public string link_flair_text_color { get; set; }
        public float upvote_ratio { get; set; }
        public string author_flair_background_color { get; set; }
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public int? thumbnail_width { get; set; }
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public bool author_premium { get; set; }
        public string thumbnail { get; set; }
        public bool is_self { get; set; }
        public string link_flair_type { get; set; }
        public int wls { get; set; }
        public string author_flair_type { get; set; }
        public string domain { get; set; }
        public bool allow_live_comments { get; set; }
        public string selftext_html { get; set; }
        public bool? likes { get; set; }
        public string suggested_sort { get; set; }
        public bool archived { get; set; }
        public bool no_follow { get; set; }
        public bool is_crosspostable { get; set; }
        public bool pinned { get; set; }
        public bool over_18 { get; set; }
        public bool media_only { get; set; }
        public string link_flair_template_id { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        public string author_flair_text { get; set; }
        public bool visited { get; set; }
        public string subreddit_id { get; set; }
        public string link_flair_background_color { get; set; }
        public string RedditId { get; set; }
        public bool is_robot_indexable { get; set; }
        public string author { get; set; }
        public int num_comments { get; set; }
        public bool send_replies { get; set; }
        public string whitelist_status { get; set; }
        public bool contest_mode { get; set; }
        public bool author_patreon_flair { get; set; }
        public string author_flair_text_color { get; set; }
        public string permalink { get; set; }
        public string parent_whitelist_status { get; set; }
        public bool stickied { get; set; }
        public string url { get; set; }
        public int subreddit_subscribers { get; set; }
        public float created_utc { get; set; }
        public int num_crossposts { get; set; }
        public bool is_video { get; set; }
        public string post_hint { get; set; }
    }
}
