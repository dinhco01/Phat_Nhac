
namespace PlayMusic.UserControls.SongMusic
{
    partial class PlaylistTag
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
            this.lbl_PlaylistName = new System.Windows.Forms.Label();
            this.lbl_NumberSong = new System.Windows.Forms.Label();
            this.pic_Img4 = new System.Windows.Forms.PictureBox();
            this.pic_Img3 = new System.Windows.Forms.PictureBox();
            this.pic_Img2 = new System.Windows.Forms.PictureBox();
            this.pic_Img1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PlaylistName
            // 
            this.lbl_PlaylistName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistName.Location = new System.Drawing.Point(56, 10);
            this.lbl_PlaylistName.Name = "lbl_PlaylistName";
            this.lbl_PlaylistName.Size = new System.Drawing.Size(225, 20);
            this.lbl_PlaylistName.TabIndex = 1;
            this.lbl_PlaylistName.Text = "Tên danh sách phát";
            this.lbl_PlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_PlaylistName.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.lbl_PlaylistName.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // lbl_NumberSong
            // 
            this.lbl_NumberSong.AutoSize = true;
            this.lbl_NumberSong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NumberSong.Location = new System.Drawing.Point(56, 37);
            this.lbl_NumberSong.Name = "lbl_NumberSong";
            this.lbl_NumberSong.Size = new System.Drawing.Size(96, 13);
            this.lbl_NumberSong.TabIndex = 2;
            this.lbl_NumberSong.Text = "Số bài hát: 00 bài";
            this.lbl_NumberSong.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.lbl_NumberSong.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // pic_Img4
            // 
            this.pic_Img4.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img4.Location = new System.Drawing.Point(30, 30);
            this.pic_Img4.Name = "pic_Img4";
            this.pic_Img4.Size = new System.Drawing.Size(20, 20);
            this.pic_Img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img4.TabIndex = 0;
            this.pic_Img4.TabStop = false;
            this.pic_Img4.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.pic_Img4.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // pic_Img3
            // 
            this.pic_Img3.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img3.Location = new System.Drawing.Point(10, 30);
            this.pic_Img3.Name = "pic_Img3";
            this.pic_Img3.Size = new System.Drawing.Size(20, 20);
            this.pic_Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img3.TabIndex = 0;
            this.pic_Img3.TabStop = false;
            this.pic_Img3.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.pic_Img3.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // pic_Img2
            // 
            this.pic_Img2.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img2.Location = new System.Drawing.Point(30, 10);
            this.pic_Img2.Name = "pic_Img2";
            this.pic_Img2.Size = new System.Drawing.Size(20, 20);
            this.pic_Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img2.TabIndex = 0;
            this.pic_Img2.TabStop = false;
            this.pic_Img2.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.pic_Img2.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // pic_Img1
            // 
            this.pic_Img1.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img1.Location = new System.Drawing.Point(10, 10);
            this.pic_Img1.Name = "pic_Img1";
            this.pic_Img1.Size = new System.Drawing.Size(20, 20);
            this.pic_Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img1.TabIndex = 0;
            this.pic_Img1.TabStop = false;
            this.pic_Img1.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.pic_Img1.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            // 
            // PlaylistTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_NumberSong);
            this.Controls.Add(this.lbl_PlaylistName);
            this.Controls.Add(this.pic_Img4);
            this.Controls.Add(this.pic_Img3);
            this.Controls.Add(this.pic_Img2);
            this.Controls.Add(this.pic_Img1);
            this.Name = "PlaylistTag";
            this.Size = new System.Drawing.Size(284, 60);
            this.Load += new System.EventHandler(this.PlaylistTag_Load);
            this.Click += new System.EventHandler(this.PlaylistTag_Click);
            this.DoubleClick += new System.EventHandler(this.PlaylistTag_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Img1;
        private System.Windows.Forms.PictureBox pic_Img2;
        private System.Windows.Forms.PictureBox pic_Img3;
        private System.Windows.Forms.PictureBox pic_Img4;
        private System.Windows.Forms.Label lbl_PlaylistName;
        private System.Windows.Forms.Label lbl_NumberSong;
    }
}
