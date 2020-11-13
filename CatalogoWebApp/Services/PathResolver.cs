using Microsoft.AspNetCore.Http;

namespace CatalogoWebApp.Services
{
    public class PathResolver : IPathResolver
    {
        private readonly IHttpContextAccessor _context;

        public PathResolver(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUrl(string imagenPaths)
        {
            if (string.IsNullOrEmpty(imagenPaths)) return null;
            var paths = imagenPaths.Split(";");
            if (paths.Length <= 0) return null;
            var newsPaths = string.Empty;
            var urlBase = $"{_context.HttpContext.Request.Scheme}://{_context.HttpContext.Request.Host}";
            foreach (var path in paths)
            {
                newsPaths += @$"{urlBase}/{path};";
            }

            if (newsPaths.Contains(";")) return newsPaths.Remove((newsPaths.Length - 1));
            return newsPaths;
        }
    }
}
