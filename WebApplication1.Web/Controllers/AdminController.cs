using System.Web.Mvc;
using WebApplication1.Web.Controllers.Attributes;
using WebApplication1.Web.Extensions;

namespace WebApplication1.Web.Controllers
{
    public class AdminController : BaseController
    {
        [AdminMod]
        public ActionResult Index()
        {
            SessionStatus();

            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] == "login")
            {
                var user = System.Web.HttpContext.Current.GetMySessionObject();

                return View(user);
            }
            return View();

        }
    }
}