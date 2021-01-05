namespace PlayMusic.UserControls.Playlist
{
    partial class Playlist_Detail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_PlaylistDetail = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_NumberSong = new System.Windows.Forms.Label();
            this.lbl_NamePlaylist = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.panel_ImgPlaylist = new System.Windows.Forms.Panel();
            this.pic_Img4 = new System.Windows.Forms.PictureBox();
            this.pic_Img3 = new System.Windows.Forms.PictureBox();
            this.pic_Img2 = new System.Windows.Forms.PictureBox();
            this.pic_Img1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_ContainSong = new System.Windows.Forms.Panel();
            this.panel_LableSongs = new System.Windows.Forms.Panel();
            this.lbl_TitleSong = new System.Windows.Forms.Label();
            this.panel_PlaylistDetail.SuspendLayout();
            this.panel_ImgPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_LableSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_PlaylistDetail
            // 
            this.panel_PlaylistDetail.Controls.Add(this.lbl_Time);
            this.panel_PlaylistDetail.Controls.Add(this.lbl_NumberSong);
            this.panel_PlaylistDetail.Controls.Add(this.lbl_NamePlaylist);
            this.panel_PlaylistDetail.Controls.Add(this.btn_Edit);
            this.panel_PlaylistDetail.Controls.Add(this.btn_Remove);
            this.panel_PlaylistDetail.Controls.Add(this.btn_Shuffle);
            this.panel_PlaylistDetail.Controls.Add(this.btn_Play);
            this.panel_PlaylistDetail.Controls.Add(this.panel_ImgPlaylist);
            this.panel_PlaylistDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PlaylistDetail.Location = new System.Drawing.Point(10, 0);
            this.panel_PlaylistDetail.Name = "panel_PlaylistDetail";
            this.panel_PlaylistDetail.Size = new System.Drawing.Size(394, 167);
            this.panel_PlaylistDetail.TabIndex = 1;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(172, 64);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(169, 20);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "Thời lượng: 20 phút 05 giây";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NumberSong
            // 
            this.lbl_NumberSong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberSong.Location = new System.Drawing.Point(172, 39);
            this.lbl_NumberSong.Name = "lbl_NumberSong";
            this.lbl_NumberSong.Size = new System.Drawing.Size(169, 20);
            this.lbl_NumberSong.TabIndex = 1;
            this.lbl_NumberSong.Text = "Số bài hát: 20 bài";
            this.lbl_NumberSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NamePlaylist
            // 
            this.lbl_NamePlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamePlaylist.Location = new System.Drawing.Point(172, 8);
            this.lbl_NamePlaylist.Name = "lbl_NamePlaylist";
            this.lbl_NamePlaylist.Size = new System.Drawing.Size(185, 31);
            this.lbl_NamePlaylist.TabIndex = 0;
            this.lbl_NamePlaylist.Text = "Nhạc của tui";
            this.lbl_NamePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackgroundImage = global::PlayMusic.Properties.Resources.edit_gray;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(372, 14);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(20, 20);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.MouseLeave += new System.EventHandler(this.btn_Edit_MouseLeave);
            this.btn_Edit.MouseHover += new System.EventHandler(this.btn_Edit_MouseHover);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImage = global::PlayMusic.Properties.Resources.remove_gray;
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Location = new System.Drawing.Point(312, 109);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(30, 30);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            this.btn_Remove.MouseLeave += new System.EventHandler(this.btn_Remove_MouseLeave);
            this.btn_Remove.MouseHover += new System.EventHandler(this.btn_Remove_MouseHover);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.BackgroundImage = global::PlayMusic.Properties.Resources.shuffle_gray;
            this.btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.btn_Shuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Shuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shuffle.Location = new System.Drawing.Point(179, 109);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(30, 30);
            this.btn_Shuffle.TabIndex = 2;
            this.btn_Shuffle.UseVisualStyleBackColor = true;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            this.btn_Shuffle.MouseLeave += new System.EventHandler(this.btn_Shuffle_MouseLeave);
            this.btn_Shuffle.MouseHover += new System.EventHandler(this.btn_Shuffle_MouseHover);
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_circled_blue;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(230, 94);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Play.Size = new System.Drawing.Size(60, 60);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // panel_ImgPlaylist
            // 
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img4);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img3);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img2);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img1);
            this.panel_ImgPlaylist.Location = new System.Drawing.Point(17, 14);
            this.panel_ImgPlaylist.Name = "panel_ImgPlaylist";
            this.panel_ImgPlaylist.Size = new System.Drawing.Size(140, 140);
            this.panel_ImgPlaylist.TabIndex = 1;
            // 
            // pic_Img4
            // 
            this.pic_Img4.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img4.Location = new System.Drawing.Point(70, 70);
            this.pic_Img4.Name = "pic_Img4";
            this.pic_Img4.Size = new System.Drawing.Size(70, 70);
            this.pic_Img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img4.TabIndex = 0;
            this.pic_Img4.TabStop = false;
            // 
            // pic_Img3
            // 
            this.pic_Img3.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img3.Location = new System.Drawing.Point(0, 70);
            this.pic_Img3.Name = "pic_Img3";
            this.pic_Img3.Size = new System.Drawing.Size(70, 70);
            this.pic_Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img3.TabIndex = 0;
            this.pic_Img3.TabStop = false;
            // 
            // pic_Img2
            // 
            this.pic_Img2.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img2.Location = new System.Drawing.Point(70, 0);
            this.pic_Img2.Name = "pic_Img2";
            this.pic_Img2.Size = new System.Drawing.Size(70, 70);
            this.pic_Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img2.TabIndex = 0;
            this.pic_Img2.TabStop = false;
            // 
            // pic_Img1
            // 
            this.pic_Img1.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img1.Location = new System.Drawing.Point(0, 0);
            this.pic_Img1.Name = "pic_Img1";
            this.pic_Img1.Size = new System.Drawing.Size(70, 70);
            this.pic_Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img1.TabIndex = 0;
            this.pic_Img1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_ContainSong);
            this.panel1.Controls.Add(this.panel_LableSongs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 383);
            this.panel1.TabIndex = 2;
            // 
            // panel_ContainSong
            // 
            this.panel_ContainSong.AutoScroll = true;
            this.panel_ContainSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainSong.Location = new System.Drawing.Point(0, 33);
            this.panel_ContainSong.Name = "panel_ContainSong";
            this.panel_ContainSong.Size = new System.Drawing.Size(394, 350);
            this.panel_ContainSong.TabIndex = 1;
            // 
            // panel_LableSongs
            // 
            this.panel_LableSongs.Controls.Add(this.lbl_TitleSong);
            this.panel_LableSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LableSongs.Location = new System.Drawing.Point(0, 0);
            this.panel_LableSongs.Name = "panel_LableSongs";
            this.panel_LableSongs.Size = new System.Drawing.Size(394, 33);
            this.panel_LableSongs.TabIndex = 0;
            // 
            // lbl_TitleSong
            // 
            this.lbl_TitleSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TitleSong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSong.ForeColor = System.Drawing.Color.Black;
            this.lbl_TitleSong.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleSong.Name = "lbl_TitleSong";
            this.lbl_TitleSong.Size = new System.Drawing.Size(119, 33);
            this.lbl_TitleSong.TabIndex = 3;
            this.lbl_TitleSong.Text = "Danh sách bài hát";
            this.lbl_TitleSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Playlist_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_PlaylistDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Playlist_Detail";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin danh sách phát";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playlist_Detail_FormClosing);
            this.Load += new System.EventHandler(this.Playlist_Detail_Load);
            this.panel_PlaylistDetail.ResumeLayout(false);
            this.panel_ImgPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_LableSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_PlaylistDetail;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_NumberSong;
        private System.Windows.Forms.Label lbl_NamePlaylist;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Panel panel_ImgPlaylist;
        private System.Windows.Forms.PictureBox pic_Img4;
        private System.Windows.Forms.PictureBox pic_Img3;
        private System.Windows.Forms.PictureBox pic_Img2;
        private System.Windows.Forms.PictureBox pic_Img1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_LableSongs;
        private System.Windows.Forms.Label lbl_TitleSong;
        public System.Windows.Forms.Panel panel_ContainSong;
    }
}