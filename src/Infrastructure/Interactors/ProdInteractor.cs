using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entities Improcons
using ProdImpro = Domain.Entities.Improcons.Prod;
//Entities Hipotina
using ProdHipo = Domain.Entities.Hipotina.Prod;
//Entities Auxiliar
using ProdAux = Domain.Entities.Auxiliar.Prod;
//para inyeccion
using Application.Gateways;
using Application.Boundaries;
//factorizacion
using Domain.Entities.Common;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Application.DTOsOwn;
using Application.Models.Responses.ListaRapidaWebPageMain;

namespace Infrastructure.Interactors
{
    public class ProdInteractor : IProdBoundary
    {
        protected readonly IProdGateway iProdDsGateway;

        public ProdInteractor(IProdGateway _prodDsGateway)
        {
            iProdDsGateway = _prodDsGateway;
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/
        public async Task<List<ProdAux>> GetAllAuxAsync()
        {
            try
            {
                /*TODO: aqui esta toda la logica para encontrar los productos*/
                //IQueryable<ProdAux> listProd = await iProdDsGateway.FindAllAuxAsync();
                List<ProdAux> listProd = await iProdDsGateway.FindAllAuxAsync();
                return listProd.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdHipo>> GetAllHipoAsync()
        {
            try
            {
                /*TODO: aqui esta toda la logica para encontrar los productos*/
                //IQueryable<ProdHipo> listProd = await iProdDsGateway.FindAllHipoAsync();
                List<ProdHipo> listProd = await iProdDsGateway.FindAllHipoAsync();
                return listProd.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdImpro>> GetAllImproAsync()
        {
            try
            {
                /*TODO: aqui esta toda la logica para encontrar los productos*/
                //IQueryable<ProdImpro> listProd = await iProdDsGateway.FindAllImproAsync();
                List<ProdImpro> listProd = await iProdDsGateway.FindAllImproAsync();
                return listProd.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdBase>> GetAllWitoutRefactEnterpriseAsync()
        {
            //IQueryable<ProdImpro> listImpro = await iProdDsGateway.FindAllImproAsync();
            //IQueryable<ProdHipo> listHipo = await iProdDsGateway.FindAllHipoAsync();
            //IQueryable<ProdAux> listAux = await iProdDsGateway.FindAllAuxAsync();
            List<ProdImpro> listImpro = await iProdDsGateway.FindAllImproAsync();
            List<ProdHipo> listHipo = await iProdDsGateway.FindAllHipoAsync();
            List<ProdAux> listAux = await iProdDsGateway.FindAllAuxAsync();
            List<ProdBase> list = new List<ProdBase>();

            list.AddRange(listImpro.Select(x => new ProdBase
            {
                ProdId = x.ProdId,
                DescripcionCompleta = x.DescripcionCompleta,
                DescripcionCorta = x.DescripcionCorta,
                Estado = x.Estado,
                Codigo = x.Codigo,
                NombreFabrica = x.NombreFabrica,
                CodigoFabrica = x.CodigoFabrica,
                CodigoBarra = x.CodigoBarra,
                Unidad = x.Unidad,
                Peso = x.Peso,
                UnidadPeso = x.UnidadPeso,
                PrecioBase = x.PrecioBase,
                Oculto = x.Oculto,
                Liquidacion = x.Liquidacion,
                MarkBase = x.Mark,
                CategoryBase = x.Category,
                IndustryBase = x.Industry,
                TypeProdBase = new TypeProdBase
                {
                    TypeProdId = x.TypeProd.TypeProdId,
                    ClassProdId = x.TypeProd.ClassProdId,
                    Descripcion = x.TypeProd.Descripcion,
                    DescripcionCorta = x.TypeProd.DescripcionCorta,
                    Codificacion = x.TypeProd.Codificacion,
                    Estado = x.TypeProd.Estado,
                    Valor = x.TypeProd.Valor,
                    Util = x.TypeProd.Util,
                    ClassProdBase = x.TypeProd.ClassProd
                    //new ClassProdBase
                    //{
                    //    ClassProdId = x.TypeProd.ClassProd.ClassProdId,
                    //    Descripcion = x.TypeProd.ClassProd.Descripcion,
                    //    DescripcionCorta = x.TypeProd.ClassProd.DescripcionCorta,
                    //    Codificacion = x.TypeProd.ClassProd.Codificacion,
                    //    Estado = x.TypeProd.ClassProd.Estado,
                    //    Valor = x.TypeProd.ClassProd.Valor,
                    //    Util = x.TypeProd.ClassProd.Util,
                    //}
                },
                ArchivosProductoBases = x.ArchivosProductos.ToList().Select(c => new ArchivosProductoBase
                {
                    ArchivosProductoId = c.ArchivosProductoId,
                    Nombre = c.Nombre,
                    Descipcion = c.Descipcion,
                    Foto = c.Foto,
                    TipoArchivoProductoId = c.TipoArchivoProductoId,
                    ProdId = c.ProdId,
                    FotoTecnica = c.FotoTecnica,
                    FotoVolumen = c.FotoVolumen,
                    FecModifTec = c.FecModifTec,
                    FecModifImg = c.FecModifImg,
                    FecModifImgVol = c.FecModifImgVol,
                }).ToList(),
                DefaultValueBases = x.DefaultValues.ToList().Select(y => new DefaultValueBase
                {
                    DefaultValueId = y.DefaultValueId,
                    ProdId = y.ProdId,
                    DefaultAttribId = y.DefaultAttribId,
                    Valor = y.Valor,
                    Estado = y.Estado,
                    Util = y.Util,
                    DefaultAttribBase = new DefaultAttribBase
                    {
                        DefaultAttribId = y.DefaultAttrib.DefaultAttribId,
                        DefaultDomainId = y.DefaultAttrib.DefaultDomainId,
                        Descripcion = y.DefaultAttrib.Descripcion,
                        Tipo = y.DefaultAttrib.Tipo,
                        Nivel = y.DefaultAttrib.Nivel,
                        Orden = y.DefaultAttrib.Orden,
                        Util = y.DefaultAttrib.Util,
                        Estado = y.DefaultAttrib.Estado,
                        DefaultDomain = y.DefaultAttrib.DefaultDomain,
                        DefaultDomainNavigationBase = y.DefaultAttrib.DefaultDomainNavigation
                    }
                }).ToList(),
            }).ToList());

            list.AddRange(listHipo.Select(x => new ProdBase
            {
                ProdId = x.ProdId,
                DescripcionCompleta = x.DescripcionCompleta,
                DescripcionCorta = x.DescripcionCorta,
                Estado = x.Estado,
                Codigo = x.Codigo,
                NombreFabrica = x.NombreFabrica,
                CodigoFabrica = x.CodigoFabrica,
                CodigoBarra = x.CodigoBarra,
                Unidad = x.Unidad,
                Peso = x.Peso,
                UnidadPeso = x.UnidadPeso,
                PrecioBase = x.PrecioBase,
                Oculto = x.Oculto,
                Liquidacion = x.Liquidacion,
                MarkBase = x.Mark,
                CategoryBase = x.Category,
                IndustryBase = x.Industry,
                TypeProdBase = new TypeProdBase
                {
                    TypeProdId = x.TypeProd.TypeProdId,
                    ClassProdId = x.TypeProd.ClassProdId,
                    Descripcion = x.TypeProd.Descripcion,
                    DescripcionCorta = x.TypeProd.DescripcionCorta,
                    Codificacion = x.TypeProd.Codificacion,
                    Estado = x.TypeProd.Estado,
                    Valor = x.TypeProd.Valor,
                    Util = x.TypeProd.Util,
                    ClassProdBase = x.TypeProd.ClassProd
                    //new ClassProdBase
                    //{
                    //    ClassProdId = x.TypeProd.ClassProd.ClassProdId,
                    //    Descripcion = x.TypeProd.ClassProd.Descripcion,
                    //    DescripcionCorta = x.TypeProd.ClassProd.DescripcionCorta,
                    //    Codificacion = x.TypeProd.ClassProd.Codificacion,
                    //    Estado = x.TypeProd.ClassProd.Estado,
                    //    Valor = x.TypeProd.ClassProd.Valor,
                    //    Util = x.TypeProd.ClassProd.Util,
                    //}
                },
                ArchivosProductoBases = x.ArchivosProductos.ToList().Select(c => new ArchivosProductoBase
                {
                    ArchivosProductoId = c.ArchivosProductoId,
                    Nombre = c.Nombre,
                    Descipcion = c.Descipcion,
                    Foto = c.Foto,
                    TipoArchivoProductoId = c.TipoArchivoProductoId,
                    ProdId = c.ProdId,
                    FotoTecnica = c.FotoTecnica,
                    FotoVolumen = c.FotoVolumen,
                    FecModifTec = c.FecModifTec,
                    FecModifImg = c.FecModifImg,
                    FecModifImgVol = c.FecModifImgVol,
                }).ToList(),
                DefaultValueBases = x.DefaultValues.ToList().Select(y => new DefaultValueBase
                {
                    DefaultValueId = y.DefaultValueId,
                    ProdId = y.ProdId,
                    DefaultAttribId = y.DefaultAttribId,
                    Valor = y.Valor,
                    Estado = y.Estado,
                    Util = y.Util,
                    DefaultAttribBase = new DefaultAttribBase
                    {
                        DefaultAttribId = y.DefaultAttrib.DefaultAttribId,
                        DefaultDomainId = y.DefaultAttrib.DefaultDomainId,
                        Descripcion = y.DefaultAttrib.Descripcion,
                        Tipo = y.DefaultAttrib.Tipo,
                        Nivel = y.DefaultAttrib.Nivel,
                        Orden = y.DefaultAttrib.Orden,
                        Util = y.DefaultAttrib.Util,
                        Estado = y.DefaultAttrib.Estado,
                        DefaultDomain = y.DefaultAttrib.DefaultDomain,
                        DefaultDomainNavigationBase = y.DefaultAttrib.DefaultDomainNavigation
                    }
                }).ToList(),
            }).ToList());


            list.AddRange(listAux.Select(x => new ProdBase
            {
                ProdId = x.ProdId,
                DescripcionCompleta = x.DescripcionCompleta,
                DescripcionCorta = x.DescripcionCorta,
                Estado = x.Estado,
                Codigo = x.Codigo,
                NombreFabrica = x.NombreFabrica,
                CodigoFabrica = x.CodigoFabrica,
                CodigoBarra = x.CodigoBarra,
                Unidad = x.Unidad,
                Peso = x.Peso,
                UnidadPeso = x.UnidadPeso,
                PrecioBase = x.PrecioBase,
                Oculto = x.Oculto,
                Liquidacion = x.Liquidacion,
                MarkBase = x.Mark,
                CategoryBase = x.Category,
                IndustryBase = x.Industry,
                TypeProdBase = new TypeProdBase
                {
                    TypeProdId = x.TypeProd.TypeProdId,
                    ClassProdId = x.TypeProd.ClassProdId,
                    Descripcion = x.TypeProd.Descripcion,
                    DescripcionCorta = x.TypeProd.DescripcionCorta,
                    Codificacion = x.TypeProd.Codificacion,
                    Estado = x.TypeProd.Estado,
                    Valor = x.TypeProd.Valor,
                    Util = x.TypeProd.Util,
                    ClassProdBase = x.TypeProd.ClassProd
                    //new ClassProdBase
                    //{
                    //    ClassProdId = x.TypeProd.ClassProd.ClassProdId,
                    //    Descripcion = x.TypeProd.ClassProd.Descripcion,
                    //    DescripcionCorta = x.TypeProd.ClassProd.DescripcionCorta,
                    //    Codificacion = x.TypeProd.ClassProd.Codificacion,
                    //    Estado = x.TypeProd.ClassProd.Estado,
                    //    Valor = x.TypeProd.ClassProd.Valor,
                    //    Util = x.TypeProd.ClassProd.Util,
                    //}
                },
                ArchivosProductoBases = x.ArchivosProductos.ToList().Select(c => new ArchivosProductoBase
                {
                    ArchivosProductoId = c.ArchivosProductoId,
                    Nombre = c.Nombre,
                    Descipcion = c.Descipcion,
                    Foto = c.Foto,
                    TipoArchivoProductoId = c.TipoArchivoProductoId,
                    ProdId = c.ProdId,
                    FotoTecnica = c.FotoTecnica,
                    FotoVolumen = c.FotoVolumen,
                    FecModifTec = c.FecModifTec,
                    FecModifImg = c.FecModifImg,
                    FecModifImgVol = c.FecModifImgVol,
                }).ToList(),
                DefaultValueBases = x.DefaultValues.ToList().Select(y => new DefaultValueBase
                {
                    DefaultValueId = y.DefaultValueId,
                    ProdId = y.ProdId,
                    DefaultAttribId = y.DefaultAttribId,
                    Valor = y.Valor,
                    Estado = y.Estado,
                    Util = y.Util,
                    DefaultAttribBase = new DefaultAttribBase
                    {
                        DefaultAttribId = y.DefaultAttrib.DefaultAttribId,
                        DefaultDomainId = y.DefaultAttrib.DefaultDomainId,
                        Descripcion = y.DefaultAttrib.Descripcion,
                        Tipo = y.DefaultAttrib.Tipo,
                        Nivel = y.DefaultAttrib.Nivel,
                        Orden = y.DefaultAttrib.Orden,
                        Util = y.DefaultAttrib.Util,
                        Estado = y.DefaultAttrib.Estado,
                        DefaultDomain = y.DefaultAttrib.DefaultDomain,
                        DefaultDomainNavigationBase = y.DefaultAttrib.DefaultDomainNavigation
                    }
                }).ToList(),
            }).ToList());

            return list;
        }

        public async Task<List<ProdBase>> GetTheBestSalesEnterpriseAsync()
        {

            List<ProdImpro> listImpro = await iProdDsGateway.FindTheBestSalesImproAsync();
            List<ProdHipo> listHipo = await iProdDsGateway.FindTheBestSalesHipoAsync();
            List<ProdAux> listAux = await iProdDsGateway.FindTheBestSalesAuxAsync();
            List<ProdBase> list = new List<ProdBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);
            IEnumerable<ProdBase>? nuevaList = (from prod in list.ToList()
                                                group prod.CantidadPallet by new { prod.ProdId, prod.DescripcionCorta } into grupo
                                                select new ProdBase
                                                {
                                                    ProdId = grupo.Key.ProdId,
                                                    DescripcionCorta = grupo.Key.DescripcionCorta,
                                                    CantidadPallet = grupo.ToList().Max()
                                                });
            return nuevaList.ToList();
        }

        public async Task<List<ProdBase>> GetAllRefactorEnterprisesAsync(string descripcionClase)
        {
            //IQueryable<ProdImpro> listClassProdImpro = await iProdDsGateway.FindAllImproAsync();
            //IQueryable<ProdHipo> listClassProdHipo = await iProdDsGateway.FindAllHipoAsync();
            //IQueryable<ProdAux> listClassProdAux = await iProdDsGateway.FindAllAuxAsync();
            List<ProdImpro> listClassProdImpro = await iProdDsGateway.FindAllImproAsync();
            List<ProdHipo> listClassProdHipo = await iProdDsGateway.FindAllHipoAsync();
            List<ProdAux> listClassProdAux = await iProdDsGateway.FindAllAuxAsync();

            var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.DescripcionCompleta == x.DescripcionCompleta))).ToList();

            //combina dos listas
            var NewListImproDTO_ImproWith_NewListHipoNotInImpr = listClassProdImpro
                .Cast<ProdBase>()
                .Concat(newListHipoNotInImpr.Cast<ProdBase>())
                .ToList();
            //var NewListImproDTO_ImproWith_NewListHipoNotInImpr = GetCombinedDTOListImproNewHipo(listClassProdImpro, newListHipoNotInImpr);

            var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.DescripcionCompleta == x.DescripcionCompleta))).ToList();

            //combine dos listas
            var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr
                .Cast<ProdBase>()
                .Concat(newListAuxNotIn_NewList1.Cast<ProdBase>())
                .ToList();
            //var list = GetCombinedDTOListNewImproDTOWithNewAux(NewListImproDTO_ImproWith_NewListHipoNotInImpr, newListAuxNotIn_NewList1);

            //var verificarLista = list.Select(x => x.DescripcionCompleta).ToList();
            //foreach (var item in verificarLista)
            //{
            //    Console.WriteLine(item);
            //}
            return list;
        }

