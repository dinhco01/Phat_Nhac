namespace PlayMusic.UserControls.Recent
{
    partial class SongRecents
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
            this.lbl_SongName = new System.Windows.Forms.Label();
            this.lbl_SingerName = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Favorite = new System.Windows.Forms.Button();
            this.pic_SongImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SongName
            // 
            this.lbl_SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SongName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongName.Location = new System.Drawing.Point(57, 10);
            this.lbl_SongName.Name = "lbl_SongName";
            this.lbl_SongName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_SongName.Size = new System.Drawing.Size(281, 40);
            this.lbl_SongName.TabIndex = 1;
            this.lbl_SongName.Text = "Tình Nhạt Phai - Remix";
            this.lbl_SongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SingerName
            // 
            this.lbl_SingerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SingerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SingerName.Location = new System.Drawing.Point(344, 9);
            this.lbl_SingerName.Name = "lbl_SingerName";
            this.lbl_SingerName.Size = new System.Drawing.Size(165, 40);
            this.lbl_SingerName.TabIndex = 1;
            this.lbl_SingerName.Text = "Châu Khải Phong";
            this.lbl_SingerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_gray;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(556, 20);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(20, 20);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Favorite.BackgroundImage = global::PlayMusic.Properties.Resources.heart_gray;
            this.btn_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Favorite.FlatAppearance.BorderSize = 0;
            this.btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Favorite.Location = new System.Drawing.Point(582, 20);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Size = new System.Drawing.Size(20, 20);
            this.btn_Favorite.TabIndex = 2;
            this.btn_Favorite.UseVisualStyleBackColor = true;
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // pic_SongImg
            // 
            this.pic_SongImg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_SongImg.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_SongImg.Location = new System.Drawing.Point(10, 10);
            this.pic_SongImg.Name = "pic_SongImg";
            this.pic_SongImg.Size = new System.Drawing.Size(40, 40);
            this.pic_SongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SongImg.TabIndex = 0;
            this.pic_SongImg.TabStop = false;
            // 
            // SongRecents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Favorite);
            this.Controls.Add(this.lbl_SingerName);
            this.Controls.Add(this.lbl_SongName);
            this.Controls.Add(this.pic_SongImg);
            this.Name = "SongRecents";
            this.Size = new System.Drawing.Size(624, 60);
            this.Load += new System.EventHandler(this.SongRecents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_SongImg;
        private System.Windows.Forms.Label lbl_SongName;
        private System.Windows.Forms.Label lbl_SingerName;
        private System.Windows.Forms.Button btn_Favorite;
        private System.Windows.Forms.Button btn_Play;
    }
}
