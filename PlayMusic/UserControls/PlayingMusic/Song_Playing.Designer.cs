namespace PlayMusic.UserControls.PlayingMusic
{
    partial class Song_Playing
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
            this.lbl_Song = new System.Windows.Forms.Label();
            this.lbl_Singger = new System.Windows.Forms.Label();
            this.btn_Favorite = new System.Windows.Forms.Button();
            this.btn_RemoveSong = new System.Windows.Forms.Button();
            this.pic_Song = new PlayMusic.CustomControl.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Song
            // 
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.Location = new System.Drawing.Point(58, 10);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(172, 20);
            this.lbl_Song.TabIndex = 0;
            this.lbl_Song.Text = "Tình Nhạt Phai";
            this.lbl_Song.DoubleClick += new System.EventHandler(this.Song_Playing_DoubleClick);
            // 
            // lbl_Singger
            // 
            this.lbl_Singger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Singger.Location = new System.Drawing.Point(59, 37);
            this.lbl_Singger.Name = "lbl_Singger";
            this.lbl_Singger.Size = new System.Drawing.Size(172, 13);
            this.lbl_Singger.TabIndex = 0;
            this.lbl_Singger.Text = "Châu Khải Phong";
            this.lbl_Singger.DoubleClick += new System.EventHandler(this.Song_Playing_DoubleClick);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Favorite.BackgroundImage = global::PlayMusic.Properties.Resources.heart_gray;
            this.btn_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Favorite.FlatAppearance.BorderSize = 0;
            this.btn_Favorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Favorite.Location = new System.Drawing.Point(236, 20);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Size = new System.Drawing.Size(20, 20);
            this.btn_Favorite.TabIndex = 2;
            this.btn_Favorite.UseVisualStyleBackColor = true;
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // btn_RemoveSong
            // 
            this.btn_RemoveSong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_RemoveSong.BackgroundImage = global::PlayMusic.Properties.Resources.remove_song_blue;
            this.btn_RemoveSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RemoveSong.FlatAppearance.BorderSize = 0;
            this.btn_RemoveSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_RemoveSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_RemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveSong.Location = new System.Drawing.Point(266, 20);
            this.btn_RemoveSong.Name = "btn_RemoveSong";
            this.btn_RemoveSong.Size = new System.Drawing.Size(20, 20);
            this.btn_RemoveSong.TabIndex = 2;
            this.btn_RemoveSong.UseVisualStyleBackColor = true;
            this.btn_RemoveSong.Click += new System.EventHandler(this.btn_RemoveSong_Click);
            this.btn_RemoveSong.MouseLeave += new System.EventHandler(this.btn_RemoveSong_MouseLeave);
            this.btn_RemoveSong.MouseHover += new System.EventHandler(this.btn_RemoveSong_MouseHover);
            // 
            // pic_Song
            // 
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_Song.Location = new System.Drawing.Point(10, 10);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(40, 40);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 1;
            this.pic_Song.TabStop = false;
            this.pic_Song.DoubleClick += new System.EventHandler(this.Song_Playing_DoubleClick);
            // 
            // Song_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Favorite);
            this.Controls.Add(this.btn_RemoveSong);
            this.Controls.Add(this.pic_Song);
            this.Controls.Add(this.lbl_Singger);
            this.Controls.Add(this.lbl_Song);
            this.Name = "Song_Playing";
            this.Size = new System.Drawing.Size(306, 60);
            this.Load += new System.EventHandler(this.Song_Playing_Load);
            this.DoubleClick += new System.EventHandler(this.Song_Playing_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Song;
        private System.Windows.Forms.Label lbl_Singger;
        private PlayMusic.CustomControl.RoundPictureBox pic_Song;
        private System.Windows.Forms.Button btn_RemoveSong;
        private System.Windows.Forms.Button btn_Favorite;
    }
}
