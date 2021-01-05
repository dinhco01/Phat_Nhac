
namespace PlayMusic.UserControls.FromYoutube
{
    partial class VideoResolutionItem
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
            this.pic_Video = new System.Windows.Forms.PictureBox();
            this.lbl_Memory = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Video
            // 
            this.pic_Video.Image = global::PlayMusic.Properties.Resources.cinema_blue;
            this.pic_Video.Location = new System.Drawing.Point(10, 5);
            this.pic_Video.Name = "pic_Video";
            this.pic_Video.Size = new System.Drawing.Size(30, 30);
            this.pic_Video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Video.TabIndex = 0;
            this.pic_Video.TabStop = false;
            this.pic_Video.Click += new System.EventHandler(this.VideoResolutionItem_Click);
            // 
            // lbl_Memory
            // 
            this.lbl_Memory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Memory.Location = new System.Drawing.Point(46, 23);
            this.lbl_Memory.Name = "lbl_Memory";
            this.lbl_Memory.Size = new System.Drawing.Size(60, 12);
            this.lbl_Memory.TabIndex = 1;
            this.lbl_Memory.Text = "100 MB";
            this.lbl_Memory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Memory.Click += new System.EventHandler(this.VideoResolutionItem_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(46, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(190, 17);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "MP4 - 720p";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Click += new System.EventHandler(this.VideoResolutionItem_Click);
            // 
            // VideoResolutionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Memory);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Video);
            this.Name = "VideoResolutionItem";
            this.Size = new System.Drawing.Size(239, 40);
            this.Load += new System.EventHandler(this.VideoResolutionItem_Load);
            this.Click += new System.EventHandler(this.VideoResolutionItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Video;
        private System.Windows.Forms.Label lbl_Memory;
        private System.Windows.Forms.Label lbl_Title;
    }
}
