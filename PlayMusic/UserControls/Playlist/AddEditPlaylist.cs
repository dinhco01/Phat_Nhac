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
    public partial class AddEditPlaylist : Form
    {
        public bool IsEditPlaylist { get; set; } = false;

        public Model.Playlist playlist { get; set; }

        public ChildForm.PlaylistMusic playlistMusic { get; set; }

        public Playlist_Detail detail { get; set; }

        public AddEditPlaylist(ChildForm.PlaylistMusic playlistMusic)
        {
            InitializeComponent();
            LoadLanguage();
            this.playlistMusic = playlistMusic;
        }

        private void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("addPlaylist", culture);
        }

        public AddEditPlaylist(Model.Playlist playlist, Playlist_Detail detail)
        {
            InitializeComponent();
            this.playlist = playlist;
            this.detail = detail;
            IsEditPlaylist = true;
            this.Text = Program.rm.GetString("editPlaylist", Program.culture);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Program.rm.GetString("questionCancel", Program.culture),
                                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private int CountSongSelected()
        {
            int count = 0;
            foreach (SelectSong item in panel_ContainSong.Controls)
            {
                if (item.IsSelected)
                    count++;
            }
            return count;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CountSongSelected() == 0)
            {
                MessageBox.Show(Program.rm.GetString("noSongSelect", Program.culture),
                                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txb_NewName.Text))
            {
                MessageBox.Show(Program.rm.GetString("pleaseEnterNamePlaylist", Program.culture),
                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsEditPlaylist)
            {
                playlist.NamePlaylist = txb_NewName.Text;
                playlist.Songs.Clear();
                foreach (SelectSong item in panel_ContainSong.Controls)
                {
                    if (item.IsSelected)
                    {
                        playlist.Songs.Add(item.song.UrlSource);
                    }
                }
                playlist.LastModify = DateTime.Now;
            }
            else
            {
                var newPlaylist = new Model.Playlist();
                newPlaylist.NamePlaylist = txb_NewName.Text;
                newPlaylist.CreateDate = newPlaylist.LastModify = DateTime.Now;
                newPlaylist.Songs = new List<string>();
                foreach (SelectSong item in panel_ContainSong.Controls)
                {
                    if (item.IsSelected)
                    {
                        newPlaylist.Songs.Add(item.song.UrlSource);
                    }
                }
                Program.dataPlaylist.Playlists.Add(newPlaylist);
            }
            new Mp3Player().SaveDataPlaylist(Program.dataPlaylist);
            this.Close();
        }

        private void txb_NewName_Click(object sender, EventArgs e)
        {
            //if (playlist != null && txb_NewName.Text == playlist.NamePlaylist)
            //    txb_NewName.SelectAll();
        }
        private void txb_NewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_OK_Click(this, new EventArgs());
            }
        }


        private void RenamePlaylist_Load(object sender, EventArgs e)
        {
            if (IsEditPlaylist)
            {
                txb_NewName.Text = playlist.NamePlaylist;
                LoadSongs();
                return;
            }
            txb_NewName.Text = Program.rm.GetString("playlist", Program.culture) +  $" #{Program.dataPlaylist.Playlists.Count() + 1}";
            LoadAllSong();
        }

        private void LoadAllSong()
        {
            var songs = new Mp3Player().LoadAllSong(@"D:\MediaApp");
            List<SelectSong> ucSongPlaylists = new List<SelectSong>();
            foreach (var item in songs)
            {
                SelectSong ucSongSelect = new SelectSong(new Model.Song(item))
                {
                    IsSelected = false
                };
                ucSongPlaylists.Add(ucSongSelect);
            }
            DisplaySong(ucSongPlaylists);
        }
        private void LoadSongs()
        {
            var songs = new Mp3Player().LoadAllSong(@"D:\MediaApp");
            List<SelectSong> ucSongPlaylists = new List<SelectSong>();
            var songLoadeds = new List<string>();
            foreach (var item in playlist.Songs)
            {
                if (songs.Contains(item))
                {
                    SelectSong ucSongSelect = new SelectSong(new Model.Song(item))
                    {
                        IsSelected = true
                    };
                    ucSongPlaylists.Add(ucSongSelect);
                    songLoadeds.Add(item);
                }
            }
            foreach (var item in songs)
            {
                if (songLoadeds.Contains(item))
                    continue;
                SelectSong ucSongSelect = new SelectSong(new Model.Song(item))
                {
                    IsSelected = false
                };
                ucSongPlaylists.Add(ucSongSelect);
            }
            DisplaySong(ucSongPlaylists);
        }

        private void DisplaySong(List<SelectSong> ucSongs)
        {
            foreach (var item in ucSongs)
            {
                panel_ContainSong.Controls.Add(item);
            }
        }

        private void AddEditPlaylist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playlistMusic != null)
            {
                playlistMusic.LoadPlaylists(Program.dataPlaylist);
            }
            if (detail != null)
            {
                detail.LoadPlaylist(false);
            }
        }
    }
}
