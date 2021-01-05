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
    public partial class AddPlaylistForm : Form
    {
        public Model.Song song { get; set; }

        public int SelectedId { get; set; } = -1;

        public AddPlaylistForm(Model.Song song)
        {
            InitializeComponent();
            LoadLanguage();
            this.song = song;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("addToPlaylist", culture);
            lbl_Title.Text = rm.GetString("selectPlaylist", culture);
        }

        private void AddPlaylistForm_Load(object sender, EventArgs e)
        {
            var playlists = Program.dataPlaylist.Playlists;
            int i = 0;
            foreach (var item in playlists)
            {
                if (!item.Songs.Contains(song.UrlSource))
                {
                    PlaylistTag tag = new PlaylistTag(this, item, song, i);
                    panel_ContainPlaylists.Controls.Add(tag);
                }
                i++;
            }
            if (panel_ContainPlaylists.Controls.Count == 0)
            {
                MessageBox.Show(Program.rm.GetString("currentAll", Program.culture),
                                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RestoreAllColor()
        {
            foreach (PlaylistTag item in panel_ContainPlaylists.Controls)
            {
                item.BackColor = Color.White;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (SelectedId == -1)
            {
                MessageBox.Show(Program.rm.GetString("noSelectPlaylist", Program.culture),
                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Program.dataPlaylist.Playlists[SelectedId].Songs.Add(song.UrlSource);
                new Mp3Player().SaveDataPlaylist(Program.dataPlaylist);
                this.Close();
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("cantAddSong", Program.culture));
            }
        }
    }
}
