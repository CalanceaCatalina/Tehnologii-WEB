using System.Web;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public UserEntity GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }

        public HttpCookie GenCookie(string username)
        {
            return Cookie(username);
        }

        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }
    }
}
