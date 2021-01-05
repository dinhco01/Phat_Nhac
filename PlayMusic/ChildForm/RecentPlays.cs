using PlayMusic.Properties;
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
    public partial class RecentPlays : Form
    {
        public PlaylistMusic playlistMusic { get; set; }

        public RecentPlays()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_PlaylistTitle.Text = rm.GetString("recentPlaylists", culture);
            lbl_SongTitle.Text = rm.GetString("recentSongs", culture);
        }

        private void RecentPlays_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
            LoadSongs();
        }

        public void LoadPlaylist()
        {
            panel_ContainPlaylist.Controls.Clear();
            foreach (var item in Program.dataRecent.Playlists)
            {
                var data = Program.dataPlaylist.Playlists.FirstOrDefault(x => x.NamePlaylist == item.NamePlaylist);
                if(data != null)
                {
                    UC_Playlist ucPlaylist = new UC_Playlist(item, playlistMusic);
                    panel_ContainPlaylist.Controls.Add(ucPlaylist);
                }
            }
            new Mp3Player().SaveDataRecent(Program.dataRecent);
        }

        public void LoadSongs()
        {
            List<string> favorites = new Mp3Player().LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            List<string> allSongs = new Mp3Player().LoadAllSong(@"D:\MediaApp");
            panel_ContainSong.Controls.Clear();
            foreach (var item in Program.dataRecent.Songs)
            {
                if(allSongs.Contains(item))
                {
                    SongRecents ucSong = new SongRecents(new Model.Song(item))
                    {
                        IsFavorite = favorites.Contains(item),
                        mp3 = playlistMusic.mp3
                    };
                    panel_ContainSong.Controls.Add(ucSong);
                }    
            }
            new Mp3Player().SaveDataRecent(Program.dataRecent);
        }

        private void btn_PlayShuffle_MouseHover(object sender, EventArgs e)
        {
            btn_PlayShuffle.BackgroundImage = Resources.shuffle_blue;
        }

        private void btn_PlayShuffle_MouseLeave(object sender, EventArgs e)
        {
            btn_PlayShuffle.BackgroundImage = Resources.shuffle_gray;
        }

        private void lbl_SongTitle_Click(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void lbl_PlaylistTitle_Click(object sender, EventArgs e)
        {
            LoadPlaylist();
        }

        private void btn_PlayShuffle_Click(object sender, EventArgs e)
        {
            if (panel_ContainSong.Controls.Count == 0)
                return;
            List<string> songs = new List<string>();
            foreach(SongRecents item in panel_ContainSong.Controls)
            {
                songs.Add(item.song.UrlSource);
            }
            playlistMusic.mp3.PlayListSong(songs);
            playlistMusic.mp3.player.settings.setMode("shuffle", true);
            playlistMusic.mp3.Shuffle = true;
            playlistMusic.main.btn_PlayPause.BackgroundImage = playlistMusic.main.playingMusic.btn_PlayPause.BackgroundImage = Resources.pause_blue;
            playlistMusic.main.btn_Shuffle.BackgroundImage = playlistMusic.main.playingMusic.btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
        }
    }
}
