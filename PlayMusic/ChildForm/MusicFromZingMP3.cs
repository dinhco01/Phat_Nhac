using Newtonsoft.Json;
using PlayMusic.Model.ZingMP3API;
using PlayMusic.Properties;
using PlayMusic.UserControls.FromZingMP3;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class MusicFromZingMP3 : Form
    {
        public MainForm main;

        private string _folderName = @"D:\MediaApp";

        private string _folderStream = @"data\ZingMP3_Stream";

        public MusicFromZingMP3()
        {
            InitializeComponent();
            LoadLanguage();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_Key.Text) || txb_Key.Text == Program.rm.GetString("enterKeywords", Program.culture))
            {
                panel_NoResult.Visible = true;
                lbl_NoContent.Text = Program.rm.GetString("enterSongSearch", Program.culture);
                panel_Content.Controls.Clear();
                return;
            }
            SearchSong(txb_Key.Text);
        }

        private void panel_Search_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            panel_SearchBar.Visible = true;
            panel_NoResult.Visible = true;
            RestoreAllMenu();
            ChangeColorMenu(pic_Search, btn_SearchMenu, 1);
            btn_Search_Click(sender, e);
        }

        private void panel_ZingChart_Click(object sender, EventArgs e)
        {
            panel_Content.Controls.Clear();
            panel_SearchBar.Visible = false;
            RestoreAllMenu();
            ChangeColorMenu(pic_ZingChart, btn_ZingChart, 2);
            LoadZingChart();
        }

        private void LoadZingChart()
        {
            try
            {
                var data = new Mp3Player().LoadAllSong(_folderName);
                var client = new RestClient("https://mp3.zing.vn/xhr/chart-realtime");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var dataZingChart = JsonConvert.DeserializeObject<DataZingChartFromZingMP3>(response.Content);
                if (dataZingChart != null)
                {
                    panel_NoResult.Visible = false;
                    panel_Content.Controls.Clear();
                    int i = 1;
                    foreach (var item in dataZingChart.data.songs)
                    {
                        var fileName = Path.Combine(_folderName, item.name + "-" + item.artists_names + ".mp3");
                        var uc = new Song_Ranking(item, i, data.Contains(fileName), main);
                        panel_Content.Controls.Add(uc);
                        i++;
                    }
                }
                else
                {
                    panel_NoResult.Visible = true;
                }
            }
            catch { }
        }

        private void SearchSong(string keyWord)
        {
            try
            {
                var data = new Mp3Player().LoadAllSong(_folderName);
                var client = new RestClient("http://ac.mp3.zing.vn/complete?type=artist,song,key,code&num=500&query=" + keyWord);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var searchResult = JsonConvert.DeserializeObject<SearchResult>(response.Content);
                if (searchResult != null)
                {
                    if (searchResult.data == null || searchResult.data.FirstOrDefault() == null || searchResult.data.FirstOrDefault().songs == null || searchResult.data.FirstOrDefault().songs.Count == 0) 
                    {
                        lbl_NoContent.Visible = true;
                        return;
                    }    
                    panel_NoResult.Visible = false;
                    panel_Content.Controls.Clear();
                    foreach (var item in searchResult.data.FirstOrDefault().songs)
                    {
                        var fileName = Path.Combine(_folderName, item.name + "-" + item.artist + ".mp3");
                        var uc = new Song_ZingMP3(item, data.Contains(fileName), main);
                        panel_Content.Controls.Add(uc);
                    }
                }
                else
                {
                    panel_NoResult.Visible = true;
                }
            }
            catch { }
        }

        private void txb_Key_Click(object sender, EventArgs e)
        {
            txb_Key.SelectAll();
        }

        private void txb_Key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(this, new EventArgs());
            }
        }

        private void RestoreAllMenu()
        {
            RestoreColorMenuSearch(pic_Search, btn_SearchMenu, 1);
            RestoreColorMenuSearch(pic_ZingChart, btn_ZingChart, 2);
        }

        private void RestoreColorMenuSearch(PictureBox picture, Button button, int i)
        {
            picture.Image = (i == 1) ? Resources.search_gray : Resources.line_chart_gray;
            button.ForeColor = Color.FromArgb(0, 144, 255);
            button.ForeColor = Color.FromArgb(169, 169, 169);
        }

        private void ChangeColorMenu(PictureBox picture, Button button, int i)
        {
            picture.Image = (i == 1) ? Resources.search_blue1 : Resources.line_chart_blue;
            button.ForeColor = Color.FromArgb(0, 144, 255);
        }

        private void MusicFromZingMP3_Load(object sender, EventArgs e)
        {
            lbl_NoContent.Text = Program.rm.GetString("enterSongSearch", Program.culture);
            if (!Directory.Exists(_folderStream))
            {
                Directory.CreateDirectory(_folderStream);
            }    
        }

        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            btn_SearchMenu.Text = rm.GetString("search", culture);
            btn_ZingChart.Text = rm.GetString("zingChart", culture);
            lbl_NoContent.Text = rm.GetString("noSongsFound", culture);
            txb_Key.Text = rm.GetString("enterKeywords", culture);
        }
    }
}