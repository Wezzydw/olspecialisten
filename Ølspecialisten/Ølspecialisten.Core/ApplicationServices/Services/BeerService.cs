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
        public List<Beer> GetAllBeers()
        {
            return _beerRepository.GetAllBeers();
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

        public List<Beer> GetBeersByType(Beer.TypeBeer type)
        {
            return _beerRepository.GetBeersByType(type);
        }
    }
}