        public async Task<List<ProdBase>> GetAllByTypeProd_DescripcionRefactorEnterprisesAsync(string descripcionTipo)
        {
            List<ProdImpro> listClassProdImpro = await iProdDsGateway.FindAllByTypeProd_DescripcionImproWebPageAsync(descripcionTipo);
            List<ProdHipo> listClassProdHipo = await iProdDsGateway.FindAllByTypeProd_DescripcionHipoWebPageAsync(descripcionTipo);
            List<ProdAux> listClassProdAux = await iProdDsGateway.FindAllByTypeProd_DescripcionAuxWebPageAsync(descripcionTipo);
            //List<ProdImpro> listClassProdImpro = await iProdDsGateway.FindAllByTypeProd_DescripcionImproAsync(descripcionClase);
            //List<ProdHipo> listClassProdHipo = await iProdDsGateway.FindAllByTypeProd_DescripcionHipoAsync(descripcionClase);
            //List<ProdAux> listClassProdAux = await iProdDsGateway.FindAllByTypeProd_DescripcionAuxAsync(descripcionClase);
            var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.DescripcionCompleta == x.DescripcionCompleta))).ToList();
            //combina dos listas
            var NewListImproDTO_ImproWith_NewListHipoNotInImpr = new List<ProdBase>();
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(listClassProdImpro);
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListHipoNotInImpr);
            var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.DescripcionCompleta == x.DescripcionCompleta))).ToList();
            //combina
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListAuxNotIn_NewList1);
            var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr;
            return list;
        }

        public async Task<List<string>> GetAllDescripionDistinctByTypeProd_DescripcionRefactorEnterprisesAsync(string descripcionTipo)
        {
            try
            {
                IQueryable<string> listImpro = await iProdDsGateway.FindAllDescripcionDistinctByTypeProd_DescripcionImproAsync(descripcionTipo);
                IQueryable<string> listHipo = await iProdDsGateway.FindAllDescripcionDistinctByTypeProd_DescripcionHipoAsync(descripcionTipo);
                IQueryable<string> listAux = await iProdDsGateway.FindAllDescripcionDistinctByTypeProd_DescripcionAuxAsync(descripcionTipo);
                List<string> list = new List<string>();
                list.AddRange(listImpro);
                list.AddRange(listHipo);
                list.AddRange(listAux);
                list = list.Distinct().ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //PROPIEDADES DEL PRODUCTO
        public async Task<List<string>> GetAllShortDescriptionsDistinctByDescripcionCompletaEnterpriseAsync(string descripcionCorta)
        {
            try
            {
                IQueryable<string> listImpro = await iProdDsGateway.FindAllDescriptionCompletByDescripcionCortaImproAsync(descripcionCorta);
                IQueryable<string> listHipo = await iProdDsGateway.FindAllDescriptionCompletByDescripcionCortaImproAsync(descripcionCorta);
                IQueryable<string> listAux = await iProdDsGateway.FindAllDescriptionCompletByDescripcionCortaImproAsync(descripcionCorta);
                List<string> list = new List<string>();
                list.AddRange(listImpro);
                list.AddRange(listHipo);
                list.AddRange(listAux);
                list = list.Distinct().ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/

        //TODO: inicio %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public async Task<IEnumerable<string?>> RenderModel(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(catetogoria => catetogoria.Category?.Descripcion)
                                .Distinct().ToList();
        }

        public async Task<IEnumerable<CategoryViewModel>> RenderModels(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(catetogoria => catetogoria.Category?.Descripcion)
                                .Distinct().ToList()
                                .Select(DescripcionIndice => new CategoryViewModel { Descripcion = DescripcionIndice }).ToList();
        }

        public async Task<IEnumerable<string?>> RenderMarca(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(c => new MarkViewModel { DescripcionCorta = c.MarkBase?.DescripcionCorta, Descripcion = c.MarkBase?.Descripcion }).ToList()
                                .Select(u => u.Descripcion).Distinct().ToList();
        }

        public async Task<IEnumerable<MarkViewModel>>? RenderMarcas(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(c => new MarkViewModel { DescripcionCorta = c.MarkBase?.DescripcionCorta, Descripcion = c.MarkBase?.Descripcion })
                                .ToList()
                                .Select(u => u.Descripcion).Distinct()
                                .Select(p => new MarkViewModel { Descripcion = p }).ToList();
        }

        public async Task<IEnumerable<ArchivosImagenViewModel>>? RenderArchivosImagenes(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return (from img in carateristicas
                                .SelectMany(xCaract => xCaract?.ArchivosProductoBases ?? new List<ArchivosProductoBase>()).Select(archivo => new ArchivosImagenViewModel
                                {
                                    Nombre = archivo.Nombre ?? "No exists",
                                    Descipcion = archivo.Descipcion ?? "No exists",
                                    Foto = archivo.Foto ?? "No exists",
                                    FotoTecnica = archivo.FotoTecnica ?? "No exists",
                                    FotoVolumen = archivo.FotoVolumen ?? "No exists"
                                }).ToList()
                                .Where(ahora => ahora.Foto != null || ahora.FotoTecnica != null || ahora.FotoVolumen != null)
                    group new { Descripcion = img.Descipcion, Nombre = img.Nombre } by new { img.Foto, img.FotoTecnica, img.FotoVolumen } into agrupacion
                    select new ArchivosImagenViewModel
                    {
                        Nombre = agrupacion?.ToList()?.FirstOrDefault()?.Nombre ?? "No exists",
                        Descipcion = agrupacion?.ToList()?.FirstOrDefault()?.Descripcion ?? "No exists",
                        Foto = agrupacion.Key.Foto,
                        FotoTecnica = agrupacion.Key.FotoTecnica,
                        FotoVolumen = agrupacion.Key.FotoVolumen
                    }).ToList();
        }

        public async Task<IEnumerable<AtributoViewModel?>> RenderAtributos(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .SelectMany(xCaract => xCaract.DefaultValueBases
                                .Select(s => new AtributoViewModel { DefAttrib = s.DefaultAttribBase.Descripcion, DefDomain = s.DefaultAttribBase.DefaultDomainNavigationBase.Descripcion })
                                .ToList()).ToList()
                                .GroupBy(a => a.DefDomain)
                                .Select(grop => grop.First())
                                .ToList();
        }

        public async Task<IEnumerable<PriceViewModel?>> RenderProdsEspecYPrecios(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(xCaract => new PriceViewModel
                                {
                                    ProdId = xCaract.ProdId,
                                    Precio = xCaract.PrecioB,
                                    Atributos = xCaract.DefaultValueBases.ToList().Select(w => new AtributoViewModel
                                    {
                                        DefValueId = w.DefaultValueId,
                                        DefAttrib = w.DefaultAttribBase.Descripcion,
                                        DefDomain = w.DefaultAttribBase.DefaultDomainNavigationBase.Descripcion
                                    }).ToList()
                                }).ToList();
        }

        public async Task<IEnumerable<IndustryViewModel>> RenderIndustrias(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .Select(xCaract => new IndustryViewModel { Descripcion = xCaract.IndustryBase?.Descripcion }).ToList()
                                .Select(xCaract => xCaract.Descripcion).ToList()
                                .Distinct()
                                .Select(desc => new IndustryViewModel { Descripcion = desc }).ToList();
        }

        public async Task<IEnumerable<ColoresProdViewModel?>> RenderColores(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, IEnumerable<ColoreBase> coloresBases, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy)
        {
            return carateristicas
                                .SelectMany(xCaract => xCaract.DefaultValueBases ?? new List<DefaultValueBase>())
                                .Where(val => val.DefaultAttribBase.DefaultDomainNavigationBase.Descripcion == "COLOR")
                                .Select(values => values.DefaultAttribBase.Descripcion).Distinct()
                                .Select(indiceDescripcion => new ColoresProdViewModel
                                {
                                    ColorDescripcion = indiceDescripcion ?? "No exists",
                                    ColorHexadecimal = coloresBases.Where(colo => colo.Descripcion == indiceDescripcion).Select(x => x.Valor).ToList().FirstOrDefault() ?? "No exists",
                                    ColorImagen = coloresBases.Where(colo => colo.Descripcion == indiceDescripcion).Select(x => x.Imagen).ToList().FirstOrDefault() ?? "No exists"
                                })
                                .ToList();
        }

        //public async Task<bool> OfertaActiva(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionCrotaProdBy, string descripcionClassBy, string descripcionTypeBy)
        //{

        //    return carateristicas
        //                        .Select(x =>
        //                        {
        //                            var oferClase = LasClasesEnOferta.Where(proof => proof.nombre == descripcionClassBy).ToList().Count() > 0;
        //                            var oferTipos = LosTiposEnOferta.Where(proof => proof.nombre == descripcionTypeBy).ToList().Count() > 0;
        //                            var oferProdu = LosProductosEnOferta.Where(proof => proof.nombre == descripcionCrotaProdBy).ToList().Count() > 0;
        //                            var oferMarca = LasMarcasEnOferta
        //                                   .Select(clasOfer => clasOfer.nombre)
        //                                   .Intersect(
        //                                         RenderMarca(carateristicas, descripcionCrotaProdBy, descripcionClassBy, descripcionTypeBy).Result
        //                                        .Select(p => new MarkViewModel { Descripcion = p }).ToList()
        //                                        .Select(k => k.Descripcion).ToList()
        //                                    ).Count() > 0;
        //                            var oferCateg = LasCategoEnOferta
        //                                   .Select(clasOfer => clasOfer.nombre)
        //                                   .Intersect(
        //                                           RenderModels(carateristicas, descripcionCrotaProdBy, descripcionClassBy, descripcionTypeBy).Result
        //                                         .Select(descripDistint => descripDistint.Descripcion).ToList()
        //                                   ).Count() > 0;
        //                            return oferClase || oferTipos || oferMarca || oferCateg || oferProdu;
        //                        }).FirstOrDefault();
        //}
        //TODO: fin %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}
