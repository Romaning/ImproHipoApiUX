using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Gateways;
using Persistence.DbContexts;

using ClassProdAux = Domain.Entities.Auxiliar.ClassProd;
using ClassProdHipo = Domain.Entities.Hipotina.ClassProd;
using ClassProdImpro = Domain.Entities.Improcons.ClassProd;
using Domain.Entities.Common;
using Infrastructure.Gateways.Injections;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Gateways
{
    public class ClassProdDsGatImpl : DependencyInjectContext, IClassProdGateway
    {
        public ClassProdDsGatImpl(ApplicationDbImproContext dbImproContexts, ApplicationDbHipoContext dbHipoContexts, ApplicationDbAuxContext dbAuxContexts)
            : base(dbImproContexts, dbHipoContexts, dbAuxContexts)
        {
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/

        public async Task<List<ClassProdAux>> FindAllAuxAsync()
        {
            try
            {
                List<ClassProdAux> list = new List<ClassProdAux>();
                list = dbAuxContext.ClassProds
                    .Select(x => new ClassProdAux { Descripcion = x.Descripcion })
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdHipo>> FindAllHipoAsync()
        {
            try
            {
                List<ClassProdHipo> list = new List<ClassProdHipo>();
                list = dbHipoContext.ClassProds
                    .Select(x => new ClassProdHipo { Descripcion = x.Descripcion })
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdImpro>> FindAllImproAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = dbImproContext.ClassProds
                    .Select(x => new ClassProdImpro { Descripcion = x.Descripcion })
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdAux>> FindAllAuxWebPageAsync()
        {
            try
            {
                List<ClassProdAux> list = new List<ClassProdAux>();
                list = (from cp in dbAuxContext.ClassProds
                        group new { cp } by new { cp.Descripcion } into grouped
                        select new ClassProdAux { Descripcion = grouped.Key.Descripcion }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdHipo>> FindAllHipoWebPageAsync()
        {
            try
            {
                List<ClassProdHipo> list = new List<ClassProdHipo>();
                list = (from cp in dbHipoContext.ClassProds
                        group new { cp } by new { cp.Descripcion } into grouped
                        select new ClassProdHipo { Descripcion = grouped.Key.Descripcion }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdImpro>> FindAllImproWebPageAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = (from cp in dbImproContext.ClassProds
                        group new { cp } by new { cp.Descripcion } into grouped
                        select new ClassProdImpro { Descripcion = grouped.Key.Descripcion }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<List<ClassProdAux>> FindAllByDescripcionAndEstadoAuxAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdHipo>> FindAllByDescripcionAndEstadoHipoAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdImpro>> FindAllByDescripcionAndEstadoImproAsync(string descripcion, int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdAux>> FindAllByDescripcionAuxAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdHipo>> FindAllByDescripcionHipoAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdImpro>> FindAllByDescripcionImproAsync(string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdAux>> FindAllByEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdHipo>> FindAllByEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassProdImpro>> FindAllByEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdAux> FindByIdAndEstadoAuxAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdHipo> FindByIdAndEstadoHipoAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdImpro> FindByIdAndEstadoImproAsync(int estado)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdAux> FindByIdAuxAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdHipo> FindByIdHipoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClassProdImpro> FindByIdImproAsync(int id)
        {
            throw new NotImplementedException();
        }

        //relaciones
        public async Task<List<ClassProdAux>> FindAllWith_TypeProdAndWith_ProdAuxAsync()
        {
            try
            {
                List<ClassProdAux> list = new List<ClassProdAux>();
                list = dbAuxContext.ClassProds
                    .Include(x => x.TypeProds).ThenInclude(y => y.Prods)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdHipo>> FindAllWith_TypeProdAndWith_ProdHipoAsync()
        {
            try
            {
                List<ClassProdHipo> list = new List<ClassProdHipo>();
                list = dbHipoContext.ClassProds
                    .Include(x => x.TypeProds).ThenInclude(y => y.Prods)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdImpro>> FindAllWith_TypeProdAndWith_ProdImproAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = dbImproContext.ClassProds
                    .Include(x => x.TypeProds).ThenInclude(y => y.Prods)
                    .ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescipcionDistinctImproAsync()
        {
            try
            {
                return dbImproContext.ClassProds.Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescipcionDistinctHipoAsync()
        {
            try
            {
                return dbHipoContext.ClassProds.Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<string>> FindAllDescipcionDistinctAuxAsync()
        {
            try
            {
                return dbAuxContext.ClassProds.Select(x => x.Descripcion).Distinct();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/

    }
}
