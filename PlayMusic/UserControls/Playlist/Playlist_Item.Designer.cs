namespace PlayMusic.UserControls.Playlist
{
    partial class Playlist_Item
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
            this.panel_ImgPlaylist = new System.Windows.Forms.Panel();
            this.pic_Img4 = new System.Windows.Forms.PictureBox();
            this.pic_Img3 = new System.Windows.Forms.PictureBox();
            this.pic_Img2 = new System.Windows.Forms.PictureBox();
            this.pic_Img1 = new System.Windows.Forms.PictureBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.lbl_Detail = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.panel_ImgPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ImgPlaylist
            // 
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img4);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img3);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img2);
            this.panel_ImgPlaylist.Controls.Add(this.pic_Img1);
            this.panel_ImgPlaylist.Location = new System.Drawing.Point(10, 10);
            this.panel_ImgPlaylist.Name = "panel_ImgPlaylist";
            this.panel_ImgPlaylist.Size = new System.Drawing.Size(230, 230);
            this.panel_ImgPlaylist.TabIndex = 0;
            // 
            // pic_Img4
            // 
            this.pic_Img4.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img4.Location = new System.Drawing.Point(115, 115);
            this.pic_Img4.Name = "pic_Img4";
            this.pic_Img4.Size = new System.Drawing.Size(115, 115);
            this.pic_Img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img4.TabIndex = 0;
            this.pic_Img4.TabStop = false;
            this.pic_Img4.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // pic_Img3
            // 
            this.pic_Img3.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img3.Location = new System.Drawing.Point(0, 115);
            this.pic_Img3.Name = "pic_Img3";
            this.pic_Img3.Size = new System.Drawing.Size(115, 115);
            this.pic_Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img3.TabIndex = 0;
            this.pic_Img3.TabStop = false;
            this.pic_Img3.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // pic_Img2
            // 
            this.pic_Img2.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img2.Location = new System.Drawing.Point(115, 0);
            this.pic_Img2.Name = "pic_Img2";
            this.pic_Img2.Size = new System.Drawing.Size(115, 115);
            this.pic_Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img2.TabIndex = 0;
            this.pic_Img2.TabStop = false;
            this.pic_Img2.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // pic_Img1
            // 
            this.pic_Img1.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Img1.Location = new System.Drawing.Point(0, 0);
            this.pic_Img1.Name = "pic_Img1";
            this.pic_Img1.Size = new System.Drawing.Size(115, 115);
            this.pic_Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img1.TabIndex = 0;
            this.pic_Img1.TabStop = false;
            this.pic_Img1.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.lbl_Detail);
            this.panel_Info.Controls.Add(this.lbl_Title);
            this.panel_Info.Location = new System.Drawing.Point(3, 3);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(198, 46);
            this.panel_Info.TabIndex = 1;
            this.panel_Info.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // lbl_Detail
            // 
            this.lbl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Detail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detail.Location = new System.Drawing.Point(0, 24);
            this.lbl_Detail.Name = "lbl_Detail";
            this.lbl_Detail.Size = new System.Drawing.Size(198, 22);
            this.lbl_Detail.TabIndex = 1;
            this.lbl_Detail.Text = "20 bài - 20 phút 05 giây";
            this.lbl_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Detail.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(198, 24);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Nhạc của tui";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Click += new System.EventHandler(this.panel_Info_Click);
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.btn_Play);
            this.panel_Control.Controls.Add(this.btn_Shuffle);
            this.panel_Control.Controls.Add(this.panel_Info);
            this.panel_Control.Location = new System.Drawing.Point(10, 245);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(230, 52);
            this.panel_Control.TabIndex = 2;
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_gray;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(207, 6);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(20, 20);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.BackgroundImage = global::PlayMusic.Properties.Resources.shuffle_gray;
            this.btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.btn_Shuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Shuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shuffle.Location = new System.Drawing.Point(207, 29);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(20, 20);
            this.btn_Shuffle.TabIndex = 2;
            this.btn_Shuffle.UseVisualStyleBackColor = true;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            this.btn_Shuffle.MouseLeave += new System.EventHandler(this.btn_Shuffle_MouseLeave);
            this.btn_Shuffle.MouseHover += new System.EventHandler(this.btn_Shuffle_MouseHover);
            // 
            // Playlist_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Control);
            this.Controls.Add(this.panel_ImgPlaylist);
            this.Name = "Playlist_Item";
            this.Size = new System.Drawing.Size(250, 300);
            this.Load += new System.EventHandler(this.Playlist_Item_Load);
            this.Click += new System.EventHandler(this.panel_Info_Click);
            this.panel_ImgPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ImgPlaylist;
        private System.Windows.Forms.PictureBox pic_Img4;
        private System.Windows.Forms.PictureBox pic_Img3;
        private System.Windows.Forms.PictureBox pic_Img2;
        private System.Windows.Forms.PictureBox pic_Img1;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label lbl_Detail;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Button btn_Play;
    }
}
