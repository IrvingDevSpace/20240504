﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Models;

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
            
        }
    }
}
