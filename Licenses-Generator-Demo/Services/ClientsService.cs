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
    public class ClientsService
    {
        public ClientsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<ClientEntity>> GetClientsAsync()
        {

            IEnumerable<ClientEntity> clients = null;
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = metaData.Client;
                clients = await query.ToListAsync();
            }
            return clients;
        }

        public IEnumerable<ClientEntity> GetClients()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.Client.ToList();
            }
        }

        public void SaveClient(ClientEntity clientEntity)
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(clientEntity);
            }
        }
    }
}
