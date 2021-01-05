using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.Settings
{
    public partial class SelectLanguage : Form
    {
        public MainForm main { get; set; }

        public StartForm start { get; set; }

        public SelectLanguage(MainForm main)
        {
            InitializeComponent();
            LoadLanguege();
            this.main = main;
        }

        public SelectLanguage(StartForm start)
        {
            InitializeComponent();
            LoadLanguege();
            this.start = start;
        }

        public void LoadLanguege()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            Text = rm.GetString("changeLang", culture);
            lbl_Title.Text = rm.GetString("chooseLang", culture);
            rd_Eng.Text = rm.GetString("english", culture);
            rd_Vie.Text = rm.GetString("vietnamese", culture);
            btn_Ok.Text = rm.GetString("change", culture);
            btn_Cancel.Text = rm.GetString("cancel", culture);
        }

        private void SelectLanguage_Load(object sender, EventArgs e)
        {
            if (Program.culture.Name == "en-US")
            {
                rd_Eng.Checked = true;
                rd_Vie.Checked = false;
            }
            else
            {
                rd_Eng.Checked = false;
                rd_Vie.Checked = true;
            }
        }

        private void rd_Vie_CheckedChanged(object sender, EventArgs e)
        {
            rd_Vie.Checked = true;
        }

        private void rd_Eng_CheckedChanged(object sender, EventArgs e)
        {
            rd_Eng.Checked = true;
        }

        private void btn_ChangeAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if ((Program.culture.Name == "vi-VN" && rd_Vie.Checked) || (Program.culture.Name == "en-US" && rd_Eng.Checked))
            {
                this.Close();
                return;
            }
            Program.SetLanguage(rd_Vie.Checked == true ? Program.langs[0] : Program.langs[1]);
            RefeshUI();
        }

        private void RefeshUI()
        {
            if(main != null)
            {
                main.LoadLanguage();
                main.playingMusic.LoadLanguage();
                main.recent.LoadLanguage();
                main.search.LoadLanguage();
                main.songs.LoadLanguage();
                main.playlists.LoadLanguage();
                main.videos.LoadLanguage();
                main.onlineForm.LoadLanguage();
                main.zingMP3.LoadLanguage();
                main.settings.LoadLanguage();
            }
            if(start != null)
            {
                start.LoadLanguage();
            }    
            this.Close();
        }

    }
}
