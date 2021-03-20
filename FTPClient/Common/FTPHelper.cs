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

        public Uri serverUri;
        private NetworkCredential credentials;
        public NetworkCredential Credentials => credentials;
        private FTPHelper()
        {

        }

        public void SetCredentials(string server, string username, string password)
        {
            credentials = new NetworkCredential(username, password);
            serverUri = new Uri("ftp://" + server + "/");
        }
        public List<string> GetDirectoryDetails(Uri directoryUri)
        {
            var request = CreateRequest(WebRequestMethods.Ftp.ListDirectoryDetails, directoryUri);

            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream)) {
                        string lines = reader.ReadToEnd();

                        return lines.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        
                    }
                }
            }
        }

        public long GetFileSize(Uri uri)
        {
            //try
            //{
            //    var a = uri;
            //    var request = CreateRequest(WebRequestMethods.Ftp.GetFileSize);

            //    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            //    long size = response.ContentLength;
            //    response.Close();
            //    return size;
            //}
            //catch (Exception e)
            //{
            //    return 0;
            //}
            return 0;
        }


        public void UploadFileToFtp(Uri uri, string filePath)
        {
            var fileName = System.IO.Path.GetFileName(filePath);
            var request = CreateRequest(WebRequestMethods.Ftp.UploadFile,new Uri(uri.ToString() + "/" + fileName));

            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (var fileStream = File.OpenRead(filePath))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                    requestStream.Close();
                }
            }

            var response = (FtpWebResponse)request.GetResponse();
            response.Close();
        }


        public void DeleteFileFromFtp(Uri uri)
        {
            var request = CreateRequest(WebRequestMethods.Ftp.DeleteFile, uri);

            var response = (FtpWebResponse)request.GetResponse();
            response.Close();
        }

        public FtpWebRequest CreateRequest(string method)
        {
            //Todo check if valid metod (možná idk)

            var request = (FtpWebRequest)WebRequest.Create(serverUri);
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
