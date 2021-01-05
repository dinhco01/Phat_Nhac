using PlayMusic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.SongMusic
{
    public partial class PlaylistTag : UserControl
    {
        public Model.Playlist playlist { get; set; }

        public Model.Song song {get; set;}

        public AddPlaylistForm parentForm { get; set; }

        public int Id { get; set; }

        public PlaylistTag(AddPlaylistForm parentForm, Model.Playlist playlist, Model.Song song, int id)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.playlist = playlist;
            this.song = song;
            this.Id = id;
        }

        private void PlaylistTag_Load(object sender, EventArgs e)
        {
            if (playlist != null)
            {
                lbl_PlaylistName.Text = playlist.NamePlaylist;
                lbl_NumberSong.Text = "Số bài hát: " + playlist.Songs.Count + " bài";

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

        private void PlaylistTag_Click(object sender, EventArgs e)
        {
            parentForm.RestoreAllColor();
            parentForm.SelectedId = this.Id;
            BackColor = Color.FromArgb(175, 220, 255);
        }

        private void PlaylistTag_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                playlist.Songs.Add(song.UrlSource);
                new Mp3Player().SaveDataPlaylist(Program.dataPlaylist);
                parentForm.Close();
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("cantAddSong", Program.culture));
            }
        }
    }
}
