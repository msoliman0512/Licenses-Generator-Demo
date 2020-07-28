using Licenses_Generator_DBFirst.DatabaseSpecific;
using Licenses_Generator_DBFirst.EntityClasses;
using Licenses_Generator_DBFirst.Linq;
using Microsoft.AspNetCore.Hosting;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenses_Generator_Demo.Services
{
    public class GovernoratesService
    {
        public GovernoratesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<GovernorateEntity>> GetGovernoratesAsync()
        {
            IEnumerable<GovernorateEntity> governorates = null;
            await Task.Run(async () =>
            {
                using (var adapter = new DataAccessAdapter())
                {
                    var metaData = new LinqMetaData(adapter);
                    adapter.CloseConnection();
                    governorates = await metaData.Governorate.ToListAsync();
                }
            });

            return governorates;
        }

        public IEnumerable<GovernorateEntity> GetGovernorates()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.Governorate.ToList();
            }
        }
    }
}