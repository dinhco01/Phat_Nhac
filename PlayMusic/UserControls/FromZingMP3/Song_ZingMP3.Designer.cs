
namespace PlayMusic.UserControls.FromZingMP3
{
    partial class Song_ZingMP3
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
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_Singger = new System.Windows.Forms.Label();
            this.lbl_Song = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.pic_Song = new PlayMusic.CustomControl.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(491, 15);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(39, 30);
            this.lbl_Duration.TabIndex = 8;
            this.lbl_Duration.Text = "00:00";
            this.lbl_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Singger
            // 
            this.lbl_Singger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Singger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Singger.Location = new System.Drawing.Point(330, 15);
            this.lbl_Singger.Name = "lbl_Singger";
            this.lbl_Singger.Size = new System.Drawing.Size(155, 30);
            this.lbl_Singger.TabIndex = 9;
            this.lbl_Singger.Text = "Đang tải...";
            this.lbl_Singger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Song
            // 
            this.lbl_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.Location = new System.Drawing.Point(56, 15);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(268, 30);
            this.lbl_Song.TabIndex = 10;
            this.lbl_Song.Text = "Đang tải...";
            this.lbl_Song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Play.BackgroundImage = global::PlayMusic.Properties.Resources.play_gray;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(588, 21);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(20, 20);
            this.btn_Play.TabIndex = 12;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Download.BackgroundImage = global::PlayMusic.Properties.Resources.download_zing_gray;
            this.btn_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Download.FlatAppearance.BorderSize = 0;
            this.btn_Download.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.Location = new System.Drawing.Point(614, 21);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(20, 20);
            this.btn_Download.TabIndex = 15;
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            this.btn_Download.MouseLeave += new System.EventHandler(this.btn_Download_MouseLeave);
            this.btn_Download.MouseHover += new System.EventHandler(this.btn_Download_MouseHover);
            // 
            // pic_Song
            // 
            this.pic_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_Song.Location = new System.Drawing.Point(10, 10);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(40, 40);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 11;
            this.pic_Song.TabStop = false;
            // 
            // Song_ZingMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.pic_Song);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_Singger);
            this.Controls.Add(this.lbl_Song);
            this.Name = "Song_ZingMP3";
            this.Size = new System.Drawing.Size(644, 60);
            this.Load += new System.EventHandler(this.Song_ZingMP3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private CustomControl.RoundPictureBox pic_Song;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Singger;
        private System.Windows.Forms.Label lbl_Song;
        private System.Windows.Forms.Button btn_Download;
    }
}
