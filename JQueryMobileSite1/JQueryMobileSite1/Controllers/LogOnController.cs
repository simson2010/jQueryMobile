using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace JQueryMobileSite1.Controllers
{
    public class LogOnController : Controller
    {
        //
        // GET: /LogOn/

        public ActionResult LogOn()
        {
            return View();
        }

        public string LoadRemote()
        {
            string s = "";
            HttpWebRequest hwr = HttpWebRequest.Create("http://203.186.126.121/Login.aspx") as HttpWebRequest;
            
            hwr.Method = "GET";
            
            hwr.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
            HttpWebResponse hwrp = hwr.GetResponse() as HttpWebResponse;
            if (hwrp != null)
            {
                StreamReader sr = new StreamReader(hwrp.GetResponseStream());
                s = sr.ReadToEnd();
            }
            return s;
        }
    }
}
