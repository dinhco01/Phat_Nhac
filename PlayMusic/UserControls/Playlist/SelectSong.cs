using PlayMusic.ChildForm;
using PlayMusic.Model;
using PlayMusic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.Playlist
{
    public partial class SelectSong : UserControl
    {
        public bool IsSelected { get; set; } = false;

        public Song song { get; set; }

        public SelectSong()
        {
            InitializeComponent();
        }

        public SelectSong(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void SelectSong_Click(object sender, EventArgs e)
        {
            btn_Tick.BackgroundImage = IsSelected == true? null: Resources.check_ok_blue;
            IsSelected = !IsSelected;
        }

        private void SelectSong_Load(object sender, EventArgs e)
        {
            if(song != null)
            {
                pic_Song.Image = song.Image;
                lbl_Song.Text = song.NameSong;
                lbl_Singger.Text = song.Artist;
            }    
            btn_Tick.BackgroundImage = IsSelected == false ? null : Resources.check_ok_blue;
        }
    }
}
