using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Day_10_sol.Models;
using Task_Day_10_sol.ViewModel;

namespace Task_Day_10_sol.UserRepo
{
    public class UserRepository : IUserRepo
    {
        UserManager<User> UserManger;
        public UserRepository(UserManager<User> _userManger)
        {
            UserManger = _userManger;
        }
        public async Task<string> SignUp(SingUpModel _SingUpModel)
        {
            User temp = _SingUpModel.SignUpModelToUser();
            var newUser = await UserManger.CreateAsync(temp, _SingUpModel.Password);
            
            if (!newUser.Succeeded)
                return null;

            var secret = "ASDFAEFASDGRGTERFIVFWENIFSJADOIJWDF;LKJEGEWIO";
            var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var token = new JwtSecurityToken
                (
                issuer: "this api",
                audience: "this api",
                expires: DateTime.Now.AddDays(14) , 
                signingCredentials:new SigningCredentials(signKey ,SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
