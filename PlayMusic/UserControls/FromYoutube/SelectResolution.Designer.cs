
namespace PlayMusic.UserControls.FromYoutube
{
    partial class SelectResolution
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
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Video = new System.Windows.Forms.Panel();
            this.lbl_TitleVideo = new System.Windows.Forms.Label();
            this.pic_Thumnail = new System.Windows.Forms.PictureBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.AutoScroll = true;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Content.Location = new System.Drawing.Point(0, 93);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(274, 258);
            this.panel_Content.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Title.Size = new System.Drawing.Size(274, 30);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Chọn độ phân giải video";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Video
            // 
            this.panel_Video.Controls.Add(this.lbl_TitleVideo);
            this.panel_Video.Controls.Add(this.pic_Thumnail);
            this.panel_Video.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Video.Location = new System.Drawing.Point(0, 33);
            this.panel_Video.Name = "panel_Video";
            this.panel_Video.Size = new System.Drawing.Size(274, 60);
            this.panel_Video.TabIndex = 11;
            // 
            // lbl_TitleVideo
            // 
            this.lbl_TitleVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleVideo.Location = new System.Drawing.Point(69, 5);
            this.lbl_TitleVideo.Name = "lbl_TitleVideo";
            this.lbl_TitleVideo.Size = new System.Drawing.Size(187, 50);
            this.lbl_TitleVideo.TabIndex = 1;
            this.lbl_TitleVideo.Text = "Đang phân tích Video...";
            this.lbl_TitleVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_Thumnail
            // 
            this.pic_Thumnail.Image = global::PlayMusic.Properties.Resources.youtube;
            this.pic_Thumnail.Location = new System.Drawing.Point(12, 5);
            this.pic_Thumnail.Name = "pic_Thumnail";
            this.pic_Thumnail.Size = new System.Drawing.Size(50, 50);
            this.pic_Thumnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Thumnail.TabIndex = 0;
            this.pic_Thumnail.TabStop = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackgroundImage = global::PlayMusic.Properties.Resources.ok_blue;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(232, 0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(30, 31);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::PlayMusic.Properties.Resources.cancel_red;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(196, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(30, 31);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SelectResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 351);
            this.Controls.Add(this.panel_Video);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.panel_Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectResolution";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tải xuống";
            this.Load += new System.EventHandler(this.SelectResolution_Load);
            this.panel_Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel_Video;
        private System.Windows.Forms.Label lbl_TitleVideo;
        private System.Windows.Forms.PictureBox pic_Thumnail;
    }
}