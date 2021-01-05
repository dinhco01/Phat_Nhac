﻿
namespace PlayMusic.UserControls.FromYoutube
{
    partial class Downloading
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
            this.progressBar_Downloading = new System.Windows.Forms.ProgressBar();
            this.pic_Thumbnail = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_PercentDownloaded = new System.Windows.Forms.Label();
            this.lbl_MemoryProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_Downloading
            // 
            this.progressBar_Downloading.Location = new System.Drawing.Point(33, 122);
            this.progressBar_Downloading.Name = "progressBar_Downloading";
            this.progressBar_Downloading.Size = new System.Drawing.Size(359, 23);
            this.progressBar_Downloading.TabIndex = 0;
            // 
            // pic_Thumbnail
            // 
            this.pic_Thumbnail.Image = global::PlayMusic.Properties.Resources.youtube;
            this.pic_Thumbnail.Location = new System.Drawing.Point(33, 12);
            this.pic_Thumbnail.Name = "pic_Thumbnail";
            this.pic_Thumbnail.Size = new System.Drawing.Size(65, 65);
            this.pic_Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Thumbnail.TabIndex = 1;
            this.pic_Thumbnail.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(114, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(278, 65);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Tên video";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PercentDownloaded
            // 
            this.lbl_PercentDownloaded.AutoSize = true;
            this.lbl_PercentDownloaded.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PercentDownloaded.Location = new System.Drawing.Point(30, 101);
            this.lbl_PercentDownloaded.Name = "lbl_PercentDownloaded";
            this.lbl_PercentDownloaded.Size = new System.Drawing.Size(22, 13);
            this.lbl_PercentDownloaded.TabIndex = 3;
            this.lbl_PercentDownloaded.Text = "0%";
            // 
            // lbl_MemoryProgress
            // 
            this.lbl_MemoryProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MemoryProgress.Location = new System.Drawing.Point(240, 101);
            this.lbl_MemoryProgress.Name = "lbl_MemoryProgress";
            this.lbl_MemoryProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_MemoryProgress.Size = new System.Drawing.Size(150, 13);
            this.lbl_MemoryProgress.TabIndex = 3;
            this.lbl_MemoryProgress.Text = "0/100 MB";
            this.lbl_MemoryProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Downloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 157);
            this.Controls.Add(this.lbl_MemoryProgress);
            this.Controls.Add(this.lbl_PercentDownloaded);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Thumbnail);
            this.Controls.Add(this.progressBar_Downloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Downloading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đang tải xuống";
            this.Load += new System.EventHandler(this.Downloading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Downloading;
        private System.Windows.Forms.PictureBox pic_Thumbnail;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_PercentDownloaded;
        private System.Windows.Forms.Label lbl_MemoryProgress;
    }
}