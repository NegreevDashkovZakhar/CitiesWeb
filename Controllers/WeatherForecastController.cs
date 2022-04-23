using CitiesWeb.Database.contexts;
using CitiesWeb.Database.models;
using Microsoft.AspNetCore.Mvc;
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
    public class WeatherForecastController : ControllerBase
    {
        private CityContext cityContext;

        public WeatherForecastController()
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
