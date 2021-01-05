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
    public partial class Playlist_Item : UserControl
    {

        public Model.Playlist playlist { get; set; }

        public ChildForm.PlaylistMusic playlistMusic { get; set; }

        public Playlist_Item()
        {
            InitializeComponent();
            LoadLanguage();
        }        

        public Playlist_Item(Model.Playlist playlist, ChildForm.PlaylistMusic playingMusic)
        {
            InitializeComponent();
            LoadLanguage();
            this.playlist = playlist;
            this.playlistMusic = playingMusic;
        }

        public void LoadLanguage()
        {
            //code
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            try
            {
                playlistMusic.mp3.PlayListSong(playlist.Songs);
                playlistMusic.mp3.player.settings.setMode("shuffle", true);
                playlistMusic.mp3.Shuffle = true;
                playlistMusic.main.btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
                playlistMusic.mp3.IsPlay = true;
                playlistMusic.main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                playlistMusic.mp3.AddPlaylistToRecent(playlist);
            }
            catch { }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            try
            {
                playlistMusic.mp3.PlayListSong(playlist.Songs);
                playlistMusic.mp3.player.settings.setMode("shuffle", false);
                playlistMusic.mp3.Shuffle = false;
                playlistMusic.main.btn_Shuffle.BackgroundImage = Resources.shuffle_gray;
                playlistMusic.mp3.IsPlay = true;
                playlistMusic.main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                playlistMusic.mp3.AddPlaylistToRecent(playlist);
            }
            catch { }
        }

        #region Đổi màu button
        private void btn_Shuffle_MouseHover(object sender, EventArgs e)
        {
            btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
        }

        private void btn_Shuffle_MouseLeave(object sender, EventArgs e)
        {
            btn_Shuffle.BackgroundImage = Resources.shuffle_gray;
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

        private void Playlist_Item_Load(object sender, EventArgs e)
        {
            if(playlist!=null)
            {
                lbl_Title.Text = playlist.NamePlaylist;
                lbl_Detail.Text = playlist.Songs.Count() + " " +
                    Program.rm.GetString("songUnit", Program.culture) + " - 00 " +
                    Program.rm.GetString("minute", Program.culture) + " 00 " + 
                    Program.rm.GetString("second", Program.culture);

                int i = playlist.Songs.Count;
                if (i >= 1)
                {
                    pic_Img1.Image = new Song(playlist.Songs[0]).Image;
                    if (i >= 2)
                    {
                        pic_Img2.Image = new Song(playlist.Songs[1]).Image;
                        if (i >= 3)
                        {
                            pic_Img3.Image = new Song(playlist.Songs[2]).Image;
                            if (i >= 4)
                            {
                                pic_Img4.Image = new Song(playlist.Songs[3]).Image;
                            }
                        }
                    }
                }
            }
        }

        private void panel_Info_Click(object sender, EventArgs e)
        {
            Playlist_Detail detail = new Playlist_Detail(playlistMusic.mp3, playlistMusic)
            {
                playlist = playlist,
                ShowInTaskbar = false
            };
            detail.ShowDialog();
        }
    }
}
