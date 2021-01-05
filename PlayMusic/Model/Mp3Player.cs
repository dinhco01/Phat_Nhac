using Newtonsoft.Json;
using PlayMusic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WMPLib;

namespace PlayMusic
{
    public class Mp3Player
    {
        public WindowsMediaPlayer player { get; set; } = new WindowsMediaPlayer();

        //static string rootDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PlayMusic\\data");
        //static string MusicDataPath = rootDataFolder + "";

        public bool IsPlay { get; set; } = false;

        public bool Shuffle { get; set; } = false;

        public int Repeat { get; set; } = 0;

        public bool IsMute { get; set; } = false;

        public int CurrentVolume { get; set; } = 50;

        public int PlayVideoStep { get; set; } = 5;

        public void AddSongToRecent(Song song)
        {
            if (Program.dataRecent.Songs.Contains(song.UrlSource))
            {
                Program.dataRecent.Songs.Remove(song.UrlSource);
            }
            Program.dataRecent.Songs.Insert(0, song.UrlSource);
            SaveDataRecent(Program.dataRecent);
        }

        public void AddPlaylistToRecent(Playlist playlist)
        {
            var data = Program.dataRecent.Playlists.FirstOrDefault(x => x.NamePlaylist == playlist.NamePlaylist);
            if (data != null)
            {
                Program.dataRecent.Playlists.Remove(data);
            }
            Program.dataRecent.Playlists.Insert(0, playlist);
            SaveDataRecent(Program.dataRecent);
        }

        /// <summary>
        /// Tải dữ liệu bài hát và playlist gần đây
        /// </summary>
        /// <param name="fileName">Đường dẫn file</param>
        /// <returns></returns>
        public Recent LoadDataRecent(string fileName)
        {
            fileName = @"data\recent.json";
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                return new Recent();
            }

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            var reader = new StreamReader(stream);
            var recentText = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            if (String.IsNullOrEmpty(recentText))
            {
                return new Recent();
            }

            var recent = JsonConvert.DeserializeObject<Recent>(recentText);
            return recent;
        }
        /// <summary>
        /// Lưu dữ liệu phát gần đây vào file json
        /// </summary>
        /// <param name="recent"></param>
        public void SaveDataRecent(Recent recent)
        {
            string fileName = @"data\recent.json";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);

