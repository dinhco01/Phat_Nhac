using Mp3Lib;
using PlayMusic.Properties;
using PlayMusic.UserControls.PlayingMusic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PlayMusic.ChildForm
{
    public partial class PlayingMusic : Form
    {
        public Mp3Player mp3 { get; set; }

        public MainForm main { get; set; }

        private List<Song_Playing> songs = new List<Song_Playing>();

        public PlayingMusic()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public PlayingMusic(MainForm main)
        {
            InitializeComponent();
            LoadLanguage();
            this.main = main;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_TitlePlayList.Text = rm.GetString("playlist", culture);
            lbl_NoSong.Text = rm.GetString("noSong", culture);
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (mp3.player.playState == WMPPlayState.wmppsUndefined)
                return;
            if (mp3.IsPlay)
            {
                btn_PlayPause.BackgroundImage = main.btn_PlayPause.BackgroundImage = Resources.play_blue;
                mp3.player.controls.pause();
            }
            else
            {
                btn_PlayPause.BackgroundImage = main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                mp3.player.controls.play();
            }
            GetInfoSong(mp3.player.currentMedia.sourceURL);
            mp3.IsPlay = !mp3.IsPlay;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            mp3.player.controls.next();
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            mp3.player.controls.previous();
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
        }

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            switch (mp3.Repeat)
            {
                case 0:
                    btn_Repeat.BackgroundImage = main.btn_Repeat.BackgroundImage = Resources.repeat_one_blue;
                    mp3.Repeat = 1;
                    break;
                case 1:
                    btn_Repeat.BackgroundImage = main.btn_Repeat.BackgroundImage = Resources.repeat_blue;
                    mp3.player.settings.setMode("loop", true);
                    mp3.Repeat = 2;
                    break;
                case 2:
                    btn_Repeat.BackgroundImage = main.btn_Repeat.BackgroundImage = Resources.repeat_gray;
                    mp3.player.settings.setMode("loop", false);
                    mp3.Repeat = 0;
                    break;
            }
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            if (!mp3.Shuffle)
            {
                btn_Shuffle.BackgroundImage = main.btn_Shuffle.BackgroundImage = Resources.shuffle_blue;
                mp3.player.settings.setMode("shuffle", true);
            }
            else
            {
                btn_Shuffle.BackgroundImage = main.btn_Shuffle.BackgroundImage = Resources.shuffle_gray;
                mp3.player.settings.setMode("shuffle", true);
            }
            mp3.Shuffle = !mp3.Shuffle;
        }

        private void PlayFirst()
        {
            var allSong = mp3.LoadAllSong(@"D:\MediaApp");
            IWMPPlaylist playlist = mp3.player.playlistCollection.newPlaylist("Play");
            IWMPMedia media;
            foreach (var song in allSong)
            {
                media = mp3.player.newMedia(song);
                playlist.appendItem(media);
            }
            mp3.player.currentPlaylist = playlist;
            mp3.IsPlay = false;
        }

        private bool _isFirst = true;

        public void PlayingMusic_Load(object sender, EventArgs e)
        {
            if (_isFirst)
            {
                PlayFirst();
            }
            LoadPlayList();
            mp3.player.controls.pause();
            btn_Shuffle.BackgroundImage = mp3.Shuffle == true ? Resources.shuffle_blue : Resources.shuffle_gray;
            btn_PlayPause.BackgroundImage = mp3.IsPlay == true ? Resources.pause_blue : Resources.play_blue;
            switch (mp3.Repeat)
            {
                case 0:
                    btn_Repeat.BackgroundImage = Resources.repeat_gray;
                    break;
                case 1:
                    btn_Repeat.BackgroundImage = Resources.repeat_one_blue;
                    break;
                case 2:
                    btn_Repeat.BackgroundImage = Resources.repeat_blue;
                    break;
            }
            btn_VolMute.BackgroundImage = mp3.IsMute == true ? Resources.mute_gray : Resources.audio_blue;
        }

        public void RestoreColorPlayList()
        {
            foreach (var item in songs)
            {
                item.RestoreBackColor();
            }
        }

        public void LoadPlayList()
        {
            List<string> favorites = mp3.LoadAllFavoriteSong(@"data\favoriteSongs.txt");
            lbl_NoSong.Visible = true;
            if (songs != null) songs.Clear();
            for (int j = 0; j < mp3.player.currentPlaylist.count; j++)
            {
                var song_Playing = new Song_Playing(this, mp3.player.currentPlaylist.Item[j].sourceURL, j);
                if (favorites.Contains(song_Playing.song.UrlSource))
                {
                    song_Playing.IsFavorite = true;
                }
                songs.Add(song_Playing);
            }
            if (songs.Count > 0)
                lbl_NoSong.Visible = false;
            DisplayPlaylist();
        }

        private void btn_VolMute_Click(object sender, EventArgs e)
        {
            if (mp3.IsMute)
            {
                btn_VolMute.BackgroundImage = main.btn_MuteVol.BackgroundImage = Resources.audio_blue;
                mp3.player.settings.volume = mp3.CurrentVolume;
            }
            else
            {
                btn_VolMute.BackgroundImage = main.btn_MuteVol.BackgroundImage = Resources.no_audio_gray;
                mp3.player.settings.volume = 0;
            }
            trackBar_Volume.Value = mp3.player.settings.volume;
            mp3.IsMute = !mp3.IsMute;
        }

        public void GetInfoSong(string fileName)
        {
            try
            {
                if (mp3.player.currentMedia == null)
                {
                    lbl_SongName.Text = main.lbl_SongName.Text = "---";
                    lbl_SinggerName.Text = main.lbl_NameSingger.Text = "---";
                    pic_ImgSong.Image = Resources.song_default;
                    main.ChangeImgSongControlBar(pic_ImgSong.Image);
                    return;
                }
                Mp3File file = new Mp3File(fileName);
                lbl_SongName.Text = main.lbl_SongName.Text = file.TagHandler.Title;
                lbl_SinggerName.Text = main.lbl_NameSingger.Text = file.TagHandler.Artist;
                try
                {
                    pic_ImgSong.Image = file.TagHandler.Picture != null ? file.TagHandler.Picture : Resources.song_default;
                }
                catch
                {
                    pic_ImgSong.Image = Resources.song_default;
                }
                main.ChangeImgSongControlBar(pic_ImgSong.Image);
            }
            catch { }
        }

        private void trackPlaying_Scroll(object sender, ScrollEventArgs e)
        {
            if (mp3.player.playState == WMPPlayState.wmppsPlaying)
            {
                if (trackPlaying.Value >= (decimal)mp3.player.currentMedia.duration)
                {
                    return;
                }
                mp3.player.controls.currentPosition = (double)trackPlaying.Value;
            }
        }

        private void trackBar_Volume_ValueChanged(object sender, EventArgs e)
        {
            mp3.player.settings.volume = (int)trackBar_Volume.Value;
            lbl_Vol.Text = ((int)trackBar_Volume.Value).ToString() + "%";
            btn_VolMute.BackgroundImage = main.btn_MuteVol.BackgroundImage = mp3.player.settings.volume == 0 ? Resources.no_audio_gray : Resources.audio_blue;
        }

        private void DisplayPlaylist()
        {
            if (panel_ContainSongs.Controls.Count > 0)
                panel_ContainSongs.Controls.Clear();
            int tempHeigh = 0;
            int i = 0;
            foreach (var item in songs)
            {
                item.Location = new Point(panel_ListSong.AutoScrollPosition.X, panel_ListSong.AutoScrollPosition.Y + tempHeigh);
                panel_ContainSongs.Controls.Add(item);
                tempHeigh += 60;
                i++;
            }
        }

        public void RemoveSong(int id)
        {
            IWMPMedia media = mp3.player.currentPlaylist.get_Item(id);
            mp3.player.currentPlaylist.removeItem(media);
            songs.RemoveAt(id);
            for (int k = id; k < songs.Count; k++)
            {
                songs[k].Id--;
            }
            DisplayPlaylist();
            if (songs.Count == 0)
            {
                lbl_NoSong.Visible = true;
                GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
                return;
            }
            mp3.player.controls.play();
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
        }

        public void ChangeImgSong(Image img)
        {
            pic_ImgSong.Image = img;
        }

        private void PlayingMusic_Shown(object sender, EventArgs e)
        {
            if (_isFirst)
            {
                mp3.player.controls.pause();
                main.RefeshControlBar();
                btn_PlayPause.BackgroundImage = Resources.play_blue;
                _isFirst = false;
            }
        }
    }
}
