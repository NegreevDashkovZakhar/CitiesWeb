using CitiesWeb.Database.contexts;
using CitiesWeb.Database.models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors()]
    public class CitiesController : ControllerBase
    {
        private CityContext cityContext;

        public CitiesController()
        {
            cityContext = new CityContext();
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return cityContext.cities.Include(x=>x.coords);
        }

        [HttpGet("{id}")]
        public City GetById(int id)
        {
            return cityContext.cities.Include(x=>x.coords).ToList().Find(x=>x.cityId == id);
        }
    }
}
