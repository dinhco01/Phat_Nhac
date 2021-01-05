using PlayMusic.Model;
using PlayMusic.Properties;
using PlayMusic.UserControls.Playlist;
using PlayMusic.UserControls.Recent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class PlaylistMusic : Form
    {
        public Mp3Player mp3;

        public MainForm main { get; set; }

        public PlaylistMusic()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            label_TitlePlaylist.Text = rm.GetString("playlists", culture);
        }

        private void PlaylistMusic_Load(object sender, EventArgs e)
        {
            LoadPlaylists(Program.dataPlaylist);
        }

        public void LoadPlaylists(DataPlaylist dataPlaylist)
        {
            List<Playlist_Item> ucPlaylist = new List<Playlist_Item>();
            foreach (var item in dataPlaylist.Playlists)
            {
                Playlist_Item uc = new Playlist_Item(item, this);
                ucPlaylist.Add(uc);
            }
            DisplayPlaylists(ucPlaylist);
        }

        private void DisplayPlaylists(List<Playlist_Item> ucPlaylists)
        {
            panel_ContainPlaylist.Controls.Clear();
            foreach(var item in ucPlaylists)
            {
                panel_ContainPlaylist.Controls.Add(item);
            }    
        }

        //public void LoadDataPlaylist(Playlist_Item ucPlaylist)
        //{
        //    pic_Img1.Image = ucPlaylist.pic_Img1.Image;
        //    pic_Img2.Image = ucPlaylist.pic_Img2.Image;
        //    pic_Img3.Image = ucPlaylist.pic_Img3.Image;
        //    pic_Img4.Image = ucPlaylist.pic_Img4.Image;

        //    lbl_NamePlaylist.Text = ucPlaylist.lbl_TitlePlaylist.Text;
        //    lbl_NumberSong.Text = "Số bài hát: " + ucPlaylist.playlist.Songs.Count() + " bài";
        //    lbl_Time.Text = "Thòi lượng: " + "--:--";
        //}

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            //code
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            //code
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //code
        }

        private void btn_AddSong_Click(object sender, EventArgs e)
        {
            //code
        }

        private void btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            AddEditPlaylist add = new AddEditPlaylist(this);
            add.ShowDialog();
        }

        #region Đổi màu button

        private void btn_AddPlaylist_MouseHover(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_blue;
        }

        private void btn_AddPlaylist_MouseLeave(object sender, EventArgs e)
        {
            btn_AddPlaylist.BackgroundImage = Resources.add_gray;
        }
        #endregion

    }
}
