namespace PlayMusic.ChildForm
{
    partial class SongsMusic
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_PlayAllSongOrFavotite = new System.Windows.Forms.Button();
            this.panel_MenuAlbum = new System.Windows.Forms.Panel();
            this.pic_Album = new System.Windows.Forms.PictureBox();
            this.btn_Album = new System.Windows.Forms.Button();
            this.panel_MenuArtist = new System.Windows.Forms.Panel();
            this.btn_Artist = new System.Windows.Forms.Button();
            this.pic_Artist = new System.Windows.Forms.PictureBox();
            this.panel_MenuPlaylist = new System.Windows.Forms.Panel();
            this.btn_Favorite = new System.Windows.Forms.Button();
            this.pic_Favorite = new System.Windows.Forms.PictureBox();
            this.panel_AllSong = new System.Windows.Forms.Panel();
            this.btn_AllSong = new System.Windows.Forms.Button();
            this.pic_AllSong = new System.Windows.Forms.PictureBox();
            this.panel_AllContent = new System.Windows.Forms.Panel();
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NoResult = new System.Windows.Forms.Panel();
            this.lbl_NoContent = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            this.panel_MenuAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).BeginInit();
            this.panel_MenuArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).BeginInit();
            this.panel_MenuPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favorite)).BeginInit();
            this.panel_AllSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AllSong)).BeginInit();
            this.panel_AllContent.SuspendLayout();
            this.panel_NoResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.btn_PlayAllSongOrFavotite);
            this.panel_Menu.Controls.Add(this.panel_MenuAlbum);
            this.panel_Menu.Controls.Add(this.panel_MenuArtist);
            this.panel_Menu.Controls.Add(this.panel_MenuPlaylist);
            this.panel_Menu.Controls.Add(this.panel_AllSong);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(684, 50);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_PlayAllSongOrFavotite
            // 
            this.btn_PlayAllSongOrFavotite.BackgroundImage = global::PlayMusic.Properties.Resources.play_circled_gray;
            this.btn_PlayAllSongOrFavotite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayAllSongOrFavotite.FlatAppearance.BorderSize = 0;
            this.btn_PlayAllSongOrFavotite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayAllSongOrFavotite.Location = new System.Drawing.Point(555, 11);
            this.btn_PlayAllSongOrFavotite.Name = "btn_PlayAllSongOrFavotite";
            this.btn_PlayAllSongOrFavotite.Size = new System.Drawing.Size(30, 30);
            this.btn_PlayAllSongOrFavotite.TabIndex = 6;
            this.btn_PlayAllSongOrFavotite.UseVisualStyleBackColor = true;
            this.btn_PlayAllSongOrFavotite.Click += new System.EventHandler(this.btn_PlayAllSongOrFavotite_Click);
            this.btn_PlayAllSongOrFavotite.MouseLeave += new System.EventHandler(this.btn_PlayAllSongOrFavotite_MouseLeave);
            this.btn_PlayAllSongOrFavotite.MouseHover += new System.EventHandler(this.btn_PlayAllSongOrFavotite_MouseHover);
            // 
            // panel_MenuAlbum
            // 
            this.panel_MenuAlbum.Controls.Add(this.pic_Album);
            this.panel_MenuAlbum.Controls.Add(this.btn_Album);
            this.panel_MenuAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuAlbum.Location = new System.Drawing.Point(430, 0);
            this.panel_MenuAlbum.Name = "panel_MenuAlbum";
            this.panel_MenuAlbum.Size = new System.Drawing.Size(119, 50);
            this.panel_MenuAlbum.TabIndex = 3;
            this.panel_MenuAlbum.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // pic_Album
            // 
            this.pic_Album.Image = global::PlayMusic.Properties.Resources.album_gray;
            this.pic_Album.Location = new System.Drawing.Point(15, 12);
            this.pic_Album.Name = "pic_Album";
            this.pic_Album.Size = new System.Drawing.Size(25, 25);
            this.pic_Album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Album.TabIndex = 1;
            this.pic_Album.TabStop = false;
            this.pic_Album.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // btn_Album
            // 
            this.btn_Album.FlatAppearance.BorderSize = 0;
            this.btn_Album.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Album.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Album.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Album.ForeColor = System.Drawing.Color.Gray;
            this.btn_Album.Location = new System.Drawing.Point(46, 9);
            this.btn_Album.Name = "btn_Album";
            this.btn_Album.Size = new System.Drawing.Size(65, 32);
            this.btn_Album.TabIndex = 0;
            this.btn_Album.Text = "Album";
            this.btn_Album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Album.UseVisualStyleBackColor = true;
            this.btn_Album.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // panel_MenuArtist
            // 
            this.panel_MenuArtist.Controls.Add(this.btn_Artist);
            this.panel_MenuArtist.Controls.Add(this.pic_Artist);
            this.panel_MenuArtist.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuArtist.Location = new System.Drawing.Point(303, 0);
            this.panel_MenuArtist.Name = "panel_MenuArtist";
            this.panel_MenuArtist.Size = new System.Drawing.Size(127, 50);
            this.panel_MenuArtist.TabIndex = 4;
            this.panel_MenuArtist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // btn_Artist
            // 
            this.btn_Artist.FlatAppearance.BorderSize = 0;
            this.btn_Artist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Artist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Artist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Artist.ForeColor = System.Drawing.Color.Gray;
            this.btn_Artist.Location = new System.Drawing.Point(46, 9);
            this.btn_Artist.Name = "btn_Artist";
            this.btn_Artist.Size = new System.Drawing.Size(72, 32);
            this.btn_Artist.TabIndex = 0;
            this.btn_Artist.Text = "Nghệ sĩ";
            this.btn_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Artist.UseVisualStyleBackColor = true;
            this.btn_Artist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // pic_Artist
            // 
            this.pic_Artist.Image = global::PlayMusic.Properties.Resources.artist_gray;
            this.pic_Artist.Location = new System.Drawing.Point(15, 12);
            this.pic_Artist.Name = "pic_Artist";
            this.pic_Artist.Size = new System.Drawing.Size(25, 25);
            this.pic_Artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Artist.TabIndex = 1;
            this.pic_Artist.TabStop = false;
            this.pic_Artist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // panel_MenuPlaylist
            // 
            this.panel_MenuPlaylist.Controls.Add(this.btn_Favorite);
            this.panel_MenuPlaylist.Controls.Add(this.pic_Favorite);
            this.panel_MenuPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuPlaylist.Location = new System.Drawing.Point(165, 0);
            this.panel_MenuPlaylist.Name = "panel_MenuPlaylist";
            this.panel_MenuPlaylist.Size = new System.Drawing.Size(138, 50);
            this.panel_MenuPlaylist.TabIndex = 5;
            this.panel_MenuPlaylist.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.FlatAppearance.BorderSize = 0;
            this.btn_Favorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Favorite.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Favorite.ForeColor = System.Drawing.Color.Gray;
            this.btn_Favorite.Location = new System.Drawing.Point(46, 9);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Size = new System.Drawing.Size(84, 32);
            this.btn_Favorite.TabIndex = 0;
            this.btn_Favorite.Text = "Yêu thích";
            this.btn_Favorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Favorite.UseVisualStyleBackColor = true;
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // pic_Favorite
            // 
            this.pic_Favorite.Image = global::PlayMusic.Properties.Resources.heart_gray;
            this.pic_Favorite.Location = new System.Drawing.Point(15, 12);
            this.pic_Favorite.Name = "pic_Favorite";
            this.pic_Favorite.Size = new System.Drawing.Size(25, 25);
            this.pic_Favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Favorite.TabIndex = 1;
            this.pic_Favorite.TabStop = false;
            this.pic_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // panel_AllSong
            // 
            this.panel_AllSong.Controls.Add(this.btn_AllSong);
            this.panel_AllSong.Controls.Add(this.pic_AllSong);
            this.panel_AllSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_AllSong.Location = new System.Drawing.Point(0, 0);
            this.panel_AllSong.Name = "panel_AllSong";
            this.panel_AllSong.Size = new System.Drawing.Size(165, 50);
            this.panel_AllSong.TabIndex = 2;
            this.panel_AllSong.Click += new System.EventHandler(this.btn_AllSong_Click);
            // 
            // btn_AllSong
            // 
            this.btn_AllSong.FlatAppearance.BorderSize = 0;
            this.btn_AllSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AllSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AllSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AllSong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_AllSong.Location = new System.Drawing.Point(46, 9);
            this.btn_AllSong.Name = "btn_AllSong";
            this.btn_AllSong.Size = new System.Drawing.Size(113, 32);
            this.btn_AllSong.TabIndex = 0;
            this.btn_AllSong.Text = "Tất cả bài hát";
            this.btn_AllSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllSong.UseVisualStyleBackColor = true;
            this.btn_AllSong.Click += new System.EventHandler(this.btn_AllSong_Click);
            // 
            // pic_AllSong
            // 
            this.pic_AllSong.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_AllSong.Location = new System.Drawing.Point(15, 12);
            this.pic_AllSong.Name = "pic_AllSong";
            this.pic_AllSong.Size = new System.Drawing.Size(25, 25);
            this.pic_AllSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AllSong.TabIndex = 1;
            this.pic_AllSong.TabStop = false;
            this.pic_AllSong.Click += new System.EventHandler(this.btn_AllSong_Click);
            // 
            // panel_AllContent
            // 
            this.panel_AllContent.Controls.Add(this.panel_Content);
            this.panel_AllContent.Controls.Add(this.panel_NoResult);
            this.panel_AllContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AllContent.Location = new System.Drawing.Point(0, 50);
            this.panel_AllContent.Name = "panel_AllContent";
            this.panel_AllContent.Size = new System.Drawing.Size(684, 431);
            this.panel_AllContent.TabIndex = 1;
            // 
            // panel_Content
            // 
            this.panel_Content.AutoScroll = true;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 50);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(684, 381);
            this.panel_Content.TabIndex = 1;
            // 
            // panel_NoResult
            // 
            this.panel_NoResult.Controls.Add(this.lbl_NoContent);
            this.panel_NoResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NoResult.Location = new System.Drawing.Point(0, 0);
            this.panel_NoResult.Name = "panel_NoResult";
            this.panel_NoResult.Size = new System.Drawing.Size(684, 50);
            this.panel_NoResult.TabIndex = 0;
            // 
            // lbl_NoContent
            // 
            this.lbl_NoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NoContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NoContent.Location = new System.Drawing.Point(0, 0);
            this.lbl_NoContent.Name = "lbl_NoContent";
            this.lbl_NoContent.Size = new System.Drawing.Size(684, 50);
            this.lbl_NoContent.TabIndex = 0;
            this.lbl_NoContent.Text = "Không tìm thấy bài hát nào";
            this.lbl_NoContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongsMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_AllContent);
            this.Controls.Add(this.panel_Menu);
            this.Name = "SongsMusic";
            this.Text = "Songs";
            this.Load += new System.EventHandler(this.SongsMusic_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_MenuAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).EndInit();
            this.panel_MenuArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).EndInit();
            this.panel_MenuPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favorite)).EndInit();
            this.panel_AllSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_AllSong)).EndInit();
            this.panel_AllContent.ResumeLayout(false);
            this.panel_NoResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_AllContent;
        private System.Windows.Forms.Panel panel_MenuAlbum;
        private System.Windows.Forms.PictureBox pic_Album;
        private System.Windows.Forms.Button btn_Album;
        private System.Windows.Forms.Panel panel_MenuArtist;
        private System.Windows.Forms.Button btn_Artist;
        private System.Windows.Forms.PictureBox pic_Artist;
        private System.Windows.Forms.Panel panel_MenuPlaylist;
        private System.Windows.Forms.Button btn_Favorite;
        private System.Windows.Forms.PictureBox pic_Favorite;
        private System.Windows.Forms.Panel panel_AllSong;
        private System.Windows.Forms.Button btn_AllSong;
        private System.Windows.Forms.PictureBox pic_AllSong;
        private System.Windows.Forms.Panel panel_NoResult;
        private System.Windows.Forms.Label lbl_NoContent;
        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.Button btn_PlayAllSongOrFavotite;
    }
}