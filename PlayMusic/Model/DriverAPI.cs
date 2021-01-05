using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using FileDriver = Google.Apis.Drive.v3.Data.File;
using Google.Apis.Oauth2.v2;
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Services;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace PlayMusic.Model
{
    public class DriverAPI
    {
        string[] Scopes = { DriveService.Scope.Drive, "email", "profile" };
        string ApplicationName = "Play Music";

        private DriveService service;
        private UserCredential credential;

        public DriverAPI()
        {
            if (CheckInternetConnection())
            {
                using (var stream = new FileStream("credentialsGoogleDriveAPI.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            else
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static string[] ReadDataUser()
        {
            string fileName = @"token.json\UserInfo.txt";
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var reader = new StreamReader(stream);
            var dataText = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            return dataText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        public void SaveInfoData(Dictionary<string, string> dict)
        {
            string fileName = @"token.json\UserInfo.txt";
            TextWriter write = new StreamWriter(fileName, false);
            foreach (KeyValuePair<string, string> item in dict)
            {
                write.WriteLine(item.Value);
            }
            write.Close();
            WebRequest request = WebRequest.Create(dict["picture"]);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            Bitmap picUser = new Bitmap(responseStream);
            picUser.Save(@"token.json\user.png", ImageFormat.Png);
        }

        /// <summary>
        /// Kiểm tra kết nối Internet
        /// </summary>
        /// <returns></returns>

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var clinet = new WebClient())
                {
                    using (var stream = clinet.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy thông tin gồm id và tên file trong thư mục được chỉ định
        /// </summary>
        /// <param name="folderId">id thư mục</param>
        /// <returns></returns>
        public Dictionary<string, string> GetFilesInFolder(string folderId)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.Fields = "nextPageToken, files(id, name)";
            listRequest.Q = $"'{folderId}' in parents";
            listRequest.PageSize = 100;

            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
            foreach (var item in files)
            {
                dict.Add(item.Id, item.Name);
            }
            return dict;
        }

        public Dictionary<string, string> GetUserProfile()
        {
            try
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                var oauthSerivce = new Oauth2Service(new BaseClientService.Initializer { HttpClientInitializer = credential });

                Userinfo userInfo = oauthSerivce.Userinfo.Get().Execute();
                if (userInfo == null) return dict;
                dict.Add("name", userInfo.Name);
                dict.Add("email", userInfo.Email);
                dict.Add("picture", userInfo.Picture);
                return dict;
            }
            catch { }
            return new Dictionary<string, string>();
        }

        public void DownloadFile(string fileId, string fileName, string filePath)
        {
            var request = service.Files.Get(fileId);
            using (var mem = new MemoryStream())
            {
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            //Console.WriteLine("Downloading...");
                            break;
                        case DownloadStatus.Completed:
                            //Console.WriteLine("Completed");
                            break;
                        case DownloadStatus.Failed:
                            //Console.WriteLine("Failed");
                            break;
                    }
                };

                request.Download(mem);
                var filetream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create, FileAccess.Write);
                filetream.Write(mem.GetBuffer(), 0, mem.GetBuffer().Length);
                filetream.Close();
            }
        }

        public string UploadFile(string folderId, string fileName, string filePath, string contentType)
        {
            try
            {
                var fileMetadata = new FileDriver();
                fileMetadata.Name = fileName;
                fileMetadata.Parents = new List<string>() { folderId };
                FilesResource.CreateMediaUpload request;

                using (var fileStream = new FileStream(filePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, fileStream, contentType);
                    request.Upload();
                }
                var file = request.ResponseBody;
                return file == null ? String.Empty : file.Id;
            }
            catch
            {
                return String.Empty;
            }
        }

        public void DeleteFile(string fileId)
        {
            try
            {
                service.Files.Delete(fileId).Execute();
            }
            catch
            {
                return;
            }
        }

        public string CreateFolder(string folderName, string folderDecripstion = "")
        {
            FileDriver body = new FileDriver();
            body.Name = folderName;
            if (!string.IsNullOrEmpty(folderDecripstion))
                body.Description = folderDecripstion;
            body.MimeType = "application/vnd.google-apps.folder";

            FileDriver folder = service.Files.Create(body).Execute();
            return folder.Id;
        }

        public List<string> LoadAllSongNameInFolder(out string folderId)
        {
            if (!CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                folderId = String.Empty;
                return new List<string>();
            }
            try
            {
                List<string> songsName = new List<string>();
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.PageSize = 10;
                listRequest.Q = "mimeType = 'application/vnd.google-apps.folder' and name = 'MediaApp'";
                listRequest.Fields = "nextPageToken, files(id, name)";

                IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

                if (files == null || files.Count == 0)
                {
                    folderId = CreateFolder("MediaApp", Program.rm.GetString("sync", Program.culture));
                    return new List<string>();
                }
                folderId = files.FirstOrDefault().Id;
                Dictionary<string, string> dict = GetFilesInFolder(folderId);
                foreach (KeyValuePair<string, string> item in dict)
                {
                    songsName.Add(item.Value);
                }
                return songsName;
            }
            catch
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            folderId = String.Empty;
            return new List<string>();
        }

        public Dictionary<string, string> LoadAllSongIdInFolder(out string folderId)
        {
            if (!CheckInternetConnection())
            {
                MessageBox.Show(Program.rm.GetString("noInternetConnection", Program.culture),
                                                       Program.rm.GetString("notification", Program.culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
                folderId = String.Empty;
                return new Dictionary<string, string>();
            }
            Dictionary<string, string> songIds = new Dictionary<string, string>();
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Q = "mimeType = 'application/vnd.google-apps.folder' and name = 'MediaApp'";
            listRequest.Fields = "nextPageToken, files(id, name)";


            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

            if (files == null || files.Count == 0)
            {
                folderId = CreateFolder("MediaApp", Program.rm.GetString("sync", Program.culture));
                return new Dictionary<string, string>();
            }
            folderId = files.FirstOrDefault().Id;
            Dictionary<string, string> dict = GetFilesInFolder(folderId);
            foreach (KeyValuePair<string, string> item in dict)
            {
                songIds.Add(item.Key, item.Value);
            }
            return songIds;
        }
    }
}