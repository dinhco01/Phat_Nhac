namespace PlayMusic.UserControls.Playlist
{
    partial class Song_Item
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Singger = new System.Windows.Forms.Label();
            this.lbl_Song = new System.Windows.Forms.Label();
            this.btn_Favorite = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.pic_Song = new PlayMusic.CustomControl.RoundPictureBox();
            this.toolTip_InfoSong = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Singger
            // 
            this.lbl_Singger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Singger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Singger.Location = new System.Drawing.Point(178, 15);
            this.lbl_Singger.Name = "lbl_Singger";
            this.lbl_Singger.Size = new System.Drawing.Size(93, 30);
            this.lbl_Singger.TabIndex = 15;
            this.lbl_Singger.Text = "Châu Khải Phong";
            this.lbl_Singger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Singger.MouseHover += new System.EventHandler(this.pic_Song_MouseHover);
            // 
            // lbl_Song
            // 
            this.lbl_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.Location = new System.Drawing.Point(51, 15);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(121, 30);
            this.lbl_Song.TabIndex = 16;
            this.lbl_Song.Text = "Tình Nhạt Phai";
            this.lbl_Song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Song.MouseHover += new System.EventHandler(this.pic_Song_MouseHover);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Favorite.BackgroundImage = global::PlayMusic.Properties.Resources.heart_gray;
            this.btn_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Favorite.FlatAppearance.BorderSize = 0;
            this.btn_Favorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Favorite.Location = new System.Drawing.Point(305, 20);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Size = new System.Drawing.Size(20, 20);
            this.btn_Favorite.TabIndex = 19;
            this.btn_Favorite.UseVisualStyleBackColor = true;
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Remove.BackgroundImage = global::PlayMusic.Properties.Resources.remove_gray;
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Location = new System.Drawing.Point(331, 20);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(20, 20);
            this.btn_Remove.TabIndex = 20;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            this.btn_Remove.MouseLeave += new System.EventHandler(this.btn_Remove_MouseLeave);
            this.btn_Remove.MouseHover += new System.EventHandler(this.btn_Remove_MouseHover);
            // 
            // pic_Song
            // 
            this.pic_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_Song.Location = new System.Drawing.Point(5, 10);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(40, 40);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 17;
            this.pic_Song.TabStop = false;
            this.pic_Song.MouseHover += new System.EventHandler(this.pic_Song_MouseHover);
            // 
            // Song_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Favorite);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.pic_Song);
            this.Controls.Add(this.lbl_Singger);
            this.Controls.Add(this.lbl_Song);
            this.Name = "Song_Item";
            this.Size = new System.Drawing.Size(354, 60);
            this.Load += new System.EventHandler(this.Song_Item_Load);
            this.MouseHover += new System.EventHandler(this.pic_Song_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Favorite;
        private System.Windows.Forms.Button btn_Remove;
        private CustomControl.RoundPictureBox pic_Song;
        private System.Windows.Forms.Label lbl_Singger;
        private System.Windows.Forms.Label lbl_Song;
        private System.Windows.Forms.ToolTip toolTip_InfoSong;
    }
}
