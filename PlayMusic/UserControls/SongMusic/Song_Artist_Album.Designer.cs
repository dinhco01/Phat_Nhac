namespace PlayMusic.UserControls.SongMusic
{
    partial class Song_Artist_Album
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
            this.panel_InfoArtist = new System.Windows.Forms.Panel();
            this.pic_Album = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_SongNumber = new System.Windows.Forms.Label();
            this.lbl_TitleSongNumber = new System.Windows.Forms.Label();
            this.lbl_ArtistOrAlbum = new System.Windows.Forms.Label();
            this.pic_Artist = new PlayMusic.CustomControl.RoundPictureBox();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_ContainSong = new System.Windows.Forms.Panel();
            this.lbl_TitleSong = new System.Windows.Forms.Label();
            this.panel_InfoArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).BeginInit();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_InfoArtist
            // 
            this.panel_InfoArtist.Controls.Add(this.pic_Album);
            this.panel_InfoArtist.Controls.Add(this.btn_Play);
            this.panel_InfoArtist.Controls.Add(this.lbl_SongNumber);
            this.panel_InfoArtist.Controls.Add(this.lbl_TitleSongNumber);
            this.panel_InfoArtist.Controls.Add(this.lbl_ArtistOrAlbum);
            this.panel_InfoArtist.Controls.Add(this.pic_Artist);
            this.panel_InfoArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InfoArtist.Location = new System.Drawing.Point(10, 0);
            this.panel_InfoArtist.Name = "panel_InfoArtist";
            this.panel_InfoArtist.Size = new System.Drawing.Size(394, 130);
            this.panel_InfoArtist.TabIndex = 0;
            // 
            // pic_Album
            // 
            this.pic_Album.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Album.Location = new System.Drawing.Point(15, 15);
            this.pic_Album.Name = "pic_Album";
            this.pic_Album.Size = new System.Drawing.Size(100, 100);
            this.pic_Album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Album.TabIndex = 4;
            this.pic_Album.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_circled_gray;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(325, 41);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(50, 50);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // lbl_SongNumber
            // 
            this.lbl_SongNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongNumber.Location = new System.Drawing.Point(239, 68);
            this.lbl_SongNumber.Name = "lbl_SongNumber";
            this.lbl_SongNumber.Size = new System.Drawing.Size(51, 23);
            this.lbl_SongNumber.TabIndex = 2;
            this.lbl_SongNumber.Text = "10 bài";
            this.lbl_SongNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TitleSongNumber
            // 
            this.lbl_TitleSongNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSongNumber.Location = new System.Drawing.Point(132, 68);
            this.lbl_TitleSongNumber.Name = "lbl_TitleSongNumber";
            this.lbl_TitleSongNumber.Size = new System.Drawing.Size(101, 23);
            this.lbl_TitleSongNumber.TabIndex = 2;
            this.lbl_TitleSongNumber.Text = "Số bài hát:";
            this.lbl_TitleSongNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ArtistOrAlbum
            // 
            this.lbl_ArtistOrAlbum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistOrAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ArtistOrAlbum.Location = new System.Drawing.Point(131, 41);
            this.lbl_ArtistOrAlbum.Name = "lbl_ArtistOrAlbum";
            this.lbl_ArtistOrAlbum.Size = new System.Drawing.Size(188, 27);
            this.lbl_ArtistOrAlbum.TabIndex = 1;
            this.lbl_ArtistOrAlbum.Text = "Tên nghệ sĩ/album";
            this.lbl_ArtistOrAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_Artist
            // 
            this.pic_Artist.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Artist.Location = new System.Drawing.Point(15, 15);
            this.pic_Artist.Name = "pic_Artist";
            this.pic_Artist.Size = new System.Drawing.Size(100, 100);
            this.pic_Artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Artist.TabIndex = 0;
            this.pic_Artist.TabStop = false;
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.panel_ContainSong);
            this.panel_Content.Controls.Add(this.lbl_TitleSong);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(10, 130);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(394, 420);
            this.panel_Content.TabIndex = 1;
            // 
            // panel_ContainSong
            // 
            this.panel_ContainSong.AutoScroll = true;
            this.panel_ContainSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainSong.Location = new System.Drawing.Point(0, 22);
            this.panel_ContainSong.Name = "panel_ContainSong";
            this.panel_ContainSong.Size = new System.Drawing.Size(394, 398);
            this.panel_ContainSong.TabIndex = 1;
            // 
            // lbl_TitleSong
            // 
            this.lbl_TitleSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TitleSong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSong.ForeColor = System.Drawing.Color.Black;
            this.lbl_TitleSong.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleSong.Name = "lbl_TitleSong";
            this.lbl_TitleSong.Size = new System.Drawing.Size(394, 22);
            this.lbl_TitleSong.TabIndex = 0;
            this.lbl_TitleSong.Text = "Bài hát";
            this.lbl_TitleSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Song_Artist_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 550);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_InfoArtist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Song_Artist_Album";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bài hát";
            this.Load += new System.EventHandler(this.Song_Artist_Load);
            this.panel_InfoArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).EndInit();
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InfoArtist;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_SongNumber;
        private System.Windows.Forms.Label lbl_TitleSongNumber;
        private System.Windows.Forms.Label lbl_ArtistOrAlbum;
        private CustomControl.RoundPictureBox pic_Artist;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_ContainSong;
        private System.Windows.Forms.Label lbl_TitleSong;
        private System.Windows.Forms.PictureBox pic_Album;
    }
}