namespace PlayMusic.ChildForm
{
    partial class PlayingMusic
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
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_ListSong = new System.Windows.Forms.Panel();
            this.panel_ContainSongs = new System.Windows.Forms.Panel();
            this.lbl_NoSong = new System.Windows.Forms.Label();
            this.panel_TitlePlayList = new System.Windows.Forms.Panel();
            this.lbl_TitlePlayList = new System.Windows.Forms.Label();
            this.panel_ControlBar = new System.Windows.Forms.Panel();
            this.btn_VolMute = new System.Windows.Forms.Button();
            this.btn_Repeat = new System.Windows.Forms.Button();
            this.lbl_Vol = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.lbl_SongName = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.lbl_SinggerName = new System.Windows.Forms.Label();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.lbl_CurrentPosition = new System.Windows.Forms.Label();
            this.pic_ImgSong = new PlayMusic.CustomControl.RoundPictureBox();
            this.trackBar_Volume = new PlayMusic.TrackBarCustom();
            this.trackPlaying = new PlayMusic.TrackBarCustom();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_ListSong.SuspendLayout();
            this.panel_ContainSongs.SuspendLayout();
            this.panel_TitlePlayList.SuspendLayout();
            this.panel_ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImgSong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(629, 92);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(39, 17);
            this.lbl_Duration.TabIndex = 29;
            this.lbl_Duration.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel_ListSong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 375);
            this.panel1.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pic_ImgSong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 375);
            this.panel4.TabIndex = 2;
            // 
            // panel_ListSong
            // 
            this.panel_ListSong.AutoScroll = true;
            this.panel_ListSong.BackColor = System.Drawing.Color.White;
            this.panel_ListSong.Controls.Add(this.panel_ContainSongs);
            this.panel_ListSong.Controls.Add(this.panel_TitlePlayList);
            this.panel_ListSong.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ListSong.Location = new System.Drawing.Point(360, 0);
            this.panel_ListSong.Name = "panel_ListSong";
            this.panel_ListSong.Size = new System.Drawing.Size(324, 375);
            this.panel_ListSong.TabIndex = 1;
            // 
            // panel_ContainSongs
            // 
            this.panel_ContainSongs.AutoScroll = true;
            this.panel_ContainSongs.Controls.Add(this.lbl_NoSong);
            this.panel_ContainSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainSongs.Location = new System.Drawing.Point(0, 26);
            this.panel_ContainSongs.Name = "panel_ContainSongs";
            this.panel_ContainSongs.Size = new System.Drawing.Size(324, 349);
            this.panel_ContainSongs.TabIndex = 1;
            // 
            // lbl_NoSong
            // 
            this.lbl_NoSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_NoSong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NoSong.Location = new System.Drawing.Point(0, 0);
            this.lbl_NoSong.Name = "lbl_NoSong";
            this.lbl_NoSong.Size = new System.Drawing.Size(324, 17);
            this.lbl_NoSong.TabIndex = 0;
            this.lbl_NoSong.Text = "Chưa có bài hát nào";
            this.lbl_NoSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_TitlePlayList
            // 
            this.panel_TitlePlayList.Controls.Add(this.lbl_TitlePlayList);
            this.panel_TitlePlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitlePlayList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_TitlePlayList.Location = new System.Drawing.Point(0, 0);
            this.panel_TitlePlayList.Name = "panel_TitlePlayList";
            this.panel_TitlePlayList.Size = new System.Drawing.Size(324, 26);
            this.panel_TitlePlayList.TabIndex = 0;
            // 
            // lbl_TitlePlayList
            // 
            this.lbl_TitlePlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TitlePlayList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitlePlayList.ForeColor = System.Drawing.Color.Black;
            this.lbl_TitlePlayList.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitlePlayList.Name = "lbl_TitlePlayList";
            this.lbl_TitlePlayList.Size = new System.Drawing.Size(324, 26);
            this.lbl_TitlePlayList.TabIndex = 0;
            this.lbl_TitlePlayList.Text = "Danh sách phát";
            this.lbl_TitlePlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ControlBar
            // 
            this.panel_ControlBar.BackColor = System.Drawing.Color.White;
            this.panel_ControlBar.Controls.Add(this.btn_VolMute);
            this.panel_ControlBar.Controls.Add(this.btn_Repeat);
            this.panel_ControlBar.Controls.Add(this.lbl_Vol);
            this.panel_ControlBar.Controls.Add(this.lbl_Duration);
            this.panel_ControlBar.Controls.Add(this.btn_Next);
            this.panel_ControlBar.Controls.Add(this.btn_Shuffle);
            this.panel_ControlBar.Controls.Add(this.lbl_SongName);
            this.panel_ControlBar.Controls.Add(this.btn_Previous);
            this.panel_ControlBar.Controls.Add(this.lbl_SinggerName);
            this.panel_ControlBar.Controls.Add(this.btn_PlayPause);
            this.panel_ControlBar.Controls.Add(this.trackBar_Volume);
            this.panel_ControlBar.Controls.Add(this.trackPlaying);
            this.panel_ControlBar.Controls.Add(this.lbl_CurrentPosition);
            this.panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ControlBar.Location = new System.Drawing.Point(0, 375);
            this.panel_ControlBar.Name = "panel_ControlBar";
            this.panel_ControlBar.Size = new System.Drawing.Size(684, 170);
            this.panel_ControlBar.TabIndex = 36;
            // 
            // btn_VolMute
            // 
            this.btn_VolMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VolMute.BackgroundImage = global::PlayMusic.Properties.Resources.audio_blue;
            this.btn_VolMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VolMute.FlatAppearance.BorderSize = 0;
            this.btn_VolMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolMute.Location = new System.Drawing.Point(412, 126);
            this.btn_VolMute.Name = "btn_VolMute";
            this.btn_VolMute.Size = new System.Drawing.Size(20, 20);
            this.btn_VolMute.TabIndex = 39;
            this.btn_VolMute.UseVisualStyleBackColor = true;
            this.btn_VolMute.Click += new System.EventHandler(this.btn_VolMute_Click);
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Repeat.BackgroundImage = global::PlayMusic.Properties.Resources.repeat_gray;
            this.btn_Repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Repeat.FlatAppearance.BorderSize = 0;
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.Location = new System.Drawing.Point(320, 120);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(30, 30);
            this.btn_Repeat.TabIndex = 39;
            this.btn_Repeat.UseVisualStyleBackColor = true;
            this.btn_Repeat.Click += new System.EventHandler(this.btn_Repeat_Click);
            // 
            // lbl_Vol
            // 
            this.lbl_Vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Vol.AutoSize = true;
            this.lbl_Vol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vol.Location = new System.Drawing.Point(629, 126);
            this.lbl_Vol.Name = "lbl_Vol";
            this.lbl_Vol.Size = new System.Drawing.Size(33, 17);
            this.lbl_Vol.TabIndex = 29;
            this.lbl_Vol.Text = "50%";
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Next.BackgroundImage = global::PlayMusic.Properties.Resources.next_blue;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(269, 120);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(30, 30);
            this.btn_Next.TabIndex = 40;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Shuffle.BackgroundImage = global::PlayMusic.Properties.Resources.shuffle_gray;
            this.btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shuffle.Location = new System.Drawing.Point(116, 120);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(30, 30);
            this.btn_Shuffle.TabIndex = 41;
            this.btn_Shuffle.UseVisualStyleBackColor = true;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            // 
            // lbl_SongName
            // 
            this.lbl_SongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SongName.AutoSize = true;
            this.lbl_SongName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_SongName.Location = new System.Drawing.Point(12, 9);
            this.lbl_SongName.Name = "lbl_SongName";
            this.lbl_SongName.Size = new System.Drawing.Size(35, 32);
            this.lbl_SongName.TabIndex = 35;
            this.lbl_SongName.Text = "--";
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Previous.BackgroundImage = global::PlayMusic.Properties.Resources.previous_blue;
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previous.FlatAppearance.BorderSize = 0;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Location = new System.Drawing.Point(167, 120);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(30, 30);
            this.btn_Previous.TabIndex = 42;
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // lbl_SinggerName
            // 
            this.lbl_SinggerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SinggerName.AutoSize = true;
            this.lbl_SinggerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SinggerName.Location = new System.Drawing.Point(13, 53);
            this.lbl_SinggerName.Name = "lbl_SinggerName";
            this.lbl_SinggerName.Size = new System.Drawing.Size(21, 20);
            this.lbl_SinggerName.TabIndex = 36;
            this.lbl_SinggerName.Text = "--";
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_PlayPause.BackgroundImage = global::PlayMusic.Properties.Resources.play_blue;
            this.btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.Location = new System.Drawing.Point(218, 120);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(30, 30);
            this.btn_PlayPause.TabIndex = 43;
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // lbl_CurrentPosition
            // 
            this.lbl_CurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CurrentPosition.AutoSize = true;
            this.lbl_CurrentPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPosition.Location = new System.Drawing.Point(14, 92);
            this.lbl_CurrentPosition.Name = "lbl_CurrentPosition";
            this.lbl_CurrentPosition.Size = new System.Drawing.Size(39, 17);
            this.lbl_CurrentPosition.TabIndex = 38;
            this.lbl_CurrentPosition.Text = "00:00";
            // 
            // pic_ImgSong
            // 
            this.pic_ImgSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_ImgSong.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_ImgSong.Location = new System.Drawing.Point(59, 71);
            this.pic_ImgSong.Name = "pic_ImgSong";
            this.pic_ImgSong.Size = new System.Drawing.Size(250, 250);
            this.pic_ImgSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImgSong.TabIndex = 0;
            this.pic_ImgSong.TabStop = false;
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Volume.BackColor = System.Drawing.Color.White;
            this.trackBar_Volume.BarInnerColor = System.Drawing.Color.Silver;
            this.trackBar_Volume.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.trackBar_Volume.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.trackBar_Volume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBar_Volume.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackBar_Volume.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackBar_Volume.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackBar_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.trackBar_Volume.ForeColor = System.Drawing.Color.White;
            this.trackBar_Volume.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBar_Volume.Location = new System.Drawing.Point(447, 126);
            this.trackBar_Volume.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.trackBar_Volume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.trackBar_Volume.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBar_Volume.ShowDivisionsText = true;
            this.trackBar_Volume.ShowSmallScale = false;
            this.trackBar_Volume.Size = new System.Drawing.Size(176, 20);
            this.trackBar_Volume.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackBar_Volume.TabIndex = 37;
            this.trackBar_Volume.Text = "tracBarCustom1";
            this.trackBar_Volume.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackBar_Volume.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackBar_Volume.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
            this.trackBar_Volume.ThumbSize = new System.Drawing.Size(10, 10);
            this.trackBar_Volume.TickAdd = 0F;
            this.trackBar_Volume.TickColor = System.Drawing.Color.White;
            this.trackBar_Volume.TickDivide = 0F;
            this.trackBar_Volume.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.trackBar_Volume.ValueChanged += new System.EventHandler(this.trackBar_Volume_ValueChanged);
            // 
            // trackPlaying
            // 
            this.trackPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackPlaying.BackColor = System.Drawing.Color.White;
            this.trackPlaying.BarInnerColor = System.Drawing.Color.Silver;
            this.trackPlaying.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.trackPlaying.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.trackPlaying.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackPlaying.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.trackPlaying.ForeColor = System.Drawing.Color.White;
            this.trackPlaying.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackPlaying.Location = new System.Drawing.Point(59, 87);
            this.trackPlaying.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.trackPlaying.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackPlaying.Name = "trackPlaying";
            this.trackPlaying.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.trackPlaying.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackPlaying.ShowDivisionsText = true;
            this.trackPlaying.ShowSmallScale = false;
            this.trackPlaying.Size = new System.Drawing.Size(564, 29);
            this.trackPlaying.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackPlaying.TabIndex = 37;
            this.trackPlaying.Text = "tracBarCustom1";
            this.trackPlaying.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ThumbRoundRectSize = new System.Drawing.Size(12, 12);
            this.trackPlaying.ThumbSize = new System.Drawing.Size(12, 12);
            this.trackPlaying.TickAdd = 0F;
            this.trackPlaying.TickColor = System.Drawing.Color.White;
            this.trackPlaying.TickDivide = 0F;
            this.trackPlaying.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackPlaying.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackPlaying_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(359, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 375);
            this.panel2.TabIndex = 1;
            // 
            // PlayingMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ControlBar);
            this.Name = "PlayingMusic";
            this.Text = "PlayingMusic";
            this.Load += new System.EventHandler(this.PlayingMusic_Load);
            this.Shown += new System.EventHandler(this.PlayingMusic_Shown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_ListSong.ResumeLayout(false);
            this.panel_ContainSongs.ResumeLayout(false);
            this.panel_TitlePlayList.ResumeLayout(false);
            this.panel_ControlBar.ResumeLayout(false);
            this.panel_ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImgSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_Duration;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private PlayMusic.CustomControl.RoundPictureBox pic_ImgSong;
        public System.Windows.Forms.Panel panel_ListSong;
        public System.Windows.Forms.Panel panel_ControlBar;
        public System.Windows.Forms.Button btn_Repeat;
        private System.Windows.Forms.Button btn_Next;
        public System.Windows.Forms.Button btn_Shuffle;
        public System.Windows.Forms.Label lbl_SongName;
        private System.Windows.Forms.Button btn_Previous;
        public System.Windows.Forms.Label lbl_SinggerName;
        public System.Windows.Forms.Button btn_PlayPause;
        public TrackBarCustom trackPlaying;
        public System.Windows.Forms.Label lbl_CurrentPosition;
        private System.Windows.Forms.Panel panel_ContainSongs;
        private System.Windows.Forms.Panel panel_TitlePlayList;
        private System.Windows.Forms.Label lbl_TitlePlayList;
        public System.Windows.Forms.Button btn_VolMute;
        public TrackBarCustom trackBar_Volume;
        private System.Windows.Forms.Label lbl_Vol;
        private System.Windows.Forms.Label lbl_NoSong;
        private System.Windows.Forms.Panel panel2;
    }
}