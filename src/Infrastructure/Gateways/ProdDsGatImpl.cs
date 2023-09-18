using Application.Gateways;
using Persistence.DbContexts;
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
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Common;
using Infrastructure.Gateways.Injections;
using MarkImpro = Domain.Entities.Improcons.Mark;
using MarkHipo = Domain.Entities.Hipotina.Mark;
using MarkAux = Domain.Entities.Auxiliar.Mark;
using CategoryImpro = Domain.Entities.Improcons.Category;
using CategoryHipo = Domain.Entities.Hipotina.Category;
using CategoryAux = Domain.Entities.Auxiliar.Category;
using DefaultAttribImpro = Domain.Entities.Improcons.DefaultAttrib;
using DefaultAttribHipo = Domain.Entities.Hipotina.DefaultAttrib;
using DefaultAttribAux = Domain.Entities.Auxiliar.DefaultAttrib;
using DefaultDomainImpro = Domain.Entities.Improcons.DefaultDomain;
using DefaultDomainHipo = Domain.Entities.Hipotina.DefaultDomain;
using DefaultDomainAux = Domain.Entities.Auxiliar.DefaultDomain;
using DefaultValueImpro = Domain.Entities.Improcons.DefaultValue;
using DefaultValueHipo = Domain.Entities.Hipotina.DefaultValue;
using DefaultValueAux = Domain.Entities.Auxiliar.DefaultValue;


