using Mp3Lib;
using PlayMusic.ChildForm;
using PlayMusic.Model;
using PlayMusic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace PlayMusic
{
    public partial class MainForm : Form
    {
        public bool IsPlayVideo { get; set; } = false;

        public Mp3Player mp3 { get; set; } = new Mp3Player();

        public Timer t;

        public MainForm()
        {
            InitializeComponent();
            LoadLanguage();
            mp3.player.PlayStateChange += Player_PlayStateChange;
            Init();
            panel_ControlBar.Visible = false;
            AddChildForm(playingMusic);
        }

        private void Init()
        {
            menu_Youtube.Visible = menu_Zing.Visible = pic_SelectZing.Visible = pic_SelectYotube.Visible = false;
            panel_User.Visible = false;
            playingMusic.mp3 = playlists.mp3 = songs.mp3 = search.mp3 = mp3;
            playlists.main = playingMusic.main = zingMP3.main = settings.main = songs.main = this;
            search.playlistMusic = recent.playlistMusic = playlists;
        }
        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                if (mp3.Repeat == 1)
                {
                    mp3.player.controls.previous();
                    mp3.player.controls.play();
                    return;
                }
            }
            if (mp3.player.currentMedia != null)
            {
                GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (mp3.player.playState == WMPPlayState.wmppsPaused || mp3.player.playState == WMPPlayState.wmppsStopped || mp3.player.playState == WMPPlayState.wmppsUndefined)
                return;

            trackPlaying.Maximum = playingMusic.trackPlaying.Maximum = (decimal)mp3.player.currentMedia.duration;
            TimeSpan t = TimeSpan.FromSeconds(mp3.player.currentMedia.duration);
            string time = string.Format("{0:D2}:{1:D2}", t.Hours * 60 + t.Minutes, t.Seconds);
            lbl_Duration.Text = playingMusic.lbl_Duration.Text = time;

            trackPlaying.Value = playingMusic.trackPlaying.Value = (decimal)mp3.player.controls.currentPosition;
            t = TimeSpan.FromSeconds(mp3.player.controls.currentPosition);
            time = string.Format("{0:D2}:{1:D2}", t.Hours * 60 + t.Minutes, t.Seconds);
            lbl_CurrentPosition.Text = playingMusic.lbl_CurrentPosition.Text = time;
        }

        public void PlayPlaylist(List<string> songs)
        {
            if (mp3.player.playState == WMPPlayState.wmppsPlaying)
            {
                mp3.player.controls.stop();
            }
            IWMPPlaylist playlist = mp3.player.playlistCollection.newPlaylist("MyPlaylist");
            IWMPMedia media;
            foreach (var song in songs)
            {
                media = mp3.player.newMedia(song);
                playlist.appendItem(media);
            }
            mp3.player.currentPlaylist = playlist;
            mp3.player.controls.play();
        }

        private void lbl_UserDisplayName_Click(object sender, EventArgs e)
        {
            if (!panel_User.Visible)
                panel_User.Visible = true;
            else
                panel_User.Visible = false;
        }

        //private Form _activeForm;

        public void AddChildForm(Form childForm)
        {
            //if (_activeForm != null)
            //    _activeForm.Close();
            //_activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public PlayingMusic playingMusic { get; set; } = new PlayingMusic();
        private void btn_Playing_Click(object sender, EventArgs e)
        {
            if (playingMusic == null)
                playingMusic = new PlayingMusic(this);
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Playing, panel_SelectedPlaying, pic_Playing, btn_Playing, 1);
            panel_ControlBar.Visible = false;
            playingMusic.LoadPlayList();
            AddChildForm(playingMusic);
        }

        public RecentPlays recent { get; set; } = new RecentPlays();
        private void btn_Recent_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Recent, panel_SelectedRecent, pic_Recent, btn_Recent, 2);
            panel_ControlBar.Visible = true;
            AddChildForm(recent);
            //Code
        }

        public SearchMusic search { get; set; } = new SearchMusic();
        private void btn_Search_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Search, panel_SelectedSearch, pic_Search, btn_Search, 3);
            panel_ControlBar.Visible = true;
            AddChildForm(search);
        }

        public SongsMusic songs { get; set; } = new SongsMusic();
        private void menu_Song_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Song, panel_SelectedSong, pic_Song, btn_Song, 4);
            panel_ControlBar.Visible = true;
            AddChildForm(songs);
        }

        public PlaylistMusic playlists { get; set; } = new PlaylistMusic();
        private void menu_Playlist_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Playlist, panel_SelectedPlaylist, pic_Playlist, btn_Playlist, 5);
            panel_ControlBar.Visible = true;
            if (playlists.mp3 == null)
            {
                playlists.mp3 = mp3;
            }
            if (playlists.main == null)
            {
                playlists.main = this;
            }
            AddChildForm(playlists);
        }

        public Form PlayingVideo { get; set; }

        public VideosPlay videos { get; set; } = new VideosPlay();
        private void menu_Video_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Video, panel_SelectedVideo, pic_Video, btn_Video, 6);
            panel_ControlBar.Visible = true;
            videos.main = this;
            if (IsPlayVideo && PlayingVideo != null)
            {
                panel_ControlBar.Visible = false;
                AddChildForm(PlayingVideo);
                return;
            }
            AddChildForm(videos);
        }

        private void ChangeColorMenuOnline()
        {
            menu_Online.BackColor = btn_Online.BackColor = Color.FromArgb(0, 144, 255);
            btn_Online.ForeColor = Color.White;
            btn_Online.FlatAppearance.MouseOverBackColor = btn_Online.FlatAppearance.MouseDownBackColor = menu_Online.BackColor;
            pic_Online.Image = Resources.online_white;
            pic_Online.BackColor = menu_Online.BackColor;
        }

        public OnlineSource onlineForm { get; set; } = new OnlineSource();
        private void menu_Online_Click(object sender, EventArgs e)
        {
            if (!DriverAPI.CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (menu_Zing.Visible && menu_Youtube.Visible)
                return;
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Online, panel_SelectedOnline, pic_Online, btn_Online, 7);
            panel_ControlBar.Visible = true;
            menu_Youtube.Visible = menu_Zing.Visible = true;
            panel_ControlBar.Visible = false;
            AddChildForm(onlineForm);
        }

        public VideoFromYoutube youtube { get; set; } = new VideoFromYoutube();
        private void menu_Youtube_Click(object sender, EventArgs e)
        {
            if (!DriverAPI.CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mp3.player.playState == WMPPlayState.wmppsPlaying)
            {
                mp3.player.controls.pause();
                mp3.IsPlay = false;
                btn_PlayPause.BackgroundImage = playingMusic.btn_PlayPause.BackgroundImage = Resources.play_blue;
            }
            panel_ControlBar.Visible = false;
            pic_SelectZing.Visible = false;
            pic_SelectYotube.Visible = true;
            AddChildForm(youtube);
            lbl_Title.Text = (btn_Online.Text + " - " + btn_Youtube.Text).ToUpper();
        }

        public MusicFromZingMP3 zingMP3 { get; set; } = new MusicFromZingMP3();
        private void menu_Zing_Click(object sender, EventArgs e)
        {
            if (!DriverAPI.CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            panel_ControlBar.Visible = false;
            pic_SelectZing.Visible = true;
            pic_SelectYotube.Visible = false;
            AddChildForm(zingMP3);
            lbl_Title.Text = (btn_Online.Text + " - " + btn_Zing.Text).ToUpper();
        }

        public SettingsMusic settings { get; set; } = new SettingsMusic();
        private void menu_Settings_Click(object sender, EventArgs e)
        {
            RestoreColorMenu();
            ChangeColorMenuItem(menu_Settings, panel_SelectedSettings, pic_Settings, btn_Settings, 8);
            panel_ControlBar.Visible = true;
            AddChildForm(settings);
        }

        private void panel_ControlBar_DoubleClick(object sender, EventArgs e)
        {
            btn_Playing_Click(sender, e);
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            PausePlayMusic();
        }

        public void PausePlayMusic()
        {
            if (lbl_SongName.Text == "--" || lbl_NameSingger.Text == "--")
                return;
            if (mp3.IsPlay)
            {
                btn_PlayPause.BackgroundImage = playingMusic.btn_PlayPause.BackgroundImage = Resources.play_blue;
                mp3.player.controls.pause();
            }
            else
            {
                btn_PlayPause.BackgroundImage = playingMusic.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                mp3.player.controls.play();
            }
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
            mp3.IsPlay = !mp3.IsPlay;
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            mp3.player.settings.setMode("shuffle", mp3.Shuffle == false ? true : false);
            mp3.Shuffle = !mp3.Shuffle;
            btn_Shuffle.BackgroundImage = playingMusic.btn_Shuffle.BackgroundImage = mp3.Shuffle == true ? Resources.shuffle_blue : Resources.shuffle_gray;
        }

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            switch (mp3.Repeat)
            {
                case 0:
                    mp3.Repeat = 1;
                    break;
                case 1:
                    mp3.player.settings.setMode("loop", true);
                    mp3.Repeat = 2;
                    break;
                case 2:
                    mp3.player.settings.setMode("loop", false);
                    mp3.Repeat = 0;
                    break;
            }
            RefeshControlBar();
            playingMusic.PlayingMusic_Load(sender, new EventArgs());
        }

        private void btn_MuteVol_Click(object sender, EventArgs e)
        {
            if (mp3.IsMute)
            {
                btn_MuteVol.BackgroundImage = playingMusic.btn_VolMute.BackgroundImage = Resources.audio_blue;
                mp3.player.settings.volume = mp3.CurrentVolume;
            }
            else
            {
                btn_MuteVol.BackgroundImage = playingMusic.btn_VolMute.BackgroundImage = Resources.no_audio_gray;
                mp3.player.settings.volume = 0;
            }
            playingMusic.trackBar_Volume.Value = mp3.player.settings.volume;
            mp3.IsMute = !mp3.IsMute;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            mp3.player.controls.previous();
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            mp3.player.controls.next();
            GetInfoSong(mp3.player.currentMedia != null ? mp3.player.currentMedia.sourceURL : "");
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

        private void GetInfoSong(string fileName)
        {
            if (!File.Exists(fileName))
                return;
            if (mp3.player.currentMedia == null)
            {
                lbl_SongName.Text = playingMusic.lbl_SongName.Text = "---";
                lbl_NameSingger.Text = playingMusic.lbl_SinggerName.Text = "---";
                pic_ImageSong.Image = Resources.song_default;
                playingMusic.ChangeImgSong(pic_ImageSong.Image);
                return;
            }
            Mp3File file = new Mp3File(fileName);
            lbl_SongName.Text = playingMusic.lbl_SongName.Text = file.TagHandler.Title;
            lbl_NameSingger.Text = playingMusic.lbl_SinggerName.Text = file.TagHandler.Artist;
            try
            {
                pic_ImageSong.Image = file.TagHandler.Picture != null ? file.TagHandler.Picture : Resources.music_blue1;
            }
            catch
            {
                pic_ImageSong.Image = Resources.music_blue1;
            }
            playingMusic.ChangeImgSong(pic_ImageSong.Image);
        }

        public void ChangeImgSongControlBar(Image img)
        {
            pic_ImageSong.Image = img;
        }

        #region Đổi màu thanh menu
        private void ChangeColorMenuItem(Panel panel, Panel panelSelected, PictureBox picture, Button button, int i)
        {
            panel_User.Visible = false;
            panelSelected.BackColor = Color.FromArgb(0, 66, 255);
            panel.BackColor = button.BackColor = picture.BackColor = button.FlatAppearance.MouseDownBackColor = button.FlatAppearance.MouseOverBackColor = Color.White;
            button.ForeColor = Color.FromArgb(0, 144, 255);
            lbl_Title.Text = button.Text.ToUpper();

            switch (i)
            {
                case 1:
                    picture.Image = Resources.playing_blue1;
                    break;
                case 2:
                    picture.Image = Resources.recent_blue;
                    break;
                case 3:
                    picture.Image = Resources.search_blue1;
                    break;
                case 4:
                    picture.Image = Resources.musical_blue;
                    break;
                case 5:
                    picture.Image = Resources.playlist_blue1;
                    break;
                case 6:
                    picture.Image = Resources.video_blue1;
                    break;
                case 7:
                    picture.Image = Resources.online_blue;
                    ChangeColorMenuOnline();
                    break;
                case 8:
                    picture.Image = Resources.settings_blue1;
                    break;
            }
        }

        private void RestoreColorMenuItem(Panel panel, Panel panelSelected, PictureBox picture, Button button, int i)
        {
            menu_Zing.Visible = menu_Youtube.Visible = false;
            panel.BackColor = panelSelected.BackColor = button.BackColor = picture.BackColor = button.FlatAppearance.MouseDownBackColor = button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 144, 255);
            button.ForeColor = Color.White;

            switch (i)
            {
                case 1:
                    picture.Image = Resources.playing_white;
                    break;
                case 2:
                    picture.Image = Resources.recent_white;
                    break;
                case 3:
                    picture.Image = Resources.search_white;
                    break;
                case 4:
                    picture.Image = Resources.musical_white;
                    break;
                case 5:
                    picture.Image = Resources.playlist_white;
                    break;
                case 6:
                    picture.Image = Resources.video_white;
                    break;
                case 7:
                    picture.Image = Resources.online_white;
                    break;
                case 8:
                    picture.Image = Resources.settings_white;
                    break;
            }
        }

        private void RestoreColorMenu()
        {
            panel_ControlBar.Visible = true;
            pic_SelectZing.Visible = pic_SelectYotube.Visible = false;
            RestoreColorMenuItem(menu_Playing, panel_SelectedPlaying, pic_Playing, btn_Playing, 1);
            RestoreColorMenuItem(menu_Recent, panel_SelectedRecent, pic_Recent, btn_Recent, 2);
            RestoreColorMenuItem(menu_Search, panel_SelectedSearch, pic_Search, btn_Search, 3);
            RestoreColorMenuItem(menu_Song, panel_SelectedSong, pic_Song, btn_Song, 4);
            RestoreColorMenuItem(menu_Playlist, panel_SelectedPlaylist, pic_Playlist, btn_Playlist, 5);
            RestoreColorMenuItem(menu_Video, panel_SelectedVideo, pic_Video, btn_Video, 6);
            RestoreColorMenuItem(menu_Online, panel_SelectedOnline, pic_Online, btn_Online, 7);
            RestoreColorMenuItem(menu_Settings, panel_SelectedSettings, pic_Settings, btn_Settings, 8);
        }

        #endregion

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            this.Text = Program.rm.GetString("appName", Program.culture);
            btn_LogOut.Text = rm.GetString("login", culture);
            btn_Playing.Text = rm.GetString("playing", culture);
            btn_Recent.Text = rm.GetString("recent", culture);
            btn_Search.Text = rm.GetString("search", culture);
            btn_Song.Text = rm.GetString("songs", culture);
            btn_Playlist.Text = rm.GetString("playlists", culture);
            btn_Online.Text = rm.GetString("online", culture);
            btn_Settings.Text = rm.GetString("settings", culture);
            lbl_UserDisplayName.Text = rm.GetString("hello", culture);
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            string _fileName = @"token.json\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user";
            if (File.Exists(_fileName))
            {
                DriverAPI driver = new DriverAPI();
                var data = driver.GetUserProfile();
                try
                {
                    pic_User.Load(data["picture"]);
                    lbl_UserDisplayName.Text = data["name"];
                    btn_LogOut.Text = Program.rm.GetString("logout", Program.culture);
                    btn_LogOut.ForeColor = Color.Red;
                    driver.SaveInfoData(data);
                }
                catch
                {
                    string fileUserImg = @"token.json\user.png";
                    pic_User.Image = File.Exists(fileUserImg) == true ? Image.FromFile(fileUserImg) : Resources.user;
                    string[] array = DriverAPI.ReadDataUser();
                    lbl_UserDisplayName.Text = array[0];
                    btn_LogOut.Text = array[1];
                    btn_LogOut.ForeColor = Color.Red;
                }
            }
        }

        public void RefeshControlBar()
        {
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
            btn_MuteVol.BackgroundImage = mp3.IsMute == true ? Resources.mute_gray : Resources.audio_blue;
        }

        public void SetImageUser(Image img)
        {
            pic_User.Image = img;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            if (!DriverAPI.CheckInternetConnection())
            {

                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string _fileName = @"token.json\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user";
            if (File.Exists(_fileName))
            {
                DialogResult result = MessageBox.Show(Program.rm.GetString("questionSignOut", Program.culture),
                                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                File.Delete(_fileName);

                pic_User.Image = Resources.male_user_blue;
                SetImageUser(Resources.user);
                lbl_UserDisplayName.Text = "Hello!";
                btn_LogOut.Text = Program.rm.GetString("login", Program.culture);
                btn_LogOut.ForeColor = Color.Green;
            }
            else
            {
                DriverAPI driver = new DriverAPI();

                var data = new DriverAPI().GetUserProfile();
                pic_User.Image = Resources.user;
                pic_User.Load(data["picture"]);
                lbl_UserDisplayName.Text = data["name"];
                btn_LogOut.Text = Program.rm.GetString("logout", Program.culture);
                btn_LogOut.ForeColor = Color.Red;
            }
            settings.SettingsMusic_Load(sender, new EventArgs());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (mp3.player.playState == WMPPlayState.wmppsPlaying)
            //{
            //    mp3.player.controls.stop();
            //}
            //foreach (var item in Directory.GetFiles(@"data\ZingMP3_Stream"))
            //{
            //    File.Delete(item);
            //}
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mp3.player.playState == WMPPlayState.wmppsPlaying)
            {
                mp3.player.controls.stop();
            }
            foreach (var item in Directory.GetFiles(@"data\ZingMP3_Stream"))
            {
                File.Delete(item);
            }
        }

        
    }
}