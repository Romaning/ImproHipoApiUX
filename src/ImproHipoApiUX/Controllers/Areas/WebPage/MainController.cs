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
using Microsoft.AspNetCore.Cors;
using ImproHipoApiUX.MemoryCaching.Service;

namespace ImproHipoApiUX.Controllers.Areas.WebPage
{
    [EnableCors("_myAllowSpecificOrigins")]
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
        protected readonly ICacheService iCacheService;
        public MainController(IProdBoundary _iProdBoundary,
            IClassProdBoundary _iClassProdBoundary,
            ITypeProdBoundary _iTypeProdBoundary,
            IMapper _iMapper,
            IColorIBoundary _iColorIBoundary,
            IDescuentoComercialBoundary _iDescuentoComercial,
            ICacheService _iCacheService
            )
        {
            iProdBoundary = _iProdBoundary;
            iClassProdBoundary = _iClassProdBoundary;
            iTypeProdBoundary = _iTypeProdBoundary;
            iColorIBoundary = _iColorIBoundary;
            iMapper = _iMapper;
            iDescuentoComercial = _iDescuentoComercial;
            iCacheService = _iCacheService;
        }

        [HttpGet("obtener")]
        public async Task<IEnumerable<ClassProdViewModel>> ObtenerListaClases()
        {
            //logica para encontrar los refactorizado de clases con sus tipos y productos
            try
            {
                var expireTime = DateTimeOffset.Now.AddSeconds(10000);

                IEnumerable<ClassProdViewModel> classProdViewModels = new List<ClassProdViewModel>();
                var cacheDataClassProdViewModels = iCacheService.GetData<IEnumerable<ClassProdViewModel>>("cacheDataClassProdViewModels");
                if (cacheDataClassProdViewModels != null && cacheDataClassProdViewModels.Count() > 0)
                {
                    Console.WriteLine("usando cache cacheDataClassProdViewModels");
                    classProdViewModels = cacheDataClassProdViewModels.ToList();
                    return classProdViewModels;
                }
                else
                {
                    //IEnumerable<ColoreBase> coloresBases = await iColorIBoundary.GetAllWitoutRefactEnterpriseAsync();
                    IEnumerable<ColoreBase> coloresBases = null;
                    var cacheDataColor = iCacheService.GetData<IEnumerable<ColoreBase>>("coloresBases");
                    if (cacheDataColor != null && cacheDataColor.Count() > 0)
                    {
                        Console.WriteLine("usando cache cacheDataColor");
                        coloresBases = cacheDataColor.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta coloresBases");
                        coloresBases = await iColorIBoundary.GetAllWitoutRefactEnterpriseAsync();
                        iCacheService.SetData<IEnumerable<ColoreBase>>("coloresBases", coloresBases, expireTime);
                    }

                    //IEnumerable<ProdBase> masVendidos = await iProdBoundary.GetTheBestSalesEnterpriseAsync();
                    IEnumerable<ProdBase> masVendidos = null;
                    var cacheDataMasVendidos = iCacheService.GetData<IEnumerable<ProdBase>>("masVendidos");
                    if (cacheDataMasVendidos != null && cacheDataMasVendidos.Count() > 0)
                    {
                        Console.WriteLine("usando cache");
                        masVendidos = cacheDataMasVendidos.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta masVendidos");
                        masVendidos = await iProdBoundary.GetTheBestSalesEnterpriseAsync();
                        iCacheService.SetData<IEnumerable<ProdBase>>("masVendidos", masVendidos, expireTime);
                    }

                    //LISTA GENERAL
                    IEnumerable<ProdBase> listGeneralProductsAllEnterprise = null;
                    var cacheData = iCacheService.GetData<IEnumerable<ProdBase>>("ProdBase");
                    if (cacheData != null && cacheData.Count() > 0)
                    {
                        Console.WriteLine("usando cache cacheData");
                        listGeneralProductsAllEnterprise = cacheData.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta listGeneralProductsAllEnterprise");
                        listGeneralProductsAllEnterprise = await iProdBoundary.GetAllWitoutRefactEnterpriseAsync();
                        iCacheService.SetData<IEnumerable<ProdBase>>("ProdBase", listGeneralProductsAllEnterprise, expireTime);
                    }

                    //bool todosEnOfertaBlackFriday = iDescuentoComercial.GetBoolComercialDiscountToAllProductsAsync().Result;
                    bool todosEnOfertaBlackFriday = false;
                    var cacheDatatodosEnOfertaBlackFriday = iCacheService.GetData<bool>("cacheDatatodosEnOfertaBlackFriday");
                    if (cacheDatatodosEnOfertaBlackFriday != null)
                    {
                        Console.WriteLine("usando cache cacheDatatodosEnOfertaBlackFriday");
                        todosEnOfertaBlackFriday = cacheDatatodosEnOfertaBlackFriday;
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta todosEnOfertaBlackFriday");
                        todosEnOfertaBlackFriday = iDescuentoComercial.GetBoolComercialDiscountToAllProductsAsync().Result;
                        iCacheService.SetData<bool>("cacheDatatodosEnOfertaBlackFriday", todosEnOfertaBlackFriday, expireTime);
                    }

                    //var LasClasesEnOferta = iDescuentoComercial.GetAllClassProdInOfferRefactorEnterpriseAsync().Result.ToList();
                    var LasClasesEnOferta = new List<OfertaModelDTO>();
                    var cacheDataLasClasesEnOferta = iCacheService.GetData<IEnumerable<OfertaModelDTO>>("cacheDataLasClasesEnOferta");
                    if (cacheDataLasClasesEnOferta != null)
                    {
                        Console.WriteLine("usando cache cacheDataLasClasesEnOferta");
                        LasClasesEnOferta = cacheDataLasClasesEnOferta.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta LasClasesEnOferta");
                        LasClasesEnOferta = iDescuentoComercial.GetAllClassProdInOfferRefactorEnterpriseAsync().Result.ToList();
                        iCacheService.SetData<IEnumerable<OfertaModelDTO>>("cacheDataLasClasesEnOferta", LasClasesEnOferta, expireTime);
                    }

                    //var LosTiposEnOferta = iDescuentoComercial.GetAllTypeProdInOfferRefactorEnterpriseAsync().Result.ToList();
                    var LosTiposEnOferta = new List<OfertaModelDTO>();
                    var cacheDataLosTiposEnOferta = iCacheService.GetData<IEnumerable<OfertaModelDTO>>("cacheDataLosTiposEnOferta");
                    if (cacheDataLosTiposEnOferta != null)
                    {
                        Console.WriteLine("usando cache cacheDataLosTiposEnOferta");
                        LosTiposEnOferta = cacheDataLosTiposEnOferta.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta cacheDataLosTiposEnOferta");
                        LosTiposEnOferta = iDescuentoComercial.GetAllTypeProdInOfferRefactorEnterpriseAsync().Result.ToList();
                        iCacheService.SetData<IEnumerable<OfertaModelDTO>>("cacheDataLosTiposEnOferta", LosTiposEnOferta, expireTime);
                    }

                    //var LasMarcasEnOferta = iDescuentoComercial.GetAllMarkProdInOfferRefactorEnterpriseAsync().Result.ToList();
                    var LasMarcasEnOferta = new List<OfertaModelDTO>();
                    var cacheDataLasMarcasEnOferta = iCacheService.GetData<IEnumerable<OfertaModelDTO>>("cacheDataLasMarcasEnOferta");
                    if (cacheDataLasMarcasEnOferta != null)
                    {
                        Console.WriteLine("usando cache cacheDataLasMarcasEnOferta");
                        LasMarcasEnOferta = cacheDataLasMarcasEnOferta.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta cacheDataLasMarcasEnOferta");
                        LasMarcasEnOferta = iDescuentoComercial.GetAllTypeProdInOfferRefactorEnterpriseAsync().Result.ToList();
                        iCacheService.SetData<IEnumerable<OfertaModelDTO>>("cacheDataLasMarcasEnOferta", LasMarcasEnOferta, expireTime);
                    }

                    //var LasCategoEnOferta = iDescuentoComercial.GetAllCategoryProdInOfferRefactorEnterpriseAsync().Result.ToList();
                    var LasCategoEnOferta = new List<OfertaModelDTO>();
                    var cacheDataLasCategoEnOferta = iCacheService.GetData<IEnumerable<OfertaModelDTO>>("cacheDataLasCategoEnOferta");
                    if (cacheDataLasCategoEnOferta != null)
                    {
                        Console.WriteLine("usando cache cacheDataLasCategoEnOferta");
                        LasCategoEnOferta = cacheDataLasCategoEnOferta.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta cacheDataLasCategoEnOferta");
                        LasCategoEnOferta = iDescuentoComercial.GetAllCategoryProdInOfferRefactorEnterpriseAsync().Result.ToList();
                        iCacheService.SetData<IEnumerable<OfertaModelDTO>>("cacheDataLasCategoEnOferta", LasCategoEnOferta, expireTime);
                    }

                    //var LosProductosEnOferta = iDescuentoComercial.GetAllProdInOfferRefactorEnterpriseAsync().Result.ToList();
                    var LosProductosEnOferta = new List<OfertaModelDTO>();
                    var cacheDataLosProductosEnOferta = iCacheService.GetData<IEnumerable<OfertaModelDTO>>("cacheDataLosProductosEnOferta");
                    if (cacheDataLosProductosEnOferta != null)
                    {
                        Console.WriteLine("usando cache cacheDataLosProductosEnOferta");
                        LosProductosEnOferta = cacheDataLosProductosEnOferta.ToList();
                    }
                    else
                    {
                        Console.WriteLine("hara directamente la consulta cacheDataLosProductosEnOferta");
                        LosProductosEnOferta = iDescuentoComercial.GetAllCategoryProdInOfferRefactorEnterpriseAsync().Result.ToList();
                        iCacheService.SetData<IEnumerable<OfertaModelDTO>>("cacheDataLosProductosEnOferta", LosProductosEnOferta, expireTime);
                    }

                    //lista de clases VACIA para llenar
                    List<ClassProdViewModel> listClassProdViewModels = new List<ClassProdViewModel>();
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
                            listaProductos = listGeneralProductsAllEnterprise.Where(prod => prod.TypeProdBase?.Descripcion == descTipo).Select(prod => prod.DescripcionCorta).ToList()
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
                                                         //Modelos = iProdBoundary.RenderModels(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                         //CONCATENADO: DE MARCAS DIFERENTES COMO ARRAY CONVERTIDO EN CADENA DIVIDO POR COMAS//?? "No exists",
                                                         Marca = String.Join(",", iProdBoundary.RenderMarca(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result),
                                                         //LISTA: DE MARCAS DIFERENTES POR SI HUBIERA
                                                         //Marcas = iProdBoundary.RenderMarcas(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                         Atributos = iProdBoundary.RenderAtributos(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                         ProdsEspecYPrecios = iProdBoundary.RenderProdsEspecYPrecios(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                         Imagenes = iProdBoundary.RenderArchivosImagenes(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                         MasVendido = masVendidos.ToList().Where(prod => prod.DescripcionCorta == grupo.Key.DescripcionCorta).Count() > 0 ? true : false,
                                                         //CONCATENDO:
                                                         Industria = String.Join(",", iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList().Select(p => p.Descripcion).Distinct().ToList()),
                                                         //LISTA:
                                                         //Industrias = iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
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
                            //filtrar, los que no tienen IMAGENES DESCARTAR
                            //FILTRAR TYPO
                            //typeProdViewModel.Prods = listaDetallesProd;//.Where(prod => prod.Imagenes.Where(img => img.Foto != "No exists").ToList().Count() > 0 ).ToList();

                            //PRODUCTOS QUE NO TENGAN IMAGEN, CHAU
                            typeProdViewModel.Prods = listaDetallesProd.Where(prod => prod.Imagenes.Count() > 0).ToList();

                            listTypeProdViewModels.Add(typeProdViewModel);
                        });
                        //unimos esa lista de tipos en la clase

                        //TIPOS QUE NO TENGAN PRODUCTO, CHAU
                        listTypeProdViewModels = listTypeProdViewModels.Where(typ => typ.Prods.Count() > 0).ToList();

                        classProdViewModel.TypeProds = listTypeProdViewModels;
                        listClassProdViewModels.Add(classProdViewModel);
                    });

