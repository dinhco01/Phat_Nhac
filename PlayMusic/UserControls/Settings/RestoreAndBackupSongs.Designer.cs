
namespace PlayMusic.UserControls.Settings
{
    partial class RestoreAndBackupSongs
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
            this.lbl_NameSongDownloading = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.progressBar_Downloading = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.pic_Thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NameSongDownloading
            // 
            this.lbl_NameSongDownloading.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameSongDownloading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NameSongDownloading.Location = new System.Drawing.Point(29, 101);
            this.lbl_NameSongDownloading.Name = "lbl_NameSongDownloading";
            this.lbl_NameSongDownloading.Size = new System.Drawing.Size(288, 13);
            this.lbl_NameSongDownloading.TabIndex = 13;
            this.lbl_NameSongDownloading.Text = "[Tên bài hát]";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(113, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(278, 65);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Đang khôi phục/sao lưu các bài hát của bạn...";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar_Downloading
            // 
            this.progressBar_Downloading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_Downloading.Location = new System.Drawing.Point(32, 122);
            this.progressBar_Downloading.Name = "progressBar_Downloading";
            this.progressBar_Downloading.Size = new System.Drawing.Size(359, 23);
            this.progressBar_Downloading.TabIndex = 9;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Progress.Location = new System.Drawing.Point(323, 101);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(68, 13);
            this.lbl_Progress.TabIndex = 13;
            this.lbl_Progress.Text = "00/00 bài";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic_Thumbnail
            // 
            this.pic_Thumbnail.Image = global::PlayMusic.Properties.Resources.driver_icon;
            this.pic_Thumbnail.Location = new System.Drawing.Point(32, 12);
            this.pic_Thumbnail.Name = "pic_Thumbnail";
            this.pic_Thumbnail.Size = new System.Drawing.Size(65, 65);
            this.pic_Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Thumbnail.TabIndex = 10;
            this.pic_Thumbnail.TabStop = false;
            // 
            // RestoreAndBackupSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 157);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.lbl_NameSongDownloading);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Thumbnail);
            this.Controls.Add(this.progressBar_Downloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreAndBackupSongs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tải nhạc về máy tính";
            this.Load += new System.EventHandler(this.RestoreAndBackupSongs_Load);
            this.Shown += new System.EventHandler(this.RestoreAndBackupSongs_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_NameSongDownloading;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_Thumbnail;
        private System.Windows.Forms.ProgressBar progressBar_Downloading;
        private System.Windows.Forms.Label lbl_Progress;
    }
}