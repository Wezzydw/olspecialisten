using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.DomainServices
{
    public interface IUserRepository
    {
        void AddUser();
        void DeleteUser();
        void UpdateUser();

        User IsValid(LoginForm loginForm);

    }

    
}
