using PlayMusic.Model;
using PlayMusic.Properties;
using PlayMusic.UserControls.SongMusic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PlayMusic.ChildForm
{
    public partial class SongsMusic : Form
    {
        public Mp3Player mp3 { get; set; }

        public int SelectedMenu { get; set; } = 0;

        private List<string> _allSong = new List<string>();

        private List<string> _favotite = new List<string>();

        public MainForm main { get; set; }

        public SongsMusic()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            btn_AllSong.Text = rm.GetString("allSongs", culture);
            btn_Favorite.Text = rm.GetString("favorite", culture);
            btn_Artist.Text = rm.GetString("artist", culture);
            btn_Album.Text = rm.GetString("album", culture);
            lbl_NoContent.Text = rm.GetString("noSong", culture);
        }

        private void btn_PlayAllSongOrFavotite_Click(object sender, EventArgs e)
        {
            mp3.PlayListSong(_allSong, _favotite, SelectedMenu);
            main.RefeshControlBar();
            main.playingMusic.PlayingMusic_Load(sender, new EventArgs());
        }

        private void SongsMusic_Load(object sender, EventArgs e)
        {
            btn_AllSong_Click(sender, e);
        }

        private void btn_AllSong_Click(object sender, EventArgs e)
        {
            RestoreAllMenu();
            ChangeColorMenu(pic_AllSong, btn_AllSong, 1);
            LoadAllSong();
            SelectedMenu = 0;
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            RestoreAllMenu();
            ChangeColorMenu(pic_Favorite, btn_Favorite, 2);
            LoadFavoriteSong();
            SelectedMenu = 1;
        }

        private void btn_Artist_Click(object sender, EventArgs e)
        {
            RestoreAllMenu();
            ChangeColorMenu(pic_Artist, btn_Artist, 3);
            LoadArtist();
            SelectedMenu = 2;
        }

        private void btn_Album_Click(object sender, EventArgs e)
        {
            RestoreAllMenu();
            ChangeColorMenu(pic_Album, btn_Album, 4);
            LoadAlbum();
            SelectedMenu = 3;
        }

        public void LoadAllSong()
        {
            _allSong = mp3.LoadAllSong(@"D:\MediaApp");
            List<string> favorites = mp3.LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            List<UC_Song> ucSongs = new List<UC_Song>();
            foreach (var song in _allSong)
            {
                UC_Song ucSong = new UC_Song(main, new Model.Song(song))
                {
                    mp3 = mp3,
                    songsMusic = this,
                    MenuCurrent = 0
                };
                ucSong.IsFavorite = favorites.Contains(ucSong.song.UrlSource);
                ucSongs.Add(ucSong);
            }
            DisplaySong(ucSongs);
        }

        public void LoadFavoriteSong()
        {
            _favotite = mp3.LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            List<UC_Song> ucSongs = new List<UC_Song>();
            foreach (var favorite in _favotite)
            {
                UC_Song ucSong = new UC_Song(main, new Song(favorite))
                {
                    mp3 = mp3,
                    MenuCurrent = 1,
                    songsMusic = this,
                    IsFavorite = true
                };
                ucSongs.Add(ucSong);
            }
            DisplaySong(ucSongs);
        }

        public void DisplaySong(List<UC_Song> ucSongs)
        {
            if (panel_Content.Controls.Count > 0)
                panel_Content.Controls.Clear();
            if (ucSongs.Count == 0)
            {
                panel_NoResult.Visible = true;
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var item in ucSongs)
            {
                item.Size = new Size(panel_Content.Width - 40, item.Height);
                panel_Content.Controls.Add(item);
            }
        }

        public void LoadArtist()
        {
            List<Artist> data = mp3.LoadAllArtist(@"D:\MediaApp");

            List<UC_Artist> ucArists = new List<UC_Artist>();
            foreach (var item in data)
            {
                UC_Artist ucArtist = new UC_Artist(main, item)
                {
                    mp3 = mp3
                };
                ucArists.Add(ucArtist);
            }
            DisplayArtist(ucArists);
        }

        public void DisplayArtist(List<UC_Artist> ucArists)
        {
            if (panel_Content.Controls.Count > 0)
                panel_Content.Controls.Clear();
            if (ucArists.Count == 0)
            {
                panel_NoResult.Visible = true;
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var item in ucArists)
            {
                panel_Content.Controls.Add(item);
            }
        }

        public void LoadAlbum()
        {
            List<Album> data = mp3.LoadAllAlbum(@"D:\MediaApp");

            List<UC_Album> ucAlbums = new List<UC_Album>();
            foreach (var item in data)
            {
                UC_Album ucAlbum = new UC_Album(main, item)
                {
                    mp3 = mp3
                };

                ucAlbums.Add(ucAlbum);
            }
            DisplayAlbum(ucAlbums);
        }

        public void DisplayAlbum(List<UC_Album> ucAlbums)
        {
            if (panel_Content.Controls.Count > 0)
                panel_Content.Controls.Clear();
            if (ucAlbums.Count == 0)
            {
                panel_NoResult.Visible = true;
                return;
            }
            panel_NoResult.Visible = false;
            foreach (var item in ucAlbums)
            {
                panel_Content.Controls.Add(item);
            }
        }

        #region Đổi màu các button
        private void ChangeColorMenu(PictureBox picture, Button button, int i)
        {
            switch (i)
            {
                case 1:
                    picture.Image = Resources.music_blue1;
                    btn_PlayAllSongOrFavotite.Visible = true;
                    break;
                case 2:
                    picture.Image = Resources.heart_blue;
                    btn_PlayAllSongOrFavotite.Visible = true;
                    break;
                case 3:
                    picture.Image = Resources.artist_blue;
                    btn_PlayAllSongOrFavotite.Visible = false;
                    break;
                case 4:
                    picture.Image = Resources.album_blue;
                    btn_PlayAllSongOrFavotite.Visible = false;
                    break;
            }
            button.ForeColor = Color.FromArgb(0, 144, 255);
        }

        private void RestoreColorMenu(PictureBox picture, Button button, int i)
        {
            switch (i)
            {
                case 1:
                    picture.Image = Resources.music_gray;
                    break;
                case 2:
                    picture.Image = Resources.heart_gray;
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

        private void RestoreAllMenu()
        {
            RestoreColorMenu(pic_AllSong, btn_AllSong, 1);
            RestoreColorMenu(pic_Favorite, btn_Favorite, 2);
            RestoreColorMenu(pic_Artist, btn_Artist, 3);
            RestoreColorMenu(pic_Album, btn_Album, 4);
        }

        private void btn_PlayAllSongOrFavotite_MouseHover(object sender, EventArgs e)
        {
            btn_PlayAllSongOrFavotite.BackgroundImage = Resources.play_circled_blue;
        }

        private void btn_PlayAllSongOrFavotite_MouseLeave(object sender, EventArgs e)
        {
            btn_PlayAllSongOrFavotite.BackgroundImage = Resources.play_circled_gray;
        }
        #endregion
    }
}
