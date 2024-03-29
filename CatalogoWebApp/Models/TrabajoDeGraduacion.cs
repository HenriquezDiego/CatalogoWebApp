﻿using System;

namespace CatalogoWebApp.Models
{
    public class TrabajoDeGraduacion
    { 
        public int TrabajoDeGraduacionId { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public string Descripcion { get; set; }
        public string PathImagen { get; set; }
        public string PathFile { get; set; }
        public DateTime Fecha { get; set; }
        public TipoId TipoId { get; set; }
        public Tipo Tipo { get; set; }
    }
}
