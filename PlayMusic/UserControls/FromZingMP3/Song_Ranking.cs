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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.FromZingMP3
{
    public partial class Song_Ranking : UserControl
    {
        public bool IsDownloaded { get; set; } = false;

        public Model.ZingMP3API.Song song { get; set; }

        private int rank = -1;

        public MainForm main { get; set; }

        private bool IsDowndloading { get; set; } = false;

        private string _folderName = @"D:\MediaApp";

        private string _folderStream = @"data\ZingMP3_Stream";

        private string _fileName;

        private string _url;

        public Song_Ranking(Model.ZingMP3API.Song song, int rank, bool isDownloaded, MainForm main)
        {
            InitializeComponent();
            this.song = song;
            this.rank = rank;
            this.IsDownloaded = isDownloaded;
            this.main = main;
            if (song != null)
            {
                _fileName = String.Join("-", song.name, song.artist) + ".mp3";
                _url = String.Join("/", "http://api.mp3.zing.vn/api/streaming/audio", song.id, 320);
            }
        }
        private void Song_Ranking_Load(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = IsDownloaded == true ? Resources.download_zing_blue : Resources.download_zing_gray;
            if (song != null)
            {
                lbl_Rank.Text = rank.ToString();
                switch(rank)
                {
                    case 1:
                        lbl_Rank.ForeColor = Color.Blue;
                        break;
                    case 2:
                        lbl_Rank.ForeColor = Color.Green;
                        break;
                    case 3:
                        lbl_Rank.ForeColor = Color.Red;
                        break;
                }    
                pic_Song.Load(song.thumbnail);
                lbl_Song.Text = song.title;
                lbl_Singger.Text = song.artists_names;
                TimeSpan t = TimeSpan.FromSeconds(song.duration);
                string time = string.Format("{0:D2}:{1:D2}", t.Hours * 60 + t.Minutes, t.Seconds);
                lbl_Duration.Text = time;
            }    
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
                        var fileTemp = Path.Combine(@"data\ZingMP3_Stream", _fileName);
                        IsDowndloading = true;
                        wc.DownloadFileCompleted += Wc_DownloadFileCompleted; ;
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
            main.btn_PlayPause.BackgroundImage = main.playingMusic.btn_PlayPause.BackgroundImage = Resources.pause_blue;
            IsDowndloading = false;
            btn_Play.BackgroundImage = Resources.play_gray;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string filename = Path.Combine(_folderName, String.Join("-", song.name, song.artists_names) + ".mp3");
            var allSong = new Mp3Player().LoadAllSong(_folderName);
            if(allSong.Contains(filename))
            {
                MessageBox.Show(Program.rm.GetString("songDownloaded",
                    Program.culture), Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            string url = String.Join("/", "http://api.mp3.zing.vn/api/streaming/audio", song.id, 320);
            DownloadingZingMP3 downloading = new DownloadingZingMP3(String.Join("-", song.name, song.artists_names), pic_Song.Image, url, filename);
            downloading.ShowDialog();
            btn_Download.BackgroundImage = Resources.download_zing_blue;
        }

    }
}
