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
using System.IO;
using PlayMusic.ChildForm;

namespace PlayMusic.UserControls.SongMusic
{
    public partial class UC_Song : UserControl
    {
        public int MenuCurrent { get; set; } = 0;

        public Song song { get; set; }

        public SongsMusic songsMusic { get; set; }

        public Mp3Player mp3 { get; set; }

        public MainForm main { get; set; }

        public UC_Song()
        {
            InitializeComponent();
        }

        public UC_Song(MainForm main, Song song)
        {
            InitializeComponent();
            this.main = main;
            this.song = song;
        }

        private void UC_Song_Load(object sender, EventArgs e)
        {
            btn_Favorite.BackgroundImage = IsFavorite == true ? Resources.heart_pink : Resources.heart_gray;
            if (song != null)
            {
                lbl_Song.Text = song.NameSong;
                lbl_Singger.Text = song.Artist;
                pic_Song.Image = song.Image;
                if(song.Length == null)
                {
                    lbl_Duration.Text = "--:--";
                    return;
                }    
                TimeSpan? t = song.Length;
                string time = string.Format("{0:D2}:{1:D2}", t?.Hours * 60 + t?.Minutes, t?.Seconds);
                lbl_Duration.Text = time;
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
            if(Program.dataPlaylist.Playlists.Count == 0)
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

        private void btn_RemoveSong_MouseHover(object sender, EventArgs e)
        {
            btn_RemoveSong.BackgroundImage = Resources.remove_song_red;
        }

        private void btn_RemoveSong_MouseLeave(object sender, EventArgs e)
        {
            btn_RemoveSong.BackgroundImage = Resources.remove_gray;
        }

        
        private void btn_AddPlaylist_MouseHover(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_blue;
        }

        private void btn_AddPlaylist_MouseLeave(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_gray;
        }

        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_gray;
        }

        #endregion

        private void btn_RemoveSong_Click(object sender, EventArgs e)
        {
            if (song == null || !File.Exists(song.UrlSource))
            {
                return;
            }
            DialogResult result = MessageBox.Show(Program.rm.GetString("questionDeleteSong", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if(result == DialogResult.Yes)
            {
                File.Delete(song.UrlSource);
                switch (MenuCurrent)
                {
                    case 0:
                        songsMusic.LoadAllSong();
                        break;
                    case 1:
                        songsMusic.LoadFavoriteSong();
                        break;
                }
            }
        }

        private void UC_Song_MouseHover(object sender, EventArgs e)
        {
            string s = song.NameSong + " - " + song.Artist;
            toolTip_InfoSong.SetToolTip(pic_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Singger, s);
        }
    }
}
