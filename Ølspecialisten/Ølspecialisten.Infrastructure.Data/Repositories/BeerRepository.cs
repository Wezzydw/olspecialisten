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

        public List<Beer> GetAllBeers(Filter filter)
        {
            IEnumerable<Beer> list = new List<Beer>();
            list = _beerContext.Beers;

            if (filter != null && filter.Land >= 0 &&
                Enum.GetValues(typeof(Beer.Nationalitet)).Length < (int) filter.Land)
            {
               list = list.Where(f => f.Nation.Equals(filter.Land));
            }

            /*if(list.ToList().Count.Equals(0))
            {
                list = _beerContext.Beers.ToList();
            }*/
            return list.ToList();
            //return _beerContext.Beers.ToList();
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
            _beerContext.SaveChanges();
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