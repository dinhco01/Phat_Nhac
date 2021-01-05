using PlayMusic.Model;
using PlayMusic.Properties;
using PlayMusic.UserControls.Settings;
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

namespace PlayMusic.ChildForm
{
    public partial class SettingsMusic : Form
    {
        public MainForm main { get; set; }

        public bool IsLogin { get; set; } = false;

        public bool IsDownLoadFormDriver { get; set; } = false;

        public bool IsUploadToDriver { get; set; } = false;

        public bool IsTimer { get; set; } = false;

        private string _fileName = @"token.json\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user";

        public SettingsMusic()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;

            lbl_IntroAccount.Text = rm.GetString("accountInfoSettings", culture);
            btn_LoginLogout.Text = File.Exists(_fileName) == false ? rm.GetString("login", culture) : rm.GetString("logout", culture);
            btn_ChangeAccount.Text = rm.GetString("changeAccount", culture);
            lbl_DownloadSong.Text = rm.GetString("restoreSongs", culture);
            lbl_AccountRequire1.Text = rm.GetString("needAccount", culture);;
            lbl_AccountRequire2.Text = rm.GetString("needAccount", culture);;
            lbl_UploadSong.Text = rm.GetString("backupSongs", culture);
            lbl_TimerLableOff.Text = rm.GetString("timerOff", culture);
            lbl_TimerLablePlay.Text = rm.GetString("timerPlay", culture);
            lbl_Foward.Text = rm.GetString("step", culture);
            lbl_LableAccount.Text = rm.GetString("account", culture);
            lbl_LableSetting.Text = rm.GetString("settings", culture);
            lbl_Second.Text = rm.GetString("second", culture);
            lbl_MinuteOff.Text = lbl_MinutePlay.Text = rm.GetString("minute", culture);
            lbl_LanguageCurrent.Text = Program.culture.Name == "vi-VN" == true ? rm.GetString("vietnamese", culture) : lbl_LanguageCurrent.Text = rm.GetString("english", culture);
            lbl_SelectLangApp.Text = rm.GetString("selectLanguageApp", culture);
            lbl_RestoreApp.Text = rm.GetString("resetApp", culture);
            btn_RestoreApp.Text = rm.GetString("reset", culture);
        }

        private void btn_LoginLogout_Click(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                DialogResult result = MessageBox.Show(Program.rm.GetString("questionSignOut", Program.culture),
                                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                File.Delete(_fileName);
                string fileNameImgUser = @"token.json\user.png";
                string fileNameInfoData = @"token.json\UserInfo.txt";
                if (File.Exists(fileNameImgUser))
                {
                    File.Delete(fileNameImgUser);
                }
                if (File.Exists(fileNameInfoData))
                {
                    File.Delete(fileNameInfoData);
                }

                pic_User.Image = Resources.male_user_blue;
                main.SetImageUser(Resources.user);
                main.lbl_UserDisplayName.Text = Program.rm.GetString("hello", Program.culture);
                main.btn_LogOut.Text = Program.rm.GetString("login", Program.culture);
                main.btn_LogOut.ForeColor = Color.Green;

                lbl_Name.Visible = lbl_Email.Visible = btn_ChangeAccount.Visible = false;
                lbl_IntroAccount.Visible = true;
                btn_LoginLogout.Text = Program.rm.GetString("login", Program.culture);
            }
            else
            {
                DriverAPI driver = new DriverAPI();
                
                lbl_Name.Visible = lbl_Email.Visible = btn_ChangeAccount.Visible = true;
                lbl_IntroAccount.Visible = false;
                btn_LoginLogout.Text = Program.rm.GetString("logout", Program.culture);
            }
            SettingsMusic_Load(sender, new EventArgs());
            main.MainForm_Load(sender, new EventArgs());
        }

