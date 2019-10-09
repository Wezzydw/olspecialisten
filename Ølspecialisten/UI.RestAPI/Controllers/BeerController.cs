using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ølspecialisten.Core.ApplicationServices;
using Ølspecialisten.Core.Entity;

namespace UI.RestAPI.Controllers
{
 
        [Route("api/[controller]")]
        [ApiController]
        public class BeerController : ControllerBase
        {

            private IBeerService _beerService;

            public BeerController(IBeerService beerService)
            {
                _beerService = beerService;
            }
            // GET api/values
            [HttpGet]
            public ActionResult<IEnumerable<Beer>> Get([FromQuery] Filter filter)
            {
                return _beerService.GetAllBeers(filter);
            }

            // GET api/values/5//andreas syntes den skulle hedde solskin
            [HttpGet("{id}")]
            public ActionResult<Beer> Solskin(int id)
            {
                return _beerService.GetBeerById(id);
            }

            // POST api/values
            [HttpPost]
            public void Post([FromBody] Beer beer)
            {
                _beerService.CreateBeer(beer);
            }

            // PUT api/values/5
            [HttpPut]
            public void Put([FromBody] Beer beer)
            {
                _beerService.UpdateBeer(beer);
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                _beerService.DeleteBeer(id);
            }
        }
    }

