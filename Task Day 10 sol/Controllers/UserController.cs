using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Day_10_sol.UserRepo;
using Task_Day_10_sol.ViewModel;

namespace Task_Day_10_sol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepo UserRepo;
        public UserController(IUserRepo _UserRepo)
        {
            UserRepo = _UserRepo;
        }
        [HttpPost("post")]
        public async Task<IActionResult> SignUp(SingUpModel _SignUpModel)
        {
            string Token = await UserRepo.SignUp(_SignUpModel);

            if (string.IsNullOrWhiteSpace(Token))
                return Unauthorized();

            return Ok(Token);
        }
    }
}