        private void btn_ChangeAccount_Click(object sender, EventArgs e)
        {
            if (!DriverAPI.CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                    Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (File.Exists(_fileName))
            {
                DialogResult result = MessageBox.Show(Program.rm.GetString("questionChangeAccount", Program.culture),
                                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                File.Delete(_fileName);
                string fileNameImgUser = @"token.json\user.png";
                string fileNameInfoData = @"token.json\UserInfo.txt";
                if (File.Exists(fileNameImgUser))
                {
                    File.Delete(fileNameImgUser);
                }
                if (File.Exists(fileNameInfoData))
                {
                    File.Delete(fileNameInfoData);
                }
                SettingsMusic_Load(sender, new EventArgs());
                main.MainForm_Load(sender, new EventArgs());
                if (btn_LoginLogout.Text == Program.rm.GetString("login", Program.culture))
                {
                    btn_LoginLogout_Click(sender, new EventArgs());
                }
            }
            lbl_LableAccount_Click(sender, new EventArgs());
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            RestoreAndBackupSongs restore = new RestoreAndBackupSongs(false);
            restore.ShowDialog();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            RestoreAndBackupSongs backup = new RestoreAndBackupSongs(true);
            backup.ShowDialog();
        }
        private void btn_Timer_Click(object sender, EventArgs e)
        {
            if (!t.Enabled)
            {
                btn_TimerOff.BackgroundImage = Resources.toggle_on_blue;
                cb_TimerOff.Visible = lbl_MinuteOff.Visible = false;
                try
                {
                    second = int.Parse(cb_TimerOff.Text) * 60;
                    TimeSpan t = TimeSpan.FromSeconds(second);
                    string time = string.Format(Program.rm.GetString("remaining", Program.culture) +
                                       " {0:D2} " + Program.rm.GetString("minute", Program.culture) + " {1:D2} " + Program.rm.GetString("second", Program.culture),
                                       t.Hours * 60 + t.Minutes, t.Seconds);
                    lbl_TimerOff.Text = time;
                }
                catch
                {
                    MessageBox.Show(Program.rm.GetString("errorTime", Program.culture),
                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lbl_TimerOff.Visible = true;
                t.Start();
            }
            else
            {
                btn_TimerOff.BackgroundImage = Resources.toggle_off_blue;
                cb_TimerOff.Visible = lbl_MinuteOff.Visible = true;
                lbl_TimerOff.Visible = false;
                t.Stop();
                second = 0;
            }
        }

        private void LoadPlaylist()
        {
            lbl_TimerPlay.Visible = false;
            List<string> playlists = new List<string>()
            {
                Program.rm.GetString("allSongs", Program.culture),
                Program.rm.GetString("favoriteSongs", Program.culture)
            };
            foreach (var item in Program.dataPlaylist.Playlists)
            {
                playlists.Add(item.NamePlaylist);
            }
            cb_SelectPlaylist.DataSource = playlists;
            cb_SelectPlaylist.Visible = false;
        }

        public void SettingsMusic_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
            if (File.Exists(_fileName))
            {
                lbl_DownloadSong.ForeColor = lbl_UploadSong.ForeColor = Color.Black;
                lbl_AccountRequire1.Visible = lbl_AccountRequire2.Visible = false;
                btn_Download.Visible = btn_Upload.Visible = true;
                pic_Download.Image = Resources.download_from_cloud_blue;
                pic_Upload.Image = Resources.upload_to_the_cloud_blue;

                DriverAPI driver = new DriverAPI();
                var data = driver.GetUserProfile();
                try
                {
                    pic_User.Load(data["picture"]);
                    lbl_Email.Text = data["email"];
                    lbl_Name.Text = data["name"];
                    driver.SaveInfoData(data);
                }
                catch
                {
                    string fileUserImg = @"token.json\user.png";
                    pic_User.Image = File.Exists(fileUserImg) == true ? Image.FromFile(fileUserImg) : Resources.male_user_blue;
                    string[] array = DriverAPI.ReadDataUser();
                    lbl_Name.Text = array[0];
                    lbl_Email.Text = array[1];
                }
                lbl_Name.Visible = lbl_Email.Visible = btn_ChangeAccount.Visible = true;
                lbl_IntroAccount.Visible = false;
                btn_LoginLogout.Text = Program.rm.GetString("logout", Program.culture);
            }
            else
            {
                lbl_DownloadSong.ForeColor = lbl_UploadSong.ForeColor = lbl_AccountRequire1.ForeColor = lbl_AccountRequire2.ForeColor = Color.FromArgb(169, 169, 169);
                lbl_AccountRequire1.Visible = lbl_AccountRequire2.Visible = true;
                btn_Download.Visible = btn_Upload.Visible = false;
                pic_Download.Image = Resources.download_from_cloud_gray;
                pic_Upload.Image = Resources.upload_to_the_cloud_gray;

                pic_User.Image = Resources.male_user_blue;
                lbl_Name.Visible = lbl_Email.Visible = btn_ChangeAccount.Visible = false;
                lbl_IntroAccount.Visible = true;
                btn_LoginLogout.Text = Program.rm.GetString("login", Program.culture);
            }

            if (t.Enabled)
            {
                btn_TimerOff.BackgroundImage = Resources.toggle_on_blue;
                cb_TimerOff.Visible = lbl_MinuteOff.Visible = false;
                lbl_TimerOff.Visible = true;
            }
            else
            {
                btn_TimerOff.BackgroundImage = Resources.toggle_off_blue;
                cb_TimerOff.Visible = lbl_MinuteOff.Visible = true;
                lbl_TimerOff.Visible = false;
            }
        }

        private void cb_TimeForward_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_TimeForward.SelectedIndex)
            {
                case 0:
                    main.mp3.PlayVideoStep = 5;
                    break;
                case 1:
                    main.mp3.PlayVideoStep = 10;
                    break;
                case 2:
                    main.mp3.PlayVideoStep = 30;
                    break;
            }
        }

        private long second = 0;

        public void lbl_LableAccount_Click(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                var data = new DriverAPI().GetUserProfile();
                pic_User.Load(data["picture"]);
                lbl_Email.Text = data["email"];
                lbl_Name.Text = main.lbl_UserDisplayName.Text = data["name"];

                main.SetImageUser(pic_User.Image);
                main.btn_LogOut.Text = Program.rm.GetString("logout", Program.culture);
                main.btn_LogOut.ForeColor = Color.Red;
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (second <= 0)
            {
                if (main.mp3.player.playState == WMPLib.WMPPlayState.wmppsPaused || main.mp3.player.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    return;
                }
                main.PausePlayMusic();
                btn_Timer_Click(sender, new EventArgs());
                return;
            }
            second--;
            TimeSpan t = TimeSpan.FromSeconds(second);
            string time = string.Format(Program.rm.GetString("remaining", Program.culture) +
                                       " {0:D2} " + Program.rm.GetString("minute", Program.culture) + " {1:D2} " + Program.rm.GetString("second", Program.culture),
                                       t.Hours * 60 + t.Minutes, t.Seconds);
            lbl_TimerOff.Text = time;
        }

        private void cb_Timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_TimerPlay_Click(object sender, EventArgs e)
        {
            if (!tPlay.Enabled)
            {
                btn_TimerPlay.BackgroundImage = Resources.toggle_on_blue;
                cb_TimerPlay.Visible = lbl_MinutePlay.Visible = false;
                try
                {
                    secondPlayCount = int.Parse(cb_TimerPlay.Text) * 60;
                    TimeSpan t = TimeSpan.FromSeconds(secondPlayCount);
                    string time = string.Format(Program.rm.GetString("remaining", Program.culture) +
                                       " {0:D2} " + Program.rm.GetString("minute", Program.culture) + " {1:D2} " + Program.rm.GetString("second", Program.culture),
                                       t.Hours * 60 + t.Minutes, t.Seconds);
                    lbl_TimerPlay.Text = time;

                }
                catch
                {
                    MessageBox.Show(Program.rm.GetString("errorTime", Program.culture),
                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lbl_TimerPlay.Visible = true;
                tPlay.Start();
            }
            else
            {
                btn_TimerPlay.BackgroundImage = Resources.toggle_off_blue;
                cb_TimerPlay.Visible = lbl_MinutePlay.Visible = true;
                lbl_TimerPlay.Visible = false;
                tPlay.Stop();
                second = 0;
            }
            cb_SelectPlaylist.Visible = !cb_SelectPlaylist.Visible;
        }

        private long secondPlayCount = 0;
        private void tPlay_Tick(object sender, EventArgs e)
        {
            if (secondPlayCount <= 0)
            {
                if (cb_SelectPlaylist.SelectedIndex == 0)
                {
                    var data = new Mp3Player().LoadAllSong(@"D:\MediaApp");
                    main.mp3.PlayListSong(data);
                    main.btn_PlayPause.BackgroundImage = main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                }
                else if (cb_SelectPlaylist.SelectedIndex == 1)
                {
                    var data = new Mp3Player().LoadAllFavoriteSong(@"data\favoriteSongs.txt");
                    main.mp3.PlayListSong(data);
                    main.btn_PlayPause.BackgroundImage = main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                }
                else
                {
                    var data = Program.dataPlaylist.Playlists.FirstOrDefault(x => x.NamePlaylist == cb_SelectPlaylist.Text);
                    if (data != null)
                    {
                        main.mp3.PlayListSong(data.Songs);
                        main.btn_PlayPause.BackgroundImage = main.btn_PlayPause.BackgroundImage = Resources.pause_blue;
                    }
                }
                btn_TimerPlay_Click(sender, new EventArgs());
                return;
            }
            secondPlayCount--;
            TimeSpan t = TimeSpan.FromSeconds(secondPlayCount);
            string time = string.Format(Program.rm.GetString("remaining", Program.culture) +
                                       " {0:D2} " + Program.rm.GetString("minute", Program.culture) + " {1:D2} " + Program.rm.GetString("second", Program.culture),
                                       t.Hours * 60 + t.Minutes, t.Seconds);
            lbl_TimerPlay.Text = time;
        }

        private void cb_SelectPlaylist_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Download_MouseHover(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = Resources.synchronize_blue;
        }

        private void btn_Download_MouseLeave(object sender, EventArgs e)
        {
            btn_Download.BackgroundImage = Resources.synchronize_gray;
        }

        private void btn_Upload_MouseHover(object sender, EventArgs e)
        {
            btn_Upload.BackgroundImage = Resources.synchronize_blue;
        }

        private void btn_Upload_MouseLeave(object sender, EventArgs e)
        {
            btn_Upload.BackgroundImage = Resources.synchronize_gray;
        }

        private void btn_ChangeLanguage_MouseHover(object sender, EventArgs e)
        {
            btn_ChangeLanguage.BackgroundImage = Resources.change_blue;
        }

        private void btn_ChangeLanguage_MouseLeave(object sender, EventArgs e)
        {
            btn_ChangeLanguage.BackgroundImage = Resources.change_gray;
        }

        private void btn_ChangeLanguage_Click(object sender, EventArgs e)
        {
            SelectLanguage select = new SelectLanguage(main);
            select.ShowDialog();
            main.lbl_Title.Text = Program.rm.GetString("settings", Program.culture).ToUpper();
            main.Text = Program.rm.GetString("appName", Program.culture);
        }

        private void btn_RestoreApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Program.rm.GetString("questionReset", Program.culture),
                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //Xóa dữ liệu nghe nhạc
                string eventFile = "data\\event.log";
                string favoriteFile = "data\\favoriteSongs.txt";
                string playlistFile = "data\\playlist.json";
                string recentFile = "data\\recent.json";
                if (File.Exists(eventFile))
                {
                    File.Delete(eventFile);
                }
                if (File.Exists(favoriteFile))
                {
                    File.Delete(favoriteFile);
                }
                if (File.Exists(playlistFile))
                {
                    File.Delete(playlistFile);
                }
                if (File.Exists(recentFile))
                {
                    File.Delete(recentFile);
                }
                //Xóa thông tin tài khoản
                string accountFile = "token.json\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user";
                string userFile = "token.json\\user.png";
                string userInfoFile = "token.json\\UserInfo.txt";
                if (File.Exists(accountFile))
                {
                    File.Delete(accountFile);
                }
                if (File.Exists(userFile))
                {
                    File.Delete(userFile);
                }
                if (File.Exists(userInfoFile))
                {
                    File.Delete(userInfoFile);
                }
                string folderName = "token.json";
                if (Directory.Exists(folderName))
                {
                    Directory.Delete(folderName);
                }
                MessageBox.Show(Program.rm.GetString("restartApp", Program.culture),
                                        Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.Close();
            }
        }
    }
}