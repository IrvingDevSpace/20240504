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

        public bool CheckHelloWordIsExist(User user)
        {
            if (user.Account == "Hello World" && user.Password == "789")
                return true;
            return false;

        }

        public void LoginHelloWorld(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public void Html(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public void GIDLE(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }
    }
}
