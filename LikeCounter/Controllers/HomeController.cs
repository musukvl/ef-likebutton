using System.Web.Mvc;
using LikeCounter.ViewModels.Home;

namespace LikeCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string pageId = "home")
        {
            return View(new HomeIndexViewModel {PageId = pageId});
        }
    }
}