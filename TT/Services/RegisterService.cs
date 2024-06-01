using TT.Models;

namespace TT.Services
{
    public class RegisterService
    {
        public bool CheckAccountIsExist(User user)
        {
            if (user.Account == "Leo" && user.Password == "1234")
                return true;

            return false;
            
        }

        public void Regist(User user)
        {
            if (!CheckAccountIsExist(user))
            {
                // 註冊帳號
            }
        }
    }
}