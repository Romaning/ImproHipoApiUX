using Application.Boundaries;
using AutoMapper;
using Domain.Entities.Common;
using ImproHipoApiUX.Filters;
using Microsoft.AspNetCore.Mvc;

using Application.Models.Responses.ListaRapidaWebPageMain;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Application.DTOsOwn;
using AutoMapper.Execution;

namespace ImproHipoApiUX.Controllers.Areas.WebPage
{
    [ApiController]
    [Route("api/v1/principal")]
    [TypeFilter(typeof(ExceptionManagerFilter))]
    public class MainController : Controller
    {
        protected readonly IProdBoundary iProdBoundary;
        protected readonly IClassProdBoundary iClassProdBoundary;
        protected readonly ITypeProdBoundary iTypeProdBoundary;
        protected readonly IColorIBoundary iColorIBoundary;
        protected readonly IDescuentoComercialBoundary iDescuentoComercial;
        protected readonly IMapper iMapper;
        public MainController(IProdBoundary _iProdBoundary, 
            IClassProdBoundary _iClassProdBoundary, 
            ITypeProdBoundary _iTypeProdBoundary, 
            IMapper _iMapper, 
            IColorIBoundary _iColorIBoundary,
            IDescuentoComercialBoundary _iDescuentoComercial
            )
        {
            iProdBoundary = _iProdBoundary;
            iClassProdBoundary = _iClassProdBoundary;
            iTypeProdBoundary = _iTypeProdBoundary;
            iColorIBoundary = _iColorIBoundary;
            iMapper = _iMapper;
            iDescuentoComercial = _iDescuentoComercial;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            //logica para encontrar los refactorizado de clases con sus tipos y productos
            try
            {
                IEnumerable<ColoreBase> coloresBases = await iColorIBoundary.GetAllWitoutRefactEnterpriseAsync();
                IEnumerable<ProdBase> masVendidos = await iProdBoundary.GetTheBestSalesEnterpriseAsync();
                IEnumerable<ProdBase> listGeneralProductsAllEnterprise = await iProdBoundary.GetAllWitoutRefactEnterpriseAsync();

                //TODO: inicio %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                
                bool todosEnOfertaBlackFriday = iDescuentoComercial.GetBoolComercialDiscountToAllProductsAsync().Result;

                var LasClasesEnOferta = iDescuentoComercial.GetAllClassProdInOfferRefactorEnterpriseAsync().Result.ToList();
                //new List<OfertaModelDTO>() { new OfertaModelDTO { id = 1,nombre =  "PANELES" , porcentaje = 4 },
                //                                             new OfertaModelDTO { id = 1,nombre =  "MUEBLES" , porcentaje = 9 },
                //                                             new OfertaModelDTO { id = 1,nombre =  "PISO Y PARED" , porcentaje = 13 },
                //                                             new OfertaModelDTO { id = 1,nombre =  "ILUMINACIO" , porcentaje = 40 }};
                    
                var LosTiposEnOferta = iDescuentoComercial.GetAllTypeProdInOfferRefactorEnterpriseAsync().Result.ToList();
                //new List<OfertaModelDTO>() { new OfertaModelDTO { id = 1,nombre =  "COMPLEMENTOS" , porcentaje = 3 },
                //                                            new OfertaModelDTO { id = 1,nombre =  "DECORADO" , porcentaje = 2 }};

                var LasMarcasEnOferta = iDescuentoComercial.GetAllMarkProdInOfferRefactorEnterpriseAsync().Result.ToList();
                //new List<OfertaModelDTO>() { new OfertaModelDTO { id = 1,nombre =  "ALUBOL" , porcentaje = 7 },
                //                                            new OfertaModelDTO { id = 1,nombre =  "RADO" , porcentaje = 9 }};

                var LasCategoEnOferta = iDescuentoComercial.GetAllCategoryProdInOfferRefactorEnterpriseAsync().Result.ToList();
                //new List<OfertaModelDTO>() { new OfertaModelDTO { id = 1, nombre = "UNIVERSAL", porcentaje = 28 } };
                //diferenciando de bases de datos
                var LosProductosEnOferta = iDescuentoComercial.GetAllProdInOfferRefactorEnterpriseAsync().Result.ToList();
                //new List<OfertaModelDTO>() { new OfertaModelDTO { id = 1,nombre =  "PANELES" , porcentaje = 4 },
                //                                                 new OfertaModelDTO { id = 1,nombre =  "MUEBLES" , porcentaje = 9 },
                //                                                 new OfertaModelDTO { id = 1,nombre =  "PISO Y PARED" , porcentaje = 13 },
                //                                                 new OfertaModelDTO { id = 1,nombre =  "ILUMINACIO" , porcentaje = 40 }};
                //TODO: finalizado %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                //lista de clases VACIA para llenar
                List<ClassProdViewModel> listClassProdViewModels = new List<ClassProdViewModel>();

                //TODO: inicio %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                var listClassProdViewModelss = listGeneralProductsAllEnterprise.Select(prod => prod?.TypeProdBase?.ClassProdBase?.Descripcion).ToList().Distinct().ToList();
                listClassProdViewModelss.ForEach(descClase =>
                {
                    ClassProdViewModel classProdViewModel = new ClassProdViewModel();
                    classProdViewModel.Descripcion = descClase;
                    List<TypeProdViewModel> listTypeProdViewModels = new List<TypeProdViewModel>();
                    var listTypeProdViewModelss = listGeneralProductsAllEnterprise.Where(prod => prod?.TypeProdBase?.ClassProdBase?.Descripcion == descClase).Select(prod => prod?.TypeProdBase?.Descripcion).ToList().Distinct().ToList();
                    listTypeProdViewModelss.ForEach(descTipo =>
                    {
                        TypeProdViewModel typeProdViewModel = new TypeProdViewModel();
                        typeProdViewModel.Descripcion = descTipo;

                        List<ProdViewModel> listaProductos = new List<ProdViewModel>();
                        listaProductos = listGeneralProductsAllEnterprise.Where(prod => prod.TypeProdBase.Descripcion == descTipo).Select(prod => prod.DescripcionCorta).ToList()
                                                                        .Distinct().ToList()
                                                                        .Select(descProd => new ProdViewModel { DescripcionCorta = descProd, Clase = descClase, Tipo = descTipo }).ToList();
                        var listaDetallesProd = (from p in listaProductos
                                                 join pg in listGeneralProductsAllEnterprise on p.DescripcionCorta equals pg.DescripcionCorta
                                                 group new CaracteristicasFilterModelDTO { PrecioB = pg.PrecioBase, DefaultValueBases = pg.DefaultValueBases, ProdId = pg.ProdId, MarkBase = pg.MarkBase, Category = pg.CategoryBase, ArchivosProductoBases = pg.ArchivosProductoBases, IndustryBase = pg.IndustryBase }
                                                 by new { p.DescripcionCorta, p.Clase, p.Tipo } into grupo
                                                 select new ProdViewModel
                                                 {
                                                     DescripcionCorta = grupo.Key.DescripcionCorta,
                                                     Clase = grupo.Key.Clase,
                                                     Tipo = grupo.Key.Tipo,
                                                     //CONCATENADO: LISTA DE CATEGORIAS O MODELOS DIFERENTES COMO ARRAY CONVERTIDO EN CADENA DIVIDO POR COMAS
                                                     Modelo = String.Join(",", iProdBoundary.RenderModel(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result),
                                                     //LISTA: DE CATEGORIAS O MODELOS DIFERENTES COMO LISTA DE MODELOS
                                                     Modelos = iProdBoundary.RenderModels(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     //CONCATENADO: DE MARCAS DIFERENTES COMO ARRAY CONVERTIDO EN CADENA DIVIDO POR COMAS
                                                     Marca = String.Join(",", iProdBoundary.RenderMarca(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result), //?? "No exists",
                                                     //LISTA: DE MARCAS DIFERENTES POR SI HUBIERA
                                                     Marcas = iProdBoundary.RenderMarcas(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     Atributos = iProdBoundary.RenderAtributos(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     ProdsEspecYPrecios = iProdBoundary.RenderProdsEspecYPrecios(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     Imagenes = iProdBoundary.RenderArchivosImagenes(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     MasVendido = masVendidos.ToList().Where(prod => prod.DescripcionCorta == grupo.Key.DescripcionCorta).Count() > 0 ? true : false,
                                                     //CONCATENDO:
                                                     Industria = String.Join(",", iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList().Select(p => p.Descripcion).Distinct().ToList()),
                                                     //LISTA:
                                                     Industrias = iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     Colores = iProdBoundary.RenderColores(grupo, coloresBases, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     EnOferta = grupo.ToList()
                                                     .Select(x =>
                                                     {
                                                         var oferClase = LasClasesEnOferta.Where(proof => proof.nombre == grupo.Key.Clase).ToList().Count() > 0;
                                                         var oferTipos = LosTiposEnOferta.Where(proof => proof.nombre == grupo.Key.Tipo).ToList().Count() > 0;
                                                         var oferProdu = LosProductosEnOferta.Where(proof => proof.nombre == grupo.Key.DescripcionCorta).ToList().Count() > 0;
                                                         var oferMarca = LasMarcasEnOferta
                                                                .Select(clasOfer => clasOfer.nombre)
                                                                .Intersect(
                                                                      iProdBoundary.RenderMarcas(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result
                                                                     .Select(p => new MarkViewModel { Descripcion = p?.Descripcion }).ToList()
                                                                     .Select(k => k.Descripcion).ToList()
                                                                 ).Count() > 0;
                                                         var oferCateg = LasCategoEnOferta
                                                                .Select(clasOfer => clasOfer.nombre)
                                                                .Intersect(
                                                                        iProdBoundary.RenderMarcas(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result
                                                                      .Select(descripDistint => descripDistint?.Descripcion).ToList()
                                                                ).Count() > 0;
                                                         return oferClase || oferTipos || oferMarca || oferCateg || oferProdu || todosEnOfertaBlackFriday;
                                                     }).FirstOrDefault(),
                                                 }).ToList();
                        typeProdViewModel.Prods = listaDetallesProd;
                        listTypeProdViewModels.Add(typeProdViewModel);
                    });
                    //unimos esa lista de tipos en la clase
                    classProdViewModel.TypeProds = listTypeProdViewModels;
                    listClassProdViewModels.Add(classProdViewModel);
                });
                //TODO: finalizado %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                return Ok(listClassProdViewModels.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("listar")]
        public async Task<IActionResult> Listar()
        {
            //logica para encontrar los refactorizado de clases con sus tipos y productos
            try
            {
                List<ClassProdBase> listClassProdBaseRefactor = await iClassProdBoundary.GetAllDiferentsRefactorEnterprisesAsync();
                listClassProdBaseRefactor.ForEach(async (classProd) =>
                {
                    List<TypeProdBase> listTypeProdBaseRefactor = await iTypeProdBoundary.GetAllByClassProd_DescripcionRefactorEnterprisesAsync(classProd.Descripcion);
                    listTypeProdBaseRefactor.ForEach(async (typeProd) =>
                    {
                        List<ProdBase> listProdBaseRefactor = await iProdBoundary.GetAllByTypeProd_DescripcionRefactorEnterprisesAsync(typeProd.Descripcion);
                        typeProd.ProdBases = listProdBaseRefactor;
                    });
                    classProd.TypeProdBases = listTypeProdBaseRefactor;
                });
                return Ok(listClassProdBaseRefactor.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