namespace Infrastructure.Gateways
{
    public class ProdDsGatImpl : DependencyInjectContext, IProdGateway
    {
        public ProdDsGatImpl(ApplicationDbImproContext dbImproContexts, ApplicationDbHipoContext dbHipoContexts, ApplicationDbAuxContext dbAuxContexts)
            : base(dbImproContexts, dbHipoContexts, dbAuxContexts)
        {
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/
        //List 1
        public async Task<List<ProdImpro>> FindAllImproAsync()
        {
            try
            {
                //throw new Exception("sasldiasodisado");
                var listProds = dbImproContext.Prods
                .Include(x => x.Mark)
                .Include(x => x.Industry)
                .Include(x => x.Category)
                .Include(x => x.ArchivosProductos)
                .Include(x => x.TypeProd)
                    .ThenInclude(y => y.ClassProd)
                .Include(x => x.DefaultValues)
                    .ThenInclude(defaultValue => defaultValue.DefaultAttrib)
                        .ThenInclude(defaultAttrib => defaultAttrib.DefaultDomainNavigation);
                //IQueryable<ProdImpro> listProds = dbImproContext.Prods
                //    .Include(x => x.Mark)
                //    .Include(x => x.Category)
                //    .Include(x => x.ArchivosProductos)
                //    .Include(x => x.TypeProd)
                //    .Include(x => x.DefaultValues).ThenInclude(x => x.DefaultAttrib).ThenInclude(z => z.DefaultDomain)
                //.Take(100)
                //.Include(u => u.ArchivosProductos)
                //.Include(y => y.PreGuardadoProductos)
                //.Include(z => z.Mark)/*.ThenInclude(x => x.Prods)*/
                //.Include(z => z.TypeProd)
                //var productosConValuesAttribDomain = dbImproContext.Prods
                //.Select(producto => new
                //{
                //    Producto = producto,
                //    Values = producto.DefaultValues.Select(value => new
                //    {
                //        DefaultValues = value,
                //        DefaultAttrib = value.DefaultAttrib != null ? new
                //        {
                //            value.DefaultAttrib.DefaultAttribId,
                //            value.DefaultAttrib.DefaultDomainId,
                //            Domain = value.DefaultAttrib.DefaultDomainNavigation != null ? new
                //            {
                //                value.DefaultAttrib.DefaultDomain.Key.
                //            } : null
                //        } : null
                //    }).ToList()
                //})
                //.ToList();
                return listProds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //List 2
        public async Task<List<ProdHipo>> FindAllHipoAsync()
        {
            try
            {
                //throw new Exception("sasldiasodisado");
                //IQueryable<ProdHipo> listProds = dbHipoContext.Prods
                //    .Include(x => x.Mark)
                //    .Include(x => x.Category)
                //    .Include(x => x.ArchivosProductos)
                //    .Include(x => x.TypeProd)
                //    .Include(x => x.DefaultValues).ThenInclude(x => x.DefaultAttrib).ThenInclude(z => z.DefaultDomain)
                //.Take(100)
                //.Include(u => u.ArchivosProductos)
                //.Include(y => y.PreGuardadoProductos)
                //.Include(z => z.Mark)/*.ThenInclude(x => x.Prods)*/
                //.Include(z => z.TypeProd)
                ;
                var listProds = dbHipoContext.Prods
                .Include(x => x.Mark)
                .Include(x => x.Industry)
                .Include(x => x.Category)
                .Include(x => x.ArchivosProductos)
                .Include(x => x.TypeProd)
                    .ThenInclude(y => y.ClassProd)
                .Include(x => x.DefaultValues)
                    .ThenInclude(defaultValue => defaultValue.DefaultAttrib)
                        .ThenInclude(defaultAttrib => defaultAttrib.DefaultDomainNavigation)
                ;
                return listProds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //List 3
        public async Task<List<ProdAux>> FindAllAuxAsync()
        {
            try
            {
                //throw new Exception("sasldiasodisado");
                var listProds = dbAuxContext.Prods
                .Include(x => x.Mark)
                .Include(x => x.Industry)
                .Include(x => x.Category)
                .Include(x => x.ArchivosProductos)
                .Include(x => x.TypeProd)
                    .ThenInclude(y => y.ClassProd)
                .Include(x => x.DefaultValues)
                    .ThenInclude(defaultValue => defaultValue.DefaultAttrib)
                        .ThenInclude(defaultAttrib => defaultAttrib.DefaultDomainNavigation)
                    //IQueryable<ProdAux> listProds = dbAuxContext.Prods
                    //    .Include(x => x.Mark)
                    //    .Include(x => x.Category)
                    //    .Include(x => x.ArchivosProductos)
                    //    .Include(x => x.TypeProd)
                    //    .Include(x => x.DefaultValues).ThenInclude(x => x.DefaultAttrib).ThenInclude(z => z.DefaultDomain)
                    //.Take(100)
                    //.Include(u => u.ArchivosProductos)
                    //.Include(y => y.PreGuardadoProductos)
                    //.Include(z => z.Mark)/*.ThenInclude(x => x.Prods)*/
                    //.Include(z => z.TypeProd)
                    ;
                return listProds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //List 1
        public async Task<List<ProdImpro>> FindAllPARAMSImproAsync()
        {
            try
            {
                List<ProdImpro> listProds = new List<ProdImpro>();
                listProds = dbImproContext.Prods
                    //.Include(z => z.Mark)
                    //.Include(z => z.Category)
                    .Select(x => new ProdImpro
                    {
                        DescripcionCompleta = x.DescripcionCompleta,
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
                        Mark = new MarkImpro
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        },
                        Category = new CategoryImpro()
                        {
                            Descripcion = x.Category.Descripcion,
                            Estado = x.Mark.Estado
                        }
                    })
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //List 2
        public async Task<List<ProdHipo>> FindAllPARAMSHipoAsync()
        {
            try
            {
                List<ProdHipo> listProds = new List<ProdHipo>();
                listProds = dbHipoContext.Prods
                    //.Include(z => z.Mark)
                    //.Include(z => z.Category)
                    .Select(x => new ProdHipo
                    {
                        DescripcionCompleta = x.DescripcionCompleta,
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
                        Mark = new MarkHipo
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        },
                        Category = new CategoryHipo()
                        {
                            Descripcion = x.Category.Descripcion,
                            Estado = x.Mark.Estado
                        }
                    })
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //List 3
        public async Task<List<ProdAux>> FindAllPARAMSAuxAsync()
        {
            try
            {
                List<ProdAux> listProds = new List<ProdAux>();
                listProds = dbAuxContext.Prods
                    //.Include(z => z.Mark)
                    //.Include(z => z.Category)
                    .Select(x => new ProdAux
                    {
                        DescripcionCompleta = x.DescripcionCompleta,
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
                        Mark = new MarkAux
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        },
                        Category = new CategoryAux()
                        {
                            Descripcion = x.Category.Descripcion,
                            Estado = x.Mark.Estado
                        }
                    })
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<ProdImpro> FindByIdImproAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdHipo> FindByIdHipoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdAux> FindByIdAuxAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdImpro> FindByIdAndEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ProdHipo> FindByIdAndEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ProdAux> FindByIdAndEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<ProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<ProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdImpro>> FindAllByDescripcionCompletaImproAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdHipo>> FindAllByDescripcionCompletaHipoAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdAux>> FindAllByDescripcionCompletaAuxAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdImpro>> FindAllByEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdHipo>> FindAllByEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdAux>> FindAllByEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdImpro>> FindAllByDescripcionCompletaAndEstadoImproAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdHipo>> FindAllByDescripcionCompletaAndEstadoHipoAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdAux>> FindAllByDescripcionCompletaAndEstadoAuxAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        #region FindAllByTypeProd_Descripcion[Empresa]Async
        public async Task<List<ProdImpro>> FindAllByTypeProd_DescripcionImproAsync(string descripcionTipo)
        {
            try
            {
                List<ProdImpro> listProds = new List<ProdImpro>();
                listProds = dbImproContext.Prods
                    .Include(z => z.Mark)/*.ThenInclude(x => x.Prods)*/
                    .Where(x => x.TypeProd.Descripcion == descripcionTipo)
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdHipo>> FindAllByTypeProd_DescripcionHipoAsync(string descripcionTipo)
        {
            try
            {
                List<ProdHipo> listProds = new List<ProdHipo>();
                listProds = dbHipoContext.Prods
                    .Include(z => z.Mark)
                    .Where(x => x.TypeProd.Descripcion == descripcionTipo)
                    .Select(x => new ProdHipo
                    {
                        DescripcionCompleta = x.DescripcionCompleta,
                        Estado = x.Estado,
                        Mark = new MarkHipo
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        },
                        Category = new CategoryHipo()
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        }
                    })
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdAux>> FindAllByTypeProd_DescripcionAuxAsync(string descripcionTipo)
        {
            try
            {
                List<ProdAux> listProds = new List<ProdAux>();
                listProds = dbAuxContext.Prods
                    .Include(z => z.Mark)
                    .Where(x => x.TypeProd.Descripcion == descripcionTipo)
                    .Select(x => new ProdAux
                    {
                        DescripcionCompleta = x.DescripcionCompleta,
                        Estado = x.Estado,
                        Mark = new MarkAux
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado,
                        },
                        Category = new CategoryAux()
                        {
                            Descripcion = x.Mark.Descripcion,
                            Estado = x.Mark.Estado
                        }
                    })
                    .ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region FindAllByTypeProd_Descripcion[$$$$$$$ EMPRESA $$$$$$] [$$$$$ WebPage $$$$$$]Async
        public async Task<List<ProdImpro>> FindAllByTypeProd_DescripcionImproWebPageAsync(string descripcionTipo)
        {
            try
            {
                //select*
                //from Prod p
                //join TypeProd tp on p.TypeProdId = tp.TypeProdId
                //where tp.Descripcion = 'BASURERO'
                List<ProdImpro> listProds = new List<ProdImpro>();
                listProds = (from p in dbImproContext.Prods
                             join tp in dbImproContext.TypeProds on p.TypeProdId equals tp.TypeProdId
                             where tp.Descripcion == descripcionTipo
                             group p by p.DescripcionCompleta into pGroup
                             select new ProdImpro { DescripcionCompleta = pGroup.Key }).ToList();

                /*select p.DescripcionCompleta, m.Descripcion, c.Descripcion from Prod p 
                left outer join TypeProd tp on p.TypeProdId = tp.TypeProdId
                left outer join Mark m on p.MarkId = m.MarkId
                left outer join Category c on p.CategoryId = c.CategoryId
                where tp.Descripcion = 'ALUMINIO COMPUESTO'
                group by p.DescripcionCompleta, m.Descripcion, c.Descripcion*/

                //List<ProdImpro> listProds = new List<ProdImpro>();
                //listProds = (from p in dbImproContext.Prods
                //              /*primero necesitamos hacer el JOIN para luego hacer el LEFT OUTER JOIN*/
                //             join tp in dbImproContext.TypeProds on p.TypeProdId equals tp.TypeProdId into typeProdGroup /*agrupa el resultado del join de Prod con TypeProd*/
                //                 /*aqui hace el LEFT OUTER JOIN con PROD*/
                //                 from tp in typeProdGroup.DefaultIfEmpty()
                //             /*primero necesitamos hacer el JOIN para luego hacer el LEFT OUTER JOIN*/
                //             join m in dbImproContext.Marks on p.MarkId equals m.MarkId into markGroup /*agrupa el resultado del join de Prod con TypeProd*/
                //                 /*aqui hace el LEFT OUTER JOIN con PROD*/
                //                 from m in markGroup.DefaultIfEmpty()
                //             /*primero necesitamos hacer el JOIN para luego hacer el LEFT OUTER JOIN*/
                //             join c in dbImproContext.Categories on p.CategoryId equals c.CategoryId into categoryGroup
                //                 /*aqui hace el LEFT OUTER JOIN con PROD*/
                //                 from c in categoryGroup.DefaultIfEmpty()
                //             where tp.Descripcion == descripcionTipo
                //             //quienes estan involucrados
                //             group new { p, m, c } by new { p.DescripcionCompleta, DescripcionMark = m.Descripcion, DescripcionCat = c.Descripcion } into grouped
                //             select new ProdImpro
                //             {
                //                 DescripcionCompleta = grouped.Key.DescripcionCompleta,
                //                 Mark = new MarkImpro() { Descripcion = grouped.Key.DescripcionMark },
                //                 Category = new CategoryImpro() { Descripcion = grouped.Key.DescripcionCat }
                //             }).ToList();

                //var result = dbAuxContext.Prods
                //.GroupJoin(
                //    dbAuxContext.TypeProds.Where(tp => tp.Descripcion == "ALUMINIO COMPUESTO"),
                //    p => p.TypeProdId,
                //    tp => tp.TypeProdId,
                //    (p, tpGroup) => new { p, tpGroup }
                //)
                //.SelectMany(
                //    x => x.tpGroup.DefaultIfEmpty(),
                //    (x, tp) => new { x.p, tp }
                //)
                //.GroupJoin(
                //    dbAuxContext.Marks,
                //    x => x.p.MarkId,
                //    m => m.MarkId,
                //    (x, markGroup) => new { x.p, x.tp, markGroup }
                //)
                //.SelectMany(
                //    x => x.markGroup.DefaultIfEmpty(),
                //    (x, m) => new { x.p, x.tp, m }
                //)
                //.GroupJoin(
                //    dbAuxContext.Categories,
                //    x => x.p.CategoryId,
                //    c => c.CategoryId,
                //    (x, categoryGroup) => new { x.p, x.tp, x.m, categoryGroup }
                //)
                //.SelectMany(
                //    x => x.categoryGroup.DefaultIfEmpty(),
                //    (x, c) => new
                //    {
                //        DescripcionCompleta = x.p.DescripcionCompleta,
                //        MarkDescripcion = x.m != null ? x.m.Descripcion : null,
                //        CategoryDescripcion = c != null ? c.Descripcion : null
                //    }
                //)
                //.ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdHipo>> FindAllByTypeProd_DescripcionHipoWebPageAsync(string descripcionTipo)
        {
            try
            {
                List<ProdHipo> listProds = new List<ProdHipo>();
                listProds = (from p in dbHipoContext.Prods
                             join tp in dbHipoContext.TypeProds on p.TypeProdId equals tp.TypeProdId
                             where tp.Descripcion == descripcionTipo
                             group p by p.DescripcionCompleta into pGroup
                             select new ProdHipo { DescripcionCompleta = pGroup.Key }).ToList();

                //List<ProdHipo> listProds = new List<ProdHipo>();
                //listProds = (from p in dbHipoContext.Prods
                //             join tp in dbHipoContext.TypeProds on p.TypeProdId equals tp.TypeProdId
                //             into typeProdGroup
                //             from tp in typeProdGroup.DefaultIfEmpty()
                //             join m in dbHipoContext.Marks on p.MarkId equals m.MarkId
                //             into markGroup
                //             from m in markGroup.DefaultIfEmpty()
                //             join c in dbHipoContext.Categories on p.CategoryId equals c.CategoryId
                //             into categoryGroup
                //             from c in categoryGroup.DefaultIfEmpty()
                //             where tp.Descripcion == descripcionTipo
                //             group new { p, m, c } by new { p.DescripcionCompleta, DescripcionMark = m.Descripcion, DescripcionCat = c.Descripcion } into grouped
                //             select new ProdHipo
                //             {
                //                 DescripcionCompleta = grouped.Key.DescripcionCompleta,
                //                 Mark = new MarkHipo() { Descripcion = grouped.Key.DescripcionMark },
                //                 Category = new CategoryHipo() { Descripcion = grouped.Key.DescripcionCat }
                //             }).ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdAux>> FindAllByTypeProd_DescripcionAuxWebPageAsync(string descripcionTipo)
        {
            try
            {
                List<ProdAux> listProds = new List<ProdAux>();
                listProds = (from p in dbAuxContext.Prods
                             join tp in dbAuxContext.TypeProds on p.TypeProdId equals tp.TypeProdId
                             where tp.Descripcion == descripcionTipo
                             group p by p.DescripcionCompleta into pGroup
                             select new ProdAux { DescripcionCompleta = pGroup.Key }).ToList();

                //List<ProdAux> listProds = new List<ProdAux>();
                //listProds = (from p in dbAuxContext.Prods
                //             join tp in dbAuxContext.TypeProds on p.TypeProdId equals tp.TypeProdId
                //             into typeProdGroup
                //             from tp in typeProdGroup.DefaultIfEmpty()
                //             join m in dbAuxContext.Marks on p.MarkId equals m.MarkId
                //             into markGroup
                //             from m in markGroup.DefaultIfEmpty()
                //             join c in dbAuxContext.Categories on p.CategoryId equals c.CategoryId
                //             into categoryGroup
                //             from c in categoryGroup.DefaultIfEmpty()
                //             where tp.Descripcion == descripcionTipo
                //             group new { p, m, c } by new { p.DescripcionCompleta, DescripcionMark = m.Descripcion, DescripcionCat = c.Descripcion } into grouped
                //             select new ProdAux
                //             {
                //                 DescripcionCompleta = grouped.Key.DescripcionCompleta,
                //                 Mark = new MarkAux() { Descripcion = grouped.Key.DescripcionMark },
                //                 Category = new CategoryAux() { Descripcion = grouped.Key.DescripcionCat }
                //             }).ToList();
                return listProds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        public Task<List<ProdImpro>> FindAllByEstadoAndClassProd_DescripcionImproAsync(int estado, string descripcionTipo)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdHipo>> FindAllByEstadoAndClassProd_DescripcionHipoAsync(int estado, string descripcionTípo)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProdAux>> FindAllByEstadoAndClassProd_DescripcionAuxAsync(int estado, string descripcionTipo)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionImproAsync(string descripcionTipo)
        {
            try
            {
                return dbImproContext.Prods.Where(x => x.TypeProd.Descripcion == descripcionTipo).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionHipoAsync(string descripcionTipo)
        {
            try
            {
                return dbHipoContext.Prods.Where(x => x.TypeProd.Descripcion == descripcionTipo).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionAuxAsync(string descripcionTipo)
        {
            try
            {
                return dbAuxContext.Prods.Where(x => x.TypeProd.Descripcion == descripcionTipo).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region ´PROPIEDADES DEL PRODUCTO
        //PROPIEADADES DE PRODUCTO
        public async Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaImproAsync(string descripcionCorta)
        {
            try
            {
                return dbImproContext.Prods.Where(x => x.DescripcionCompleta == descripcionCorta).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaHipoAsync(string descripcionCorta)
        {
            try
            {
                return dbHipoContext.Prods.Where(x => x.DescripcionCompleta == descripcionCorta).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaAuxAsync(string descripcionCorta)
        {
            try
            {
                return dbAuxContext.Prods.Where(x => x.DescripcionCompleta == descripcionCorta).Select(x => x.DescripcionCorta).Distinct();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Task<IQueryable<string>> FindAllPricesByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllPricesByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllPricesByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllColorsByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllColorsByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllColorsByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllImagesByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllImagesByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllImagesByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllMarkByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllMarkByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllMarkByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaImproAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaHipoAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaAuxAsync(string descripcionCompleta)
        {
            throw new NotImplementedException();
        }

        #endregion
        public async Task<List<ProdImpro>> FindTheBestSalesImproAsync()
        {
            try
            {
                var today = DateTime.Today;
                var firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
                var firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);

                var resultado = from ci in dbImproContext.CotizacionItems
                                join p in dbImproContext.Prods on ci.ProductId equals p.Codigo
                                join c in dbImproContext.Cotizacions on ci.CotizacionId equals c.Codigo
                                join d in dbImproContext.Documentos on c.Codigo equals d.DocumentoId
                                join f in dbImproContext.Facturas on d.DocumentoId equals f.DocumentoAutorizacionId
                                where (f.FechaEmision.Year == today.Year && f.FechaEmision.Month == today.Month) ||
                                      (f.FechaEmision.Year == firstDayOfPreviousMonth.Year && f.FechaEmision.Month == firstDayOfPreviousMonth.Month)
                                      && (c.Estado == 3 || c.Estado == 4)
                                group new { ci, p } by new { ci.ProductId, p.DescripcionCorta } into g
                                select new
                                {
                                    ProductoId = g.Key.ProductId,
                                    DescripcionCorta = g.Key.DescripcionCorta,
                                    CantidadTotal = g.Sum(x => x.ci.Cantidad)
                                }
                                into grouped
                                orderby grouped.CantidadTotal descending
                                select grouped;

                var top30Result = resultado.Take(30).Select(item => new ProdImpro
                {
                    ProdId = item.ProductoId,
                    DescripcionCorta = item.DescripcionCorta,
                    CantidadPallet = item.CantidadTotal
                });
                return top30Result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdHipo>> FindTheBestSalesHipoAsync()
        {
            try
            {
                var today = DateTime.Today;
                var firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
                var firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);

                var resultado = from ci in dbHipoContext.CotizacionItems
                                join p in dbHipoContext.Prods on ci.ProductId equals p.Codigo
                                join c in dbHipoContext.Cotizacions on ci.CotizacionId equals c.Codigo
                                join d in dbHipoContext.Documentos on c.Codigo equals d.DocumentoId
                                join f in dbHipoContext.Facturas on d.DocumentoId equals f.DocumentoAutorizacionId
                                where (f.FechaEmision.Year == today.Year && f.FechaEmision.Month == today.Month) ||
                                      (f.FechaEmision.Year == firstDayOfPreviousMonth.Year && f.FechaEmision.Month == firstDayOfPreviousMonth.Month)
                                      && (c.Estado == 3 || c.Estado == 4)
                                group new { ci, p } by new { ci.ProductId, p.DescripcionCorta } into g
                                select new
                                {
                                    ProductoId = g.Key.ProductId,
                                    DescripcionCorta = g.Key.DescripcionCorta,
                                    CantidadTotal = g.Sum(x => x.ci.Cantidad)
                                }
                                into grouped
                                orderby grouped.CantidadTotal descending
                                select grouped;

                var top30Result = resultado.Take(30).Select(item => new ProdHipo
                {
                    ProdId = item.ProductoId,
                    DescripcionCorta = item.DescripcionCorta,
                    CantidadPallet = item.CantidadTotal
                });
                return top30Result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProdAux>> FindTheBestSalesAuxAsync()
        {
            try
            {
                var today = DateTime.Today;
                var firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
                var firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);

                var resultado = from ci in dbAuxContext.CotizacionItems
                                join p in dbAuxContext.Prods on ci.ProductId equals p.Codigo
                                join c in dbAuxContext.Cotizacions on ci.CotizacionId equals c.Codigo
                                join d in dbAuxContext.Documentos on c.Codigo equals d.DocumentoId
                                join f in dbAuxContext.Facturas on d.DocumentoId equals f.DocumentoAutorizacionId
                                where (f.FechaEmision.Year == today.Year && f.FechaEmision.Month == today.Month) ||
                                      (f.FechaEmision.Year == firstDayOfPreviousMonth.Year && f.FechaEmision.Month == firstDayOfPreviousMonth.Month)
                                      && (c.Estado == 3 || c.Estado == 4)
                                group new { ci, p } by new { ci.ProductId, p.DescripcionCorta } into g
                                select new
                                {
                                    ProductoId = g.Key.ProductId,
                                    DescripcionCorta = g.Key.DescripcionCorta,
                                    CantidadTotal = g.Sum(x => x.ci.Cantidad)
                                }
                                into grouped
                                orderby grouped.CantidadTotal descending
                                select grouped;

                var top30Result = resultado.Take(30).Select(item => new ProdAux
                {
                    ProdId = item.ProductoId,
                    DescripcionCorta = item.DescripcionCorta,
                    CantidadPallet = item.CantidadTotal
                });
                return top30Result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}