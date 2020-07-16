using System.Diagnostics;
using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;

namespace SessionLock.AspnetFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                Session["UserName"] = userName;
                string uName = (string)Session["UserName"];

                for (var i = 0; i < 10; i++)
                {
                    Trace.WriteLine($"{Session.SessionID} {uName}");
                    Thread.Sleep(1000);
                }
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}