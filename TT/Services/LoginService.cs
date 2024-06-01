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

        public static bool CheckHelloWordIsExist(User user)
        {
            if (user.Account == "Hello World" && user.Password == "789")
                return true;
            return false;

        }

        public static void LoginHelloWorld(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void Html(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void GIDLE(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }

        public static void A(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void B(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void C(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }

        public static void D(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void E(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void F(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }

        public static void G(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void H(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void I(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }

        public static void J(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void K(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void L(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }

        public static void M(User user)
        {
            if (!CheckHelloWordIsExist(user))
            {
                // 註冊帳號
                Console.WriteLine("Coco Loco");
            }
        }

        public static void N(User user)
        {
            if (user.Name == "RickRoll")
                Console.WriteLine("Fxck off");
        }

        public static void O(User user)
        {
            if (user.Name == "Wife")
                Console.WriteLine("Cream Soup");
        }
    }
}
