using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.Reddit
{
    public class RedditDdResponse
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string after { get; set; }
        public int dist { get; set; }
        public Facets facets { get; set; }
        public string modhash { get; set; }
        public Child[] children { get; set; }
    }

    public class Facets
    {
    }

    public class Child
    {
        public string kind { get; set; }
        public ChildData data { get; set; }
    }

    public class ChildData
    {
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public Link_Flair_Richtext[] link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
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
        public Media_Embed media_embed { get; set; }
        public int? thumbnail_width { get; set; }
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public Secure_Media secure_media { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public Secure_Media_Embed secure_media_embed { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public bool author_premium { get; set; }
        public string thumbnail { get; set; }
        public Author_Flair_Richtext[] author_flair_richtext { get; set; }
        public Gildings gildings { get; set; }
        public bool is_self { get; set; }
        public string link_flair_type { get; set; }
        public int? wls { get; set; }
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
        public All_Awardings[] all_awardings { get; set; }
        public bool media_only { get; set; }
        public string link_flair_template_id { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        public string author_flair_text { get; set; }
        public string[] treatment_tags { get; set; }
        public bool visited { get; set; }
        public string subreddit_id { get; set; }
        public string link_flair_background_color { get; set; }
        public string id { get; set; }
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
        public Media media { get; set; }
        public bool is_video { get; set; }
        public Media_Metadata media_metadata { get; set; }
        public string post_hint { get; set; }
        public Preview preview { get; set; }
    }

    public class Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public int height { get; set; }
    }

    public class Secure_Media
    {
        public string type { get; set; }
        public Oembed oembed { get; set; }
    }

    public class Oembed
    {
        public string provider_url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string html { get; set; }
        public string version { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public int thumbnail_height { get; set; }
    }

    public class Secure_Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public string media_domain_url { get; set; }
        public int height { get; set; }
    }

    public class Gildings
    {
        public int gid_1 { get; set; }
        public int gid_2 { get; set; }
        public int gid_3 { get; set; }
    }

    public class Media
    {
        public string type { get; set; }
        public Oembed1 oembed { get; set; }
    }

    public class Oembed1
    {
        public string provider_url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string html { get; set; }
        public string version { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public int thumbnail_height { get; set; }
    }

    public class Media_Metadata
    {
        public K5c2gmio6ej61 k5c2gmio6ej61 { get; set; }
        public Xvtnb39w6ej61 xvtnb39w6ej61 { get; set; }
        public Zp2yb1r57ej61 zp2yb1r57ej61 { get; set; }
        public Soxtt7dm7ej61 soxtt7dm7ej61 { get; set; }
        public _1Xlj4jhdcji61 _1xlj4jhdcji61 { get; set; }
        public Zyzechcy31m61 zyzechcy31m61 { get; set; }
        public Qvqwl2rw31m61 qvqwl2rw31m61 { get; set; }
        public Bfuqksue31m61 bfuqksue31m61 { get; set; }
        public D05jq0jx31m61 d05jq0jx31m61 { get; set; }
        public T91qm4t84mi61 t91qm4t84mi61 { get; set; }
        public Sjruwxd65mi61 sjruwxd65mi61 { get; set; }
        public Y6j90g954mi61 y6j90g954mi61 { get; set; }
        public Pk37q11tkmi61 pk37q11tkmi61 { get; set; }
        public Pir687z35mi61 pir687z35mi61 { get; set; }
        public _2Gvzf4m15mi61 _2gvzf4m15mi61 { get; set; }
        public Ykkeebqflmi61 ykkeebqflmi61 { get; set; }
        public _67Afe6635mi61 _67afe6635mi61 { get; set; }
        public M5p95miq4mi61 m5p95miq4mi61 { get; set; }
        public Xmsp3tc63mi61 xmsp3tc63mi61 { get; set; }
        public _4013Shwy4mi61 _4013shwy4mi61 { get; set; }
        public _5Last6ye4mi61 _5last6ye4mi61 { get; set; }
        public Nj8vhxqdvsl61 nj8vhxqdvsl61 { get; set; }
        public _7Fysfdxlusl61 _7fysfdxlusl61 { get; set; }
        public _41Y0pjcjigl61 _41y0pjcjigl61 { get; set; }
        public Py2reovn5gl61 py2reovn5gl61 { get; set; }
        public I9rysmhp5gl61 i9rysmhp5gl61 { get; set; }
        public Rqayg5oo5gl61 rqayg5oo5gl61 { get; set; }
        public _3Djwn1de2tj61 _3djwn1de2tj61 { get; set; }
        public Y22hod9b2tj61 y22hod9b2tj61 { get; set; }
        public _7Hp3ktgc2tj61 _7hp3ktgc2tj61 { get; set; }
        public Lmtsuxki0uj61 lmtsuxki0uj61 { get; set; }
        public D3vuakyd2tj61 d3vuakyd2tj61 { get; set; }
        public Osl59mnb2tj61 osl59mnb2tj61 { get; set; }
        public W8qgdhc52tj61 w8qgdhc52tj61 { get; set; }
        public Ha1vws1c2tj61 ha1vws1c2tj61 { get; set; }
        public S30997zukvl61 s30997zukvl61 { get; set; }
        public _40Z53odskvl61 _40z53odskvl61 { get; set; }
        public _9Aaem6vxkvl61 _9aaem6vxkvl61 { get; set; }
        public Gwdaxycymxj61 gwdaxycymxj61 { get; set; }
        public Ijpbroximxj61 ijpbroximxj61 { get; set; }
        public Msw9tittmxj61 msw9tittmxj61 { get; set; }
        public Uu51ljdpsyj61 uu51ljdpsyj61 { get; set; }
        public Xya25adl12k61 xya25adl12k61 { get; set; }
        public _2Lpie1wm12k61 _2lpie1wm12k61 { get; set; }
        public _3Jkeam6o12k61 _3jkeam6o12k61 { get; set; }
        public Jvvu6wat12k61 jvvu6wat12k61 { get; set; }
        public Roplc5ly12k61 roplc5ly12k61 { get; set; }
        public Xw8lu1l122k61 xw8lu1l122k61 { get; set; }
        public _449Mbia022k61 _449mbia022k61 { get; set; }
    }

    public class K5c2gmio6ej61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P[] p { get; set; }
        public S s { get; set; }
        public string id { get; set; }
    }

    public class S
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Xvtnb39w6ej61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P1[] p { get; set; }
        public S1 s { get; set; }
        public string id { get; set; }
    }

    public class S1
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P1
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Zp2yb1r57ej61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P2[] p { get; set; }
        public S2 s { get; set; }
        public string id { get; set; }
    }

    public class S2
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P2
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Soxtt7dm7ej61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P3[] p { get; set; }
        public S3 s { get; set; }
        public string id { get; set; }
    }

    public class S3
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P3
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _1Xlj4jhdcji61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P4[] p { get; set; }
        public S4 s { get; set; }
        public string id { get; set; }
    }

    public class S4
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P4
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Zyzechcy31m61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P5[] p { get; set; }
        public S5 s { get; set; }
        public string id { get; set; }
    }

    public class S5
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P5
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Qvqwl2rw31m61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P6[] p { get; set; }
        public S6 s { get; set; }
        public string id { get; set; }
    }

    public class S6
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P6
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Bfuqksue31m61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P7[] p { get; set; }
        public S7 s { get; set; }
        public string id { get; set; }
    }

    public class S7
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P7
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class D05jq0jx31m61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P8[] p { get; set; }
        public S8 s { get; set; }
        public string id { get; set; }
    }

    public class S8
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P8
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class T91qm4t84mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P9[] p { get; set; }
        public S9 s { get; set; }
        public string id { get; set; }
    }

    public class S9
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P9
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Sjruwxd65mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P10[] p { get; set; }
        public S10 s { get; set; }
        public string id { get; set; }
    }

    public class S10
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P10
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Y6j90g954mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P11[] p { get; set; }
        public S11 s { get; set; }
        public string id { get; set; }
    }

    public class S11
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P11
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Pk37q11tkmi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P12[] p { get; set; }
        public S12 s { get; set; }
        public string id { get; set; }
    }

    public class S12
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P12
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Pir687z35mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P13[] p { get; set; }
        public S13 s { get; set; }
        public string id { get; set; }
    }

    public class S13
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P13
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _2Gvzf4m15mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P14[] p { get; set; }
        public S14 s { get; set; }
        public string id { get; set; }
    }

    public class S14
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P14
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Ykkeebqflmi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P15[] p { get; set; }
        public S15 s { get; set; }
        public string id { get; set; }
    }

    public class S15
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P15
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _67Afe6635mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P16[] p { get; set; }
        public S16 s { get; set; }
        public string id { get; set; }
    }

    public class S16
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P16
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class M5p95miq4mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P17[] p { get; set; }
        public S17 s { get; set; }
        public string id { get; set; }
    }

    public class S17
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P17
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Xmsp3tc63mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P18[] p { get; set; }
        public S18 s { get; set; }
        public string id { get; set; }
    }

    public class S18
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P18
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _4013Shwy4mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P19[] p { get; set; }
        public S19 s { get; set; }
        public string id { get; set; }
    }

    public class S19
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P19
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _5Last6ye4mi61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P20[] p { get; set; }
        public S20 s { get; set; }
        public string id { get; set; }
    }

    public class S20
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P20
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Nj8vhxqdvsl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P21[] p { get; set; }
        public S21 s { get; set; }
        public string id { get; set; }
    }

    public class S21
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P21
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _7Fysfdxlusl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P22[] p { get; set; }
        public S22 s { get; set; }
        public string id { get; set; }
    }

    public class S22
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P22
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _41Y0pjcjigl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P23[] p { get; set; }
        public S23 s { get; set; }
        public string id { get; set; }
    }

    public class S23
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P23
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Py2reovn5gl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P24[] p { get; set; }
        public S24 s { get; set; }
        public string id { get; set; }
    }

    public class S24
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P24
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class I9rysmhp5gl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P25[] p { get; set; }
        public S25 s { get; set; }
        public string id { get; set; }
    }

    public class S25
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P25
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Rqayg5oo5gl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P26[] p { get; set; }
        public S26 s { get; set; }
        public string id { get; set; }
    }

    public class S26
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P26
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _3Djwn1de2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P27[] p { get; set; }
        public S27 s { get; set; }
        public string id { get; set; }
    }

    public class S27
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P27
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Y22hod9b2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P28[] p { get; set; }
        public S28 s { get; set; }
        public string id { get; set; }
    }

    public class S28
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P28
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _7Hp3ktgc2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P29[] p { get; set; }
        public S29 s { get; set; }
        public string id { get; set; }
    }

    public class S29
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P29
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Lmtsuxki0uj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P30[] p { get; set; }
        public S30 s { get; set; }
        public string id { get; set; }
    }

    public class S30
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P30
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class D3vuakyd2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P31[] p { get; set; }
        public S31 s { get; set; }
        public string id { get; set; }
    }

    public class S31
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P31
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Osl59mnb2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P32[] p { get; set; }
        public S32 s { get; set; }
        public string id { get; set; }
    }

    public class S32
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P32
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class W8qgdhc52tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P33[] p { get; set; }
        public S33 s { get; set; }
        public string id { get; set; }
    }

    public class S33
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P33
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Ha1vws1c2tj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P34[] p { get; set; }
        public S34 s { get; set; }
        public string id { get; set; }
    }

    public class S34
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P34
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class S30997zukvl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P35[] p { get; set; }
        public S35 s { get; set; }
        public string id { get; set; }
    }

    public class S35
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P35
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _40Z53odskvl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P36[] p { get; set; }
        public S36 s { get; set; }
        public string id { get; set; }
    }

    public class S36
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P36
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _9Aaem6vxkvl61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P37[] p { get; set; }
        public S37 s { get; set; }
        public string id { get; set; }
    }

    public class S37
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P37
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Gwdaxycymxj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P38[] p { get; set; }
        public S38 s { get; set; }
        public string id { get; set; }
    }

    public class S38
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P38
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Ijpbroximxj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P39[] p { get; set; }
        public S39 s { get; set; }
        public string id { get; set; }
    }

    public class S39
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P39
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Msw9tittmxj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P40[] p { get; set; }
        public S40 s { get; set; }
        public string id { get; set; }
    }

    public class S40
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P40
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Uu51ljdpsyj61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P41[] p { get; set; }
        public S41 s { get; set; }
        public string id { get; set; }
    }

    public class S41
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P41
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Xya25adl12k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P42[] p { get; set; }
        public S42 s { get; set; }
        public string id { get; set; }
    }

    public class S42
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P42
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _2Lpie1wm12k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P43[] p { get; set; }
        public S43 s { get; set; }
        public string id { get; set; }
    }

    public class S43
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P43
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _3Jkeam6o12k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P44[] p { get; set; }
        public S44 s { get; set; }
        public string id { get; set; }
    }

    public class S44
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P44
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Jvvu6wat12k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P45[] p { get; set; }
        public S45 s { get; set; }
        public string id { get; set; }
    }

    public class S45
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P45
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Roplc5ly12k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P46[] p { get; set; }
        public S46 s { get; set; }
        public string id { get; set; }
    }

    public class S46
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P46
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Xw8lu1l122k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P47[] p { get; set; }
        public S47 s { get; set; }
        public string id { get; set; }
    }

    public class S47
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P47
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _449Mbia022k61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P48[] p { get; set; }
        public S48 s { get; set; }
        public string id { get; set; }
    }

    public class S48
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P48
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Preview
    {
        public Image[] images { get; set; }
        public bool enabled { get; set; }
    }

    public class Image
    {
        public Source source { get; set; }
        public Resolution[] resolutions { get; set; }
        public Variants variants { get; set; }
        public string id { get; set; }
    }

    public class Source
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Variants
    {
    }

    public class Resolution
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Link_Flair_Richtext
    {
        public string e { get; set; }
        public string t { get; set; }
    }

    public class Author_Flair_Richtext
    {
        public string e { get; set; }
        public string t { get; set; }
    }

    public class All_Awardings
    {
        public int? giver_coin_reward { get; set; }
        public string subreddit_id { get; set; }
        public bool is_new { get; set; }
        public int days_of_drip_extension { get; set; }
        public int coin_price { get; set; }
        public string id { get; set; }
        public int? penny_donate { get; set; }
        public string award_sub_type { get; set; }
        public int coin_reward { get; set; }
        public string icon_url { get; set; }
        public int days_of_premium { get; set; }
        public Tiers_By_Required_Awardings tiers_by_required_awardings { get; set; }
        public Resized_Icons7[] resized_icons { get; set; }
        public int icon_width { get; set; }
        public int static_icon_width { get; set; }
        public int? start_date { get; set; }
        public bool is_enabled { get; set; }
        public int? awardings_required_to_grant_benefits { get; set; }
        public string description { get; set; }
        public int subreddit_coin_reward { get; set; }
        public int count { get; set; }
        public int static_icon_height { get; set; }
        public string name { get; set; }
        public Resized_Static_Icons7[] resized_static_icons { get; set; }
        public string icon_format { get; set; }
        public int icon_height { get; set; }
        public int? penny_price { get; set; }
        public string award_type { get; set; }
        public string static_icon_url { get; set; }
    }

    public class Tiers_By_Required_Awardings
    {
        public _0 _0 { get; set; }
        public _9 _9 { get; set; }
        public _3 _3 { get; set; }
        public _6 _6 { get; set; }
        public _25 _25 { get; set; }
        public _10 _10 { get; set; }
        public _5 _5 { get; set; }
    }

    public class _0
    {
        public Resized_Icons[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon static_icon { get; set; }
        public Resized_Static_Icons[] resized_static_icons { get; set; }
        public Icon icon { get; set; }
    }

    public class Static_Icon
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _9
    {
        public Resized_Icons1[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon1 static_icon { get; set; }
        public Resized_Static_Icons1[] resized_static_icons { get; set; }
        public Icon1 icon { get; set; }
    }

    public class Static_Icon1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon1
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _3
    {
        public Resized_Icons2[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon2 static_icon { get; set; }
        public Resized_Static_Icons2[] resized_static_icons { get; set; }
        public Icon2 icon { get; set; }
    }

    public class Static_Icon2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon2
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _6
    {
        public Resized_Icons3[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon3 static_icon { get; set; }
        public Resized_Static_Icons3[] resized_static_icons { get; set; }
        public Icon3 icon { get; set; }
    }

    public class Static_Icon3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon3
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _25
    {
        public Resized_Icons4[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon4 static_icon { get; set; }
        public Resized_Static_Icons4[] resized_static_icons { get; set; }
        public Icon4 icon { get; set; }
    }

    public class Static_Icon4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon4
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _10
    {
        public Resized_Icons5[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon5 static_icon { get; set; }
        public Resized_Static_Icons5[] resized_static_icons { get; set; }
        public Icon5 icon { get; set; }
    }

    public class Static_Icon5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon5
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _5
    {
        public Resized_Icons6[] resized_icons { get; set; }
        public int awardings_required { get; set; }
        public Static_Icon6 static_icon { get; set; }
        public Resized_Static_Icons6[] resized_static_icons { get; set; }
        public Icon6 icon { get; set; }
    }

    public class Static_Icon6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Icon6
    {
        public string url { get; set; }
        public int width { get; set; }
        public string format { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Icons7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
