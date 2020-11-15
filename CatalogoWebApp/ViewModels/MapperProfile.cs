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
                .ForMember(i=>i.PathImagen, opt =>
                {
                    opt.PreCondition(x=>x.Imagen==null);
                    opt.UseDestinationValue();
                });
        }
    }
}
