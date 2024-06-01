using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Models;
using TT.Services;

namespace TT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入姓名");
            String Name = Console.ReadLine();
            Console.WriteLine("請輸入地址");
            String Address = Console.ReadLine();
            Console.WriteLine("請輸入帳號：");
            String Account = Console.ReadLine();
            Console.WriteLine("請輸入密碼：");
            String Password = Console.ReadLine();

            User user = new User(Name, Address, Account, Password);
            LoginService.A(user);
            LoginService.B(user);
            LoginService.C(user);
            LoginService.D(user);
            LoginService.E(user);
            LoginService.F(user);
            LoginService.G(user);
            LoginService.H(user);
            LoginService.F(user);
            LoginService.G(user);
            LoginService.H(user);
            RegisterService service = new RegisterService();
            service.Regist(user);

            Console.ReadKey();
        }
    }
}
