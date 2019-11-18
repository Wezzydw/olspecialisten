using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data.Repositories
{
    public class UserRepository :IUserRepository
    {
        private BeerContext _beerContext;
        public UserRepository(BeerContext context)
        {
            _beerContext = context;
        }


        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

        public User IsValid(LoginForm loginForm)
        {
            User a = _beerContext.Users.FirstOrDefault(b => b.UserName == loginForm.UserName);
            if (a == null)
            {
                return null;
            }

            using (var hmac = new System.Security.Cryptography.HMACSHA512(a.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(loginForm.Password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != a.PasswordHash[i])
                    {
                        return null;
                    }
                }
            }
            return a;
        }
    }
}
