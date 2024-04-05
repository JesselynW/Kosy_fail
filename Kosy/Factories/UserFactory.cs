using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class UserFactory
    {
        public static User Create(int id, string username, string phone, string email, string password)
        {
            User user = new User();
            user.UserId = id;
            user.UserName = username;
            user.UserPhone = phone;
            user.UserEmail = email;
            user.UserPassword = password;
            return user;
        }
    }
}