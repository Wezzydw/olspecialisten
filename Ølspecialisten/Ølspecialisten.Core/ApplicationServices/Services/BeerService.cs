using System;
using System.Collections.Generic;
using System.Text;
using Ølspecialisten.Core.DomainServices;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Core.ApplicationServices.Services
{
    public class BeerService : IBeerService
    {

        private IBeerRepository _beerRepository;

        public BeerService(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }
        public List<Beer> GetAllBeers(Filter filter)
        {



            return _beerRepository.GetAllBeers(filter);
        }

        public void CreateBeer(Beer beer)
        {
            _beerRepository.CreateBeer(beer);
        }

        public void DeleteBeer(int id)
        {
            _beerRepository.DeleteBeer(id);
        }

        public void UpdateBeer(Beer beer)
        {
           _beerRepository.UpdateBeer(beer);
        }

        public List<Beer> GetBeersByType(string type)
        {
            Beer.TypeBeer t = Beer.TypeBeer.lys;
            foreach (Beer.TypeBeer beertype in Enum.GetValues(typeof(Beer.TypeBeer)))
            {
                if(beertype.ToString().Equals(type))
                {
                    t = beertype;
                }
            }
            return _beerRepository.GetBeersByType(t);
        }

        public Beer GetBeerById(int id)
        {
            return _beerRepository.GetBeerById(id);
        }
    }
}
