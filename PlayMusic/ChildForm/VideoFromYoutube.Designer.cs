
namespace PlayMusic.ChildForm
{
    partial class VideoFromYoutube
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
            this.txb_AdressBar = new System.Windows.Forms.TextBox();
            this.panel_ControlBar = new System.Windows.Forms.Panel();
            this.bnt_Download = new System.Windows.Forms.Button();
            this.btn_HomePage = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel_ContainBrower = new System.Windows.Forms.Panel();
            this.panel_ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_AdressBar
            // 
            this.txb_AdressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_AdressBar.BackColor = System.Drawing.Color.White;
            this.txb_AdressBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_AdressBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_AdressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txb_AdressBar.Location = new System.Drawing.Point(103, 5);
            this.txb_AdressBar.Name = "txb_AdressBar";
            this.txb_AdressBar.ReadOnly = true;
            this.txb_AdressBar.Size = new System.Drawing.Size(538, 18);
            this.txb_AdressBar.TabIndex = 0;
            this.txb_AdressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_AdressBar_KeyDown);
            // 
            // panel_ControlBar
            // 
            this.panel_ControlBar.Controls.Add(this.txb_AdressBar);
            this.panel_ControlBar.Controls.Add(this.bnt_Download);
            this.panel_ControlBar.Controls.Add(this.btn_HomePage);
            this.panel_ControlBar.Controls.Add(this.btn_Forward);
            this.panel_ControlBar.Controls.Add(this.btn_Back);
            this.panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBar.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBar.Name = "panel_ControlBar";
            this.panel_ControlBar.Size = new System.Drawing.Size(684, 30);
            this.panel_ControlBar.TabIndex = 2;
            // 
            // bnt_Download
            // 
            this.bnt_Download.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bnt_Download.BackgroundImage = global::PlayMusic.Properties.Resources.downloads_blue;
            this.bnt_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_Download.FlatAppearance.BorderSize = 0;
            this.bnt_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Download.Location = new System.Drawing.Point(647, 4);
            this.bnt_Download.Name = "bnt_Download";
            this.bnt_Download.Size = new System.Drawing.Size(22, 22);
            this.bnt_Download.TabIndex = 1;
            this.bnt_Download.UseVisualStyleBackColor = true;
            this.bnt_Download.Click += new System.EventHandler(this.bnt_Download_Click);
            // 
            // btn_HomePage
            // 
            this.btn_HomePage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_HomePage.BackgroundImage = global::PlayMusic.Properties.Resources.home_page_blue;
            this.btn_HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HomePage.FlatAppearance.BorderSize = 0;
            this.btn_HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HomePage.Location = new System.Drawing.Point(75, 3);
            this.btn_HomePage.Name = "btn_HomePage";
            this.btn_HomePage.Size = new System.Drawing.Size(22, 22);
            this.btn_HomePage.TabIndex = 1;
            this.btn_HomePage.UseVisualStyleBackColor = true;
            this.btn_HomePage.Click += new System.EventHandler(this.btn_HomePage_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Forward.BackgroundImage = global::PlayMusic.Properties.Resources.chevron_right_blue;
            this.btn_Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Forward.FlatAppearance.BorderSize = 0;
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.Location = new System.Drawing.Point(47, 3);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(22, 22);
            this.btn_Forward.TabIndex = 1;
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Back.BackgroundImage = global::PlayMusic.Properties.Resources.chevron_left_blue;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(11, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(22, 22);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel_ContainBrower
            // 
            this.panel_ContainBrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainBrower.Location = new System.Drawing.Point(0, 30);
            this.panel_ContainBrower.Name = "panel_ContainBrower";
            this.panel_ContainBrower.Size = new System.Drawing.Size(684, 451);
            this.panel_ContainBrower.TabIndex = 3;
            // 
            // VideoFromYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_ContainBrower);
            this.Controls.Add(this.panel_ControlBar);
            this.Name = "VideoFromYoutube";
            this.ShowIcon = false;
            this.Text = "VideoFormYoutube";
            this.panel_ControlBar.ResumeLayout(false);
            this.panel_ControlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_AdressBar;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel_ControlBar;
        private System.Windows.Forms.Button bnt_Download;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Panel panel_ContainBrower;
        private System.Windows.Forms.Button btn_HomePage;
    }
}