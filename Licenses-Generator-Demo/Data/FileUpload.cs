﻿using BlazorInputFile;
using Licenses_Generator_Demo.Services;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Licenses_Generator_Demo.Data
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _oWebHostEnvironment;

        public FileUpload(IWebHostEnvironment oWebHostEnvironment)
        {
            _oWebHostEnvironment = oWebHostEnvironment;
        }
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_oWebHostEnvironment.ContentRootPath,"UploadedFiles", file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using(FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write)) 
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
