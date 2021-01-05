namespace PlayMusic.ChildForm
{
    partial class VideosPlay
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
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.lbl_LableListVideo = new System.Windows.Forms.Label();
            this.panel_ContainVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Local = new System.Windows.Forms.Button();
            this.btn_YoutubeDownloader = new System.Windows.Forms.Button();
            this.btn_BrowerFolder = new System.Windows.Forms.Button();
            this.panel_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.Controls.Add(this.btn_Local);
            this.panel_TitleBar.Controls.Add(this.btn_YoutubeDownloader);
            this.panel_TitleBar.Controls.Add(this.btn_BrowerFolder);
            this.panel_TitleBar.Controls.Add(this.lbl_LableListVideo);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(20, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(664, 40);
            this.panel_TitleBar.TabIndex = 0;
            // 
            // lbl_LableListVideo
            // 
            this.lbl_LableListVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_LableListVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LableListVideo.ForeColor = System.Drawing.Color.Black;
            this.lbl_LableListVideo.Location = new System.Drawing.Point(0, 0);
            this.lbl_LableListVideo.Name = "lbl_LableListVideo";
            this.lbl_LableListVideo.Size = new System.Drawing.Size(116, 40);
            this.lbl_LableListVideo.TabIndex = 0;
            this.lbl_LableListVideo.Text = "Danh sách video";
            this.lbl_LableListVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ContainVideo
            // 
            this.panel_ContainVideo.AutoScroll = true;
            this.panel_ContainVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainVideo.Location = new System.Drawing.Point(20, 40);
            this.panel_ContainVideo.Name = "panel_ContainVideo";
            this.panel_ContainVideo.Size = new System.Drawing.Size(664, 441);
            this.panel_ContainVideo.TabIndex = 1;
            // 
            // btn_Local
            // 
            this.btn_Local.BackgroundImage = global::PlayMusic.Properties.Resources.video_local_blue;
            this.btn_Local.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Local.FlatAppearance.BorderSize = 0;
            this.btn_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Local.Location = new System.Drawing.Point(122, 9);
            this.btn_Local.Name = "btn_Local";
            this.btn_Local.Size = new System.Drawing.Size(24, 24);
            this.btn_Local.TabIndex = 1;
            this.btn_Local.UseVisualStyleBackColor = true;
            this.btn_Local.Click += new System.EventHandler(this.btn_Local_Click);
            this.btn_Local.MouseLeave += new System.EventHandler(this.btn_Local_MouseLeave);
            this.btn_Local.MouseHover += new System.EventHandler(this.btn_Local_MouseHover);
            // 
            // btn_YoutubeDownloader
            // 
            this.btn_YoutubeDownloader.BackgroundImage = global::PlayMusic.Properties.Resources.youtube_gray;
            this.btn_YoutubeDownloader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_YoutubeDownloader.FlatAppearance.BorderSize = 0;
            this.btn_YoutubeDownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YoutubeDownloader.Location = new System.Drawing.Point(152, 9);
            this.btn_YoutubeDownloader.Name = "btn_YoutubeDownloader";
            this.btn_YoutubeDownloader.Size = new System.Drawing.Size(24, 24);
            this.btn_YoutubeDownloader.TabIndex = 1;
            this.btn_YoutubeDownloader.UseVisualStyleBackColor = true;
            this.btn_YoutubeDownloader.Click += new System.EventHandler(this.btn_YoutubeDownloader_Click);
            this.btn_YoutubeDownloader.MouseLeave += new System.EventHandler(this.btn_YoutubeDownloader_MouseLeave);
            this.btn_YoutubeDownloader.MouseHover += new System.EventHandler(this.btn_YoutubeDownloader_MouseHover);
            // 
            // btn_BrowerFolder
            // 
            this.btn_BrowerFolder.BackgroundImage = global::PlayMusic.Properties.Resources.browse_folder_gray;
            this.btn_BrowerFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BrowerFolder.FlatAppearance.BorderSize = 0;
            this.btn_BrowerFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowerFolder.Location = new System.Drawing.Point(182, 9);
            this.btn_BrowerFolder.Name = "btn_BrowerFolder";
            this.btn_BrowerFolder.Size = new System.Drawing.Size(24, 24);
            this.btn_BrowerFolder.TabIndex = 1;
            this.btn_BrowerFolder.UseVisualStyleBackColor = true;
            this.btn_BrowerFolder.Click += new System.EventHandler(this.btn_BrowerFolder_Click);
            this.btn_BrowerFolder.MouseLeave += new System.EventHandler(this.btn_BrowerFolder_MouseLeave);
            this.btn_BrowerFolder.MouseHover += new System.EventHandler(this.btn_BrowerFolder_MouseHover);
            // 
            // VideosPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_ContainVideo);
            this.Controls.Add(this.panel_TitleBar);
            this.Name = "VideosPlay";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Text = "VideosPlay";
            this.Load += new System.EventHandler(this.VideosPlay_Load);
            this.panel_TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label lbl_LableListVideo;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainVideo;
        private System.Windows.Forms.Button btn_BrowerFolder;
        private System.Windows.Forms.Button btn_Local;
        private System.Windows.Forms.Button btn_YoutubeDownloader;
    }
}