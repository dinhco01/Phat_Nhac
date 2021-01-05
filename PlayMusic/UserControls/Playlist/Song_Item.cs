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

namespace PlayMusic.UserControls.Playlist
{
    public partial class Song_Item : UserControl
    {
        public bool IsFavorite { get; set; } = false;

        public Song song { get; set; }

        public Model.Playlist playlist { get; set; }

        public Playlist_Detail playlist_Detail { get; set; }

        public Song_Item()
        {
            InitializeComponent();
        }

        public Song_Item(Song song, Model.Playlist playlist, Playlist_Detail playlist_Detail)
        {
            InitializeComponent();
            this.song = song;
            this.playlist = playlist;
            this.playlist_Detail = playlist_Detail;
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            if (!IsFavorite)
            {
                btn_Favorite.BackgroundImage = Resources.heart_pink;
                new Mp3Player().AddFavoriteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            else
            {
                btn_Favorite.BackgroundImage = Resources.heart_gray;
                new Mp3Player().RemoveFavotiteSong(@"data\favoriteSongs.txt", song.UrlSource);
            }
            IsFavorite = !IsFavorite;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (playlist.Songs.Count == 1)
            {
                DialogResult result = MessageBox.Show("Danh sách phát này cũng sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.dataPlaylist.Playlists.Remove(playlist);
                    playlist_Detail.mp3.SaveDataPlaylist(Program.dataPlaylist);
                    playlist_Detail.Close();
                }
                return;
            }
            var data = playlist.Songs.Where(x => x == song.UrlSource).FirstOrDefault();
            if (data != null)
            {
                playlist.Songs.Remove(data);
            }
            playlist_Detail.panel_ContainSong.Controls.Clear();
            playlist_Detail.LoadPlaylist(false);
            playlist_Detail.mp3.SaveDataPlaylist(Program.dataPlaylist);
        }

        private void btn_Remove_MouseHover(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = Resources.remove_song_red;
        }

        private void btn_Remove_MouseLeave(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = Resources.remove_gray;
        }

        private void Song_Item_Load(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                btn_Favorite.BackgroundImage = Resources.heart_pink;
            }
            else
            {
                btn_Favorite.BackgroundImage = Resources.heart_gray;
            }
            if (song != null)
            {
                lbl_Singger.Text = song.Artist;
                lbl_Song.Text = song.NameSong;
                pic_Song.Image = song.Image;
            }
        }

        private void pic_Song_MouseHover(object sender, EventArgs e)
        {
            string s = song.NameSong + " - " + song.Artist;
            toolTip_InfoSong.SetToolTip(pic_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Song, s);
            toolTip_InfoSong.SetToolTip(lbl_Singger, s);
        }
    }
}
