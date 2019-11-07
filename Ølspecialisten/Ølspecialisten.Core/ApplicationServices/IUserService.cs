using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.ApplicationServices
{
    public interface IUserService
    {
        String genereateToken(LoginForm loginForm);

    }
}
