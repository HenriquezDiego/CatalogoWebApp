using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TransaccionesWebApi.Services;

namespace ContaWebApi.Api.Infrastructure
{
   public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _hosting;
        private readonly ILogger<FileService> _logger;
        public string RootDirectory { get; set; } = @"files";
        public string MediaType { get; set; } = MediaTypesExtension.Application.Pdf;

        public FileService(IWebHostEnvironment hosting,ILogger<FileService> logger)
        {
            _hosting = hosting;
            _logger = logger;
        }
        public Task<string> Upload(IFormFile file, string name)
        {
            if (file == null) throw new ArgumentNullException();
            return Upload(new List<IFormFile> { file }, name);
        }

        public async Task<string> Upload(IList<IFormFile> files, string name)
        {
            _logger.LogInformation("Iniciando..."+nameof(Upload));
            var filesPath = string.Empty;
            var namefile = name;
            if (files.Count != 0)
            {
                var directory = @$"{RootDirectory}/{namefile}";
                var fullPath = Path.Combine(_hosting.WebRootPath, directory);
                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
                var count = Directory.GetFiles(fullPath)?.Length;
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var extension = Path.GetExtension(file.FileName);
                        namefile =$"{name}-{count}";
                        var filePath = @$"{namefile}{extension}";
                        await using var stream = File.Create(Path.Combine(fullPath,filePath));
                        filesPath += $"{directory}/{filePath};";
                        await file.CopyToAsync(stream);
                        count++;
                    }
                }

                filesPath = filesPath.Remove((filesPath.Length-1));
            }
            _logger.LogInformation("Finalizando..."+nameof(Upload));
            return filesPath;
        }

        public async Task<(MemoryStream memoryStream, string MediaTypeNames, string FileName)> Download(string filepath)
        {
            if (filepath == null)
                throw new ArgumentNullException();

            var memory = new MemoryStream();
            await using (var stream = new FileStream(filepath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return (memory, MediaTypeNames.Image.Jpeg, Path.GetFileName(filepath));
        }
    }

    public static class MediaTypesExtension
    {
        public static class Image
        {
            public const string Jpeg = @".jpeg";
        }
        public static class Application
        {
            public const string Pdf = @".pdf";

        }
    }
}
