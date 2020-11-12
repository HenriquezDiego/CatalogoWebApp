using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TransaccionesWebApi.Services
{
    public interface IFileService
    {
        public string RootDirectory { get; set; }
        public string MediaType { get; set; }
        Task<string> Upload(IFormFile file, string name);
        Task<string> Upload(IList<IFormFile> files, string name);
        Task<(MemoryStream memoryStream, string MediaTypeNames, string FileName)> Download(string path);
    }
}
