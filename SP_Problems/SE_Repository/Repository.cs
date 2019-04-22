using System;
using System.IO;
using System.Linq;

namespace SE_Repository
{
    public class Repository
    {
        public static SP_SEDataContext DC { get; set; }

        public static void UpdateConnectionString(string connectionString)
        {
            Properties.Settings.Default.ConnectionString = connectionString;
            Properties.Settings.Default.Save();
            Directory.CreateDirectory(@"c:\SP_SE");
            File.WriteAllText(@"c:\SP_SE\ConnectionStringToSP_SE.txt", connectionString);
        }

        public static bool Refresh(string str = null)
        {
            bool result = false;
            try
            {
                if (str == null)
                    DC = new SP_SEDataContext(Properties.Settings.Default.ConnectionString);
                else
                    DC = new SP_SEDataContext(str);
                result = DC.DatabaseExists();
            }
            catch { }
            return result;
        }

        public static IQueryable<Content> Contents { get { return DC.Contents; } }

        public static bool CreateContent(Content content)
        {
            if (content.ID == 0)
            {
                DC.Contents.InsertOnSubmit(content);
                DC.Contents.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateContent(Content content)
        {
            var cache = DC.Contents.FirstOrDefault(x => x.ID == content.ID);
            if (cache != null)
            {
                cache.Url = content.Url;
                cache.Title = content.Title;
                cache.Text = content.Text;
                DC.Contents.Context.SubmitChanges();
                return true;
            }
            return false;
        }        
    }
}
