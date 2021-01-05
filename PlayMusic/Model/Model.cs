using Mp3Lib;
using Newtonsoft.Json;
using PlayMusic.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NReco;
using System.Diagnostics;

namespace PlayMusic.Model
{
    public class Song
    {
        public string NameSong { get; set; }

        public string Artist { get; set; }

        public Image Image { get; set; }

        public string Album { get; set; }

        public string Comment { get; set; }

        public string Composer { get; set; }

        public string Disc { get; set; }

        public string Genre { get; set; }

        public TimeSpan? Length { get; set; }

        public string Track { get; set; }

        public string Year { get; set; }

        public string UrlSource { get; set; }

        public Song(string nameSong, string artist, Image image)
        {
            NameSong = nameSong;
            Artist = artist;
            Image = image;
        }

        public Song(string url)
        {
            try
            {
                Mp3File song = new Mp3File(url);
                NameSong = song.TagHandler.Title;
                Artist = song.TagHandler.Artist;
                Image = song.TagHandler.Picture != null ? song.TagHandler.Picture : Resources.song_default;
                Album = song.TagHandler.Album;
                Comment = song.TagHandler.Comment;
                Disc = song.TagHandler.Disc;
                Genre = song.TagHandler.Genre;
                Length = song.TagHandler.Length;
                Track = song.TagHandler.Track;
                Year = song.TagHandler.Year;
                UrlSource = url;
            }
            catch { }
        }
    }

    public class Artist
    {
        public string ArtistName { get; set; }

        public Image ImgArtist { get; set; }

        public List<string> Songs { get; set; } = new List<string>();
    }

    public class Album
    {
        public string AlbumName { get; set; }

        public string Artist { get; set; }

        public Image ImgAlbum { get; set; }

        public List<string> Songs { get; set; } = new List<string>();
    }

    public class Playlist
    {
        [JsonProperty("namePlaylist")]
        public string NamePlaylist { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("lastModify")]
        public DateTime? LastModify { get; set; }

        [JsonProperty("songs")]
        public List<string> Songs { get; set; }
    }

    public class DataPlaylist
    {
        [JsonProperty("playlists")]
        public IList<Playlist> Playlists { get; set; } = new List<Playlist>();
    }

    public class Recent
    {
        [JsonProperty("recentSongs")]
        public IList<string> Songs { get; set; } = new List<string>();

        [JsonProperty("recentPlaylists")]
        public IList<Playlist> Playlists { get; set; } = new List<Playlist>();
    }

    public class Video
    {
        public string URLSource { get; set; }

        public string VideoName { get; set; }

        public TimeSpan Duration { get; set; }

        public Image Thumbnail { get; set; }

        public Video(string url)
        {
            VideoName = Path.GetFileName(url);
            var ffProbe = new NReco.VideoInfo.FFProbe();

            var videoInfo = ffProbe.GetMediaInfo(url);
            Duration = videoInfo.Duration;
            URLSource = url;
        }
    }
}
