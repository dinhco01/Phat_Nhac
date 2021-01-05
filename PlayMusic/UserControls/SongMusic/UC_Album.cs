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

namespace PlayMusic.UserControls.SongMusic
{
    public partial class UC_Album : UserControl
    {
        private Album album;

        public Mp3Player mp3 { get; set; }

        public MainForm main { get; set; }

        public UC_Album()
        {
            InitializeComponent();
        }
        public UC_Album(MainForm main, Album album)
        {
            InitializeComponent();
            this.main = main;
            this.album = album;
            lbl_AlbumName.Text = album.AlbumName;
            lbl_ArtistName.Text = album.Artist;
            pic_ImgAlbum.Image = album.ImgAlbum;
        }

        private void UC_Album_Load(object sender, EventArgs e)
        {
            if (album != null)
            {
                lbl_AlbumName.Text = album.AlbumName;
                lbl_ArtistName.Text = album.Artist;
                pic_ImgAlbum.Image = album.ImgAlbum;
            }
        }

        private void pic_ImgAlbum_Click(object sender, EventArgs e)
        {
            Song_Artist_Album song_Album = new Song_Artist_Album(main, new Artist(), album, false)
            {
                mp3 = mp3,
                ShowInTaskbar = false
            };
            song_Album.ShowDialog();
        }
    }
}
