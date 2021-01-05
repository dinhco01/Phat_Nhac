using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic.Model.ZingMP3API
{
    public class Artist
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Album
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("isoffical")]
        public bool isoffical { get; set; }

        [JsonProperty("artists_names")]
        public string artists_names { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> artists { get; set; }

        [JsonProperty("thumbnail")]
        public string thumbnail { get; set; }

        [JsonProperty("thumbnail_medium")]
        public string thumbnail_medium { get; set; }
    }

    public class Song
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("content_owner")]
        public int content_owner { get; set; }

        [JsonProperty("isoffical")]
        public bool isoffical { get; set; }

        [JsonProperty("isWorldWide")]
        public bool isWorldWide { get; set; }

        [JsonProperty("playlist_id")]
        public string playlist_id { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> artists { get; set; }

        [JsonProperty("artists_names")]
        public string artists_names { get; set; }

        [JsonProperty("performer")]
        public string performer { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("lyric")]
        public string lyric { get; set; }

        [JsonProperty("thumbnail")]
        public string thumbnail { get; set; }

        [JsonProperty("duration")]
        public int duration { get; set; }

        [JsonProperty("total")]
        public int total { get; set; }

        [JsonProperty("rank_num")]
        public object rank_num { get; set; }

        [JsonProperty("rank_status")]
        public string rank_status { get; set; }

        [JsonProperty("artist")]
        public Artist artist { get; set; }

        [JsonProperty("position")]
        public int position { get; set; }

        [JsonProperty("order")]
        public object order { get; set; }

        [JsonProperty("album")]
        public Album album { get; set; }

        [JsonProperty("mv_link")]
        public string mv_link { get; set; }
    }

    public class Data
    {

        [JsonProperty("song")]
        public IList<Song> songs { get; set; }
    }

    public class DataZingChartFromZingMP3
    {

        [JsonProperty("err")]
        public int err { get; set; }

        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }
    }
}
