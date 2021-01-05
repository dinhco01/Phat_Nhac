namespace PlayMusic.UserControls.SongMusic
{
    partial class UC_Album
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
            this.pic_ImgAlbum = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.lbl_AlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImgAlbum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_ImgAlbum
            // 
            this.pic_ImgAlbum.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_ImgAlbum.Location = new System.Drawing.Point(10, 10);
            this.pic_ImgAlbum.Name = "pic_ImgAlbum";
            this.pic_ImgAlbum.Size = new System.Drawing.Size(230, 230);
            this.pic_ImgAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImgAlbum.TabIndex = 0;
            this.pic_ImgAlbum.TabStop = false;
            this.pic_ImgAlbum.Click += new System.EventHandler(this.pic_ImgAlbum_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_ArtistName);
            this.panel1.Controls.Add(this.lbl_AlbumName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 54);
            this.panel1.TabIndex = 1;
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ArtistName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistName.Location = new System.Drawing.Point(0, 27);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_ArtistName.Size = new System.Drawing.Size(250, 27);
            this.lbl_ArtistName.TabIndex = 1;
            this.lbl_ArtistName.Text = "Tên nghệ sĩ";
            this.lbl_ArtistName.Click += new System.EventHandler(this.pic_ImgAlbum_Click);
            // 
            // lbl_AlbumName
            // 
            this.lbl_AlbumName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_AlbumName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlbumName.Location = new System.Drawing.Point(0, 0);
            this.lbl_AlbumName.Name = "lbl_AlbumName";
            this.lbl_AlbumName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_AlbumName.Size = new System.Drawing.Size(250, 27);
            this.lbl_AlbumName.TabIndex = 0;
            this.lbl_AlbumName.Text = "Tên Album";
            this.lbl_AlbumName.Click += new System.EventHandler(this.pic_ImgAlbum_Click);
            // 
            // UC_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_ImgAlbum);
            this.Name = "UC_Album";
            this.Size = new System.Drawing.Size(250, 300);
            this.Load += new System.EventHandler(this.UC_Album_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImgAlbum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ImgAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ArtistName;
        private System.Windows.Forms.Label lbl_AlbumName;
    }
}
