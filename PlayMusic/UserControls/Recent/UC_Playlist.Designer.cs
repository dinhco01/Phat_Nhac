namespace PlayMusic.UserControls.Recent
{
    partial class UC_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Playlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Img4 = new System.Windows.Forms.PictureBox();
            this.pic_Img3 = new System.Windows.Forms.PictureBox();
            this.pic_Img2 = new System.Windows.Forms.PictureBox();
            this.pic_Img1 = new System.Windows.Forms.PictureBox();
            this.lbl_TitlePlaylist = new System.Windows.Forms.Label();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Play = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Img4);
            this.panel1.Controls.Add(this.pic_Img3);
            this.panel1.Controls.Add(this.pic_Img2);
            this.panel1.Controls.Add(this.pic_Img1);
            this.panel1.Location = new System.Drawing.Point(20, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 0;
            // 
            // pic_Img4
            // 
            this.pic_Img4.Image = ((System.Drawing.Image)(resources.GetObject("pic_Img4.Image")));
            this.pic_Img4.Location = new System.Drawing.Point(75, 75);
            this.pic_Img4.Name = "pic_Img4";
            this.pic_Img4.Size = new System.Drawing.Size(75, 75);
            this.pic_Img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img4.TabIndex = 3;
            this.pic_Img4.TabStop = false;
            // 
            // pic_Img3
            // 
            this.pic_Img3.Image = ((System.Drawing.Image)(resources.GetObject("pic_Img3.Image")));
            this.pic_Img3.Location = new System.Drawing.Point(0, 75);
            this.pic_Img3.Name = "pic_Img3";
            this.pic_Img3.Size = new System.Drawing.Size(75, 75);
            this.pic_Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img3.TabIndex = 2;
            this.pic_Img3.TabStop = false;
            // 
            // pic_Img2
            // 
            this.pic_Img2.Image = ((System.Drawing.Image)(resources.GetObject("pic_Img2.Image")));
            this.pic_Img2.Location = new System.Drawing.Point(75, 0);
            this.pic_Img2.Name = "pic_Img2";
            this.pic_Img2.Size = new System.Drawing.Size(75, 75);
            this.pic_Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img2.TabIndex = 1;
            this.pic_Img2.TabStop = false;
            // 
            // pic_Img1
            // 
            this.pic_Img1.Image = ((System.Drawing.Image)(resources.GetObject("pic_Img1.Image")));
            this.pic_Img1.Location = new System.Drawing.Point(0, 0);
            this.pic_Img1.Name = "pic_Img1";
            this.pic_Img1.Size = new System.Drawing.Size(75, 75);
            this.pic_Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img1.TabIndex = 0;
            this.pic_Img1.TabStop = false;
            // 
            // lbl_TitlePlaylist
            // 
            this.lbl_TitlePlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TitlePlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitlePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TitlePlaylist.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitlePlaylist.Name = "lbl_TitlePlaylist";
            this.lbl_TitlePlaylist.Size = new System.Drawing.Size(124, 20);
            this.lbl_TitlePlaylist.TabIndex = 1;
            this.lbl_TitlePlaylist.Text = "Nhạc của tui";
            this.lbl_TitlePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.btn_Play);
            this.panel_Title.Controls.Add(this.lbl_TitlePlaylist);
            this.panel_Title.Location = new System.Drawing.Point(20, 165);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(150, 20);
            this.panel_Title.TabIndex = 1;
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_circled_gray;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(130, 0);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(20, 20);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // UC_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Playlist";
            this.Size = new System.Drawing.Size(190, 190);
            this.Load += new System.EventHandler(this.UC_Playlist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img1)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pic_Img4;
        public System.Windows.Forms.PictureBox pic_Img3;
        public System.Windows.Forms.PictureBox pic_Img2;
        public System.Windows.Forms.PictureBox pic_Img1;
        public System.Windows.Forms.Label lbl_TitlePlaylist;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Button btn_Play;
    }
}
