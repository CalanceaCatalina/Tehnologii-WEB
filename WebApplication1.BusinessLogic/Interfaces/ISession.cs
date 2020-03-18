using WebApplication1.Domain.Entities;

namespace WebApplication1.BusinessLogic
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
    }
}