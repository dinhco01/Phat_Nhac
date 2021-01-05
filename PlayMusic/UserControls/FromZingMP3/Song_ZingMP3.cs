using PlayMusic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.FromZingMP3
{
    public partial class Song_ZingMP3 : UserControl
    {
        public bool IsDownloaded { get; set; } = false;

        public Model.ZingMP3API.ZSong song { get; set; }

        public MainForm main { get; set; }

        private string _folderName = @"D:\MediaApp";

        private string _folderStream = @"data\ZingMP3_Stream";

        private string _fileName;

        private string _url;

        private bool IsDowndloading { get; set; } = false;

        public Song_ZingMP3(Model.ZingMP3API.ZSong song, bool isDownloaded, MainForm main)
        {
            InitializeComponent();
            this.song = song;
            IsDownloaded = isDownloaded;
            this.main = main;
            if(song != null)
            {
                _fileName = String.Join("-", song.name, song.artist) + ".mp3";
                _url = String.Join("/", "http://api.mp3.zing.vn/api/streaming/audio", song.id, 320);
            }    
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (main.mp3.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                main.mp3.player.controls.stop();
            }
            try
            {
                if (!String.IsNullOrEmpty(_url) && !String.IsNullOrEmpty(_fileName))
                {
                    using (WebClient wc = new WebClient())
                    {
                        var fileTemp = Path.Combine(_folderStream, _fileName); 
                        IsDowndloading = true;
                        wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                        wc.DownloadFileAsync(new Uri(_url), fileTemp);
                        btn_Play.BackgroundImage = Resources.loader;
                    }
                }
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("cantPlaySongNow", Program.culture),
                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            main.mp3.PlaySong(Path.Combine(_folderStream, _fileName));
            main.RefeshControlBar();
            main.playingMusic.PlayingMusic_Load(sender, new EventArgs());
            IsDowndloading = false;
            btn_Play.BackgroundImage = Resources.play_gray;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            var allSong = new Mp3Player().LoadAllSong(_folderName);
            var saveFile = Path.Combine(_folderName, _fileName);
            if (allSong.Contains(saveFile))
            {
                MessageBox.Show(Program.rm.GetString("songDownloaded",
                    Program.culture), Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string url = String.Join("/", "http://api.mp3.zing.vn/api/streaming/audio", song.id, 320);
            DownloadingZingMP3 downloading = new DownloadingZingMP3(String.Join("-", song.name, song.artist), pic_Song.Image, url, Path.Combine(_folderName, _fileName));
            downloading.ShowDialog();
            btn_Download.BackgroundImage = Resources.download_zing_blue;
        }

        #region Đổi màu button
        private void btn_Play_MouseHover(object sender, EventArgs e)
        {
            btn_Play.BackgroundImage = Resources.play_blue;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            if (IsDowndloading)
                return;
            btn_Play.BackgroundImage = Resources.play_gray;
        }

        private void btn_Download_MouseHover(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = Resources.download_zing_blue;
        }

        private void btn_Download_MouseLeave(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = IsDownloaded == false ? Resources.download_zing_gray : Resources.download_zing_blue;
        }
        #endregion

        private void Song_ZingMP3_Load(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = IsDownloaded == true ? Resources.download_zing_blue : Resources.download_zing_gray;
            if (song != null)
            {
                pic_Song.Load("https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/" + song.thumb);
                lbl_Song.Text = song.name;
                lbl_Singger.Text = song.artist;
                TimeSpan t = TimeSpan.FromSeconds(double.Parse(song.duration));
                string time = string.Format("{0:D2}:{1:D2}", t.Hours * 60 + t.Minutes, t.Seconds);
                lbl_Duration.Text = time;
            }
        }
    }
}
