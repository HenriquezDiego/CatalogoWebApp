using System;
using AutoMapper;
using CatalogoWebApp.Inputs;
using CatalogoWebApp.Models;

namespace CatalogoWebApp.ViewModels
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(vm=> vm.NombreCompleto,opt=> opt.MapFrom(src=>$"{src.Nombres} {src.Apellidos}"))
                .ForMember(vm=> vm.Info,opt=> opt.MapFrom(src=>$"{src.Codigo}-{src.Nombres} {src.Apellidos}"));

            CreateMap<TrabajoDeGraduacion, TrabajoDeGraduacionInput>()
                .ReverseMap()
                .ForMember(i=>i.Fecha,opt=> opt.MapFrom(src=>new DateTime(src.Year,1,1)))
                .ForMember(i=>i.PathImagen, opt =>
                {
                    opt.PreCondition(x=>x.Imagen==null);
                    opt.UseDestinationValue();
                })
                .ForMember(i=>i.PathFile, opt =>
                {
                    opt.PreCondition(x=>x.File==null);
                    opt.UseDestinationValue();
                });

        }
    }
}
