using System;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.Domain.Entities;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class AuthentificationController : Controller
    {
        private readonly ISession _session;

        public AuthentificationController()
        {
            var bl = new BusinessLogics();
            _session = bl.GetSessionBL();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Username = login.Username,
                    Password = login.Password,
                    LoginDateTime = DateTime.Now
                };

                var userLogin = _session.UserLogin(data);

                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Username);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                }
            }
            return View();
        }

       // [HttpPost]
        public ActionResult SignUp()
        {
            return View();
        }
    }
}
