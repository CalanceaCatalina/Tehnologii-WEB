using System.Web.Mvc;

namespace WebApplication1.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();
            return View();
        }
        public ActionResult FlowerCompositions()
        {
            SessionStatus();
            return View();
        }
        public ActionResult Contacts()
        {
            SessionStatus();
            return View();
        }
        public ActionResult FlowerBouquets()
        {
            SessionStatus();
            return View();
        }

        public ActionResult Cakes()
        {
            SessionStatus();
            return View();
        }

        public ActionResult Toys()
        {
            SessionStatus();
            return View();
        }

        public ActionResult Balloons()
        {
            SessionStatus();
            return View();
        }
    }
}