
namespace PlayMusic
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_IntroAccount = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pic_GG = new System.Windows.Forms.PictureBox();
            this.lbl_Skip = new System.Windows.Forms.Label();
            this.lbl_LanguageCurrent = new System.Windows.Forms.Label();
            this.btn_ChangeLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GG)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(258, 225);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 33);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_IntroAccount
            // 
            this.lbl_IntroAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IntroAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IntroAccount.Location = new System.Drawing.Point(226, 140);
            this.lbl_IntroAccount.Name = "lbl_IntroAccount";
            this.lbl_IntroAccount.Size = new System.Drawing.Size(313, 65);
            this.lbl_IntroAccount.TabIndex = 6;
            this.lbl_IntroAccount.Text = "Kết nối với tài khoản Google để có thể đồng bộ các bài hát và dữ liệu của bạn.";
            this.lbl_IntroAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(177, 46);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(300, 65);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "Chào mừng!";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_GG
            // 
            this.pic_GG.Image = global::PlayMusic.Properties.Resources.google_icon;
            this.pic_GG.Location = new System.Drawing.Point(155, 140);
            this.pic_GG.Name = "pic_GG";
            this.pic_GG.Size = new System.Drawing.Size(65, 65);
            this.pic_GG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_GG.TabIndex = 7;
            this.pic_GG.TabStop = false;
            // 
            // lbl_Skip
            // 
            this.lbl_Skip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skip.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Skip.Location = new System.Drawing.Point(255, 261);
            this.lbl_Skip.Name = "lbl_Skip";
            this.lbl_Skip.Size = new System.Drawing.Size(135, 23);
            this.lbl_Skip.TabIndex = 8;
            this.lbl_Skip.Text = "Bỏ qua";
            this.lbl_Skip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Skip.Click += new System.EventHandler(this.lbl_Skip_Click);
            this.lbl_Skip.MouseLeave += new System.EventHandler(this.lbl_Skip_MouseLeave);
            this.lbl_Skip.MouseHover += new System.EventHandler(this.lbl_Skip_MouseHover);
            // 
            // lbl_LanguageCurrent
            // 
            this.lbl_LanguageCurrent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_LanguageCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LanguageCurrent.Location = new System.Drawing.Point(258, 329);
            this.lbl_LanguageCurrent.Name = "lbl_LanguageCurrent";
            this.lbl_LanguageCurrent.Size = new System.Drawing.Size(96, 13);
            this.lbl_LanguageCurrent.TabIndex = 10;
            this.lbl_LanguageCurrent.Text = "Tiếng Việt";
            this.lbl_LanguageCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ChangeLanguage
            // 
            this.btn_ChangeLanguage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ChangeLanguage.BackgroundImage = global::PlayMusic.Properties.Resources.languge_blue;
            this.btn_ChangeLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChangeLanguage.FlatAppearance.BorderSize = 0;
            this.btn_ChangeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeLanguage.Location = new System.Drawing.Point(360, 323);
            this.btn_ChangeLanguage.Name = "btn_ChangeLanguage";
            this.btn_ChangeLanguage.Size = new System.Drawing.Size(24, 24);
            this.btn_ChangeLanguage.TabIndex = 12;
            this.btn_ChangeLanguage.UseVisualStyleBackColor = true;
            this.btn_ChangeLanguage.Click += new System.EventHandler(this.btn_ChangeLanguage_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PlayMusic.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btn_ChangeLanguage);
            this.Controls.Add(this.lbl_LanguageCurrent);
            this.Controls.Add(this.lbl_Skip);
            this.Controls.Add(this.pic_GG);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_IntroAccount);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Music";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_IntroAccount;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox pic_GG;
        private System.Windows.Forms.Label lbl_Skip;
        private System.Windows.Forms.Label lbl_LanguageCurrent;
        private System.Windows.Forms.Button btn_ChangeLanguage;
    }
}