                //var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //Environment.SpecialFolder.ApplicationData;
            }
            string textRecent = JsonConvert.SerializeObject(recent);
            TextWriter write = new StreamWriter(fileName, false);
            write.Write(textRecent);
            write.Close();
        }

        /// <summary>
        /// Phát một danh sách các bài hát
        /// </summary>
        /// <param name="songs"></param>
        public void PlayListSong(List<string> songs)
        {
            if (player.playState == WMPPlayState.wmppsPlaying || player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.stop();
            }
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist("Play");
            IWMPMedia media;
            foreach (var song in songs)
            {
                media = player.newMedia(song);
                playlist.appendItem(media);
            }
            player.currentPlaylist = playlist;
            player.controls.play();
            IsPlay = true;
        }

        /// <summary>
        /// Phát danh sách phát tùy chọn
        /// </summary>
        /// <param name="songs"></param>
        public void PlayListSong(List<string> songs0, List<string> songs1, int i)
        {
            if (player.playState == WMPPlayState.wmppsPlaying || player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.stop();
            }
            player.settings.setMode("shuffle", false);
            Shuffle = false;
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist("Play");
            IWMPMedia media;
            foreach (var song in i == 0 ? songs0 : songs1)
            {
                media = player.newMedia(song);
                playlist.appendItem(media);
            }
            player.currentPlaylist = playlist;
            player.controls.play();
            IsPlay = true;
        }

        /// <summary>
        /// Load danh sách các bài hát có trong thư mục
        /// </summary>
        /// <param name="folderName">Đường dẫn tới thư mục</param>
        /// <returns></returns>
        public List<string> LoadAllSong(string folderName)
        {
            List<string> songs = new List<string>();
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
                return new List<string>();
            }
            foreach (var fileName in Directory.GetFiles(folderName))
            {
                var array = fileName.Split(new char[] { '.' });
                if(array.Last() == "mp3")
                {
                    songs.Add(fileName);
                }    
            }
            return songs;
        }

        /// <summary>
        /// Phát một bài hát
        /// </summary>
        /// <param name="fileName">Đường dẫn bài hát cần phát</param>
        public void PlaySong(string fileName)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.stop();
            }
            player.URL = fileName;
            player.controls.play();
            IsPlay = true;
        }
        

        /// <summary>
        /// Danh sách bài hát yêu thích lưu vào file text
        /// Load danh sách tất cả các bài hát được yêu thích
        /// </summary>
        /// <param name="fileName">Đường dẫn file đã lưu</param>
        /// <returns></returns>
        public List<string> LoadAllFavoriteSong(string fileName)
        {
            fileName = @"data\FavoriteSongs.txt";
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }                

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            var reader = new StreamReader(stream);
            var dataText = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            var songStrings = dataText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> favoriteSongs = new List<string>();
            TextWriter write = new StreamWriter(fileName, false);
            foreach (var item in songStrings)
            {
                if(File.Exists(item))
                {
                    favoriteSongs.Add(item);
                    write.WriteLine(item);
                }    
            }
            write.Close();
            return favoriteSongs;
        }

        /// <summary>
        /// Thêm bài hát vào mục yêu thích
        /// </summary>
        /// <param name="fileName">Đường dẫn file cần lưu</param>
        /// <param name="songURL">Đường dẫn của bài hát cần thêm</param>
        public void AddFavoriteSong(string fileName, string songURL)
        {
            if (!Directory.Exists("data")) 
            {
                Directory.CreateDirectory("data");
            }

            if (!File.Exists(fileName))
            {
                using (File.Create(fileName)) { };
                TextWriter write = new StreamWriter(fileName, true);
                write.WriteLine(songURL);
                write.Close();
                return;
            }
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var reader = new StreamReader(stream);
            var dataText = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            
            var songStrings = dataText.Split(new char[] {'\n','\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (songStrings.Contains(songURL) || !File.Exists(songURL))   
                return;
            songStrings.Add(songURL);
            TextWriter writeAll = new StreamWriter(fileName, false);
            foreach (var item in songStrings)
            {
                writeAll.WriteLine(item);
            }
            writeAll.Close();
        }

        /// <summary>
        /// Xóa bài hát khỏi mục yêu thích
        /// </summary>
        /// <param name="fileName">Đường dẫn file cần lưu</param>
        /// <param name="songURL">Đường dẫn của bài hát cần xóa</param>
        public void RemoveFavotiteSong(string fileName, string songURL)
        {
            if(!File.Exists(fileName))
            {
                return;
            }

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var reader = new StreamReader(stream);
            var dataText = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            var songStrings = dataText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (songStrings.Contains(songURL))
            {
                songStrings.Remove(songURL);
            }
            TextWriter writeAll = new StreamWriter(fileName, false);
            foreach (var item in songStrings)
            {
                writeAll.WriteLine(item);
            }
            writeAll.Close();
        }

        /// <summary>
        /// Load danh sách các nghệ sĩ và bài hát
        /// </summary>
        /// <param name="folderName">Đường dẫn thư mục</param>
        /// <returns></returns>
        public List<Artist> LoadAllArtist(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                return new List<Artist>();
            }

            Artist artist;
            List<Artist> artists = new List<Artist>();
            foreach(var fileName in Directory.GetFiles(folderName))
            {
                var array = fileName.Split(new char[] { '.' });
                if (array.Last() == "mp3")
                {
                    Song song = new Song(fileName);
                    string artistConvert = ConvertToUnSign(song.Artist);
                    if (song.Artist.Contains(",") || song.Artist.Contains("-") || song.Artist.Contains("_") || song.Artist.Contains(";"))
                    {
                        var noArtist = artists.Where(x => x.ArtistName == "Không xác định").FirstOrDefault();
                        if (noArtist != null)
                        {
                            noArtist.Songs.Add(fileName);
                        }
                        else
                        {
                            artist = new Artist();
                            artist.ArtistName = "Không xác định";
                            artist.ImgArtist = song.Image;
                            artist.Songs.Add(fileName);
                            artists.Add(artist);
                        }
                        continue;
                    }
                    var artistData = artists.Where(x => x.ArtistName == artistConvert).FirstOrDefault();
                    if (artistData != null)
                    {
                        artistData.Songs.Add(fileName);
                        continue;
                    }    
                    artist = new Artist();
                    artist.ArtistName = artistConvert;
                    artist.ImgArtist = song.Image;
                    artist.Songs.Add(fileName);
                    artists.Add(artist);
                }
            }
            return artists.OrderBy(x => x.ArtistName).ToList();
        }

        /// <summary>
        /// Load danh sách các Album
        /// </summary>
        /// <param name="folderName">Đường dẫn thư mục</param>
        /// <returns></returns>
        public List<Album> LoadAllAlbum(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                return new List<Album>();
            }

            Album album;
            List<Album> albums = new List<Album>();
            foreach (var fileName in Directory.GetFiles(folderName))
            {
                var array = fileName.Split(new char[] { '.' });
                if (array.Last() == "mp3")
                {
                    Song song = new Song(fileName);
                    if (String.IsNullOrEmpty(song.Album))
                    {
                        var noArtist = albums.Where(x => x.AlbumName == "Không xác định").FirstOrDefault();
                        if (noArtist != null)
                        {
                            noArtist.Songs.Add(fileName);
                        }
                        else
                        {
                            album = new Album();
                            album.AlbumName = "Không xác định";
                            album.Artist = song.Artist;
                            album.ImgAlbum = song.Image;
                            album.Songs.Add(fileName);
                            albums.Add(album);
                        }
                        continue;
                    }
                    var artistData = albums.Where(x => x.AlbumName == song.Album).FirstOrDefault();
                    if (artistData != null)
                    {
                        artistData.Songs.Add(fileName);
                        continue;
                    }
                    album = new Album();
                    album.AlbumName = song.Album;
                    album.Artist = song.Artist;
                    album.ImgAlbum = song.Image;
                    album.Songs.Add(fileName);
                    albums.Add(album);
                }
            }
            return albums.OrderBy(x => x.AlbumName).ToList();
        }

        /// <summary>
        /// Lưu playlist dưới dạng json
        /// </summary>
        /// <param name="dataPlaylist">Dữ liệu playlist cần lưu</param>
        public void SaveDataPlaylist(DataPlaylist dataPlaylist)
        {
            string fileName = @"data\playlist.json";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            //var data = new DataPlaylist();
            //int i = 0;
            //foreach (var playlist in dataPlaylist.Playlists)
            //{
            //    data.Playlists.Add(playlist);
            //    data.Playlists[i].NamePlaylist = playlist.NamePlaylist;
            //    data.Playlists[i].CreateDate = playlist.CreateDate;
            //    data.Playlists[i].LastModify = playlist.LastModify;
            //    foreach (var song in playlist.Songs)
            //    {
            //        if (File.Exists(song))
            //        {
            //            data.Playlists[i].Songs.Add(song);
            //        }
            //    }
            //    i++;
            //}
            string textPlaylist = JsonConvert.SerializeObject(dataPlaylist);
            TextWriter write = new StreamWriter(fileName, false);
            write.Write(textPlaylist);
            write.Close();
        }

        /// <summary>
        /// Load dữ liệu playlist từ file
        /// </summary>
        /// <param name="fileName">Đường dẫn đến file</param>
        /// <returns></returns>
        public DataPlaylist LoadDataPlaylist(string fileName)
        {
            fileName = @"data\playlist.json";
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }    
            if(!File.Exists(fileName))
            {
                File.Create(fileName);
                return new DataPlaylist();
            }

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            var reader = new StreamReader(stream);
            var playlistText = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            
            if(String.IsNullOrEmpty(playlistText))
            {
                return new DataPlaylist();
            }    

            var playlists = JsonConvert.DeserializeObject<DataPlaylist>(playlistText);

            return playlists;
        }
        /// <summary>
        /// Đổi chuỗi thành tiếng Việt không dấu
        /// </summary>
        /// <param name="input">Chuỗi cần đổi</param>
        /// <returns></returns>
        public string ConvertToUnSign(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
    }
}
