using System;

namespace TT.Models
{
    public class User
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }

        public User(string name, string address, string account, string password)
        {
            Name = name;
            Address = address;
            Account = account;
            Password = password;
        }
    }
}