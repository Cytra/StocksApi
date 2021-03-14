using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Stocks.Data.Entities.Reddit
{
    public class RedditDdEntity : EntityBase
    {
        [StringLength(1032)]
        public string subreddit { get; set; }
        public string selftext { get; set; }
        [StringLength(1032)]
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        [StringLength(1032)]
        public string title { get; set; }
        public List<Link_Flair_Richtext> link_flair_richtext { get; set; }
        [StringLength(1032)]
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        [StringLength(1032)]
        public string link_flair_css_class { get; set; }
        public int downs { get; set; }
        public int? thumbnail_height { get; set; }
        public bool hide_score { get; set; }
        [StringLength(1032)]
        public string name { get; set; }
        public bool quarantine { get; set; }
        [StringLength(1032)]
        public string link_flair_text_color { get; set; }
        public float upvote_ratio { get; set; }
        [StringLength(1032)]
        public string author_flair_background_color { get; set; }
        [StringLength(1032)]
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public int? thumbnail_width { get; set; }
        [StringLength(1032)]
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        [StringLength(1032)]
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public bool author_premium { get; set; }
        [StringLength(1032)]
        public string thumbnail { get; set; }
        public bool is_self { get; set; }
        [StringLength(1032)]
        public string link_flair_type { get; set; }
        public int? wls { get; set; }
        [StringLength(1032)]
        public string author_flair_type { get; set; }
        [StringLength(1032)]
        public string domain { get; set; }
        public bool allow_live_comments { get; set; }
        public string selftext_html { get; set; }
        public bool? likes { get; set; }
        [StringLength(1032)]
        public string suggested_sort { get; set; }
        public bool archived { get; set; }
        public bool no_follow { get; set; }
        public bool is_crosspostable { get; set; }
        public bool pinned { get; set; }
        public bool over_18 { get; set; }
        public bool media_only { get; set; }
        [StringLength(1032)]
        public string link_flair_template_id { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        [StringLength(1032)]
        public string author_flair_text { get; set; }
        public bool visited { get; set; }
        [StringLength(1032)]
        public string subreddit_id { get; set; }
        public string link_flair_background_color { get; set; }
        [StringLength(1032)]
        public string RedditId { get; set; }
        public bool is_robot_indexable { get; set; }
        [StringLength(1032)]
        public string author { get; set; }
        public int num_comments { get; set; }
        public bool send_replies { get; set; }
        [StringLength(1032)]
        public string whitelist_status { get; set; }
        public bool contest_mode { get; set; }
        public bool author_patreon_flair { get; set; }
        [StringLength(1032)]
        public string author_flair_text_color { get; set; }
        public string permalink { get; set; }
        [StringLength(1032)]
        public string parent_whitelist_status { get; set; }
        public bool stickied { get; set; }
        [StringLength(1032)]
        public string url { get; set; }
        public int subreddit_subscribers { get; set; }
        public float created_utc { get; set; }
        public int num_crossposts { get; set; }
        public bool is_video { get; set; }
        [StringLength(1032)]
        public string post_hint { get; set; }
    }

    public class Link_Flair_Richtext
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int RedditDdEntityId { get; set; }
        [StringLength(1032)]
        public string e { get; set; }
        public string t { get; set; }
    }
}
