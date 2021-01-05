using PlayMusic.ChildForm;
using PlayMusic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.UserControls.VideoPlay
{
    public partial class UC_VideoItem : UserControl
    {
        public MainForm main { get; set; }

        public Model.Video video { get; set; }

        public UC_VideoItem(Model.Video video, MainForm main)
        {
            InitializeComponent();
            LoadLanguage();
            this.video = video;
            this.main = main;
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            lbl_Duration.Text = rm.GetString("time", culture);
        }

        private void UC_VideoItem_Load(object sender, EventArgs e)
        {
            if (video != null)
            {
                lbl_VideoName.Text = video.VideoName;
                lbl_Duration.Text = Program.rm.GetString("time", Program.culture) 
                                        + " " + (video.Duration.Hours * 60 + video.Duration.Minutes) + " " + Program.rm.GetString("minute", Program.culture) + " " +
                                        video.Duration.Seconds + " " + Program.rm.GetString("second", Program.culture);
                pic_Thumbnail.Image = video.Thumbnail;
            }
        }

        private void pic_Thumbnail_DoubleClick(object sender, EventArgs e)
        {
            if (main.mp3.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                main.mp3.player.controls.pause();
            }
            if (video != null)
            {
                VideoPlaying vd = new VideoPlaying(video.URLSource, main);
                main.panel_ControlBar.Visible = false;
                main.IsPlayVideo = true;
                main.PlayingVideo = vd;
                main.AddChildForm(vd);
            }
        }
    }
}
