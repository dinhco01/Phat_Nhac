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

namespace PlayMusic
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            LoadLanguage();
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_Welcome.Text = rm.GetString("welcome", culture);
            btn_Login.Text = rm.GetString("login", culture);
            lbl_Skip.Text = rm.GetString("skip", culture);
            lbl_IntroAccount.Text = rm.GetString("accountInfoSettings", culture);
            lbl_LanguageCurrent.Text = Program.culture.Name == "vi-VN" ? rm.GetString("vietnamese", culture) : rm.GetString("english", culture);
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            TransparetBackground(lbl_IntroAccount);
            TransparetBackground(lbl_Welcome);
            TransparetBackground(lbl_LanguageCurrent);
        }

        private void TransparetBackground(Control C)
        {
            C.Visible = false;
            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        private static void SaveFile(string content)
        {
            File.AppendAllText(@"data\event.log", $"{content} - {DateTime.Now}");
        }

        private void lbl_Skip_Click(object sender, EventArgs e)
        {
            SaveFile("Login");
            Program.IsLoadMain = true;
            this.Close();
        }

        private void lbl_Skip_MouseHover(object sender, EventArgs e)
        {
            lbl_Skip.ForeColor = Color.Red;
        }

        private void lbl_Skip_MouseLeave(object sender, EventArgs e)
        {
            lbl_Skip.ForeColor = Color.Blue;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DriverAPI driver = new DriverAPI();
            SaveFile("Login");
            Program.IsLoadMain = true;
            this.Close();
        }

        private void btn_ChangeLanguage_Click(object sender, EventArgs e)
        {
            SelectLanguage select = new SelectLanguage(this);
            select.ShowDialog();
        }
    }
}
