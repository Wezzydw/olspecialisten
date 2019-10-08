using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.ApplicationServices
{
    public interface IBeerService
    {

        List<Beer> GetAllBeers();
        void CreateBeer(Beer beer);
        void DeleteBeer(int id);
        void UpdateBeer(Beer beer);
        List<Beer> GetBeersByType(string type);

        Beer GetBeerById(int id);
    }
}
