using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayMusic.Model;
using PlayMusic.ChildForm;
using PlayMusic.Properties;

namespace PlayMusic.UserControls.SongMusic
{
    public partial class UC_Song_mini : UserControl
    {
        public Song song { get; set; }

        public SongsMusic songsMusic { get; set; }

        public Mp3Player mp3 { get; set; }

        public MainForm main { get; set; }

        public UC_Song_mini()
        {
            InitializeComponent();
        }

        public UC_Song_mini(MainForm main, Song song)
        {
            InitializeComponent();
            this.main = main;
            this.song = song;
        }

        private void UC_Song_mini_Load(object sender, EventArgs e)
        {
            if(IsFavorite)
            {
                btn_Favorite.BackgroundImage = Resources.heart_pink;
            }    
            else
            {
                btn_Favorite.BackgroundImage = Resources.heart_gray;
            }
            if(song != null)
            {
                lbl_Singger.Text = song.Artist;
                lbl_Song.Text = song.NameSong;
                pic_Song.Image = song.Image;
            }    
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            mp3.PlaySong(song.UrlSource);
            main.RefeshControlBar();
            main.playingMusic.PlayingMusic_Load(songsMusic, new EventArgs());
            mp3.AddSongToRecent(song);
        }

        private void btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            if (Program.dataPlaylist.Playlists.Count == 0)
            {
                MessageBox.Show(Program.rm.GetString("infoNoPlaylist", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AddPlaylistForm add = new AddPlaylistForm(song);
            add.ShowDialog();
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

        #region Đổi màu button
        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_gray;
        }

        private void btn_AddPlaylist_MouseHover(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_blue;
        }

        private void btn_AddPlaylist_MouseLeave(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_gray;
        }
        private void UC_Song_mini_MouseHover(object sender, EventArgs e)
        {
            string s = song.NameSong + " - " + song.Artist;
            toolTip_InfoSong.SetToolTip(pic_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Singger, s);
        }

        #endregion
    }
}
