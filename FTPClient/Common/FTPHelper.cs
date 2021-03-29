using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient.Common
{
    class FTPHelper
    {
        public static FTPHelper Instance = new FTPHelper();

        private Uri rootUri;
        public Uri RootUri => rootUri;
        private NetworkCredential credentials;

        // Protože tato třída slouží jako jedináček
        private FTPHelper()
        {

        }

        /// <summary>
        /// Nastaví uživatelské jméno, heslo, a root server
        /// <example>
        public void SetCredentials(string server, string username, string password)
        {
            credentials = new NetworkCredential(username, password);
            // Získám root složku FTP serveru
            var serverString = server.Split('/');
            rootUri = new Uri("ftp://" + serverString[0]);
        }

        /// <summary>
        /// Získá info o souborech v adresíři
        /// <example>
        public Task<List<string>> GetDirectoryDetails(Uri directoryUri)
        {
            return Task.Factory.StartNew(() =>
            {
                var request = CreateRequest(WebRequestMethods.Ftp.ListDirectoryDetails, directoryUri);

                try
                {
                    using (var response = (FtpWebResponse)request.GetResponse())
                    {
                        using (var responseStream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                string lines = reader.ReadToEnd();
                                return lines.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    return null;
                }
            });
        }

        /// <summary>
        /// Nahraje soubor na FTP server. Task aby to bylo async protože jinak by
        /// zamrzávala apka a iprogress na report progresu
        /// <example>
        public Task UploadFileToFtp(Uri uri, string filePath, IProgress<int> progress)
        {
            return Task.Factory.StartNew(() =>
            {
                var fileName = Path.GetFileName(filePath);
                var request = CreateRequest(WebRequestMethods.Ftp.UploadFile, new Uri(uri.ToString() + "/" + fileName));

                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        int buffLength = 2048;
                        byte[] buff = new byte[buffLength];

                        long contentLen = fileStream.Read(buff, 0, buffLength);
                        long totalFileSize = fileStream.Length;
                        long totalUploaded = 0;
                        while (contentLen != 0)
                        {
                            requestStream.Write(buff, 0, (int) contentLen);
                            contentLen = fileStream.Read(buff, 0, buffLength);
                            totalUploaded += contentLen;
                            int progressValue = (int) (((float) totalUploaded / (float)totalFileSize) * 100f);

                            progress?.Report(Convert.ToInt32(progressValue));
                        }
                    }
                }

                var response = (FtpWebResponse)request.GetResponse();
                response.Close();
            });
        }

        /// <summary>
        /// Přejmenuje soubor na serveru
        /// <example>
        public bool RenameFile(Uri uri, string newName)
        {
            FtpWebRequest ftp = CreateRequest(WebRequestMethods.Ftp.Rename, uri);
            ftp.RenameTo = newName;

            try
            {
                ftp.GetResponse();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Smaže soubor
        /// <example>
        public bool DeleteFileFromFtp(Uri uri)
        {
            try
            {
                var request = CreateRequest(WebRequestMethods.Ftp.DeleteFile, uri);
                request.UseBinary = false;
                request.KeepAlive = false;
                var response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public long GetFileSize(Uri fileUri)
        {
            FtpWebRequest request = CreateRequest(WebRequestMethods.Ftp.GetFileSize, fileUri);
            request.Proxy = null;
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            long size = response.ContentLength;
            response.Close();
            return size;
        }

        public Task<bool> DownloadFileFTP(Uri fileUri, string downloadPath, IProgress<int> progress)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    long fileSize = GetFileSize(fileUri);
                    var request = CreateRequest(WebRequestMethods.Ftp.DownloadFile, fileUri);

                    var filename = Path.GetFileName(fileUri.LocalPath);

                    using (var response = request.GetResponse())
                    using (Stream fileStream = File.Create(downloadPath))
                    {
                        Stream ftpStream = response.GetResponseStream();

                        long downloaded = 0;
                        byte[] buffer = new byte[10240];
                        int read;
                        while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, read);
                            downloaded += buffer.Length;

                            int progressValue = (int)(((float)downloaded / (float)fileSize) * 100f);

                            progress?.Report(Convert.ToInt32(progressValue));
                        }
                    }
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            });
        }

        public bool CreateDirectory(Uri uri, string name)
        {
            WebRequest request = CreateRequest(WebRequestMethods.Ftp.MakeDirectory, new Uri(uri.ToString() + "/" + name));

            try
            {
                var resp = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (Exception e)
            {
                return false;
            };
        }

        public bool DeleteFolder(Uri uri)
        {
            WebRequest request = CreateRequest(WebRequestMethods.Ftp.RemoveDirectory, uri);

            try
            {
                var resp = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (Exception e)
            {
                return false;
            };
        }

        public FtpWebRequest CreateRequest(string method)
        {
            //Todo check if valid metod (možná idk)

            var request = (FtpWebRequest)WebRequest.Create(rootUri);
            request.Method = method;
            request.Credentials = credentials;

            return request;
        }

        public FtpWebRequest CreateRequest(string method, Uri uri)
        {
            //Todo check if valid metod (možná idk)

            var request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = method;
            request.Credentials = credentials;

            return request;
        }
    }
}
