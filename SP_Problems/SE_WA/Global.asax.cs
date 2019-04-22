using SE_Repository;
using System;
using System.IO;

namespace SE_WA
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Repository.Refresh(File.ReadAllText(@"c:\SP_SE\ConnectionStringToSP_SE.txt"));
        }
    }
}