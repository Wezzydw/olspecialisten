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
            if (a != null && a.Password == loginForm.Password)
            {
                return a;
            }
            return null;
        }
    }
}
