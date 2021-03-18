using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient.Common
{
    class Settings
    {
        public static Settings Instance = new Settings();

        public Uri serverUri;
        private NetworkCredential credentials;
        private Settings()
        {

        }

        public bool TryCredentials(string server, string username, string password)
        {
            credentials = new NetworkCredential(username, password);
            serverUri = new Uri("ftp://" + server + "/");
            var request = CreateRequest(WebRequestMethods.Ftp.ListDirectoryDetails);

            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream)) {
                        string lines = reader.ReadToEnd();

                        var a = lines.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        // todo convert to like list of shit
                        var b = a;
                    }
                }
            }

            return true;
        }

        public FtpWebRequest CreateRequest(string method)
        {
            //Todo check if valid metod (možná idk)

            var request = (FtpWebRequest)WebRequest.Create(serverUri);
            request.Method = method;
            request.Credentials = credentials;

            return request;
        }
    }
}
