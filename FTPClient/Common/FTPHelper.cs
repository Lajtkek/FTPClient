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
        private FTPHelper()
        {

        }

        public List<string> GetDirectoryDetails(string server, string username, string password)
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

                        return lines.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        
                    }
                }
            }
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
