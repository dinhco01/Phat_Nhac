using PlayMusic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Resources;

namespace PlayMusic
{
    static class Program
    {
        public static CultureInfo culture { get; set; }

        public static ResourceManager rm { get; set; }

        public static DataPlaylist dataPlaylist = new DataPlaylist();

        public static Recent dataRecent = new Recent();

        public static string[] langs = new string[] { "vi-VN", "en-US" };

        public static bool IsLoadMain = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            try
            {
                Init();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (!File.Exists(@"data\event.log"))
                {
                    Application.Run(new StartForm());
                    if (IsLoadMain)
                    {
                        Application.Run(new MainForm());
                    }
                }
                else
                {
                    Application.Run(new MainForm());
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"data\even.log", ex.Message + "\n");
            }
        }

        private static void Init()
        {
            SetLanguage(langs[0]);
            dataPlaylist = new Mp3Player().LoadDataPlaylist(@"data\playlist.json");
            dataRecent = new Mp3Player().LoadDataRecent(@"data\recent.json");

            string folderMusic = @"D:\MediaApp";
            if (!Directory.Exists(folderMusic))
            {
                Directory.CreateDirectory(folderMusic);
            }

            string folderVideo = @"D:\MediaApp\Video";
            if (!Directory.Exists(folderVideo))
            {
                Directory.CreateDirectory(folderVideo);
            }

            string folderZingMP3 = @"data\ZingMP3_Stream";
            if (!Directory.Exists(folderZingMP3))
            {
                Directory.CreateDirectory(folderZingMP3);
            }

            string folderThumbnail = @"data\thumbnail";
            if (Directory.Exists(folderThumbnail))
            {
                foreach (var item in Directory.GetFiles(folderThumbnail))
                {
                    File.Delete(item);
                }
            }
        }
        public static void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            rm = new ResourceManager("PlayMusic.Lang.MyResource", typeof(Program).Assembly);
        }
    }
}
