using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.BusinessLogic.Entities;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Helpers;

namespace WebApplication1.BusinessLogic
{
    public class UserApi
    {
        internal UserEntity UserCookie(string apiCookieValue)
        {
			User curentUser;

			using (var db = new SiteContext())
			{
				var session = db.Sessions.FirstOrDefault(s => s.CookieString == apiCookieValue && s.ExpireTime > DateTime.Now);
				if (session == null) return null;

				curentUser = db.Users.FirstOrDefault(u => u.Username == session.Username);
				if (curentUser == null) return null;
			}

			return new UserEntity
			{
				Id = curentUser.Id,
				AvatarUrl = curentUser.AvatarUrl,
				Email = curentUser.Email,
				Level = curentUser.Level,
				RegisterDate = curentUser.RegisterDate,
				Username = curentUser.Username
			};
		}

		// Generate the cookie and put in database
		internal HttpCookie Cookie(string username)
		{
			var apiCookie = new HttpCookie("LOGIN-KEY")
			{
				Value = CookieGenerator.Create(username)
			};

			using (var db = new SiteContext())
			{
				Session curent;

				curent = db.Sessions.FirstOrDefault(u => u.Username == username);

				if (curent != null)
				{
					curent.CookieString = apiCookie.Value;
					curent.ExpireTime = DateTime.Now.AddDays(1);

					db.Entry(curent).State = EntityState.Modified;
					db.SaveChanges();
				}
				else
				{
					db.Sessions.Add(new Session
					{
						Username = username,
						CookieString = apiCookie.Value,
						ExpireTime = DateTime.Now.AddDays(1)
					});
					db.SaveChanges();
				}
			}

			return apiCookie;
		}

		internal ULoginResp UserLoginAction(ULoginData data)
        {
            User result;
            using (var db = new SiteContext())
            {
                result = db.Users.FirstOrDefault(u => u.Username == data.Username && u.Password == data.Password);
            }
            if (result == null)
            {
                return new ULoginResp { Status = false, StatusMsg = "The username or password is incorrect" };
            }
            return new ULoginResp { Status = true };
        }
    }
}
  