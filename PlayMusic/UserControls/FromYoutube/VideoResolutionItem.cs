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
using YoutubeExplode.Videos.Streams;

namespace PlayMusic.UserControls.FromYoutube
{
    public partial class VideoResolutionItem : UserControl
    {
        private SelectResolution parentForm { get; set; }

        private int Id { get; set; }

        public string Title { get; set; }

        public string Memory { get; set; }

        public IStreamInfo streamInfo { get; set; }

        public VideoResolutionItem(SelectResolution parentForm, int id, IStreamInfo streamInfo)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.Id = id;
            this.streamInfo = streamInfo;
        }

        private void VideoResolutionItem_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = Title;
            lbl_Memory.Text = Memory;
        }

        private void VideoResolutionItem_Click(object sender, EventArgs e)
        {
            SelectVideoDownload();
        }

        public void SelectVideoDownload()
        {
            parentForm.RestoreColor();
            parentForm.Selected = Id;
            BackColor = Color.FromArgb(175, 220, 255);
        }
    }
}
