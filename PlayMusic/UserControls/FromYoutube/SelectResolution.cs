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
using YoutubeExplode;
using YoutubeExplode.Channels;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.ClosedCaptions;
using YoutubeExplode.Videos.Streams;

namespace PlayMusic.UserControls.FromYoutube
{
    public partial class SelectResolution : Form
    {
        private readonly YoutubeClient _youtube;

        public bool IsBusy;

        public string Query;

        public Video Video;

        public IReadOnlyList<MuxedStreamInfo> MuxedStreamInfos;

        public IReadOnlyList<AudioOnlyStreamInfo> AudioOnlyStreamInfos;

        public IReadOnlyList<VideoOnlyStreamInfo> VideoOnlyStreamInfos;

        public List<VideoResolutionItem> ucResolutions = new List<VideoResolutionItem>();

        public bool IsProgressIndeterminate;

        private string folderName = @"D:\MediaApp\YoutubeDownload";

        public int Selected { get; set; } = 0;

        public SelectResolution(string url)
        {
            InitializeComponent();
            LoadLanguage();
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            this.Query = url;
            _youtube = new YoutubeClient();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("downloading", culture);
            lbl_Title.Text = rm.GetString("selectResolution", culture);
            lbl_TitleVideo.Text = rm.GetString("analyzingVideo", culture);
        }

        private void SelectResolution_Load(object sender, EventArgs e)
        {
            PullData();
        }

        public void RestoreColor()
        {
            foreach(var item in ucResolutions)
            {
                item.BackColor = Color.White;
            }    
        }

        private async void PullData()
        {
            try
            {
                IsBusy = true;
                IsProgressIndeterminate = true;
                Video = null;
                MuxedStreamInfos = null;
                AudioOnlyStreamInfos = null;
                VideoOnlyStreamInfos = null;
                var videoId = new VideoId(Query);
                var streamManifest = await _youtube.Videos.Streams.GetManifestAsync(videoId);
                Video = await _youtube.Videos.GetAsync(videoId);
                MuxedStreamInfos = streamManifest.GetMuxed().ToArray();
                AudioOnlyStreamInfos = streamManifest.GetAudioOnly().ToArray();
                VideoOnlyStreamInfos = streamManifest.GetVideoOnly().ToArray();

                pic_Thumnail.Load(Video.Thumbnails.StandardResUrl);
                lbl_TitleVideo.Text = Video.Title;

                AddUCControl(MuxedStreamInfos, AudioOnlyStreamInfos, VideoOnlyStreamInfos);
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("cantGetInfo", Program.culture),
                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            finally
            {
                IsBusy = false;
                IsProgressIndeterminate = false;
            }
        }

        private void AddUCControl(IReadOnlyList<MuxedStreamInfo> MuxedStreamInfos, IReadOnlyList<AudioOnlyStreamInfo> AudioOnlyStreamInfos, IReadOnlyList<VideoOnlyStreamInfo> VideoOnlyStreamInfos)
        {
            int i = 0;
            foreach (var item in MuxedStreamInfos)
            {
                 
                string line1 = String.Join(" - ", item.VideoQualityLabel, item.Container, item.VideoCodec);
                string line2 = item.Size.ToString();
                VideoResolutionItem uc = new VideoResolutionItem(this, i, item)
                {
                    Title = line1,
                    Memory = line2
                };
                if (i == 0)
                {
                    uc.SelectVideoDownload();
                }
                ucResolutions.Add(uc);
                panel_Content.Controls.Add(uc);
                i++;
            }
            foreach (var item in VideoOnlyStreamInfos)
            {
                string line1 = String.Join(" - ", item.VideoQualityLabel, item.Container, item.VideoCodec);
                string line2 = item.Size.ToString();
                VideoResolutionItem uc = new VideoResolutionItem(this, i, item)
                {
                    Title = line1,
                    Memory = line2
                };
                ucResolutions.Add(uc);
                panel_Content.Controls.Add(uc);
                i++;
            }
            foreach (var item in AudioOnlyStreamInfos)
            {
                string line1 = String.Join(" - ", item.Container, item.AudioCodec);
                string line2 = item.Size.ToString();
                VideoResolutionItem uc = new VideoResolutionItem(this, i, item)
                {
                    Title = line1,
                    Memory = line2
                };
                ucResolutions.Add(uc);
                panel_Content.Controls.Add(uc);
                i++;
            }

            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Downloading downloading = new Downloading(pic_Thumnail.Image, lbl_TitleVideo.Text, _youtube, ucResolutions[Selected].streamInfo);
                downloading.ShowDialog();
            }
            catch { }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
