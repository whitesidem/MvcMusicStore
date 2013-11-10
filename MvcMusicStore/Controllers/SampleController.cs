using System.Web.Mvc;

namespace MvcMusicStore.Controllers {
    public class SampleController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult Index2() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View("NotIndex");
        }

        public ActionResult Index3() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View("~/Views/Example/Index.cshtml");
        }

        public ActionResult Message(string name) {
            ViewBag.Message = string.Format("This is a partial view for {0}.",name);
            return PartialView();
        }

        public ActionResult PartialViewDemo() {
            return View();
        }
    }
}
