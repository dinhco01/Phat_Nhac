
namespace PlayMusic.ChildForm
{
    partial class VideoPlaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlaying));
            this.mp4Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.t = new System.Windows.Forms.Timer(this.components);
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.btn_ReplaySecond = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_FowardSecond = new System.Windows.Forms.Button();
            this.btn_Repeat = new System.Windows.Forms.Button();
            this.btn_FullScreen = new System.Windows.Forms.Button();
            this.lbl_CurrentPosition = new System.Windows.Forms.Label();
            this.trackPlaying = new PlayMusic.TrackBarCustom();
            this.trackBar_Volume = new PlayMusic.TrackBarCustom();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_Vol = new System.Windows.Forms.Label();
            this.btn_VolMute = new System.Windows.Forms.Button();
            this.panel_ControlBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mp4Player)).BeginInit();
            this.panel_ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mp4Player
            // 
            this.mp4Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mp4Player.Enabled = true;
            this.mp4Player.Location = new System.Drawing.Point(0, 0);
            this.mp4Player.Name = "mp4Player";
            this.mp4Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp4Player.OcxState")));
            this.mp4Player.Size = new System.Drawing.Size(684, 481);
            this.mp4Player.TabIndex = 0;
            // 
            // delay
            // 
            this.delay.Interval = 200;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // t
            // 
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_PlayPause.BackgroundImage = global::PlayMusic.Properties.Resources.pause_blue;
            this.btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.Location = new System.Drawing.Point(119, 38);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(25, 25);
            this.btn_PlayPause.TabIndex = 34;
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // btn_ReplaySecond
            // 
            this.btn_ReplaySecond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ReplaySecond.BackgroundImage = global::PlayMusic.Properties.Resources.replay_5_blue;
            this.btn_ReplaySecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ReplaySecond.FlatAppearance.BorderSize = 0;
            this.btn_ReplaySecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReplaySecond.Location = new System.Drawing.Point(68, 38);
            this.btn_ReplaySecond.Name = "btn_ReplaySecond";
            this.btn_ReplaySecond.Size = new System.Drawing.Size(25, 25);
            this.btn_ReplaySecond.TabIndex = 33;
            this.btn_ReplaySecond.UseVisualStyleBackColor = true;
            this.btn_ReplaySecond.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Stop.BackgroundImage = global::PlayMusic.Properties.Resources.stop_gray;
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Location = new System.Drawing.Point(17, 38);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(25, 25);
            this.btn_Stop.TabIndex = 32;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            this.btn_Stop.MouseLeave += new System.EventHandler(this.btn_Stop_MouseLeave);
            this.btn_Stop.MouseHover += new System.EventHandler(this.btn_Stop_MouseHover);
            // 
            // btn_FowardSecond
            // 
            this.btn_FowardSecond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FowardSecond.BackgroundImage = global::PlayMusic.Properties.Resources.forward_5_blue;
            this.btn_FowardSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FowardSecond.FlatAppearance.BorderSize = 0;
            this.btn_FowardSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FowardSecond.Location = new System.Drawing.Point(170, 38);
            this.btn_FowardSecond.Name = "btn_FowardSecond";
            this.btn_FowardSecond.Size = new System.Drawing.Size(25, 25);
            this.btn_FowardSecond.TabIndex = 31;
            this.btn_FowardSecond.UseVisualStyleBackColor = true;
            this.btn_FowardSecond.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Repeat.BackgroundImage = global::PlayMusic.Properties.Resources.repeat_blue;
            this.btn_Repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Repeat.FlatAppearance.BorderSize = 0;
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.Location = new System.Drawing.Point(221, 38);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(25, 25);
            this.btn_Repeat.TabIndex = 30;
            this.btn_Repeat.UseVisualStyleBackColor = true;
            this.btn_Repeat.Click += new System.EventHandler(this.btn_Repeat_Click);
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FullScreen.BackgroundImage = global::PlayMusic.Properties.Resources.full_screen_gray;
            this.btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FullScreen.FlatAppearance.BorderSize = 0;
            this.btn_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FullScreen.Location = new System.Drawing.Point(275, 38);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.Size = new System.Drawing.Size(25, 25);
            this.btn_FullScreen.TabIndex = 30;
            this.btn_FullScreen.UseVisualStyleBackColor = true;
            this.btn_FullScreen.Click += new System.EventHandler(this.btn_FullScreen_Click);
            this.btn_FullScreen.MouseLeave += new System.EventHandler(this.btn_FullScreen_MouseLeave);
            this.btn_FullScreen.MouseHover += new System.EventHandler(this.btn_FullScreen_MouseHover);
            // 
            // lbl_CurrentPosition
            // 
            this.lbl_CurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CurrentPosition.AutoSize = true;
            this.lbl_CurrentPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPosition.Location = new System.Drawing.Point(3, 13);
            this.lbl_CurrentPosition.Name = "lbl_CurrentPosition";
            this.lbl_CurrentPosition.Size = new System.Drawing.Size(39, 17);
            this.lbl_CurrentPosition.TabIndex = 44;
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
            this.trackPlaying.Location = new System.Drawing.Point(48, 8);
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
            this.trackPlaying.Size = new System.Drawing.Size(588, 29);
            this.trackPlaying.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackPlaying.TabIndex = 43;
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
            this.trackBar_Volume.Location = new System.Drawing.Point(460, 38);
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
            this.trackBar_Volume.TabIndex = 42;
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
            // lbl_Duration
            // 
            this.lbl_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(642, 13);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(39, 17);
            this.lbl_Duration.TabIndex = 41;
            this.lbl_Duration.Text = "00:00";
            // 
            // lbl_Vol
            // 
            this.lbl_Vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Vol.AutoSize = true;
            this.lbl_Vol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vol.Location = new System.Drawing.Point(642, 38);
            this.lbl_Vol.Name = "lbl_Vol";
            this.lbl_Vol.Size = new System.Drawing.Size(33, 17);
            this.lbl_Vol.TabIndex = 40;
            this.lbl_Vol.Text = "50%";
            // 
            // btn_VolMute
            // 
            this.btn_VolMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VolMute.BackgroundImage = global::PlayMusic.Properties.Resources.audio_blue;
            this.btn_VolMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VolMute.FlatAppearance.BorderSize = 0;
            this.btn_VolMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolMute.Location = new System.Drawing.Point(425, 38);
            this.btn_VolMute.Name = "btn_VolMute";
            this.btn_VolMute.Size = new System.Drawing.Size(20, 20);
            this.btn_VolMute.TabIndex = 45;
            this.btn_VolMute.UseVisualStyleBackColor = true;
            this.btn_VolMute.Click += new System.EventHandler(this.btn_VolMute_Click);
            // 
            // panel_ControlBar
            // 
            this.panel_ControlBar.Controls.Add(this.btn_VolMute);
            this.panel_ControlBar.Controls.Add(this.lbl_Vol);
            this.panel_ControlBar.Controls.Add(this.lbl_Duration);
            this.panel_ControlBar.Controls.Add(this.trackBar_Volume);
            this.panel_ControlBar.Controls.Add(this.trackPlaying);
            this.panel_ControlBar.Controls.Add(this.lbl_CurrentPosition);
            this.panel_ControlBar.Controls.Add(this.btn_FullScreen);
            this.panel_ControlBar.Controls.Add(this.btn_Repeat);
            this.panel_ControlBar.Controls.Add(this.btn_FowardSecond);
            this.panel_ControlBar.Controls.Add(this.btn_Stop);
            this.panel_ControlBar.Controls.Add(this.btn_ReplaySecond);
            this.panel_ControlBar.Controls.Add(this.btn_PlayPause);
            this.panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ControlBar.Location = new System.Drawing.Point(0, 412);
            this.panel_ControlBar.Name = "panel_ControlBar";
            this.panel_ControlBar.Size = new System.Drawing.Size(684, 69);
            this.panel_ControlBar.TabIndex = 1;
            // 
            // VideoPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_ControlBar);
            this.Controls.Add(this.mp4Player);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoPlaying";
            this.Text = "VideoPlaying";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlaying_FormClosing);
            this.Load += new System.EventHandler(this.VideoPlaying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mp4Player)).EndInit();
            this.panel_ControlBar.ResumeLayout(false);
            this.panel_ControlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp4Player;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Timer t;
        public System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.Button btn_ReplaySecond;
        public System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_FowardSecond;
        public System.Windows.Forms.Button btn_Repeat;
        public System.Windows.Forms.Button btn_FullScreen;
        public System.Windows.Forms.Label lbl_CurrentPosition;
        public TrackBarCustom trackPlaying;
        public TrackBarCustom trackBar_Volume;
        public System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Vol;
        public System.Windows.Forms.Button btn_VolMute;
        private System.Windows.Forms.Panel panel_ControlBar;
    }
}