                    //CLASES QUE NO TENGAN TYPO, CHAU
                    listClassProdViewModels = listClassProdViewModels.Where(clas => clas.TypeProds.Count() > 0).ToList();

                    var clasesOrdenadas = listClassProdViewModels.OrderByDescending(clase => clase.TypeProds.Sum(tipo => tipo.Prods.Count())).ToList();

                    iCacheService.SetData<IEnumerable<ClassProdViewModel>>("cacheDataClassProdViewModels", clasesOrdenadas, expireTime);

                    return clasesOrdenadas.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("")]
        public async Task<IActionResult> Index([FromQuery] int pageClases = 1, [FromQuery] int pageSizeClases = 5, [FromQuery] int pageProds = 1, [FromQuery] int pageSizeProds = 8)
        {
            IEnumerable<ClassProdViewModel> _clases = ObtenerListaClases().Result;

            var totalItems = _clases.Count();

            var clasesPaginadas = _clases
                .OrderByDescending(clase => clase.TypeProds.Sum(tipo => tipo.Prods.Count()))
                .Skip((pageClases - 1) * pageSizeClases)
                .Take(pageSizeClases)
                .ToList().Select(clas => new ClassProdViewModel()
                {
                    Descripcion = clas.Descripcion,
                    TypeProds = clas.TypeProds.Select(type => new TypeProdViewModel()
                    {
                        Descripcion = type.Descripcion,
                        Prods = type.Prods.Skip((pageProds - 1) * pageSizeProds).Take(pageSizeProds).ToList(),

                        TotalItemsProd = type.Prods.Count(),
                        TotalPagesProd = (int)Math.Ceiling(type.Prods.Count() / (double)pageSizeProds),
                        PageProd = pageProds,
                        NextPageProd = pageProds + 1,
                        PageSizeProd = pageSizeProds,
                    }).ToList(),
                });

            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSizeClases);

            var response = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Page = pageClases,
                NextPage = pageClases + 1,
                PageSize = pageSizeClases,
                Clases = clasesPaginadas
            };

            return Ok(response);
        }


        [HttpGet("productos")]
        public async Task<IActionResult> Prods([FromQuery] string clase = "", [FromQuery] string tipo = "", [FromQuery] int pageProds = 2, [FromQuery] int pageSizeProds = 8)
        {
            IEnumerable<ClassProdViewModel> _clases = ObtenerListaClases().Result;

            var totalItems = _clases.Count();

            var clasesPaginadas = _clases
                //.OrderByDescending(clase => clase.TypeProds.Sum(tipo => tipo.Prods.Count()))
                .Where(clas => clas.Descripcion == clase)
                .ToList().Select(clas => new ClassProdViewModel()
                {
                    Descripcion = clas.Descripcion,
                    TypeProds = clas.TypeProds.Where(typ => typ.Descripcion == tipo).Select(type => new TypeProdViewModel()
                    {
                        Descripcion = type.Descripcion,
                        Prods = type.Prods.Skip((pageProds - 1) * pageSizeProds).Take(pageSizeProds).ToList(),

                        TotalItemsProd = type.Prods.Count(),
                        TotalPagesProd = (int)Math.Ceiling(type.Prods.Count() / (double)pageSizeProds),
                        PageProd = pageProds,
                        NextPageProd = pageProds + 1,
                        PageSizeProd = pageSizeProds,
                    }).ToList(),
                });

            //var totalPages = (int)Math.Ceiling(totalItems / (double)pageSizeClases);

            //var response = new
            //{
            //    TotalItems = totalItems,
            //    TotalPages = totalPages,
            //    Page = pageClases,
            //    PageSize = pageSizeClases,
            //    Clases = clasesPaginadas
            //};

            return Ok(clasesPaginadas);
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

        [HttpGet("CargarDatos")]

        public async Task<IEnumerable<ClassProdViewModel>> cargarDAtosEnLaBD()
        {
            //logica para encontrar los refactorizado de clases con sus tipos y productos
            try
            {
                //var expireTime = DateTimeOffset.Now.AddSeconds(10000);

                IEnumerable<ClassProdViewModel> classProdViewModels = new List<ClassProdViewModel>();
                IEnumerable<ColoreBase> coloresBases = await iColorIBoundary.GetAllWitoutRefactEnterpriseAsync();
                IEnumerable<ProdBase> masVendidos = await iProdBoundary.GetTheBestSalesEnterpriseAsync();

                //LISTA GENERAL
                IEnumerable<ProdBase> listGeneralProductsAllEnterprise = await iProdBoundary.GetAllWitoutRefactEnterpriseAsync();
                bool todosEnOfertaBlackFriday = iDescuentoComercial.GetBoolComercialDiscountToAllProductsAsync().Result;
                var LasClasesEnOferta = iDescuentoComercial.GetAllClassProdInOfferRefactorEnterpriseAsync().Result.ToList();
                var LosTiposEnOferta = iDescuentoComercial.GetAllTypeProdInOfferRefactorEnterpriseAsync().Result.ToList();
                var LasMarcasEnOferta = iDescuentoComercial.GetAllMarkProdInOfferRefactorEnterpriseAsync().Result.ToList();
                var LasCategoEnOferta = iDescuentoComercial.GetAllCategoryProdInOfferRefactorEnterpriseAsync().Result.ToList();
                var LosProductosEnOferta = iDescuentoComercial.GetAllProdInOfferRefactorEnterpriseAsync().Result.ToList();

                //lista de clases VACIA para llenar
                List<ClassProdViewModel> listClassProdViewModels = new List<ClassProdViewModel>();
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
                        listaProductos = listGeneralProductsAllEnterprise.Where(prod => prod.TypeProdBase?.Descripcion == descTipo).Select(prod => prod.DescripcionCorta).ToList()
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
                                                     //Modelos = iProdBoundary.RenderModels(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     //CONCATENADO: DE MARCAS DIFERENTES COMO ARRAY CONVERTIDO EN CADENA DIVIDO POR COMAS//?? "No exists",
                                                     Marca = String.Join(",", iProdBoundary.RenderMarca(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result),
                                                     //LISTA: DE MARCAS DIFERENTES POR SI HUBIERA
                                                     //Marcas = iProdBoundary.RenderMarcas(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     Atributos = iProdBoundary.RenderAtributos(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     ProdsEspecYPrecios = iProdBoundary.RenderProdsEspecYPrecios(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     Imagenes = iProdBoundary.RenderArchivosImagenes(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
                                                     MasVendido = masVendidos.ToList().Where(prod => prod.DescripcionCorta == grupo.Key.DescripcionCorta).Count() > 0 ? true : false,
                                                     //CONCATENDO:
                                                     Industria = String.Join(",", iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList().Select(p => p.Descripcion).Distinct().ToList()),
                                                     //LISTA:
                                                     //Industrias = iProdBoundary.RenderIndustrias(grupo, grupo.Key.DescripcionCorta, grupo.Key.Clase, grupo.Key.Tipo).Result.ToList(),
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
                        //filtrar, los que no tienen IMAGENES DESCARTAR
                        //FILTRAR TYPO
                        //typeProdViewModel.Prods = listaDetallesProd;//.Where(prod => prod.Imagenes.Where(img => img.Foto != "No exists").ToList().Count() > 0 ).ToList();

                        //PRODUCTOS QUE NO TENGAN IMAGEN, CHAU
                        typeProdViewModel.Prods = listaDetallesProd.Where(prod => prod.Imagenes.Count() > 0).ToList();

                        listTypeProdViewModels.Add(typeProdViewModel);
                    });
                    //unimos esa lista de tipos en la clase

                    //TIPOS QUE NO TENGAN PRODUCTO, CHAU
                    listTypeProdViewModels = listTypeProdViewModels.Where(typ => typ.Prods.Count() > 0).ToList();

                    classProdViewModel.TypeProds = listTypeProdViewModels;
                    listClassProdViewModels.Add(classProdViewModel);
                });

                //CLASES QUE NO TENGAN TYPO, CHAU
                listClassProdViewModels = listClassProdViewModels.Where(clas => clas.TypeProds.Count() > 0).ToList();
                var clasesOrdenadas = listClassProdViewModels.OrderByDescending(clase => clase.TypeProds.Sum(tipo => tipo.Prods.Count())).ToList();
                return clasesOrdenadas.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
