using CatalogoWebApp.Models;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public static IEnumerable<Autor> GetAutores(IHostEnvironment hosting)
        {
            var filepath = Path.Combine(hosting.ContentRootPath, @"DataAccess\Data\autores.json");
            var json = JObject.Parse(File.ReadAllText(filepath));
            var jsonResult = JsonConvert.DeserializeObject<IEnumerable<AutorJson>>(json["Autores"]
                .ToString(Formatting.None));

            var id = 2;
            return jsonResult.Select(x =>
            {
                var nombreCompleto = x.Nombre;
                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    var nombreSplit = nombreCompleto.Split(" ");
                    if (nombreSplit.Length > 2)
                    {
                        id += 1;
                        return new Autor
                        {
                            AutorId = id,
                            Codigo = x.Codigo,
                            Nombres = nombreSplit.Take(2)
                                .Aggregate((partialPhrase, word)=>$"{partialPhrase} {word}"),
                            Apellidos = nombreSplit.Skip(2)
                                .Aggregate((partialPhrase, word)=>$"{partialPhrase} {word}"),
                            CarreraId = int.Parse(x.CarreraId)
                        };
                    }
                }

                return null;
            });
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

    public class AutorJson
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CarreraId { get; set; }
    }
}
