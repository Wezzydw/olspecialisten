using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data.Repositories
{
    public class BeerRepository : IBeerRepository
    {
        public List<Beer> GetAllBeers()
        {
            throw new NotImplementedException();
        }

        public void CreateBeer(Beer beer)
        {
            throw new NotImplementedException();
        }

        public void DeleteBeer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBeer(Beer beer)
        {
            throw new NotImplementedException();
        }

        public List<Beer> GetBeersByType(Beer.TypeØl type)
        {
            throw new NotImplementedException();
        }
    }
}
