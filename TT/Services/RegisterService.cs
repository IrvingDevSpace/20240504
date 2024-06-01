using TT.Models;

namespace TT.Services
{
    public class RegisterService
    {
        public bool CheckAccountIsExist(User user)
        {
            if (user.Account == "Leo" && user.Password == "1234")
                return false;

            return true;
            
        }
    }
}