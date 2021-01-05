using PlayMusic.Model;
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

namespace PlayMusic.UserControls.Settings
{
    public partial class RestoreAndBackupSongs : Form
    {
        private bool IsBackup { get; set; } = true;

        public RestoreAndBackupSongs(bool isBackup)
        {
            InitializeComponent();
            this.IsBackup = isBackup;
            LoadLanguage();

            lbl_Progress.Visible = false;
            progressBar_Downloading.Visible = false;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            if (!IsBackup)
            {
                Text = rm.GetString("downToComputer", culture);
                lbl_Title.Text = rm.GetString("restoring", culture);
            }
            else
            {
                Text = rm.GetString("upToDriver", culture);
                lbl_Title.Text = rm.GetString("backingup", culture);
            }
            lbl_NameSongDownloading.Text = rm.GetString("getInfo", culture);
        }

        private void RestoreAndBackupSongs_Load(object sender, EventArgs e)
        {

        }

        private void DownloadAllMusicFromDriver()
        {
            var allSong = new Mp3Player().LoadAllSong(@"D:\MediaApp");
            var driver = new DriverAPI();
            string folderId = String.Empty;
            var songs = driver.LoadAllSongIdInFolder(out folderId);
            int count = 0;
            Dictionary<string, string> down = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in songs)
            {
                if (!allSong.Contains(Path.Combine(@"D:\MediaApp", item.Value)))
                {
                    down.Add(item.Key, item.Value);
                    count++;
                }
            }
            lbl_Progress.Text = $"{0}/{count} " + Program.rm.GetString("songs", Program.culture).ToLower();
            if (count == 0)
            {
                MessageBox.Show(Program.rm.GetString("restored", Program.culture),
                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            lbl_Progress.Visible = progressBar_Downloading.Visible = true;
            progressBar_Downloading.Maximum = count;
            int i = 0;
            progressBar_Downloading.Value = 1;
            foreach (KeyValuePair<string, string> item in down)
            {
                lbl_NameSongDownloading.Text = item.Value;
                driver.DownloadFile(item.Key, item.Value, @"D:\MediaApp");
                try
                {
                    i++;
                    lbl_Progress.Text = $"{i}/{count} " + Program.rm.GetString("songs", Program.culture).ToLower();
                    progressBar_Downloading.Value++;
                }
                catch { }
            }
            MessageBox.Show(Program.rm.GetString("restored", Program.culture) +
                "\n" + Program.rm.GetString("added", Program.culture) + $" {count} " + Program.rm.GetString("songs", Program.culture).ToLower(),
                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void UploadAllMusicToDriver()
        {
            var allSong = new Mp3Player().LoadAllSong(@"D:\MediaApp");
            var driver = new DriverAPI();
            string folderId = String.Empty;
            var songs = driver.LoadAllSongNameInFolder(out folderId);

            int count = 0;
            Dictionary<string, string> up = new Dictionary<string, string>();

            foreach (var item in allSong)
            {
                var nameSongs = Path.GetFileName(item);
                if (!songs.Contains(nameSongs))
                {
                    up.Add(nameSongs, item);
                    count++;
                }
            }

            lbl_Progress.Text = $"{0}/{count} " + Program.rm.GetString("songs", Program.culture).ToLower();
            if (count == 0)
            {
                MessageBox.Show(Program.rm.GetString("backedup", Program.culture),
                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            lbl_Progress.Visible = progressBar_Downloading.Visible = true;
            progressBar_Downloading.Maximum = count;
            int i = 0;
            progressBar_Downloading.Value = 1;
            foreach (KeyValuePair<string, string> item in up)
            {
                lbl_NameSongDownloading.Text = item.Key;
                driver.UploadFile(folderId, item.Key, item.Value, "audio/mpeg");
                try
                {
                    i++;
                    lbl_Progress.Text = $"{i}/{count} " + Program.rm.GetString("songs", Program.culture).ToLower();
                    progressBar_Downloading.Value++;
                }
                catch { }
            }
            MessageBox.Show(Program.rm.GetString("backedup", Program.culture) +
                "\n" + Program.rm.GetString("added", Program.culture) + $" {count} " + Program.rm.GetString("songs", Program.culture).ToLower(),
                Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void RestoreAndBackupSongs_Shown(object sender, EventArgs e)
        {
            if (!IsBackup)
            {
                DownloadAllMusicFromDriver();
            }
            else
            {
                UploadAllMusicToDriver();
            }
        }
    }
}
