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
            IEnumerable<Beer> list = _beerContext.Beers;



            foreach (var VARIABLE in Enum.GetValues(typeof(Beer.Nationalitet)))
            {
                if(VARIABLE.ToString().Equals(filter.Land))
                {
                    list = list.Where(f => f.Nation.ToString().Equals(filter.Land));
                }
            }

            foreach (var VARIABLE in Enum.GetValues(typeof(Beer.TypeBeer)))
            {
                if (VARIABLE.ToString().Equals(filter.Type))
                {
                    list = list.Where(f => f.TypeOfBeer.ToString().Equals(filter.Type));
                }
            }



            /*if (filter.Land >= 0 &&
                Enum.GetValues(typeof(Beer.Nationalitet)).Length > (int) filter.Land)
            {
               list = _beerContext.Beers.Where(f => (int)f.Nation ==(filter.Land));
            }*/

            /*if ((int)filter.Type > 0 &&
                Enum.GetValues(typeof(Beer.TypeBeer)).Length >= (int)filter.Type)
            {
                list = _beerContext.Beers.Where(f => f.TypeOfBeer.Equals(filter.Type-1));
            }*/



            /*if (filter.Land.ToString().Length == 0)
            {
                list = list.Where(f => f.Nation.ToString() ==(filter.Land.ToString()));
            }

            if (filter.Type != 0)
            {
                list = list.Where(f => f.TypeOfBeer.Equals(filter.Type));
            }*/

            /*if ((int)filter.Type > 0 &&
                Enum.GetValues(typeof(Beer.TypeBeer)).Length >= (int)filter.Type)
            {
                list= list.Where(f => (int)f.TypeOfBeer == (int)filter.Type - 1);
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