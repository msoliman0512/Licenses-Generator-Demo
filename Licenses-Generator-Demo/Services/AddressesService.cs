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
    public class AddressesService
    {
        public AddressesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<AddressEntity>> GetAddressesAsync()
        {
           
            IEnumerable<AddressEntity> addresses = null;
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = metaData.Address;
                addresses = await query.ToListAsync();
            }
            return addresses;
        }

        public IEnumerable<AddressEntity> GetAddresses()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.Address.ToList();
            }
        }

        public void SaveAddress(AddressEntity addressEntity)
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(addressEntity);
            }
        }
    }
}

