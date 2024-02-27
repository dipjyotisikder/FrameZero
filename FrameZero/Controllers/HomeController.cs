using FrameZero.Data;
using System.Linq;
using System.Web.Mvc;

namespace FrameZero.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new FrameDbContext())
            {
                var list = context.Frames.ToList();
                ViewBag.FrameNames = list.Select(x => x.Name).ToList();
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