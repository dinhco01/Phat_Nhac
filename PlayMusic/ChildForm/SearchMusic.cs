using PlayMusic.Model;
using PlayMusic.Properties;
using PlayMusic.UserControls.Playlist;
using PlayMusic.UserControls.SongMusic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class SearchMusic : Form
    {
        public Mp3Player mp3 { get; set; }

        private OptionSearch optionSearch = OptionSearch.Song;

        public PlaylistMusic playlistMusic { get; set; }

        public SearchMusic()
        {
            InitializeComponent();
            LoadLanguage();
            panel_NoResult.Visible = true;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_TitleSearch.Text = rm.GetString("search", culture);
            lbl_NoResult.Text = Program.rm.GetString("enterKeywordsToSearch", Program.culture);
            txb_Key.Text = rm.GetString("enterKeywords", culture);
            btn_Song.Text = rm.GetString("songs", culture);
            btn_Playlist.Text = rm.GetString("playlist", culture);
            btn_Artist.Text = rm.GetString("artist", culture);
            btn_Album.Text = rm.GetString("album", culture);
        }

        public SearchMusic(PlaylistMusic playingMusic)
        {
            InitializeComponent();
            panel_NoResult.Visible = true;
            this.playlistMusic = playingMusic;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_Key.Text))
            {
                panel_ContainResult.Controls.Clear();
                panel_NoResult.Visible = true;
                lbl_NoResult.Text = Program.rm.GetString("noSongsFound", Program.culture);
                return;
            }
            switch (optionSearch)
            {
                case OptionSearch.Song:
                    DisplaySong(SearchSong(txb_Key.Text));
                    break;
                case OptionSearch.Playlist:
                    DisplayPlaylist(SearchPlaylist(txb_Key.Text));
                    break;
                case OptionSearch.Artist:
                    DisplayArtist(SearchArtist(txb_Key.Text));
                    break;
                case OptionSearch.Album:
                    DisplayAlbum(SearchAlbum(txb_Key.Text));
                    break;
            }
        }

        private List<Song> SearchSong(string key)
        {
            key = ConvertToUnSign(key);
            key = key.ToLower();
            if (string.IsNullOrEmpty(key))
            {
                return new List<Song>();
            }
            List<Song> songs = new List<Song>();
            var data = mp3.LoadAllSong(@"D:\MediaApp");
            foreach (var item in data)
            {
                songs.Add(new Song(item));
            }
            return songs.Where(x => ConvertToUnSign(x.NameSong).ToLower().Contains(key)).ToList();
        }

        private void DisplaySong(List<Song> songs)
        {
            if (panel_ContainResult.Controls.Count > 0)
            {
                panel_ContainResult.Controls.Clear();
            }
            if (songs == null || songs.Count == 0)
            {
                panel_NoResult.Visible = true;
                lbl_NoResult.Text = Program.rm.GetString("noSongsFound", Program.culture);
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var song in songs)
            {
                var ucSong = new UC_Song(playlistMusic.main, song)
                {
                    mp3 = mp3
                };
                ucSong.Size = new Size(panel_ContainResult.Width, ucSong.Height);
                panel_ContainResult.Controls.Add(ucSong);
            }
        }

        private List<Playlist> SearchPlaylist(string key)
        {
            key = ConvertToUnSign(key);
            key = key.ToLower();
            if (string.IsNullOrEmpty(key))
            {
                return new List<Playlist>();
            }
            return Program.dataPlaylist.Playlists.Where(x => ConvertToUnSign(x.NamePlaylist).ToLower().Contains(key)).ToList();
        }

        private void DisplayPlaylist(List<Playlist> playlists)
        {
            if (panel_ContainResult.Controls.Count > 0)
            {
                panel_ContainResult.Controls.Clear();
            }
            if (playlists == null || playlists.Count == 0)
            {
                panel_NoResult.Visible = true;
                lbl_NoResult.Text = Program.rm.GetString("noPlaylistsFound", Program.culture);
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var playlist in playlists)
            {
                var ucSong = new Playlist_Item(playlist, playlistMusic);
                ucSong.Size = new Size(panel_ContainResult.Width, ucSong.Height);
                panel_ContainResult.Controls.Add(ucSong);
            }
        }

        private List<Artist> SearchArtist(string key)
        {
            key = ConvertToUnSign(key);
            key = key.ToLower();
            if (string.IsNullOrEmpty(key))
            {
                return new List<Artist>();
            }
            var data = mp3.LoadAllArtist(@"D:\MediaApp");
            return data.Where(x => ConvertToUnSign(x.ArtistName).ToLower().Contains(key)).ToList();
        }

        private void DisplayArtist(List<Artist> artists)
        {
            if (panel_ContainResult.Controls.Count > 0)
            {
                panel_ContainResult.Controls.Clear();
            }
            if (artists == null || artists.Count == 0)
            {
                panel_NoResult.Visible = true;
                lbl_NoResult.Text = Program.rm.GetString("noArtistsFound", Program.culture);
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var artist in artists)
            {
                panel_ContainResult.Controls.Add(new UC_Artist(playlistMusic.main, artist)
                {
                    mp3 = mp3
                });
            }
        }

        private List<Album> SearchAlbum(string key)
        {
            key = ConvertToUnSign(key);
            key = key.ToLower();
            if (string.IsNullOrEmpty(key))
            {
                return new List<Album>();
            }
            var data = mp3.LoadAllAlbum(@"D:\MediaApp");
            return data.Where(x => ConvertToUnSign(x.AlbumName).ToLower().Contains(key) || ConvertToUnSign(x.Artist).ToLower().Contains(key)).ToList();
        }

        private void DisplayAlbum(List<Album> albums)
        {
            if (panel_ContainResult.Controls.Count > 0)
            {
                panel_ContainResult.Controls.Clear();
            }
            if (albums == null || albums.Count == 0)
            {
                panel_NoResult.Visible = true;
                lbl_NoResult.Text = Program.rm.GetString("noAlbumsFound", Program.culture);
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var album in albums)
            {
                panel_ContainResult.Controls.Add(new UC_Album(playlistMusic.main, album)
                {
                    mp3 = mp3
                });
            }
        }

        public static string ConvertToUnSign(string input)
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

        private void txb_Key_Click(object sender, EventArgs e)
        {
            txb_Key.SelectAll();
        }

        private void txb_Key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(this, new EventArgs());
            }
        }

        #region Đổi màu button
        private void btn_Song_Click(object sender, EventArgs e)
        {
            RestoreAllMenuSearch();
            ChangeColorMenuSearch(pic_Song, btn_Song, 1);
            btn_Search_Click(sender, e);
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            RestoreAllMenuSearch();
            ChangeColorMenuSearch(pic_Playlist, btn_Playlist, 2);
            btn_Search_Click(sender, e);
        }

        private void btn_Artist_Click(object sender, EventArgs e)
        {
            RestoreAllMenuSearch();
            ChangeColorMenuSearch(pic_Artist, btn_Artist, 3);
            btn_Search_Click(sender, e);
        }

        private void btn_Album_Click(object sender, EventArgs e)
        {
            RestoreAllMenuSearch();
            ChangeColorMenuSearch(pic_Album, btn_Album, 4);
            btn_Search_Click(sender, e);
        }

        private void ChangeColorMenuSearch(PictureBox picture, Button button, int i)
        {
            switch (i)
            {
                case 1:
                    picture.Image = Resources.music_blue1;
                    optionSearch = OptionSearch.Song;
                    break;
                case 2:
                    picture.Image = Resources.playlist_blue1;
                    optionSearch = OptionSearch.Playlist;
                    break;
                case 3:
                    picture.Image = Resources.artist_blue;
                    optionSearch = OptionSearch.Artist;
                    break;
                case 4:
                    picture.Image = Resources.album_blue;
                    optionSearch = OptionSearch.Album;
                    break;
            }
            button.ForeColor = Color.FromArgb(0, 144, 255);
        }

        private void RestoreColorMenuSearch(PictureBox picture, Button button, int i)
        {
            switch (i)
            {
                case 1:
                    picture.Image = Resources.music_gray;
                    break;
                case 2:
                    picture.Image = Resources.playlist_gray;
                    break;
                case 3:
                    picture.Image = Resources.artist_gray;
                    break;
                case 4:
                    picture.Image = Resources.album_gray;
                    break;
            }
            button.ForeColor = Color.FromArgb(169, 169, 169);
        }

        private void RestoreAllMenuSearch()
        {
            RestoreColorMenuSearch(pic_Song, btn_Song, 1);
            RestoreColorMenuSearch(pic_Playlist, btn_Playlist, 2);
            RestoreColorMenuSearch(pic_Artist, btn_Artist, 3);
            RestoreColorMenuSearch(pic_Album, btn_Album, 4);
        }
        #endregion
    }
    public enum OptionSearch
    {
        Song, Playlist, Artist, Album
    }
}
