using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
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

        public Beer CreateBeer(Beer beer)
        {
            _beerContext.Attach(beer).State = EntityState.Added;
            _beerContext.SaveChanges();
            return beer;
        }

        public Beer DeleteBeer(int id)
        {
            var beerRemove = _beerContext.Remove(new Beer() { Id = id }).Entity;
            return beerRemove;
        }

        public Beer UpdateBeer(Beer beer)
        {
            _beerContext.Attach(beer).State = EntityState.Modified;
            _beerContext.SaveChanges();
            return beer;
        }

        public List<Beer> GetBeersByType(Beer.TypeBeer type)
        {
            return _beerContext.Beers.Where(b => b.TypeOfBeer.Equals(type)).ToList();
        }

        public Beer GetBeerById(int id)
        {
           return _beerContext.Beers.FirstOrDefault(i => i.Id == id);
        }
    }
}