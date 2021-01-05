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
    public partial class Playlist_Detail : Form
    {
        public Model.Playlist playlist { get; set; }

        public Mp3Player mp3 { get; set; }

        public ChildForm.PlaylistMusic playlistMusic { get; set; }

        public Playlist_Detail(Mp3Player mp3, ChildForm.PlaylistMusic playlistMusic)
        {
            InitializeComponent();
            LoadLanguage();
            this.mp3 = mp3;
            this.playlistMusic = playlistMusic;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("playlistInfo", culture);
            lbl_TitleSong.Text = rm.GetString("listSongs", culture);
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            try
            {
                mp3.PlayListSong(playlist.Songs);
                mp3.player.settings.setMode("shuffle", true);
                playlistMusic.mp3.IsPlay = true;
                playlistMusic.main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                playlistMusic.mp3.Shuffle = true;
                playlistMusic.main.btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
                playlistMusic.mp3.AddPlaylistToRecent(playlist);
                this.Close();
            }
            catch { }
        }

        private void btn_Shuffle_MouseHover(object sender, EventArgs e)
        {
            btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
        }

        private void btn_Shuffle_MouseLeave(object sender, EventArgs e)
        {
            btn_Shuffle.BackgroundImage = Resources.shuffle_gray;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Program.rm.GetString("questionDeletePlaylist", Program.culture),
                                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var data = Program.dataPlaylist.Playlists.Where(x => x == playlist).FirstOrDefault();
                if(data != null)
                {
                    Program.dataPlaylist.Playlists.Remove(data);
                }
                mp3.SaveDataPlaylist(Program.dataPlaylist);
                Program.dataPlaylist = mp3.LoadDataPlaylist(@"data\playlist.json");
                this.Close();
            }
        }

        private void btn_Remove_MouseHover(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = Resources.remove_song_red;
        }

        private void btn_Remove_MouseLeave(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = Resources.remove_gray;
        }

        private void Playlist_Detail_Load(object sender, EventArgs e)
        {
            LoadPlaylist(true);
        }

        public void LoadPlaylist(bool check)
        {
            if (playlist != null)
            {
                lbl_NamePlaylist.Text = playlist.NamePlaylist;
                lbl_NumberSong.Text = Program.rm.GetString("numberSongs", Program.culture) + $" {playlist.Songs.Count()} " + Program.rm.GetString("songUnit", Program.culture);
                lbl_Time.Text = Program.rm.GetString("time", Program.culture)
                                                            + " 00 " + Program.rm.GetString("minute", Program.culture) 
                                                            + " 00 " + Program.rm.GetString("second", Program.culture);

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
            LoadSongs();
            if (check)
                Location = new Point(Location.X + 115, Location.Y);
        }

        private void LoadSongs()
        {
            List<string> favorites = new Mp3Player().LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            List<Song_Item> ucSongs = new List<Song_Item>();
            foreach (var item in playlist.Songs)
            {
                Song_Item ucSongMini = new Song_Item(new Song(item), playlist, this)
                {
                    IsFavorite = favorites.Contains(item)
                };
                ucSongs.Add(ucSongMini);
            }
            DisplaySong(ucSongs); 
        }

        private void DisplaySong(List<Song_Item> ucSongs)
        {
            panel_ContainSong.Controls.Clear();
            int tempHeigh = 0;
            int i = 0;
            foreach (var item in ucSongs)
            {
                item.Location = new Point(panel_ContainSong.AutoScrollPosition.X, panel_ContainSong.AutoScrollPosition.Y + tempHeigh);
                item.Size = new Size(panel_ContainSong.Width - 40, item.Height);
                panel_ContainSong.Controls.Add(item);
                tempHeigh += 60;
                i++;
            }
        }

        private void btn_Edit_MouseHover(object sender, EventArgs e)
        {
            btn_Edit.BackgroundImage = Resources.edit_blue;
        }

        private void btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            btn_Edit.BackgroundImage = Resources.edit_gray;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            AddEditPlaylist edit = new AddEditPlaylist(playlist, this);
            edit.ShowDialog();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            try
            {
                mp3.PlayListSong(playlist.Songs);
                mp3.player.settings.setMode("shuffle", false);
                playlistMusic.mp3.Shuffle = false;
                playlistMusic.mp3.IsPlay = true;
                playlistMusic.main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                playlistMusic.main.btn_Shuffle.BackgroundImage = Resources.shuffle_gray;
                playlistMusic.mp3.AddPlaylistToRecent(playlist);
                this.Close();
            }
            catch { }
        }

        private void Playlist_Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            playlistMusic.LoadPlaylists(Program.dataPlaylist);
        }
    }
}
