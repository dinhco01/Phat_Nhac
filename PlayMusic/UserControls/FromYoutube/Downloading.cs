using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace PlayMusic.UserControls.FromYoutube
{
    public partial class Downloading : Form
    {
        public YoutubeClient Youtube { get; set; }

        public Image image { get; set; }

        public string text { get; set; }

        public IStreamInfo streamInfo;

        public Downloading(Image img, string text, YoutubeClient youtube, IStreamInfo streamInfo)
        {
            InitializeComponent();
            LoadLanguage();
            this.image = img;
            this.text = text;
            this.streamInfo = streamInfo;
            this.Youtube = youtube;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("downloading", culture);
        }

        private void Downloading_Load(object sender, EventArgs e)
        {
            pic_Thumbnail.Image = image;
            lbl_Title.Text = text;
            lbl_PercentDownloaded.Text = "0%";
            lbl_MemoryProgress.Text = $"0/{streamInfo.Size}";
            DownloadStream(streamInfo);
        }
        private async void DownloadStream(IStreamInfo streamInfo)
        {
            try
            {
                var defaultFileName = SanitizeFileName($"{lbl_Title.Text}.{streamInfo.Container.Name}");
                var filePath = PromptSaveFilePath(defaultFileName, $"{streamInfo.Container.Name} files|*.{streamInfo.Container.Name}|All Files|*.*");
                if (string.IsNullOrWhiteSpace(filePath))
                    return;
                var progressHandler = new Progress<double>(p =>
                {
                    progressBar_Downloading.Value = (int)(p * 100);
                    lbl_PercentDownloaded.Text = Math.Round(p * 100, 2) + "%";
                    lbl_MemoryProgress.Text = $"{Math.Round(p * streamInfo.Size.TotalMegaBytes, 2)}/{streamInfo.Size}";
                });
                await Youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, progressHandler);
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("downloadFailed", Program.culture),
                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            MessageBox.Show(Program.rm.GetString("downloadComplete", Program.culture),
                                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private string SanitizeFileName(string fileName)
        {
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
                fileName = fileName.Replace(invalidChar, '_');

            return fileName;
        }

        private string PromptSaveFilePath(string defaultFileName, string filter)
        {
            var dialog = new SaveFileDialog
            {
                FileName = defaultFileName,
                Filter = filter,
                AddExtension = true,
                DefaultExt = Path.GetExtension(defaultFileName) ?? ""
            };
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
            if (result == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }
    }
}
