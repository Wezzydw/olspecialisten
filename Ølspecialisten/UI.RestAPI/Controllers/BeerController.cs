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
            public ActionResult<IEnumerable<Beer>> Get()
            {
                return _beerService.GetAllBeers();
            }

            // GET api/values/5
            [HttpGet("{id}")]
            public ActionResult<string> Get(int id)
            {
                return "value";
            }

            // POST api/values
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // PUT api/values/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }

