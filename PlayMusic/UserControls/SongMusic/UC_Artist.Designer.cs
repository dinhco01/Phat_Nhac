namespace PlayMusic.UserControls.SongMusic
{
    partial class UC_Artist
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
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Artist = new PlayMusic.CustomControl.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Artist.Location = new System.Drawing.Point(0, 0);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Artist.Size = new System.Drawing.Size(250, 32);
            this.lbl_Artist.TabIndex = 1;
            this.lbl_Artist.Text = "Tên nghệ sĩ";
            this.lbl_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Artist.Click += new System.EventHandler(this.lbl_Artist_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Artist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 32);
            this.panel1.TabIndex = 2;
            // 
            // pic_Artist
            // 
            this.pic_Artist.Image = global::PlayMusic.Properties.Resources.song_default;
            this.pic_Artist.Location = new System.Drawing.Point(10, 10);
            this.pic_Artist.Name = "pic_Artist";
            this.pic_Artist.Size = new System.Drawing.Size(230, 230);
            this.pic_Artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Artist.TabIndex = 0;
            this.pic_Artist.TabStop = false;
            this.pic_Artist.Click += new System.EventHandler(this.lbl_Artist_Click);
            // 
            // UC_Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_Artist);
            this.Name = "UC_Artist";
            this.Size = new System.Drawing.Size(250, 282);
            this.Load += new System.EventHandler(this.UC_Artist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.RoundPictureBox pic_Artist;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Panel panel1;
    }
}
