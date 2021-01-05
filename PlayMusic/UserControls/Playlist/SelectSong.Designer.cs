
namespace PlayMusic.UserControls.Playlist
{
    partial class SelectSong
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Singger = new System.Windows.Forms.Label();
            this.lbl_Song = new System.Windows.Forms.Label();
            this.toolTip_InfoSong = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Tick = new System.Windows.Forms.Button();
            this.pic_Song = new PlayMusic.CustomControl.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Singger
            // 
            this.lbl_Singger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Singger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Singger.Location = new System.Drawing.Point(244, 15);
            this.lbl_Singger.Name = "lbl_Singger";
            this.lbl_Singger.Size = new System.Drawing.Size(107, 30);
            this.lbl_Singger.TabIndex = 21;
            this.lbl_Singger.Text = "Châu Khải Phong";
            this.lbl_Singger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Singger.Click += new System.EventHandler(this.SelectSong_Click);
            // 
            // lbl_Song
            // 
            this.lbl_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Song.Location = new System.Drawing.Point(83, 15);
            this.lbl_Song.Name = "lbl_Song";
            this.lbl_Song.Size = new System.Drawing.Size(155, 30);
            this.lbl_Song.TabIndex = 22;
            this.lbl_Song.Text = "Tình Nhạt Phai";
            this.lbl_Song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Song.Click += new System.EventHandler(this.SelectSong_Click);
            // 
            // btn_Tick
            // 
            this.btn_Tick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Tick.BackgroundImage = global::PlayMusic.Properties.Resources.check_ok_blue;
            this.btn_Tick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tick.FlatAppearance.BorderSize = 0;
            this.btn_Tick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Tick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Tick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tick.Location = new System.Drawing.Point(8, 20);
            this.btn_Tick.Name = "btn_Tick";
            this.btn_Tick.Size = new System.Drawing.Size(20, 20);
            this.btn_Tick.TabIndex = 25;
            this.btn_Tick.UseVisualStyleBackColor = true;
            this.btn_Tick.Click += new System.EventHandler(this.SelectSong_Click);
            // 
            // pic_Song
            // 
            this.pic_Song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_Song.Location = new System.Drawing.Point(37, 10);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(40, 40);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 23;
            this.pic_Song.TabStop = false;
            this.pic_Song.Click += new System.EventHandler(this.SelectSong_Click);
            // 
            // SelectSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Tick);
            this.Controls.Add(this.pic_Song);
            this.Controls.Add(this.lbl_Singger);
            this.Controls.Add(this.lbl_Song);
            this.Name = "SelectSong";
            this.Size = new System.Drawing.Size(354, 60);
            this.Load += new System.EventHandler(this.SelectSong_Load);
            this.Click += new System.EventHandler(this.SelectSong_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.RoundPictureBox pic_Song;
        private System.Windows.Forms.Label lbl_Singger;
        private System.Windows.Forms.Label lbl_Song;
        private System.Windows.Forms.ToolTip toolTip_InfoSong;
        private System.Windows.Forms.Button btn_Tick;
    }
}
