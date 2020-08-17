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
    public class LicenseTypeService
    {
        public LicenseTypeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<LicenseTypeEntity>> GetLicensesTypesAsync()
        {
            IEnumerable<LicenseTypeEntity> types = null;
            await Task.Run(async () =>
            {
                using (var adapter = new DataAccessAdapter())
                {
                    var metaData = new LinqMetaData(adapter);
                    adapter.CloseConnection();
                    types = await metaData.LicenseType.ToListAsync();
                }
            });

            return types;
        }

        public IEnumerable<LicenseTypeEntity> GetLicensesTypes()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.LicenseType.ToList();
            }
        }
    }
}
