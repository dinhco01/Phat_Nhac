using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using PlayMusic.Properties;
using PlayMusic.UserControls.FromYoutube;

namespace PlayMusic.ChildForm
{
    public partial class VideoFromYoutube : Form
    {
        public ChromiumWebBrowser chrome;

        public string Url { get; set; } = "https://www.youtube.com/";

        public VideoFromYoutube()
        {
            InitializeComponent();
            Initchrome();
            chrome.Load(txb_AdressBar.Text);
        }

        private void Initchrome()
        {
            Cef.Initialize(new CefSettings());
            txb_AdressBar.Text = Url;
            chrome = new ChromiumWebBrowser(Url);
            panel_ContainBrower.Controls.Add(chrome);
            if (Program.culture.Name == "vi-VN")
            {
                chrome.BrowserSettings.AcceptLanguageList = "vi-VN";
            }
            else if (Program.culture.Name == "en-US")
            {
                chrome.BrowserSettings.AcceptLanguageList = "en-US";
            }
            else
            {
                chrome.BrowserSettings.AcceptLanguageList = "en-US";
            }
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += chrome_AddressChanged;
        }

        private void chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            txb_AdressBar.Invoke((Action)delegate
            {
                txb_AdressBar.Text = e.Address;
            });
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoBack)
            {
                chrome.Back();
            }
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        private void bnt_Download_Click(object sender, EventArgs e)
        {
            SelectResolution select = new SelectResolution(txb_AdressBar.Text);
            select.ShowDialog();
        }

        private void txb_AdressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txb_AdressBar.Text))
                {
                    chrome.Load(txb_AdressBar.Text);
                }
            }
        }

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            chrome.Load(Url);
        }
    }
}
