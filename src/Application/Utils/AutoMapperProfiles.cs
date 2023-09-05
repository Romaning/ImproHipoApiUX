using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entities Improcons
using ProdImpro = Domain.Entities.Improcons.Prod;
using ClassProdImpro = Domain.Entities.Improcons.ClassProd;
using TypeProdImpro = Domain.Entities.Improcons.TypeProd;

//Entities Hipotina
using ProdHipo = Domain.Entities.Hipotina.Prod;
using ClassProdHipo = Domain.Entities.Hipotina.ClassProd;
using TypeProdHipo = Domain.Entities.Hipotina.TypeProd;

//Entities Auxiliar
using ProdAux = Domain.Entities.Auxiliar.Prod;
using ClassProdAux = Domain.Entities.Auxiliar.ClassProd;
using TypeProdAux = Domain.Entities.Auxiliar.TypeProd;

using AutoMapper;
using Domain.Entities.Common;

namespace Application.Utils
{
    internal class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            /*&&&&&&&&&&&&&&&&&& PROD X -> PROD DTO &&&&&&&&&&&&&&&&&&*/
            CreateMap<ProdImpro, DTOs.Prod>().ReverseMap();
            CreateMap<DTOs.Prod, ProdImpro>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database1"));

            CreateMap<ProdHipo, DTOs.Prod>().ReverseMap();
            CreateMap<DTOs.Prod, ProdHipo>();

            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            CreateMap<ProdAux, DTOs.Prod>().ReverseMap();
            CreateMap<DTOs.Prod, ProdAux>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            /*&&&&&&&&&&&&&&&&&& CLASS PROD X -> CALSS PROD DTO &&&&&&&&&&&&&&&&&&*/
            CreateMap<ClassProdImpro, DTOs.ClassProd>().ReverseMap();
            CreateMap<DTOs.ClassProd, ClassProdImpro>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database1"));

            CreateMap<ClassProdHipo, DTOs.ClassProd>().ReverseMap();
            CreateMap<DTOs.ClassProd, ClassProdHipo>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            CreateMap<ClassProdAux, DTOs.ClassProd>().ReverseMap();
            CreateMap<DTOs.ClassProd, ClassProdAux>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            /*&&&&&&&&&&&&&&&&&& TYPE PROD X -> TYPE PROD DTO &&&&&&&&&&&&&&&&&&*/
            CreateMap<TypeProdImpro, DTOs.TypeProd>().ReverseMap();
            CreateMap<DTOs.TypeProd, TypeProdImpro>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database1"));

            CreateMap<TypeProdHipo, DTOs.TypeProd>().ReverseMap();
            CreateMap<DTOs.TypeProd, TypeProdHipo>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            CreateMap<TypeProdAux, DTOs.TypeProd>().ReverseMap();
            CreateMap<DTOs.TypeProd, TypeProdAux>();
            //.ForMember(dest => dest.SourceDatabase, opt => opt.MapFrom(src => "Database2"));

            /*&&&&&&&&&&&&&&&&&& BASE PROD X -> TYPE PROD DTO &&&&&&&&&&&&&&&&&&*/
            CreateMap<ProdBase, DTOs.Prod>().ReverseMap();
            CreateMap<DTOs.Prod, ProdBase>();

            CreateMap<TypeProdBase, DTOs.TypeProd>().ReverseMap();
            CreateMap<DTOs.TypeProd, TypeProdBase>();

            CreateMap<ClassProdBase, DTOs.ClassProd>().ReverseMap();
            CreateMap<DTOs.ClassProd, ClassProdBase>();
            //PAGINA WEB
            //CreateMap<ProdBase, DTOsWebPageMain.Prod>().ReverseMap();
            //CreateMap<DTOsWebPageMain.Prod, ProdBase>();

            //CreateMap<TypeProdBase, DTOsWebPageMain.TypeProd>().ReverseMap();
            //CreateMap<DTOsWebPageMain.TypeProd, TypeProdBase>();

            //CreateMap<ClassProdBase, DTOsWebPageMain.ClassProd>().ReverseMap();
            //CreateMap<DTOsWebPageMain.ClassProd, ClassProdBase>();

            //Mapper.CreateMap<Autor, AutorDTO>()
            //.ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.Nombre));
            //CreateMap<ProdBase, Prod>().ReverseMap();//mapea desde Autor hacia AutorDTO y viceversa
            //CreateMap<Prod, ProdBase>();//mapea desde AutorCreacionDTO hacia Autor

            //CreateMap<TypeProdBase, TypeProd>().ReverseMap();//mapea desde Autor hacia AutorDTO y viceversa
            //CreateMap<TypeProd, TypeProdBase>();//mapea desde AutorCreacionDTO hacia Autor

            //CreateMap<ClassProdBase, ClassProd>().ReverseMap();//mapea desde Autor hacia AutorDTO y viceversa
            //CreateMap<ClassProd, ClassProdBase>();//mapea desde AutorCreacionDTO hacia Autor
        }
    }
}
