using CitiesWeb.Database.contexts;
using CitiesWeb.Database.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CitiesWeb.Database
{
    public class DatabaseInitializer
    {
        public static void initializeDatabase()
        {
            string json = File.ReadAllText("Properties\\table_json.json");
            IEnumerable<City> cities = JsonSerializer.Deserialize<IEnumerable<City>>(json);
            using (CityContext cityContext = new CityContext())
            {
                cityContext.Database.EnsureDeleted();
                cityContext.Database.EnsureCreated();
                cityContext.cities.AddRange(cities);
                cityContext.SaveChanges();
            }
        }
    }
}
