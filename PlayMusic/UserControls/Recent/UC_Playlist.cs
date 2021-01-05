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
using PlayMusic.UserControls.Playlist;

namespace PlayMusic.UserControls.Recent
{
    public partial class UC_Playlist : UserControl
    {
        public Model.Playlist playlist { get; set; }

        public ChildForm.PlaylistMusic playlistMusic { get; set; }

        public UC_Playlist()
        {
            InitializeComponent();
        }

        public UC_Playlist(Model.Playlist playlist, ChildForm.PlaylistMusic playlistMusic)
        {
            InitializeComponent();
            this.playlist = playlist;
            this.playlistMusic = playlistMusic;
        }

        private void UC_Playlist_Load(object sender, EventArgs e)
        {
            if (playlist != null)
            {
                lbl_TitlePlaylist.Text = playlist.NamePlaylist;
                pic_Img1.Image = pic_Img2.Image = pic_Img3.Image = pic_Img4.Image = Resources.song_default;
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

        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_circled_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_circled_gray;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            try
            {
                playlistMusic.mp3.PlayListSong(playlist.Songs);
                playlistMusic.mp3.player.settings.setMode("shuffle", false);
                playlistMusic.mp3.Shuffle = false;
                playlistMusic.mp3.IsPlay = true;
                playlistMusic.main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                playlistMusic.main.btn_Shuffle.BackgroundImage = Resources.shuffle_gray;

                var data =Program.dataRecent.Playlists.FirstOrDefault(x => x.NamePlaylist == playlist.NamePlaylist);
                if(data != null)
                {
                    Program.dataRecent.Playlists.Remove(data);
                }
                Program.dataRecent.Playlists.Insert(0, playlist);
                playlistMusic.mp3.SaveDataRecent(Program.dataRecent);
            }
            catch { }
        }
    }
}