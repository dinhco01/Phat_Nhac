using PlayMusic.Properties;
using PlayMusic.UserControls.VideoPlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class VideosPlay : Form
    {
        private string folderName = @"D:\MediaApp\Video";

        public MainForm main { get; set; }

        public VideosPlay()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_LableListVideo.Text = rm.GetString("videoPlaylist", culture);
        }

        private void btn_Local_Click(object sender, EventArgs e)
        {
            folderName = @"D:\MediaApp\Video";
            VideosPlay_Load(sender, new EventArgs());
        }

        private void btn_YoutubeDownloader_Click(object sender, EventArgs e)
        {
            folderName = @"D:\MediaApp\YoutubeDownload";
            VideosPlay_Load(sender, new EventArgs());
        }

        private void btn_BrowerFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.SelectedPath == folderName)
                    return;
                folderName = open.SelectedPath;
                VideosPlay_Load(sender, new EventArgs());
            }
        }

        public void LoadListVideo()
        {
            string pathThumbnail = @"data\thumbnail";
            if (!Directory.Exists(pathThumbnail))
            {
                var create = Directory.CreateDirectory(pathThumbnail);
            }
            try
            {
                var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                int i = Directory.GetFiles(pathThumbnail).Count();
                panel_ContainVideo.Invoke((MethodInvoker)(() => panel_ContainVideo.Controls.Clear()));
                foreach (var fileName in Directory.GetFiles(folderName))
                {
                    var array = fileName.Split(new char[] { '.' });
                    if (array.Last() == "mp4")
                    {
                        var pathTemp = Path.Combine(pathThumbnail, $"{i}.jpg");

                        Model.Video vd = new Model.Video(fileName);

                        ffMpeg.GetVideoThumbnail(fileName, pathTemp, 10);
                        vd.Thumbnail = Image.FromFile(pathTemp);
                        panel_ContainVideo.Invoke((MethodInvoker)(() => panel_ContainVideo.Controls.Add(new UC_VideoItem(vd, main))));
                        i++;
                    }
                }
            }
            catch { }
        }

        public void VideosPlay_Load(object sender, EventArgs e)
        {
            using (FormWaiting wait = new FormWaiting(LoadListVideo))
            {
                main.panel_ChildForm.Visible = false;
                wait.Location = new Point(main.Location.X + main.panel_Main.Width - 17 + Width / 2, main.Location.Y + Height / 2);
                wait.ShowDialog();
                main.panel_ChildForm.Visible = true;
            }
            ChangeColor();
        }

        private void ChangeColor()
        {
            switch (folderName)
            {
                case @"D:\MediaApp\Video":
                    btn_Local.BackgroundImage = Resources.video_local_blue;
                    btn_YoutubeDownloader.BackgroundImage = Resources.youtube_gray;
                    btn_BrowerFolder.BackgroundImage = Resources.browse_folder_gray;
                    break;
                case @"D:\MediaApp\YoutubeDownload":
                    btn_Local.BackgroundImage = Resources.video_local_gray;
                    btn_YoutubeDownloader.BackgroundImage = Resources.youtube_blue;
                    btn_BrowerFolder.BackgroundImage = Resources.browse_folder_gray;
                    break;
                default:
                    btn_Local.BackgroundImage = Resources.video_local_gray;
                    btn_YoutubeDownloader.BackgroundImage = Resources.youtube_gray;
                    btn_BrowerFolder.BackgroundImage = Resources.browse_folder_blue;
                    break;
            }
        }

        #region Đổi màu button

        private void btn_BrowerFolder_MouseHover(object sender, EventArgs e)
        {
            btn_BrowerFolder.BackgroundImage = Resources.browse_folder_blue;
        }

        private void btn_BrowerFolder_MouseLeave(object sender, EventArgs e)
        {
            btn_BrowerFolder.BackgroundImage = (folderName != @"D:\MediaApp\YoutubeDownload") && (folderName != @"D:\MediaApp\Video") ? Resources.browse_folder_blue : Resources.browse_folder_gray;
        }

        //public static Bitmap GetThumbnail(string video, string thumbnail)
        //{
        //    var cmd = "ffmpeg  -itsoffset -1  -i " + '"' + video + '"' + " -vcodec mjpeg -vframes 1 -an -f rawvideo -s 320x240 " + '"' + thumbnail + '"';

        //    var startInfo = new ProcessStartInfo
        //    {
        //        WindowStyle = ProcessWindowStyle.Hidden,
        //        FileName = "cmd.exe",
        //        Arguments = "/C " + cmd
        //    };

        //    var process = new Process
        //    {
        //        StartInfo = startInfo
        //    };

        //    process.Start();
        //    process.WaitForExit(5000);
        //    using (var ms = new MemoryStream(File.ReadAllBytes(thumbnail)))
        //    {
        //        return (Bitmap)Image.FromStream(ms);
        //        //var ms = new MemoryStream(File.ReadAllBytes(thumbnail));
        //    }
        //}

        private void btn_YoutubeDownloader_MouseHover(object sender, EventArgs e)
        {
            btn_YoutubeDownloader.BackgroundImage = Resources.youtube_blue;
        }

        private void btn_YoutubeDownloader_MouseLeave(object sender, EventArgs e)
        {
            btn_YoutubeDownloader.BackgroundImage = folderName == @"D:\MediaApp\YoutubeDownload" ? Resources.youtube_blue : Resources.youtube_gray;
        }

        private void btn_Local_MouseHover(object sender, EventArgs e)
        {
            btn_Local.BackgroundImage = Resources.video_local_blue;
        }

        private void btn_Local_MouseLeave(object sender, EventArgs e)
        {
            btn_Local.BackgroundImage = folderName == @"D:\MediaApp\Video" ? Resources.video_local_blue : Resources.video_local_gray;
        }
        #endregion
    }
}
