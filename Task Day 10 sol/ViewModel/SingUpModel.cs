using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Day_10_sol.Models;

namespace Task_Day_10_sol.ViewModel
{
    public class SingUpModel
    {
        public string UserName { get; set; }
        public string Password{ get; set; }
    }

    public static class SignUpModelExtension
    {
        public static User SignUpModelToUser(this SingUpModel _SignUpModel)
        {
            return new User
            {
                UserName = _SignUpModel.UserName,
                PasswordHash = _SignUpModel.Password
            };
        }
    }
}
