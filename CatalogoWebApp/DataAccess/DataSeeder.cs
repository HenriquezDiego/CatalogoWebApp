using System;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CatalogoWebApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatalogoWebApp.DataAccess
{
    public static class DataSeeder
    {
        
        public static IEnumerable<Carrera> GetCarreras(IHostEnvironment hosting)
        {
            var filepath = Path.Combine(hosting.ContentRootPath, @"DataAccess\Data\carreras.json");
            var json = JObject.Parse(File.ReadAllText(filepath));

            var carreras = JsonConvert.DeserializeObject<IEnumerable<Carrera>>(json["Carreras"]
                .ToString(Formatting.None));
            return carreras;
        }

        public static IEnumerable<Facultad> GetFacultades(IHostEnvironment hosting)
        {
            var filepath = Path.Combine(hosting.ContentRootPath, @"DataAccess\Data\facultades.json");
            var json = JObject.Parse(File.ReadAllText(filepath));

            var facultades = JsonConvert.DeserializeObject<IEnumerable<Facultad>>(json["Facultades"]
                .ToString(Formatting.None));
            return facultades;
        }

        public static readonly List<Tipo> Tipos
            = Enum.GetValues(typeof(TipoId))
                .Cast<TipoId>()
                .Select(e => new Tipo()
                {
                    TipoId = e,
                    Nombre = e.ToString()
                }).ToList();
    }
}
