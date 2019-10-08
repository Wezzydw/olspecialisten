using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.DomainServices
{
   public interface IBeerRepository
    {
        List<Beer> GetAllBeers();
        void CreateBeer(Beer beer);
        void DeleteBeer(int id);
        void UpdateBeer(Beer beer);
        List<Beer> GetBeersByType(Beer.TypeBeer type);

        Beer GetBeerById(int id);
    }
}
