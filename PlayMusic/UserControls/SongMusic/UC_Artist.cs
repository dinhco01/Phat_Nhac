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
    public partial class UC_Artist : UserControl
    {
        private Artist artist;

        public Mp3Player mp3 { get; set; }

        public MainForm main { get; set; }

        public UC_Artist()
        {
            InitializeComponent();
        }

        public UC_Artist(MainForm main, Artist artist)
        {
            InitializeComponent();
            this.main = main;
            this.artist = artist;
            lbl_Artist.Text = artist.ArtistName;
            pic_Artist.Image = artist.ImgArtist;
        }

        private void UC_Artist_Load(object sender, EventArgs e)
        {
            if (artist != null)
            {
                lbl_Artist.Text = artist.ArtistName;
                pic_Artist.Image = artist.ImgArtist;
            }    
        }

        private void lbl_Artist_Click(object sender, EventArgs e)
        {
            Song_Artist_Album song_Artist = new Song_Artist_Album(main, artist, new Album(), true)
            {
                mp3 = mp3,
                ShowInTaskbar = false
            };
            song_Artist.ShowDialog();
        }
    }
}
