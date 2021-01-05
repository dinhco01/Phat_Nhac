using PlayMusic.Properties;

namespace PlayMusic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_ControlBar = new System.Windows.Forms.Panel();
            this.btn_Repeat = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_MuteVol = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_CurrentPosition = new System.Windows.Forms.Label();
            this.trackPlaying = new PlayMusic.TrackBarCustom();
            this.lbl_NameSingger = new System.Windows.Forms.Label();
            this.lbl_SongName = new System.Windows.Forms.Label();
            this.pic_ImageSong = new PlayMusic.CustomControl.RoundPictureBox();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_UserInfo = new System.Windows.Forms.Panel();
            this.pic_User = new PlayMusic.CustomControl.RoundPictureBox();
            this.lbl_UserDisplayName = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.menu_Settings = new System.Windows.Forms.Panel();
            this.panel_SelectedSettings = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pic_Settings = new System.Windows.Forms.PictureBox();
            this.menu_Zing = new System.Windows.Forms.Panel();
            this.btn_Zing = new System.Windows.Forms.Button();
            this.pic_Zing = new System.Windows.Forms.PictureBox();
            this.pic_SelectZing = new System.Windows.Forms.PictureBox();
            this.menu_Youtube = new System.Windows.Forms.Panel();
            this.btn_Youtube = new System.Windows.Forms.Button();
            this.pic_Youtube = new System.Windows.Forms.PictureBox();
            this.pic_SelectYotube = new System.Windows.Forms.PictureBox();
            this.menu_Online = new System.Windows.Forms.Panel();
            this.panel_SelectedOnline = new System.Windows.Forms.Panel();
            this.btn_Online = new System.Windows.Forms.Button();
            this.pic_Online = new System.Windows.Forms.PictureBox();
            this.menu_Video = new System.Windows.Forms.Panel();
            this.panel_SelectedVideo = new System.Windows.Forms.Panel();
            this.btn_Video = new System.Windows.Forms.Button();
            this.pic_Video = new System.Windows.Forms.PictureBox();
            this.menu_Playlist = new System.Windows.Forms.Panel();
            this.panel_SelectedPlaylist = new System.Windows.Forms.Panel();
            this.btn_Playlist = new System.Windows.Forms.Button();
            this.pic_Playlist = new System.Windows.Forms.PictureBox();
            this.menu_Song = new System.Windows.Forms.Panel();
            this.panel_SelectedSong = new System.Windows.Forms.Panel();
            this.btn_Song = new System.Windows.Forms.Button();
            this.pic_Song = new System.Windows.Forms.PictureBox();
            this.menu_Search = new System.Windows.Forms.Panel();
            this.panel_SelectedSearch = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.menu_Recent = new System.Windows.Forms.Panel();
            this.panel_SelectedRecent = new System.Windows.Forms.Panel();
            this.btn_Recent = new System.Windows.Forms.Button();
            this.pic_Recent = new System.Windows.Forms.PictureBox();
            this.menu_Playing = new System.Windows.Forms.Panel();
            this.panel_SelectedPlaying = new System.Windows.Forms.Panel();
            this.btn_Playing = new System.Windows.Forms.Button();
            this.pic_Playing = new System.Windows.Forms.PictureBox();
            this.panel_User = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.panel_ChildForm.SuspendLayout();
            this.panel_ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageSong)).BeginInit();
            this.panel_TitleBar.SuspendLayout();
            this.panel_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_Main.SuspendLayout();
            this.menu_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).BeginInit();
            this.menu_Zing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Zing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SelectZing)).BeginInit();
            this.menu_Youtube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SelectYotube)).BeginInit();
            this.menu_Online.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Online)).BeginInit();
            this.menu_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Video)).BeginInit();
            this.menu_Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).BeginInit();
            this.menu_Song.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.menu_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            this.menu_Recent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Recent)).BeginInit();
            this.menu_Playing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playing)).BeginInit();
            this.panel_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.AutoSize = true;
            this.panel_ChildForm.BackColor = System.Drawing.Color.White;
            this.panel_ChildForm.Controls.Add(this.panel_ControlBar);
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(250, 30);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(700, 520);
            this.panel_ChildForm.TabIndex = 5;
            // 
            // panel_ControlBar
            // 
            this.panel_ControlBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ControlBar.Controls.Add(this.btn_Repeat);
            this.panel_ControlBar.Controls.Add(this.btn_Next);
            this.panel_ControlBar.Controls.Add(this.btn_MuteVol);
            this.panel_ControlBar.Controls.Add(this.btn_Shuffle);
            this.panel_ControlBar.Controls.Add(this.btn_Previous);
            this.panel_ControlBar.Controls.Add(this.btn_PlayPause);
            this.panel_ControlBar.Controls.Add(this.lbl_Duration);
            this.panel_ControlBar.Controls.Add(this.lbl_CurrentPosition);
            this.panel_ControlBar.Controls.Add(this.trackPlaying);
            this.panel_ControlBar.Controls.Add(this.lbl_NameSingger);
            this.panel_ControlBar.Controls.Add(this.lbl_SongName);
            this.panel_ControlBar.Controls.Add(this.pic_ImageSong);
            this.panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ControlBar.Location = new System.Drawing.Point(0, 456);
            this.panel_ControlBar.Name = "panel_ControlBar";
            this.panel_ControlBar.Size = new System.Drawing.Size(700, 64);
            this.panel_ControlBar.TabIndex = 6;
            this.panel_ControlBar.DoubleClick += new System.EventHandler(this.panel_ControlBar_DoubleClick);
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Repeat.BackgroundImage = global::PlayMusic.Properties.Resources.repeat_gray;
            this.btn_Repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Repeat.FlatAppearance.BorderSize = 0;
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.Location = new System.Drawing.Point(623, 29);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(25, 25);
            this.btn_Repeat.TabIndex = 24;
            this.btn_Repeat.UseVisualStyleBackColor = true;
            this.btn_Repeat.Click += new System.EventHandler(this.btn_Repeat_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Next.BackgroundImage = global::PlayMusic.Properties.Resources.next_blue;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(572, 29);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(25, 25);
            this.btn_Next.TabIndex = 24;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_MuteVol
            // 
            this.btn_MuteVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_MuteVol.BackgroundImage = global::PlayMusic.Properties.Resources.audio_blue;
            this.btn_MuteVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MuteVol.FlatAppearance.BorderSize = 0;
            this.btn_MuteVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MuteVol.Location = new System.Drawing.Point(312, 29);
            this.btn_MuteVol.Name = "btn_MuteVol";
            this.btn_MuteVol.Size = new System.Drawing.Size(25, 25);
            this.btn_MuteVol.TabIndex = 24;
            this.btn_MuteVol.UseVisualStyleBackColor = true;
            this.btn_MuteVol.Click += new System.EventHandler(this.btn_MuteVol_Click);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Shuffle.BackgroundImage = global::PlayMusic.Properties.Resources.shuffle_gray;
            this.btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shuffle.Location = new System.Drawing.Point(419, 29);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(25, 25);
            this.btn_Shuffle.TabIndex = 24;
            this.btn_Shuffle.UseVisualStyleBackColor = true;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Previous.BackgroundImage = global::PlayMusic.Properties.Resources.previous_blue;
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previous.FlatAppearance.BorderSize = 0;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Location = new System.Drawing.Point(470, 29);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(25, 25);
            this.btn_Previous.TabIndex = 24;
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_PlayPause.BackgroundImage = global::PlayMusic.Properties.Resources.play_blue;
            this.btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.Location = new System.Drawing.Point(521, 29);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(25, 25);
            this.btn_PlayPause.TabIndex = 24;
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(751, 11);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(34, 13);
            this.lbl_Duration.TabIndex = 3;
            this.lbl_Duration.Text = "00:00";
            // 
            // lbl_CurrentPosition
            // 
            this.lbl_CurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CurrentPosition.AutoSize = true;
            this.lbl_CurrentPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPosition.Location = new System.Drawing.Point(272, 11);
            this.lbl_CurrentPosition.Name = "lbl_CurrentPosition";
            this.lbl_CurrentPosition.Size = new System.Drawing.Size(34, 13);
            this.lbl_CurrentPosition.TabIndex = 3;
            this.lbl_CurrentPosition.Text = "00:00";
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
            this.trackPlaying.Location = new System.Drawing.Point(312, 3);
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
            this.trackPlaying.Size = new System.Drawing.Size(375, 29);
            this.trackPlaying.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackPlaying.TabIndex = 2;
            this.trackPlaying.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.trackPlaying.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
            this.trackPlaying.ThumbSize = new System.Drawing.Size(10, 10);
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
            // lbl_NameSingger
            // 
            this.lbl_NameSingger.AutoSize = true;
            this.lbl_NameSingger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameSingger.Location = new System.Drawing.Point(57, 36);
            this.lbl_NameSingger.Name = "lbl_NameSingger";
            this.lbl_NameSingger.Size = new System.Drawing.Size(17, 15);
            this.lbl_NameSingger.TabIndex = 1;
            this.lbl_NameSingger.Text = "--";
            this.lbl_NameSingger.DoubleClick += new System.EventHandler(this.panel_ControlBar_DoubleClick);
            // 
            // lbl_SongName
            // 
            this.lbl_SongName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongName.Location = new System.Drawing.Point(56, 11);
            this.lbl_SongName.Name = "lbl_SongName";
            this.lbl_SongName.Size = new System.Drawing.Size(173, 21);
            this.lbl_SongName.TabIndex = 1;
            this.lbl_SongName.Text = "--";
            this.lbl_SongName.DoubleClick += new System.EventHandler(this.panel_ControlBar_DoubleClick);
            // 
            // pic_ImageSong
            // 
            this.pic_ImageSong.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_ImageSong.Location = new System.Drawing.Point(10, 11);
            this.pic_ImageSong.Name = "pic_ImageSong";
            this.pic_ImageSong.Size = new System.Drawing.Size(40, 40);
            this.pic_ImageSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImageSong.TabIndex = 0;
            this.pic_ImageSong.TabStop = false;
            this.pic_ImageSong.DoubleClick += new System.EventHandler(this.panel_ControlBar_DoubleClick);
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_TitleBar.Controls.Add(this.lbl_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(250, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(700, 30);
            this.panel_TitleBar.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(700, 30);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ĐANG PHÁT";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_UserInfo
            // 
            this.panel_UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_UserInfo.Controls.Add(this.pic_User);
            this.panel_UserInfo.Controls.Add(this.lbl_UserDisplayName);
            this.panel_UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_UserInfo.Name = "panel_UserInfo";
            this.panel_UserInfo.Size = new System.Drawing.Size(233, 173);
            this.panel_UserInfo.TabIndex = 6;
            // 
            // pic_User
            // 
            this.pic_User.Image = ((System.Drawing.Image)(resources.GetObject("pic_User.Image")));
            this.pic_User.Location = new System.Drawing.Point(56, 12);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(120, 120);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_User.TabIndex = 2;
            this.pic_User.TabStop = false;
            // 
            // lbl_UserDisplayName
            // 
            this.lbl_UserDisplayName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_UserDisplayName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserDisplayName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserDisplayName.Location = new System.Drawing.Point(0, 140);
            this.lbl_UserDisplayName.Name = "lbl_UserDisplayName";
            this.lbl_UserDisplayName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lbl_UserDisplayName.Size = new System.Drawing.Size(233, 33);
            this.lbl_UserDisplayName.TabIndex = 1;
            this.lbl_UserDisplayName.Text = "Hello!";
            this.lbl_UserDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UserDisplayName.Click += new System.EventHandler(this.lbl_UserDisplayName_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_Main.Controls.Add(this.menu_Settings);
            this.panel_Main.Controls.Add(this.menu_Zing);
            this.panel_Main.Controls.Add(this.menu_Youtube);
            this.panel_Main.Controls.Add(this.menu_Online);
            this.panel_Main.Controls.Add(this.menu_Video);
            this.panel_Main.Controls.Add(this.menu_Playlist);
            this.panel_Main.Controls.Add(this.menu_Song);
            this.panel_Main.Controls.Add(this.menu_Search);
            this.panel_Main.Controls.Add(this.menu_Recent);
            this.panel_Main.Controls.Add(this.menu_Playing);
            this.panel_Main.Controls.Add(this.panel_User);
            this.panel_Main.Controls.Add(this.panel_UserInfo);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(250, 550);
            this.panel_Main.TabIndex = 3;
            // 
            // menu_Settings
            // 
            this.menu_Settings.Controls.Add(this.panel_SelectedSettings);
            this.menu_Settings.Controls.Add(this.btn_Settings);
            this.menu_Settings.Controls.Add(this.pic_Settings);
            this.menu_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Settings.Location = new System.Drawing.Point(0, 613);
            this.menu_Settings.Name = "menu_Settings";
            this.menu_Settings.Size = new System.Drawing.Size(233, 50);
            this.menu_Settings.TabIndex = 32;
            this.menu_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // panel_SelectedSettings
            // 
            this.panel_SelectedSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedSettings.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedSettings.Name = "panel_SelectedSettings";
            this.panel_SelectedSettings.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedSettings.TabIndex = 24;
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Location = new System.Drawing.Point(56, 0);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(177, 50);
            this.btn_Settings.TabIndex = 19;
            this.btn_Settings.Text = "Cài đặt";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // pic_Settings
            // 
            this.pic_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Settings.Image = global::PlayMusic.Properties.Resources.video_white;
            this.pic_Settings.Location = new System.Drawing.Point(28, 14);
            this.pic_Settings.Name = "pic_Settings";
            this.pic_Settings.Size = new System.Drawing.Size(22, 22);
            this.pic_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Settings.TabIndex = 23;
            this.pic_Settings.TabStop = false;
            this.pic_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // menu_Zing
            // 
            this.menu_Zing.BackColor = System.Drawing.Color.White;
            this.menu_Zing.Controls.Add(this.btn_Zing);
            this.menu_Zing.Controls.Add(this.pic_Zing);
            this.menu_Zing.Controls.Add(this.pic_SelectZing);
            this.menu_Zing.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Zing.Location = new System.Drawing.Point(0, 583);
            this.menu_Zing.Name = "menu_Zing";
            this.menu_Zing.Size = new System.Drawing.Size(233, 30);
            this.menu_Zing.TabIndex = 30;
            this.menu_Zing.Click += new System.EventHandler(this.menu_Zing_Click);
            // 
            // btn_Zing
            // 
            this.btn_Zing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Zing.BackColor = System.Drawing.Color.White;
            this.btn_Zing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Zing.FlatAppearance.BorderSize = 0;
            this.btn_Zing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Zing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Zing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Zing.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Zing.Location = new System.Drawing.Point(82, 0);
            this.btn_Zing.Name = "btn_Zing";
            this.btn_Zing.Size = new System.Drawing.Size(151, 30);
            this.btn_Zing.TabIndex = 21;
            this.btn_Zing.Text = "Zing MP3";
            this.btn_Zing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Zing.UseVisualStyleBackColor = false;
            this.btn_Zing.Click += new System.EventHandler(this.menu_Zing_Click);
            // 
            // pic_Zing
            // 
            this.pic_Zing.BackColor = System.Drawing.Color.White;
            this.pic_Zing.Image = global::PlayMusic.Properties.Resources.zing_mp3_icon_color;
            this.pic_Zing.Location = new System.Drawing.Point(56, 5);
            this.pic_Zing.Name = "pic_Zing";
            this.pic_Zing.Size = new System.Drawing.Size(20, 20);
            this.pic_Zing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Zing.TabIndex = 23;
            this.pic_Zing.TabStop = false;
            this.pic_Zing.Click += new System.EventHandler(this.menu_Zing_Click);
            // 
            // pic_SelectZing
            // 
            this.pic_SelectZing.BackColor = System.Drawing.Color.White;
            this.pic_SelectZing.Image = global::PlayMusic.Properties.Resources.chevron_right_blue;
            this.pic_SelectZing.Location = new System.Drawing.Point(40, 8);
            this.pic_SelectZing.Name = "pic_SelectZing";
            this.pic_SelectZing.Size = new System.Drawing.Size(15, 15);
            this.pic_SelectZing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SelectZing.TabIndex = 23;
            this.pic_SelectZing.TabStop = false;
            // 
            // menu_Youtube
            // 
            this.menu_Youtube.BackColor = System.Drawing.Color.White;
            this.menu_Youtube.Controls.Add(this.btn_Youtube);
            this.menu_Youtube.Controls.Add(this.pic_Youtube);
            this.menu_Youtube.Controls.Add(this.pic_SelectYotube);
            this.menu_Youtube.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Youtube.Location = new System.Drawing.Point(0, 553);
            this.menu_Youtube.Name = "menu_Youtube";
            this.menu_Youtube.Size = new System.Drawing.Size(233, 30);
            this.menu_Youtube.TabIndex = 31;
            this.menu_Youtube.Click += new System.EventHandler(this.menu_Youtube_Click);
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Youtube.BackColor = System.Drawing.Color.White;
            this.btn_Youtube.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Youtube.FlatAppearance.BorderSize = 0;
            this.btn_Youtube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Youtube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Youtube.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Youtube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Youtube.Location = new System.Drawing.Point(82, 0);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(148, 30);
            this.btn_Youtube.TabIndex = 21;
            this.btn_Youtube.Text = "YouTube";
            this.btn_Youtube.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Youtube.UseVisualStyleBackColor = false;
            this.btn_Youtube.Click += new System.EventHandler(this.menu_Youtube_Click);
            // 
            // pic_Youtube
            // 
            this.pic_Youtube.BackColor = System.Drawing.Color.White;
            this.pic_Youtube.Image = global::PlayMusic.Properties.Resources.youtube1;
            this.pic_Youtube.Location = new System.Drawing.Point(56, 5);
            this.pic_Youtube.Name = "pic_Youtube";
            this.pic_Youtube.Size = new System.Drawing.Size(20, 20);
            this.pic_Youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Youtube.TabIndex = 23;
            this.pic_Youtube.TabStop = false;
            this.pic_Youtube.Click += new System.EventHandler(this.menu_Youtube_Click);
            // 
            // pic_SelectYotube
            // 
            this.pic_SelectYotube.BackColor = System.Drawing.Color.White;
            this.pic_SelectYotube.Image = global::PlayMusic.Properties.Resources.chevron_right_blue;
            this.pic_SelectYotube.Location = new System.Drawing.Point(40, 8);
            this.pic_SelectYotube.Name = "pic_SelectYotube";
            this.pic_SelectYotube.Size = new System.Drawing.Size(15, 15);
            this.pic_SelectYotube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SelectYotube.TabIndex = 23;
            this.pic_SelectYotube.TabStop = false;
            // 
            // menu_Online
            // 
            this.menu_Online.Controls.Add(this.panel_SelectedOnline);
            this.menu_Online.Controls.Add(this.btn_Online);
            this.menu_Online.Controls.Add(this.pic_Online);
            this.menu_Online.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Online.Location = new System.Drawing.Point(0, 503);
            this.menu_Online.Name = "menu_Online";
            this.menu_Online.Size = new System.Drawing.Size(233, 50);
            this.menu_Online.TabIndex = 29;
            this.menu_Online.Click += new System.EventHandler(this.menu_Online_Click);
            // 
            // panel_SelectedOnline
            // 
            this.panel_SelectedOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedOnline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedOnline.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedOnline.Name = "panel_SelectedOnline";
            this.panel_SelectedOnline.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedOnline.TabIndex = 24;
            // 
            // btn_Online
            // 
            this.btn_Online.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Online.FlatAppearance.BorderSize = 0;
            this.btn_Online.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Online.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Online.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Online.ForeColor = System.Drawing.Color.White;
            this.btn_Online.Location = new System.Drawing.Point(56, 0);
            this.btn_Online.Name = "btn_Online";
            this.btn_Online.Size = new System.Drawing.Size(177, 50);
            this.btn_Online.TabIndex = 21;
            this.btn_Online.Text = "Trực tuyến";
            this.btn_Online.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Online.UseVisualStyleBackColor = false;
            this.btn_Online.Click += new System.EventHandler(this.menu_Online_Click);
            // 
            // pic_Online
            // 
            this.pic_Online.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Online.Image = global::PlayMusic.Properties.Resources.online_white;
            this.pic_Online.Location = new System.Drawing.Point(28, 14);
            this.pic_Online.Name = "pic_Online";
            this.pic_Online.Size = new System.Drawing.Size(22, 22);
            this.pic_Online.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Online.TabIndex = 23;
            this.pic_Online.TabStop = false;
            this.pic_Online.Click += new System.EventHandler(this.menu_Online_Click);
            // 
            // menu_Video
            // 
            this.menu_Video.Controls.Add(this.panel_SelectedVideo);
            this.menu_Video.Controls.Add(this.btn_Video);
            this.menu_Video.Controls.Add(this.pic_Video);
            this.menu_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Video.Location = new System.Drawing.Point(0, 453);
            this.menu_Video.Name = "menu_Video";
            this.menu_Video.Size = new System.Drawing.Size(233, 50);
            this.menu_Video.TabIndex = 18;
            this.menu_Video.Click += new System.EventHandler(this.menu_Video_Click);
            // 
            // panel_SelectedVideo
            // 
            this.panel_SelectedVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedVideo.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedVideo.Name = "panel_SelectedVideo";
            this.panel_SelectedVideo.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedVideo.TabIndex = 24;
            this.panel_SelectedVideo.Click += new System.EventHandler(this.menu_Video_Click);
            // 
            // btn_Video
            // 
            this.btn_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Video.FlatAppearance.BorderSize = 0;
            this.btn_Video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Video.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Video.ForeColor = System.Drawing.Color.White;
            this.btn_Video.Location = new System.Drawing.Point(56, 0);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Size = new System.Drawing.Size(177, 50);
            this.btn_Video.TabIndex = 19;
            this.btn_Video.Text = "Video";
            this.btn_Video.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Video.UseVisualStyleBackColor = false;
            this.btn_Video.Click += new System.EventHandler(this.menu_Video_Click);
            // 
            // pic_Video
            // 
            this.pic_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Video.Image = global::PlayMusic.Properties.Resources.video_white;
            this.pic_Video.Location = new System.Drawing.Point(28, 14);
            this.pic_Video.Name = "pic_Video";
            this.pic_Video.Size = new System.Drawing.Size(22, 22);
            this.pic_Video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Video.TabIndex = 23;
            this.pic_Video.TabStop = false;
            this.pic_Video.Click += new System.EventHandler(this.menu_Video_Click);
            // 
            // menu_Playlist
            // 
            this.menu_Playlist.Controls.Add(this.panel_SelectedPlaylist);
            this.menu_Playlist.Controls.Add(this.btn_Playlist);
            this.menu_Playlist.Controls.Add(this.pic_Playlist);
            this.menu_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Playlist.Location = new System.Drawing.Point(0, 403);
            this.menu_Playlist.Name = "menu_Playlist";
            this.menu_Playlist.Size = new System.Drawing.Size(233, 50);
            this.menu_Playlist.TabIndex = 16;
            this.menu_Playlist.Click += new System.EventHandler(this.menu_Playlist_Click);
            // 
            // panel_SelectedPlaylist
            // 
            this.panel_SelectedPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedPlaylist.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedPlaylist.Name = "panel_SelectedPlaylist";
            this.panel_SelectedPlaylist.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedPlaylist.TabIndex = 24;
            this.panel_SelectedPlaylist.Click += new System.EventHandler(this.menu_Playlist_Click);
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playlist.FlatAppearance.BorderSize = 0;
            this.btn_Playlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Playlist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playlist.ForeColor = System.Drawing.Color.White;
            this.btn_Playlist.Location = new System.Drawing.Point(56, 0);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Size = new System.Drawing.Size(177, 50);
            this.btn_Playlist.TabIndex = 17;
            this.btn_Playlist.Text = "Danh sách phát";
            this.btn_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playlist.UseVisualStyleBackColor = false;
            this.btn_Playlist.Click += new System.EventHandler(this.menu_Playlist_Click);
            // 
            // pic_Playlist
            // 
            this.pic_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Playlist.Image = global::PlayMusic.Properties.Resources.playlist_white;
            this.pic_Playlist.Location = new System.Drawing.Point(28, 14);
            this.pic_Playlist.Name = "pic_Playlist";
            this.pic_Playlist.Size = new System.Drawing.Size(22, 22);
            this.pic_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Playlist.TabIndex = 23;
            this.pic_Playlist.TabStop = false;
            this.pic_Playlist.Click += new System.EventHandler(this.menu_Playlist_Click);
            // 
            // menu_Song
            // 
            this.menu_Song.Controls.Add(this.panel_SelectedSong);
            this.menu_Song.Controls.Add(this.btn_Song);
            this.menu_Song.Controls.Add(this.pic_Song);
            this.menu_Song.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Song.Location = new System.Drawing.Point(0, 353);
            this.menu_Song.Name = "menu_Song";
            this.menu_Song.Size = new System.Drawing.Size(233, 50);
            this.menu_Song.TabIndex = 14;
            this.menu_Song.Click += new System.EventHandler(this.menu_Song_Click);
            // 
            // panel_SelectedSong
            // 
            this.panel_SelectedSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedSong.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedSong.Name = "panel_SelectedSong";
            this.panel_SelectedSong.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedSong.TabIndex = 24;
            this.panel_SelectedSong.Click += new System.EventHandler(this.menu_Song_Click);
            // 
            // btn_Song
            // 
            this.btn_Song.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Song.FlatAppearance.BorderSize = 0;
            this.btn_Song.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Song.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Song.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Song.ForeColor = System.Drawing.Color.White;
            this.btn_Song.Location = new System.Drawing.Point(56, 0);
            this.btn_Song.Name = "btn_Song";
            this.btn_Song.Size = new System.Drawing.Size(177, 50);
            this.btn_Song.TabIndex = 15;
            this.btn_Song.Text = "Bài hát";
            this.btn_Song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Song.UseVisualStyleBackColor = false;
            this.btn_Song.Click += new System.EventHandler(this.menu_Song_Click);
            // 
            // pic_Song
            // 
            this.pic_Song.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.musical_white;
            this.pic_Song.Location = new System.Drawing.Point(28, 14);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(22, 22);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 23;
            this.pic_Song.TabStop = false;
            this.pic_Song.Click += new System.EventHandler(this.menu_Song_Click);
            // 
            // menu_Search
            // 
            this.menu_Search.Controls.Add(this.panel_SelectedSearch);
            this.menu_Search.Controls.Add(this.btn_Search);
            this.menu_Search.Controls.Add(this.pic_Search);
            this.menu_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Search.Location = new System.Drawing.Point(0, 303);
            this.menu_Search.Name = "menu_Search";
            this.menu_Search.Size = new System.Drawing.Size(233, 50);
            this.menu_Search.TabIndex = 12;
            this.menu_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel_SelectedSearch
            // 
            this.panel_SelectedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedSearch.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedSearch.Name = "panel_SelectedSearch";
            this.panel_SelectedSearch.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedSearch.TabIndex = 24;
            this.panel_SelectedSearch.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(56, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(177, 50);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pic_Search
            // 
            this.pic_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Search.Image = global::PlayMusic.Properties.Resources.search_white;
            this.pic_Search.Location = new System.Drawing.Point(28, 14);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(22, 22);
            this.pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Search.TabIndex = 23;
            this.pic_Search.TabStop = false;
            this.pic_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // menu_Recent
            // 
            this.menu_Recent.Controls.Add(this.panel_SelectedRecent);
            this.menu_Recent.Controls.Add(this.btn_Recent);
            this.menu_Recent.Controls.Add(this.pic_Recent);
            this.menu_Recent.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Recent.Location = new System.Drawing.Point(0, 253);
            this.menu_Recent.Name = "menu_Recent";
            this.menu_Recent.Size = new System.Drawing.Size(233, 50);
            this.menu_Recent.TabIndex = 10;
            this.menu_Recent.Click += new System.EventHandler(this.btn_Recent_Click);
            // 
            // panel_SelectedRecent
            // 
            this.panel_SelectedRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedRecent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedRecent.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedRecent.Name = "panel_SelectedRecent";
            this.panel_SelectedRecent.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedRecent.TabIndex = 24;
            this.panel_SelectedRecent.Click += new System.EventHandler(this.btn_Recent_Click);
            // 
            // btn_Recent
            // 
            this.btn_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Recent.FlatAppearance.BorderSize = 0;
            this.btn_Recent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Recent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Recent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recent.ForeColor = System.Drawing.Color.White;
            this.btn_Recent.Location = new System.Drawing.Point(56, 0);
            this.btn_Recent.Name = "btn_Recent";
            this.btn_Recent.Size = new System.Drawing.Size(177, 50);
            this.btn_Recent.TabIndex = 11;
            this.btn_Recent.Text = "Gần đây";
            this.btn_Recent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Recent.UseVisualStyleBackColor = false;
            this.btn_Recent.Click += new System.EventHandler(this.btn_Recent_Click);
            // 
            // pic_Recent
            // 
            this.pic_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Recent.Image = global::PlayMusic.Properties.Resources.recent_white;
            this.pic_Recent.Location = new System.Drawing.Point(28, 14);
            this.pic_Recent.Name = "pic_Recent";
            this.pic_Recent.Size = new System.Drawing.Size(22, 22);
            this.pic_Recent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Recent.TabIndex = 23;
            this.pic_Recent.TabStop = false;
            this.pic_Recent.Click += new System.EventHandler(this.btn_Recent_Click);
            // 
            // menu_Playing
            // 
            this.menu_Playing.Controls.Add(this.panel_SelectedPlaying);
            this.menu_Playing.Controls.Add(this.btn_Playing);
            this.menu_Playing.Controls.Add(this.pic_Playing);
            this.menu_Playing.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Playing.Location = new System.Drawing.Point(0, 203);
            this.menu_Playing.Name = "menu_Playing";
            this.menu_Playing.Size = new System.Drawing.Size(233, 50);
            this.menu_Playing.TabIndex = 8;
            this.menu_Playing.Click += new System.EventHandler(this.btn_Playing_Click);
            // 
            // panel_SelectedPlaying
            // 
            this.panel_SelectedPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel_SelectedPlaying.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SelectedPlaying.Location = new System.Drawing.Point(0, 0);
            this.panel_SelectedPlaying.Name = "panel_SelectedPlaying";
            this.panel_SelectedPlaying.Size = new System.Drawing.Size(8, 50);
            this.panel_SelectedPlaying.TabIndex = 7;
            this.panel_SelectedPlaying.Click += new System.EventHandler(this.btn_Playing_Click);
            // 
            // btn_Playing
            // 
            this.btn_Playing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playing.FlatAppearance.BorderSize = 0;
            this.btn_Playing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Playing.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playing.ForeColor = System.Drawing.Color.White;
            this.btn_Playing.Location = new System.Drawing.Point(56, 0);
            this.btn_Playing.Name = "btn_Playing";
            this.btn_Playing.Size = new System.Drawing.Size(177, 50);
            this.btn_Playing.TabIndex = 9;
            this.btn_Playing.Text = "Đang phát";
            this.btn_Playing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playing.UseVisualStyleBackColor = false;
            this.btn_Playing.Click += new System.EventHandler(this.btn_Playing_Click);
            // 
            // pic_Playing
            // 
            this.pic_Playing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pic_Playing.Image = global::PlayMusic.Properties.Resources.playing_white;
            this.pic_Playing.Location = new System.Drawing.Point(28, 14);
            this.pic_Playing.Name = "pic_Playing";
            this.pic_Playing.Size = new System.Drawing.Size(22, 22);
            this.pic_Playing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Playing.TabIndex = 23;
            this.pic_Playing.TabStop = false;
            this.pic_Playing.Click += new System.EventHandler(this.btn_Playing_Click);
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.White;
            this.panel_User.Controls.Add(this.btn_LogOut);
            this.panel_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_User.Location = new System.Drawing.Point(0, 173);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(233, 30);
            this.panel_User.TabIndex = 7;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.White;
            this.btn_LogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Green;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(233, 30);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Đăng nhập";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // t1
            // 
            this.t1.Enabled = true;
            this.t1.Interval = 1000;
            this.t1.Tick += new System.EventHandler(this.t_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Phát Nhạc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_ChildForm.ResumeLayout(false);
            this.panel_ControlBar.ResumeLayout(false);
            this.panel_ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageSong)).EndInit();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.menu_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).EndInit();
            this.menu_Zing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Zing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SelectZing)).EndInit();
            this.menu_Youtube.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SelectYotube)).EndInit();
            this.menu_Online.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Online)).EndInit();
            this.menu_Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Video)).EndInit();
            this.menu_Playlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).EndInit();
            this.menu_Song.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.menu_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).EndInit();
            this.menu_Recent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Recent)).EndInit();
            this.menu_Playing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playing)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Panel panel_TitleBar;
        public System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_UserInfo;
        public System.Windows.Forms.Panel panel_Main;
        private PlayMusic.CustomControl.RoundPictureBox pic_User;
        public System.Windows.Forms.Label lbl_UserDisplayName;
        private System.Windows.Forms.Panel menu_Video;
        private System.Windows.Forms.Button btn_Video;
        private System.Windows.Forms.PictureBox pic_Video;
        private System.Windows.Forms.Panel menu_Playlist;
        private System.Windows.Forms.Button btn_Playlist;
        private System.Windows.Forms.PictureBox pic_Playlist;
        private System.Windows.Forms.Panel menu_Song;
        private System.Windows.Forms.Button btn_Song;
        private System.Windows.Forms.PictureBox pic_Song;
        private System.Windows.Forms.Panel menu_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pic_Search;
        private System.Windows.Forms.Panel menu_Recent;
        private System.Windows.Forms.Button btn_Recent;
        private System.Windows.Forms.PictureBox pic_Recent;
        private System.Windows.Forms.Panel menu_Playing;
        private System.Windows.Forms.Button btn_Playing;
        private System.Windows.Forms.PictureBox pic_Playing;
        private System.Windows.Forms.Panel panel_User;
        public System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Panel panel_SelectedVideo;
        private System.Windows.Forms.Panel panel_SelectedPlaylist;
        private System.Windows.Forms.Panel panel_SelectedSong;
        private System.Windows.Forms.Panel panel_SelectedSearch;
        private System.Windows.Forms.Panel panel_SelectedRecent;
        private System.Windows.Forms.Panel panel_SelectedPlaying;
        public System.Windows.Forms.Panel panel_ControlBar;
        public System.Windows.Forms.Button btn_Repeat;
        private System.Windows.Forms.Button btn_Next;
        public System.Windows.Forms.Button btn_MuteVol;
        public System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Button btn_Previous;
        public System.Windows.Forms.Button btn_PlayPause;
        public System.Windows.Forms.Label lbl_Duration;
        public System.Windows.Forms.Label lbl_CurrentPosition;
        public TrackBarCustom trackPlaying;
        public System.Windows.Forms.Label lbl_NameSingger;
        public System.Windows.Forms.Label lbl_SongName;
        private CustomControl.RoundPictureBox pic_ImageSong;
        private System.Windows.Forms.Panel menu_Settings;
        private System.Windows.Forms.Panel panel_SelectedSettings;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.PictureBox pic_Settings;
        private System.Windows.Forms.Panel menu_Zing;
        private System.Windows.Forms.Button btn_Zing;
        private System.Windows.Forms.PictureBox pic_Zing;
        private System.Windows.Forms.Panel menu_Youtube;
        private System.Windows.Forms.Button btn_Youtube;
        private System.Windows.Forms.PictureBox pic_Youtube;
        private System.Windows.Forms.Panel menu_Online;
        private System.Windows.Forms.Panel panel_SelectedOnline;
        private System.Windows.Forms.Button btn_Online;
        private System.Windows.Forms.PictureBox pic_Online;
        private System.Windows.Forms.PictureBox pic_SelectZing;
        private System.Windows.Forms.PictureBox pic_SelectYotube;
        private System.Windows.Forms.Timer t1;
    }
}

