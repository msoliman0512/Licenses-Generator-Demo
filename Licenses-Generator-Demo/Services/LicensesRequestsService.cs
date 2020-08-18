using System;
using System.Collections.Generic;
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
    public class LicensesRequestsService
    {
        public LicensesRequestsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<LicenseRequestEntity>> GetLicensesRequestsAsync()
        {

            IEnumerable<LicenseRequestEntity> requests = null;
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = metaData.LicenseRequest;
                requests = await query.ToListAsync();
            }
            return requests;
        }

        public IEnumerable<LicenseRequestEntity> GetLicensesRequests()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.LicenseRequest.ToList();
            }
        }

        public async Task<bool> SaveLicenseRequest(LicenseRequestEntity licenseRequestEntity)
        {
            using (var adapter = new DataAccessAdapter())
            {
                return await adapter.SaveEntityAsync(licenseRequestEntity, refetchAfterSave: true);
            }
        }
    }
}
