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
    public class DocumentsService
    {
        public DocumentsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<DocumentEntity>> GetDocumentsAsync()
        {

            IEnumerable<DocumentEntity> documents = null;
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = metaData.Document;
                documents = await query.ToListAsync();
            }
            return documents;
        }

        public IEnumerable<DocumentEntity> GetDocuments()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                adapter.CloseConnection();
                return metaData.Document.ToList();
            }
        }

        public async Task<bool> SaveDocument(DocumentEntity documentEntity)
        {
            using (var adapter = new DataAccessAdapter())
            {
                return await adapter.SaveEntityAsync(documentEntity, refetchAfterSave: true);
            }
        }
    }
}
