using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic.Model.ZingMP3API
{
    public class ZSong
    {

        [JsonProperty("hasVideo")]
        public string hasVideo { get; set; }

        [JsonProperty("thumb")]
        public string thumb { get; set; }

        [JsonProperty("artist")]
        public string artist { get; set; }

        [JsonProperty("streamingStatus")]
        public string streamingStatus { get; set; }

        [JsonProperty("thumbVideo")]
        public string thumbVideo { get; set; }

        [JsonProperty("genreIds")]
        public string genreIds { get; set; }

        [JsonProperty("disable_platform_web")]
        public string disable_platform_web { get; set; }

        [JsonProperty("artistIds")]
        public string artistIds { get; set; }

        [JsonProperty("disSPlatform")]
        public string disSPlatform { get; set; }

        [JsonProperty("duration")]
        public string duration { get; set; }

        [JsonProperty("radioPid")]
        public string radioPid { get; set; }

        [JsonProperty("zing_choice")]
        public string zing_choice { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("block")]
        public string block { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("disDPlatform")]
        public string disDPlatform { get; set; }
    }

    public class Datum
    {

        [JsonProperty("song")]
        public IList<ZSong> songs { get; set; }
    }

    public class SearchResult
    {

        [JsonProperty("result")]
        public bool result { get; set; }

        [JsonProperty("data")]
        public IList<Datum> data { get; set; }
    }


}
