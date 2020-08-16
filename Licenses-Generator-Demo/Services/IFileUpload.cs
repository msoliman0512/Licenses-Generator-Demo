using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenses_Generator_Demo.Services
{
    public interface IFileUpload
    {


        public  Task Upload(IFileListEntry file);
    }
}
