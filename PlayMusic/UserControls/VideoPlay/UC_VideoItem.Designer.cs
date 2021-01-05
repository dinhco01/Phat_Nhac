
namespace PlayMusic.UserControls.VideoPlay
{
    partial class UC_VideoItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_VideoName = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.panel_FrameVideo = new System.Windows.Forms.Panel();
            this.pic_Thumbnail = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel_FrameVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_VideoName);
            this.panel2.Controls.Add(this.lbl_Duration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 51);
            this.panel2.TabIndex = 2;
            // 
            // lbl_VideoName
            // 
            this.lbl_VideoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_VideoName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VideoName.Location = new System.Drawing.Point(0, 0);
            this.lbl_VideoName.Name = "lbl_VideoName";
            this.lbl_VideoName.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lbl_VideoName.Size = new System.Drawing.Size(260, 32);
            this.lbl_VideoName.TabIndex = 1;
            this.lbl_VideoName.Text = "Tên Video";
            this.lbl_VideoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_VideoName.DoubleClick += new System.EventHandler(this.pic_Thumbnail_DoubleClick);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(0, 32);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lbl_Duration.Size = new System.Drawing.Size(260, 19);
            this.lbl_Duration.TabIndex = 1;
            this.lbl_Duration.Text = "Thời lượng: 20 phút 30 giây";
            this.lbl_Duration.DoubleClick += new System.EventHandler(this.pic_Thumbnail_DoubleClick);
            // 
            // panel_FrameVideo
            // 
            this.panel_FrameVideo.BackgroundImage = global::PlayMusic.Properties.Resources.frame;
            this.panel_FrameVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_FrameVideo.Controls.Add(this.pic_Thumbnail);
            this.panel_FrameVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FrameVideo.Location = new System.Drawing.Point(0, 0);
            this.panel_FrameVideo.Name = "panel_FrameVideo";
            this.panel_FrameVideo.Size = new System.Drawing.Size(260, 160);
            this.panel_FrameVideo.TabIndex = 1;
            this.panel_FrameVideo.DoubleClick += new System.EventHandler(this.pic_Thumbnail_DoubleClick);
            // 
            // pic_Thumbnail
            // 
            this.pic_Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Thumbnail.ErrorImage = null;
            this.pic_Thumbnail.Image = global::PlayMusic.Properties.Resources.search;
            this.pic_Thumbnail.InitialImage = null;
            this.pic_Thumbnail.Location = new System.Drawing.Point(24, 31);
            this.pic_Thumbnail.Name = "pic_Thumbnail";
            this.pic_Thumbnail.Size = new System.Drawing.Size(212, 96);
            this.pic_Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Thumbnail.TabIndex = 2;
            this.pic_Thumbnail.TabStop = false;
            this.pic_Thumbnail.DoubleClick += new System.EventHandler(this.pic_Thumbnail_DoubleClick);
            // 
            // UC_VideoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_FrameVideo);
            this.Name = "UC_VideoItem";
            this.Size = new System.Drawing.Size(260, 211);
            this.Load += new System.EventHandler(this.UC_VideoItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel_FrameVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_VideoName;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.PictureBox pic_Thumbnail;
        private System.Windows.Forms.Panel panel_FrameVideo;
    }
}
