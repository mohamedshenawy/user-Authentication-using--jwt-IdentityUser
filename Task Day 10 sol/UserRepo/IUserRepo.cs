using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Day_10_sol.ViewModel;

namespace Task_Day_10_sol.UserRepo
{
    public interface IUserRepo
    {
        Task<string> SignUp(SingUpModel _SingUpModel);
    }
}
