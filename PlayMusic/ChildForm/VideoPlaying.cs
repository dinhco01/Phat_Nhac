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

namespace PlayMusic.ChildForm
{
    public partial class VideoPlaying : Form
    {
        private MainForm main { get; set; }

        bool _isStart = false;

        public VideoPlaying()
        {
            InitializeComponent();
        }

        public VideoPlaying(string url, MainForm main)
        {
            InitializeComponent();
            mp4Player.URL = url;
            this.main = main;
        }

        private void VideoPlaying_Load(object sender, EventArgs e)
        {
            switch(main.mp3.PlayVideoStep)
            {
                case 5:
                    btn_FowardSecond.BackgroundImage = Resources.forward_5_blue;
                    btn_ReplaySecond.BackgroundImage = Resources.replay_5_blue;
                    break;
                case 10:
                    btn_FowardSecond.BackgroundImage = Resources.forward_10_blue;
                    btn_ReplaySecond.BackgroundImage = Resources.replay_10_blue;
                    break;
                case 30:
                    btn_FowardSecond.BackgroundImage = Resources.forward_30_blue;
                    btn_ReplaySecond.BackgroundImage = Resources.replay_30_blue;
                    break;
            }    
            mp4Player.settings.setMode("loop", true);
            mp4Player.Ctlcontrols.play();
            t.Start();
        }

        private void btn_Stop_MouseHover(object sender, EventArgs e)
        {
            btn_Stop.BackgroundImage = Resources.stop_red;
        }

        private void btn_Stop_MouseLeave(object sender, EventArgs e)
        {
            btn_Stop.BackgroundImage = Resources.stop_gray;
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mp4Player.Ctlcontrols.pause();
                btn_PlayPause.BackgroundImage = Resources.play_blue;
                return;
            }
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                mp4Player.Ctlcontrols.play();
                btn_PlayPause.BackgroundImage = Resources.pause_blue;
                return;
            }
            mp4Player.Ctlcontrols.play();
            t.Start();
            btn_PlayPause.BackgroundImage = Resources.pause_blue;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mp4Player.Ctlcontrols.currentPosition -= main.mp3.PlayVideoStep;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mp4Player.Ctlcontrols.currentPosition += main.mp3.PlayVideoStep;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying || mp4Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                mp4Player.Ctlcontrols.stop();
            }
            this.Close();
        }

        private bool _isRepeat = true;

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            if(_isRepeat)
            {
                mp4Player.settings.setMode("loop", true);
                btn_Repeat.BackgroundImage = Resources.repeat_blue;
            }    
            else
            {
                mp4Player.settings.setMode("loop", false);
                btn_Repeat.BackgroundImage = Resources.repeat_gray;
            }
            _isRepeat = !_isRepeat;
        }

        private bool _isMute = false;

        private int _currentVolume = 50;

        private void btn_VolMute_Click(object sender, EventArgs e)
        {
            //_currentVolume = (int)trackBar_Volume.Value;
            if (_isMute)
            {
                btn_VolMute.BackgroundImage = Resources.audio_blue;
                mp4Player.settings.volume = _currentVolume;
            }
            else
            {
                btn_VolMute.BackgroundImage = Resources.no_audio_gray;
                mp4Player.settings.volume = 0;
            }
            trackBar_Volume.Value = mp4Player.settings.volume;
            _isMute = !_isMute;
        }

        private void btn_FullScreen_MouseHover(object sender, EventArgs e)
        {
            btn_FullScreen.BackgroundImage = Resources.full_screen_blue;
        }

        private void btn_FullScreen_MouseLeave(object sender, EventArgs e)
        {
            btn_FullScreen.BackgroundImage = Resources.full_screen_gray;
        }

        private void trackPlaying_Scroll(object sender, ScrollEventArgs e)
        {
            _isStart = true;
            delay.Stop();
            delay.Start();
        }

        private void trackBar_Volume_ValueChanged(object sender, EventArgs e)
        {
            mp4Player.settings.volume = (int)trackBar_Volume.Value;
            lbl_Vol.Text = ((int)trackBar_Volume.Value).ToString() + "%";
            btn_VolMute.BackgroundImage = mp4Player.settings.volume == 0 ? Resources.no_audio_gray : Resources.audio_blue;
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            if (_isStart == true)
            {
                if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    mp4Player.Ctlcontrols.currentPosition = (double)trackPlaying.Value;
                }
            }
            _isStart = false;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (mp4Player == null) return;
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackPlaying.Maximum = (decimal)(mp4Player.currentMedia.duration + 1);

                TimeSpan t = TimeSpan.FromSeconds(mp4Player.currentMedia.duration);
                string answer = string.Format("{0:D2}:{1:D2}", t.Hours * 60 + t.Minutes, t.Seconds);
                lbl_Duration.Text = answer;

                trackPlaying.Value = (decimal)this.mp4Player.Ctlcontrols.currentPosition;

                TimeSpan t2 = TimeSpan.FromSeconds(mp4Player.Ctlcontrols.currentPosition);
                string answer2 = string.Format("{0:D2}:{1:D2}", t2.Hours * 60 + t2.Minutes, t2.Seconds);
                lbl_CurrentPosition.Text = answer2;
            }
        }

        private void btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying || mp4Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                mp4Player.fullScreen = true;
            }
        }

        private void VideoPlaying_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mp4Player.playState == WMPLib.WMPPlayState.wmppsPlaying || mp4Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                mp4Player.Ctlcontrols.stop();
            }
            main.panel_ControlBar.Visible = true;
            main.IsPlayVideo = false;
            main.PlayingVideo = null;
        }
    }
}
