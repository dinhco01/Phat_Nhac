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

namespace PlayMusic.UserControls.PlayingMusic
{
    public partial class Song_Playing : UserControl
    {
        public Song song { get; set; }

        public int Id { get; set; }

        private ChildForm.PlayingMusic playingMusic;

        public Song_Playing()
        {
            InitializeComponent();
        }

        public Song_Playing(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        public Song_Playing(ChildForm.PlayingMusic playingMusic, string url, int id)
        {
            InitializeComponent();
            this.playingMusic = playingMusic;
            this.song = new Song(url);
            this.Id = id;
        }

        private void Song_Playing_Load(object sender, EventArgs e)
        {
            btn_Favorite.BackgroundImage = IsFavorite == true ? Resources.heart_pink : Resources.heart_gray;  
            if (song != null)
            {
                lbl_Song.Text = song.NameSong;
                lbl_Singger.Text = song.Artist;
                pic_Song.Image = song.Image;
            }
        }
        
        private void Song_Playing_DoubleClick(object sender, EventArgs e)
        {
            playingMusic.RestoreColorPlayList();
            BackColor = btn_RemoveSong.BackColor = Color.FromArgb(175, 220, 255);
            btn_RemoveSong.FlatAppearance.MouseDownBackColor = btn_RemoveSong.FlatAppearance.MouseOverBackColor = BackColor;
            btn_Favorite.FlatAppearance.MouseDownBackColor = btn_Favorite.FlatAppearance.MouseOverBackColor = BackColor;
            WMPLib.IWMPMedia media = playingMusic.mp3.player.currentPlaylist.get_Item(Id);
            playingMusic.mp3.player.controls.playItem(media);
            playingMusic.GetInfoSong(playingMusic.mp3.player.currentMedia.sourceURL);
            playingMusic.mp3.AddSongToRecent(song);

            playingMusic.btn_PlayPause.BackgroundImage = Resources.pause_blue;
            playingMusic.mp3.IsPlay = true;
        }

        public void RestoreColor()
        {
            BackColor = btn_RemoveSong.BackColor = Color.White;
            lbl_Singger.ForeColor = lbl_Song.ForeColor = Color.Black;
            btn_RemoveSong.FlatAppearance.MouseDownBackColor = btn_RemoveSong.FlatAppearance.MouseOverBackColor = BackColor;
            btn_RemoveSong.BackgroundImage = Resources.remove_song_blue;
        }

        public bool IsFavorite {get;set;} = false;
        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            if(!IsFavorite)
            {
                btn_Favorite.BackgroundImage = Resources.heart_pink;
                playingMusic.mp3.AddFavoriteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            else
            {
                btn_Favorite.BackgroundImage = Resources.heart_gray;
                playingMusic.mp3.RemoveFavotiteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            IsFavorite = !IsFavorite;
        }

        private void btn_RemoveSong_Click(object sender, EventArgs e)
        {
            playingMusic.RemoveSong(Id);
        }

        #region Đổi màu button
        private void btn_RemoveSong_MouseHover(object sender, EventArgs e)
        {
            btn_RemoveSong.BackgroundImage = Resources.remove_song_red;
        }

        private void btn_RemoveSong_MouseLeave(object sender, EventArgs e)
        {
            btn_RemoveSong.BackgroundImage = Resources.remove_song_blue;// = BackColor == Color.White ? Resources.remove_song_blue : Resources.remove_white;
        }

        public void RestoreBackColor()
        {
            BackColor = btn_RemoveSong.BackColor = Color.White;
            //lbl_Singger.ForeColor = lbl_Song.ForeColor = Color.Black;  
            btn_RemoveSong.FlatAppearance.MouseDownBackColor = btn_RemoveSong.FlatAppearance.MouseOverBackColor = BackColor;
            btn_Favorite.FlatAppearance.MouseDownBackColor = btn_Favorite.FlatAppearance.MouseOverBackColor = BackColor;
            //btn_RemoveSong.BackgroundImage = Resources.remove_song_blue;
        }
        #endregion
    }
}
