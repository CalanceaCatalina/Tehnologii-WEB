using WebApplication1.Domain.Entities;

namespace WebApplication1.BusinessLogic
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            var _username = "test@test";
            var _password = "test";

            if (data.Username != _username || data.Password != _password)
            {
                return new ULoginResp
                {
                    Status = false,
                    StatusMsg = "The Username or Password is Incorrect"
                };
            }
            return new ULoginResp { Status = true };
        }
    }
}