using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace Ølspecialisten.Core.ApplicationServices.Services
{
    public class UserService : IUserService
    {
        private byte[] bytes; 
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public String genereateToken(LoginForm loginForm)
        {
            User user = _userRepository.IsValid(loginForm);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginForm.UserName)
                };

                if(user.IsAdmin)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                }

                var token = new JwtSecurityToken(new JwtHeader(new SigningCredentials(new SymmetricSecurityKey(bytes), SecurityAlgorithms.HmacSha256)), new JwtPayload(null, null, claims.ToArray(), DateTime.Now, DateTime.Now.AddHours(2)));
                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return null;
        }
    }
}
