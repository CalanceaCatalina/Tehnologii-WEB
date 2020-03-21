﻿using System.Linq;
using WebApplication1.Domain;
using WebApplication1.Domain.Entities;

namespace WebApplication1.BusinessLogic
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            User result;
            using (var db = new UserContext())
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
  