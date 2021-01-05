using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.FromZingMP3
{
    public partial class DownloadingZingMP3 : Form
    {
        public string Url { get; set; }

        public string FileName { get; set; }

        public string Name { get; set; }

        public Image Img { get; set; }

        public DownloadingZingMP3(string name, Image img, string url, string fileName)
        {
            InitializeComponent();
            LoadLanguage();
            this.Url = url;
            this.FileName = fileName;
            this.Name = name;
            this.Img = img;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("downloading", culture);
        }

        private void DownloadingZingMP3_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_Title.Text = Name;
                pic_Thumbnail.Image = Img;
                if (!String.IsNullOrEmpty(Url) && !String.IsNullOrEmpty(FileName))
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileCompleted += wc_completed;
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        wc.DownloadFileAsync(new Uri(Url), FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("downloadFailed", Program.culture),
                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void wc_completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show(Program.rm.GetString("downloadComplete", Program.culture),
                                Program.rm.GetString("notification"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar_Downloading.Value = e.ProgressPercentage;
            lbl_PercentDownloaded.Text = e.ProgressPercentage + "%";

            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            lbl_MemoryProgress.Text = String.Format("{0:0.00}", bytesIn / (1024.0 * 1024.0)) + "/" + String.Format("{0:0.00}", totalBytes / (1024.0 * 1024.0)) + " MB";
        }
    }
}