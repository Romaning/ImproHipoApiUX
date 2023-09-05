using Application.Gateways;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entities Improcons
using TypeProdImpro = Domain.Entities.Improcons.TypeProd;
//Entities Hipotina
using TypeProdHipo = Domain.Entities.Hipotina.TypeProd;
//Entities Auxiliar
using TypeProdAux = Domain.Entities.Auxiliar.TypeProd;
using Infrastructure.Gateways.Injections;
using Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Gateways
{
    public class TypeProdDsGatImpl : DependencyInjectContext, ITypeProdGateway
    {
        public TypeProdDsGatImpl(ApplicationDbImproContext _dbImproContexts, ApplicationDbHipoContext _dbHipoContexts, ApplicationDbAuxContext _dbAuxContexts) : base(_dbImproContexts, _dbHipoContexts, _dbAuxContexts)
        {
        }

        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/
        public async Task<List<TypeProdImpro>> FindAllImproAsync()
        {
            try
            {
                List<TypeProdImpro> list = new List<TypeProdImpro>();
                list = dbImproContext.TypeProds
                    .Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdHipo>> FindAllHipoAsync()
        {
            try
            {
                List<TypeProdHipo> list = new List<TypeProdHipo>();
                list = dbHipoContext.TypeProds
                    .Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdAux>> FindAllAuxAsync()
        {
            try
            {
                List<TypeProdAux> list = new List<TypeProdAux>();
                list = dbAuxContext.TypeProds
                    .Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/
        public async Task<List<TypeProdImpro>> FindAllDistinctImproAsync()
        {
            try
            {
                List<TypeProdImpro> list = new List<TypeProdImpro>();
                IQueryable<string> listaTiposDescripcion = dbImproContext.TypeProds.Select(x => x.Descripcion).Distinct();
                await listaTiposDescripcion.ForEachAsync(elem =>
                {
                    list.Add(new TypeProdImpro() { Descripcion = elem.ToString() });
                });
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdHipo>> FindAllDistinctHipoAsync()
        {
            try
            {
                List<TypeProdHipo> list = new List<TypeProdHipo>();
                var listaTiposDescripcion = dbHipoContext.TypeProds.Select(x => x.Descripcion).Distinct();
                await listaTiposDescripcion.ForEachAsync(elem =>
                {
                    list.Add(new TypeProdHipo() { Descripcion = elem.ToString() });
                });
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdAux>> FindAllDistinctAuxAsync()
        {
            try
            {
                List<TypeProdAux> list = new List<TypeProdAux>();
                var listaTiposDescripcion = dbAuxContext.TypeProds.Select(x => x.Descripcion).Distinct();
                await listaTiposDescripcion.ForEachAsync(elem =>
                {
                    list.Add(new TypeProdAux() { Descripcion = elem.ToString() });
                });
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<TypeProdImpro> FindByIdImproAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdHipo> FindByIdHipoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdAux> FindByIdAuxAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdImpro> FindByIdAndEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdHipo> FindByIdAndEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdAux> FindByIdAndEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<TypeProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdImpro>> FindAllByDescripcionImproAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdHipo>> FindAllByDescripcionHipoAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdAux>> FindAllByDescripcionAuxAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdImpro>> FindAllByEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdHipo>> FindAllByEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdAux>> FindAllByEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdImpro>> FindAllByDescripcionAndEstadoImproAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdHipo>> FindAllByDescripcionAndEstadoHipoAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdAux>> FindAllByDescripcionAndEstadoAuxAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        //find by class descripcion
        #region FindAllByClassProd_Descripcion[$$$ EMPRESA $$$]Async
        public async Task<List<TypeProdImpro>> FindAllByClassProd_DescripcionImproAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdImpro> list = new List<TypeProdImpro>();
                list = dbImproContext.TypeProds
                    .Where(y => y.ClassProd.Descripcion == descripcionClase)
                    .Select(x => new TypeProdImpro { Descripcion = x.Descripcion })
                    //.Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdHipo>> FindAllByClassProd_DescripcionHipoAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdHipo> list = new List<TypeProdHipo>();
                list = dbHipoContext.TypeProds
                    .Where(y => y.ClassProd.Descripcion == descripcionClase)
                    .Select(x => new TypeProdHipo { Descripcion = x.Descripcion })
                    //.Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdAux>> FindAllByClassProd_DescripcionAuxAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdAux> list = new List<TypeProdAux>();
                list = dbAuxContext.TypeProds
                    .Where(y => y.ClassProd.Descripcion == descripcionClase)
                    .Select(x => new TypeProdAux { Descripcion = x.Descripcion })
                    //.Include(x => x.ClassProd)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        //find by estate AND class descripcion

        #region FindAllByClassProd_Descripcion[$$$ EMPRESA $$$] [$$$ WebPage $$$$]Async
        public async Task<List<TypeProdImpro>> FindAllByClassProd_DescripcionImproWebPageAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdImpro> list = new List<TypeProdImpro>();
                list = (from tp in dbImproContext.TypeProds
                        join cp in dbImproContext.ClassProds on tp.ClassProdId equals cp.ClassProdId
                        where cp.Descripcion == descripcionClase
                        group tp by tp.Descripcion into tpGroup
                        select new TypeProdImpro { Descripcion = tpGroup.Key }).ToList();

                //list = (from tp in dbImproContext.TypeProds
                //        join cp in dbImproContext.ClassProds on tp.ClassProdId equals cp.ClassProdId into groupTypeAndClass /*JOIN*/
                //        from groupTPandCP in groupTypeAndClass.DefaultIfEmpty() /*para que sea nulo el campo de Clase, LEFT OUTER JOIN*/
                //        where groupTPandCP.Descripcion == descripcionClase
                //        group new { tp, groupTPandCP } by new { groupTPandCP.Descripcion } into grouped
                //        select new TypeProdImpro
                //        {
                //            Descripcion = grouped.Key.Descripcion
                //        }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdHipo>> FindAllByClassProd_DescripcionHipoWebPageAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdHipo> list = new List<TypeProdHipo>();
                list = (from tp in dbHipoContext.TypeProds
                        join cp in dbHipoContext.ClassProds on tp.ClassProdId equals cp.ClassProdId
                        where cp.Descripcion == descripcionClase
                        group tp by tp.Descripcion into tpGroup
                        select new TypeProdHipo { Descripcion = tpGroup.Key }).ToList();
                //list = (from tp in dbImproContext.TypeProds
                //        join cp in dbImproContext.ClassProds on tp.ClassProdId equals cp.ClassProdId into groupTypeAndClass /*JOIN*/
                //        from groupTPandCP in groupTypeAndClass.DefaultIfEmpty() /*para que sea nulo el campo de Clase, LEFT OUTER JOIN*/
                //        where groupTPandCP.Descripcion == descripcionClase
                //        group new { tp, groupTPandCP } by new { groupTPandCP.Descripcion } into grouped
                //        select new TypeProdHipo
                //        {
                //            Descripcion = grouped.Key.Descripcion
                //        }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdAux>> FindAllByClassProd_DescripcionAuxWebPageAsync(string descripcionClase)
        {
            try
            {
                List<TypeProdAux> list = new List<TypeProdAux>();
                list = (from tp in dbAuxContext.TypeProds
                        join cp in dbAuxContext.ClassProds on tp.ClassProdId equals cp.ClassProdId
                        where cp.Descripcion == descripcionClase
                        group tp by tp.Descripcion into tpGroup
                        select new TypeProdAux { Descripcion = tpGroup.Key }).ToList();

                //list = (from tp in dbImproContext.TypeProds
                //        join cp in dbImproContext.ClassProds on tp.ClassProdId equals cp.ClassProdId into groupTypeAndClass /*JOIN*/
                //        from groupTPandCP in groupTypeAndClass.DefaultIfEmpty() /*para que sea nulo el campo de Clase, LEFT OUTER JOIN*/
                //        where groupTPandCP.Descripcion == descripcionClase
                //        group new { tp, groupTPandCP } by new { groupTPandCP.Descripcion } into grouped
                //        select new TypeProdAux
                //        {
                //            Descripcion = grouped.Key.Descripcion
                //        }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        public Task<List<TypeProdImpro>> FindAllByEstadoAndClassProd_DescripcionImproAsync(int estado, string descripcionClase)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdHipo>> FindAllByEstadoAndClassProd_DescripcionHipoAsync(int estado, string descripcionClase)
        {
            throw new NotImplementedException();
        }

        public Task<List<TypeProdAux>> FindAllByEstadoAndClassProd_DescripcionAuxAsync(int estado, string descripcionClase)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionImproAsync(string descripcionClase)
        {
            try
            {
                return dbImproContext.TypeProds.Where(x => x.ClassProd.Descripcion == descripcionClase).Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionHipoAsync(string descripcionClase)
        {
            try
            {
                return dbHipoContext.TypeProds.Where(x => x.ClassProd.Descripcion == descripcionClase).Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionAuxAsync(string descripcionClase)
        {
            try
            {
                return dbAuxContext.TypeProds.Where(x => x.ClassProd.Descripcion == descripcionClase).Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/

    }
}
