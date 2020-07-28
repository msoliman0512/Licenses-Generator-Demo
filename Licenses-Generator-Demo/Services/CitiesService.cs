using Licenses_Generator_DBFirst.DatabaseSpecific;
using Licenses_Generator_DBFirst.EntityClasses;
using Licenses_Generator_DBFirst.Linq;
using Microsoft.AspNetCore.Hosting;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenses_Generator_Demo.Services
{
    public class CitiesService
    {
        public CitiesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<CityEntity>> GetCitiesAsync()
        {
            //IEnumerable<CityEntity> cities = null;
            //await Task.Run(async () =>
            //{
            //    using (var adapter = new DataAccessAdapter())
            //    {
            //        var metaData = new LinqMetaData(adapter);
            //        adapter.CloseConnection();
            //        cities = await metaData.City.ToListAsync();
            //    }
            //});

            //return cities;
            IEnumerable<CityEntity> cities = null;
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = metaData.City;
                 cities = await query.ToListAsync();
            }
            return cities;
        }

        public IEnumerable<CityEntity> GetCities()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.City.ToList();
            }
        }
    }
}
