using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Models;

namespace TT.Services
{
    internal class LoginService
    {
        public static bool Login(User user)
        {
            if (user == null)
                return false;
            if (String.IsNullOrEmpty(user.Account) || String.IsNullOrEmpty(user.Password))
                return false;
            return true;
        }

        public static bool ForgetPassword(User user)
        {
            if (String.IsNullOrEmpty(user.Address))
                return false;
            return true;
        }
    }
}
