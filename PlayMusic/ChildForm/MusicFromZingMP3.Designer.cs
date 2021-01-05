
namespace PlayMusic.ChildForm
{
    partial class MusicFromZingMP3
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_SearchBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_Key = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel_ZingChart = new System.Windows.Forms.Panel();
            this.btn_ZingChart = new System.Windows.Forms.Button();
            this.pic_ZingChart = new System.Windows.Forms.PictureBox();
            this.panel_AllContent = new System.Windows.Forms.Panel();
            this.panel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NoResult = new System.Windows.Forms.Panel();
            this.lbl_NoContent = new System.Windows.Forms.Label();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.btn_SearchMenu = new System.Windows.Forms.Button();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_SearchBar.SuspendLayout();
            this.panel_ZingChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ZingChart)).BeginInit();
            this.panel_AllContent.SuspendLayout();
            this.panel_NoResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            this.panel_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.panel_SearchBar);
            this.panel_Menu.Controls.Add(this.panel_ZingChart);
            this.panel_Menu.Controls.Add(this.panel_Search);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(684, 50);
            this.panel_Menu.TabIndex = 1;
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.panel1);
            this.panel_SearchBar.Controls.Add(this.txb_Key);
            this.panel_SearchBar.Controls.Add(this.btn_Search);
            this.panel_SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchBar.Location = new System.Drawing.Point(308, 0);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(376, 50);
            this.panel_SearchBar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(75, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 1);
            this.panel1.TabIndex = 3;
            // 
            // txb_Key
            // 
            this.txb_Key.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txb_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Key.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Key.ForeColor = System.Drawing.Color.Gray;
            this.txb_Key.Location = new System.Drawing.Point(75, 16);
            this.txb_Key.Name = "txb_Key";
            this.txb_Key.Size = new System.Drawing.Size(258, 18);
            this.txb_Key.TabIndex = 4;
            this.txb_Key.Text = "Nhập từ khóa";
            this.txb_Key.Click += new System.EventHandler(this.txb_Key_Click);
            this.txb_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Key_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackgroundImage = global::PlayMusic.Properties.Resources.search_blue;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(339, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(25, 25);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel_ZingChart
            // 
            this.panel_ZingChart.Controls.Add(this.btn_ZingChart);
            this.panel_ZingChart.Controls.Add(this.pic_ZingChart);
            this.panel_ZingChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ZingChart.Location = new System.Drawing.Point(126, 0);
            this.panel_ZingChart.Name = "panel_ZingChart";
            this.panel_ZingChart.Size = new System.Drawing.Size(182, 50);
            this.panel_ZingChart.TabIndex = 5;
            this.panel_ZingChart.Click += new System.EventHandler(this.panel_ZingChart_Click);
            // 
            // btn_ZingChart
            // 
            this.btn_ZingChart.FlatAppearance.BorderSize = 0;
            this.btn_ZingChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ZingChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ZingChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZingChart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZingChart.ForeColor = System.Drawing.Color.Gray;
            this.btn_ZingChart.Location = new System.Drawing.Point(46, 9);
            this.btn_ZingChart.Name = "btn_ZingChart";
            this.btn_ZingChart.Size = new System.Drawing.Size(124, 32);
            this.btn_ZingChart.TabIndex = 0;
            this.btn_ZingChart.Text = "Bảng xếp hạng";
            this.btn_ZingChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ZingChart.UseVisualStyleBackColor = true;
            this.btn_ZingChart.Click += new System.EventHandler(this.panel_ZingChart_Click);
            // 
            // pic_ZingChart
            // 
            this.pic_ZingChart.Image = global::PlayMusic.Properties.Resources.line_chart_gray;
            this.pic_ZingChart.Location = new System.Drawing.Point(15, 12);
            this.pic_ZingChart.Name = "pic_ZingChart";
            this.pic_ZingChart.Size = new System.Drawing.Size(25, 25);
            this.pic_ZingChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ZingChart.TabIndex = 1;
            this.pic_ZingChart.TabStop = false;
            this.pic_ZingChart.Click += new System.EventHandler(this.panel_ZingChart_Click);
            // 
            // panel_AllContent
            // 
            this.panel_AllContent.Controls.Add(this.panel_Content);
            this.panel_AllContent.Controls.Add(this.panel_NoResult);
            this.panel_AllContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AllContent.Location = new System.Drawing.Point(0, 50);
            this.panel_AllContent.Name = "panel_AllContent";
            this.panel_AllContent.Size = new System.Drawing.Size(684, 431);
            this.panel_AllContent.TabIndex = 2;
            // 
            // panel_Content
            // 
            this.panel_Content.AutoScroll = true;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 50);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(684, 381);
            this.panel_Content.TabIndex = 1;
            // 
            // panel_NoResult
            // 
            this.panel_NoResult.Controls.Add(this.lbl_NoContent);
            this.panel_NoResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NoResult.Location = new System.Drawing.Point(0, 0);
            this.panel_NoResult.Name = "panel_NoResult";
            this.panel_NoResult.Size = new System.Drawing.Size(684, 50);
            this.panel_NoResult.TabIndex = 0;
            // 
            // lbl_NoContent
            // 
            this.lbl_NoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NoContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NoContent.Location = new System.Drawing.Point(0, 0);
            this.lbl_NoContent.Name = "lbl_NoContent";
            this.lbl_NoContent.Size = new System.Drawing.Size(684, 50);
            this.lbl_NoContent.TabIndex = 0;
            this.lbl_NoContent.Text = "Không tìm thấy bài hát nào";
            this.lbl_NoContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Search
            // 
            this.pic_Search.Image = global::PlayMusic.Properties.Resources.search_blue1;
            this.pic_Search.Location = new System.Drawing.Point(15, 12);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(25, 25);
            this.pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Search.TabIndex = 1;
            this.pic_Search.TabStop = false;
            this.pic_Search.Click += new System.EventHandler(this.panel_Search_Click);
            // 
            // btn_SearchMenu
            // 
            this.btn_SearchMenu.FlatAppearance.BorderSize = 0;
            this.btn_SearchMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SearchMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SearchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_SearchMenu.Location = new System.Drawing.Point(46, 9);
            this.btn_SearchMenu.Name = "btn_SearchMenu";
            this.btn_SearchMenu.Size = new System.Drawing.Size(80, 32);
            this.btn_SearchMenu.TabIndex = 0;
            this.btn_SearchMenu.Text = "Tìm kiếm";
            this.btn_SearchMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchMenu.UseVisualStyleBackColor = true;
            this.btn_SearchMenu.Click += new System.EventHandler(this.panel_Search_Click);
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.btn_SearchMenu);
            this.panel_Search.Controls.Add(this.pic_Search);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Search.Location = new System.Drawing.Point(0, 0);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(126, 50);
            this.panel_Search.TabIndex = 2;
            this.panel_Search.Click += new System.EventHandler(this.panel_Search_Click);
            // 
            // MusicFromZingMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_AllContent);
            this.Controls.Add(this.panel_Menu);
            this.Name = "MusicFromZingMP3";
            this.ShowIcon = false;
            this.Text = "Zing MP3";
            this.Load += new System.EventHandler(this.MusicFromZingMP3_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_SearchBar.ResumeLayout(false);
            this.panel_SearchBar.PerformLayout();
            this.panel_ZingChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ZingChart)).EndInit();
            this.panel_AllContent.ResumeLayout(false);
            this.panel_NoResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_ZingChart;
        private System.Windows.Forms.Button btn_ZingChart;
        private System.Windows.Forms.PictureBox pic_ZingChart;
        private System.Windows.Forms.Panel panel_AllContent;
        private System.Windows.Forms.FlowLayoutPanel panel_Content;
        private System.Windows.Forms.Panel panel_NoResult;
        private System.Windows.Forms.Label lbl_NoContent;
        private System.Windows.Forms.Panel panel_SearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Key;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button btn_SearchMenu;
        private System.Windows.Forms.PictureBox pic_Search;
    }
}