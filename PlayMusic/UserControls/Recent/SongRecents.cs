using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayMusic.Properties;
using PlayMusic.Model;

namespace PlayMusic.UserControls.Recent
{
    public partial class SongRecents : UserControl
    {
        public Mp3Player mp3 { get; set; }

        public Song song { get; set; }

        public SongRecents()
        {
            InitializeComponent();
        }

        public SongRecents(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if(mp3 != null)
            {
                mp3.PlaySong(song.UrlSource);
                if (Program.dataRecent.Songs.Contains(song.UrlSource))
                {
                    Program.dataRecent.Songs.Remove(song.UrlSource);
                }
                Program.dataRecent.Songs.Insert(0, song.UrlSource);
                new Mp3Player().SaveDataRecent(Program.dataRecent);
            }    
        }

        public bool IsFavorite { get; set; } = false;

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            if (!IsFavorite)
            {
                btn_Favorite.BackgroundImage = Resources.heart_pink;
                mp3.AddFavoriteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            else
            {
                btn_Favorite.BackgroundImage = Resources.heart_gray;
                mp3.RemoveFavotiteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            IsFavorite = !IsFavorite;
        }

        private void SongRecents_Load(object sender, EventArgs e)
        {
            btn_Favorite.BackgroundImage = IsFavorite == true ? Resources.heart_pink : Resources.heart_gray;
            if (song != null)
            {
                pic_SongImg.Image = song.Image != null ? song.Image : Resources.music_blue;
                lbl_SongName.Text = song.NameSong;
                lbl_SingerName.Text = song.Artist;
            }
        }

        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_gray;
        }
    }
}
