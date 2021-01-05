namespace PlayMusic.ChildForm
{
    partial class PlaylistMusic
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Playlist = new System.Windows.Forms.Panel();
            this.panel_ContainPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_PlaylistBar = new System.Windows.Forms.Panel();
            this.btn_AddPlaylist = new System.Windows.Forms.Button();
            this.label_TitlePlaylist = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            this.panel_Playlist.SuspendLayout();
            this.panel_PlaylistBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_Playlist);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(20, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(664, 481);
            this.panel_Main.TabIndex = 0;
            // 
            // panel_Playlist
            // 
            this.panel_Playlist.Controls.Add(this.panel_ContainPlaylist);
            this.panel_Playlist.Controls.Add(this.panel_PlaylistBar);
            this.panel_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Playlist.Location = new System.Drawing.Point(0, 0);
            this.panel_Playlist.Name = "panel_Playlist";
            this.panel_Playlist.Size = new System.Drawing.Size(664, 481);
            this.panel_Playlist.TabIndex = 0;
            // 
            // panel_ContainPlaylist
            // 
            this.panel_ContainPlaylist.AutoScroll = true;
            this.panel_ContainPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainPlaylist.Location = new System.Drawing.Point(0, 36);
            this.panel_ContainPlaylist.Name = "panel_ContainPlaylist";
            this.panel_ContainPlaylist.Size = new System.Drawing.Size(664, 445);
            this.panel_ContainPlaylist.TabIndex = 3;
            // 
            // panel_PlaylistBar
            // 
            this.panel_PlaylistBar.Controls.Add(this.btn_AddPlaylist);
            this.panel_PlaylistBar.Controls.Add(this.label_TitlePlaylist);
            this.panel_PlaylistBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PlaylistBar.Location = new System.Drawing.Point(0, 0);
            this.panel_PlaylistBar.Name = "panel_PlaylistBar";
            this.panel_PlaylistBar.Size = new System.Drawing.Size(664, 36);
            this.panel_PlaylistBar.TabIndex = 2;
            // 
            // btn_AddPlaylist
            // 
            this.btn_AddPlaylist.BackgroundImage = global::PlayMusic.Properties.Resources.add_gray;
            this.btn_AddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_AddPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AddPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPlaylist.Location = new System.Drawing.Point(114, 7);
            this.btn_AddPlaylist.Name = "btn_AddPlaylist";
            this.btn_AddPlaylist.Size = new System.Drawing.Size(25, 25);
            this.btn_AddPlaylist.TabIndex = 1;
            this.btn_AddPlaylist.UseVisualStyleBackColor = true;
            this.btn_AddPlaylist.Click += new System.EventHandler(this.btn_AddPlaylist_Click);
            this.btn_AddPlaylist.MouseLeave += new System.EventHandler(this.btn_AddPlaylist_MouseLeave);
            this.btn_AddPlaylist.MouseHover += new System.EventHandler(this.btn_AddPlaylist_MouseHover);
            // 
            // label_TitlePlaylist
            // 
            this.label_TitlePlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_TitlePlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitlePlaylist.ForeColor = System.Drawing.Color.Black;
            this.label_TitlePlaylist.Location = new System.Drawing.Point(0, 0);
            this.label_TitlePlaylist.Name = "label_TitlePlaylist";
            this.label_TitlePlaylist.Size = new System.Drawing.Size(108, 36);
            this.label_TitlePlaylist.TabIndex = 0;
            this.label_TitlePlaylist.Text = "Danh sách phát";
            this.label_TitlePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlaylistMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_Main);
            this.Name = "PlaylistMusic";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Text = "PlaylistMusic";
            this.Load += new System.EventHandler(this.PlaylistMusic_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel_Playlist.ResumeLayout(false);
            this.panel_PlaylistBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Playlist;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainPlaylist;
        private System.Windows.Forms.Panel panel_PlaylistBar;
        private System.Windows.Forms.Button btn_AddPlaylist;
        private System.Windows.Forms.Label label_TitlePlaylist;
    }
}