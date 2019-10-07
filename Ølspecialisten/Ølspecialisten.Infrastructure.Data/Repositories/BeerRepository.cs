using System;
using System.Collections.Generic;
using System.Text;

namespace Ølspecialisten.Infrastructure.Data.Repositories
{
    class BeerRepository
    {
        List<Beer> GetAllBeers();
        void CreateBeer(Beer beer);
        void DeleteBeer(int id);
        void UpdateBeer(Beer beer);
        List<Beer> GetBeersByType(Beer.TypeØl type);
    }
}
