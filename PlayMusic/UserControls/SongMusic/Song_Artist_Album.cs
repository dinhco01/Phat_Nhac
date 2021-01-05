using PlayMusic.Model;
using PlayMusic.Properties;
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

namespace PlayMusic.UserControls.SongMusic
{
    public partial class Song_Artist_Album : Form
    {
        private Artist artist;

        private Album album;

        public Mp3Player mp3 { get; set; }

        private bool _isArtist = true;

        public MainForm main { get; set; }

        public Song_Artist_Album()
        {
            InitializeComponent();
        }

        public Song_Artist_Album(MainForm main,Artist artist, Album album, bool isArtist)
        {
            InitializeComponent();
            LoadLanguage();
            this.main = main;
            this.artist = artist;
            this.album = album;
            _isArtist = isArtist;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("listSongs", culture);
            lbl_TitleSongNumber.Text = rm.GetString("numberSongs", culture);
            lbl_TitleSong.Text = rm.GetString("songs", culture);
        }

        private void Song_Artist_Load(object sender, EventArgs e)
        {
            if (_isArtist)
            {
                pic_Album.Visible = false;
                pic_Artist.Visible = true;
                if (artist != null)
                {
                    pic_Artist.Image = artist.ImgArtist;
                    lbl_ArtistOrAlbum.Text = artist.ArtistName;
                    lbl_SongNumber.Text = artist.Songs.Count() + " " + Program.rm.GetString("songUnit", Program.culture);
                    LoadListSong();
                }
            }
            else
            {
                pic_Album.Visible = true;
                pic_Artist.Visible = false;
                if (album != null)
                {
                    pic_Artist.Image = album.ImgAlbum;
                    lbl_ArtistOrAlbum.Text = album.AlbumName;
                    lbl_SongNumber.Text = album.Songs.Count() + " " + Program.rm.GetString("songUnit", Program.culture);
                    LoadListSong();
                }
            }
            Location = new Point(Location.X + 115, Location.Y);
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            mp3.PlayListSong(artist.Songs, album.Songs, _isArtist == true ? 0 : 1);
            main.RefeshControlBar();
            main.playingMusic.PlayingMusic_Load(sender, new EventArgs());
            this.Close();
        }

        public void LoadListSong()
        {
            List<string> favorites = mp3.LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            List<UC_Song_mini> ucSongs = new List<UC_Song_mini>();
            foreach (var item in _isArtist == true ? artist.Songs : album.Songs)
            {
                UC_Song_mini ucSongMini = new UC_Song_mini(main, new Song(item))
                {
                    mp3 = mp3,
                    IsFavorite = favorites.Contains(item)
                };
                ucSongs.Add(ucSongMini);
            }
            DisplaySong(ucSongs);
        }

        
        private void DisplaySong(List<UC_Song_mini> ucSongs)
        {
            int tempHeigh = 0;
            int i = 0;
            foreach (var item in ucSongs)
            {
                item.Location = new Point(panel_ContainSong.AutoScrollPosition.X, panel_ContainSong.AutoScrollPosition.Y + tempHeigh);
                item.Size = new Size(panel_ContainSong.Width - 40, item.Height);
                panel_ContainSong.Controls.Add(item);
                tempHeigh += 60;
                i++;
            }    
        }

        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_circled_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_circled_gray;
        }
    }
}
