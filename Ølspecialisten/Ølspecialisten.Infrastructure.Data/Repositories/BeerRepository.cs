using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data.Repositories
{
    public class BeerRepository : IBeerRepository
    {
        private BeerContext _beerContext;
        public BeerRepository(BeerContext context)
        {
            _beerContext = context;
        }

        public List<Beer> GetAllBeers()
        {
            return _beerContext.Beers.ToList();
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
