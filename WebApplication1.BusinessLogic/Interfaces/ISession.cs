using System.Web;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        HttpCookie GenCookie(string username);
        UserEntity GetUserByCookie(string apiCookieValue);
    }
}