using System;
using System.Collections.Generic;
using System.Text;

namespace Ølspecialisten.Infrastructure.Data
{
    public interface IDBInitializer
    {
        void Initialize(BeerContext context);
    }
}
