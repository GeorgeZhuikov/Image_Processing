using HtmlAgilityPack;
using SE_Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SE_Manager
{
    public static class Manager
    {
        private static CookieContainer _cc = new CookieContainer();

        private static HtmlDocument Get(string url)
        {
            HtmlDocument doc = new HtmlDocument();
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.CookieContainer = _cc;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (response.Cookies.Count > 0)
                    _cc.Add(response.Cookies);
                html = reader.ReadToEnd();
            }
            doc.LoadHtml(html);
            return doc;
        }

        private static HtmlDocument Post(string url, string requestParam = "")
        {
            HtmlDocument doc = new HtmlDocument();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            byte[] bytes = Encoding.UTF8.GetBytes(requestParam);
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            request.ContentType = @"application/x-www-form-urlencoded; charset=UTF-8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.37";
            request.CookieContainer = _cc;
            Stream dataStream;
            StreamReader reader;
            string responseFromServer;
            using (dataStream = request.GetRequestStream())
            {
                dataStream.Write(bytes, 0, bytes.Length);
            }
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                dataStream = response.GetResponseStream();
                using (BufferedStream buffer = new BufferedStream(dataStream))
                {
                    using (reader = new StreamReader(buffer))
                    {
                        responseFromServer = reader.ReadToEnd();
                    }
                }
            }
            doc.LoadHtml(responseFromServer);
            return doc;
        }

        private static string GetInnerText(HtmlDocument doc)
        {
            var sb = new StringBuilder();
            var root = doc.DocumentNode;
            foreach (var node in root.DescendantsAndSelf())
            {
                if (!node.HasChildNodes)
                {
                    string text = node.InnerText;
                    if (!string.IsNullOrEmpty(text))
                        sb.AppendLine(text.Trim());
                }
            }
            return sb.ToString();
        }
        
        public static bool CreateDataBase(string server, string login, string password)
        {
            bool result = false;
            try
            {
                string connectionString = "Server=" + server + ";Integrated security=SSPI;database=master;User ID=" + login + ";password=" + password + ";MultipleActiveResultSets=True";
                Repository.UpdateConnectionString(connectionString.Replace("master", "SP_SE"));
                if (!Repository.Refresh())
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand command = new SqlCommand(Properties.Resources.SP_SE_CreateDB, conn);
                    command.ExecuteNonQuery();
                    command = new SqlCommand(Properties.Resources.SP_SE_Content, conn);
                    command.ExecuteNonQuery();
                    try
                    {
                        command = new SqlCommand(Properties.Resources.SP_SE_SA, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { var q = ex.Message; }
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        public static bool CheckConnection()
        {
            return Repository.Refresh();
        }

        public static bool ProceedUrl(string url)
        {
            bool result = false;
            try
            {
                var doc = Get(url);
                var text = GetInnerText(doc);
                var title = doc.DocumentNode.Descendants("title").FirstOrDefault().InnerText;
                var content = Repository.Contents.FirstOrDefault(r => r.Url == url);
                if (content == null)
                    Repository.CreateContent(new Content() { Url = url, Title = title, Text = text });
                else
                {
                    content.Title = title;
                    content.Text = text;
                    Repository.UpdateContent(content);
                }
                result = true;
            }
            catch { }
            return result;
        }

        public static List<ContentMap> GetSearchResult(string toFind)
        {
            List<ContentMap> cms = new List<ContentMap>();
            foreach (var content in Repository.Contents.Where(c => c.Text.ToLower().Contains(toFind)).ToList())
                cms.Add(new ContentMap() {
                    Url = content.Url,
                    Title = content.Title
                });
            return cms;
        }
    }
}
