using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.DomainServices
{
   public interface IBeerRepository
    {
        List<Beer> GetAllBeers(Filter filter);
        Beer CreateBeer(Beer beer);
        Beer DeleteBeer(int id);
        Beer UpdateBeer(Beer beer);
        List<Beer> GetBeersByType(Beer.TypeBeer type);

        Beer GetBeerById(int id);
    }
}
