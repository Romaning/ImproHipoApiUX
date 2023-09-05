using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescComImpro = Domain.Entities.Improcons.DescuentoComercial;
using DescComHipo = Domain.Entities.Hipotina.DescuentoComercial;
using DescComAux = Domain.Entities.Auxiliar.DescuentoComercial;
using Domain.Entities.Common;
using Application.Gateways;
using Infrastructure.Gateways.Injections;
using Persistence.DbContexts;

namespace Infrastructure.Gateways
{

    public class DescuentoComercialDsGatImpl : DependencyInjectContext, IDescuentoComercialGateway
    {
        public DescuentoComercialDsGatImpl(ApplicationDbImproContext dbImproContexts, ApplicationDbHipoContext dbHipoContexts, ApplicationDbAuxContext dbAuxContexts)
            : base(dbImproContexts, dbHipoContexts, dbAuxContexts)
        {
        }

        public Task<IQueryable<DescComImpro>> FindAllImproAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<DescComAux>> FindAllAuxAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<DescComHipo>> FindAllHipoAsync()
        {
            throw new NotImplementedException();
        }
        //Clase
        #region Clases en Oferta, se toma para todos los clientes
        public async Task<IQueryable<DescComImpro>> FindAllClassProdOfferImproAsync()
        {
            IQueryable<DescComImpro> listDesc = (from item in dbImproContext.DescuentoComercials
                                                 join item2 in dbImproContext.ClassProds on item.ClassProdId equals item2.ClassProdId
                                                 where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ClassProdId != -1 && item.ClassProdId != 0
                                                 && item.Estado == 1 && item.Finalizado == 0
                                                 select new DescComImpro
                                                 {
                                                     UnidadId = item.UnidadId,
                                                     Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                     Descuento = item.Descuento,
                                                     Observaciones = item.Descripcion,
                                                     Estado = item.Estado,
                                                     Finalizado = item.Finalizado,
                                                 });
            return listDesc;
        }

        public async Task<IQueryable<DescComHipo>> FindAllClassProdOfferHipoAsync()
        {
            IQueryable<DescComHipo> listDesc = (from item in dbHipoContext.DescuentoComercials
                                                join item2 in dbHipoContext.ClassProds on item.ClassProdId equals item2.ClassProdId
                                                where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ClassProdId != -1 && item.ClassProdId != 0
                                                && item.Estado == 1 && item.Finalizado == 0
                                                select new DescComHipo
                                                {
                                                    UnidadId = item.UnidadId,
                                                    Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                    Descuento = item.Descuento,
                                                    Observaciones = item.Descripcion,
                                                    Estado = item.Estado,
                                                    Finalizado = item.Finalizado,
                                                });
            return listDesc;
        }

        public async Task<IQueryable<DescComAux>> FindAllClassProdOfferAuxAsync()
        {
            IQueryable<DescComAux> listDesc = (from item in dbAuxContext.DescuentoComercials
                                               join item2 in dbAuxContext.ClassProds on item.ClassProdId equals item2.ClassProdId
                                               where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ClassProdId != -1 && item.ClassProdId != 0
                                               && item.Estado == 1 && item.Finalizado == 0
                                               select new DescComAux
                                               {
                                                   UnidadId = item.UnidadId,
                                                   Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                   Descuento = item.Descuento,
                                                   Observaciones = item.Descripcion,
                                                   Estado = item.Estado,
                                                   Finalizado = item.Finalizado,
                                               });
            return listDesc;
        }
        #endregion

        //Tipo
        #region Tipo en Oferta, se toma para todos los clientes
        public async Task<IQueryable<DescComImpro>> FindAllTypeProdOfferImproAsync()
        {
            IQueryable<DescComImpro> listDesc = (from item in dbImproContext.DescuentoComercials
                                                 join item2 in dbImproContext.TypeProds on item.TypeProdId equals item2.TypeProdId
                                                 where item.TipoClienteId == 0 && item.UnidadId == 0 && item.TypeProdId != -1 && item.TypeProdId != 0
                                                 && item.Estado == 1 && item.Finalizado == 0
                                                 select new DescComImpro
                                                 {
                                                     UnidadId = item.UnidadId,
                                                     Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                     Descuento = item.Descuento,
                                                     Observaciones = item.Descripcion,
                                                     Estado = item.Estado,
                                                     Finalizado = item.Finalizado,
                                                 });
            return listDesc;
        }

        public async Task<IQueryable<DescComHipo>> FindAllTypeProdOfferHipoAsync()
        {
            IQueryable<DescComHipo> listDesc = (from item in dbHipoContext.DescuentoComercials
                                                join item2 in dbHipoContext.TypeProds on item.TypeProdId equals item2.TypeProdId
                                                where item.TipoClienteId == 0 && item.UnidadId == 0 && item.TypeProdId != -1 && item.TypeProdId != 0
                                                && item.Estado == 1 && item.Finalizado == 0
                                                select new DescComHipo
                                                {
                                                    UnidadId = item.UnidadId,
                                                    Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                    Descuento = item.Descuento,
                                                    Observaciones = item.Descripcion,
                                                    Estado = item.Estado,
                                                    Finalizado = item.Finalizado,
                                                });
            return listDesc;
        }

        public async Task<IQueryable<DescComAux>> FindAllTypeProdOfferAuxAsync()
        {
            IQueryable<DescComAux> listDesc = (from item in dbAuxContext.DescuentoComercials
                                               join item2 in dbAuxContext.TypeProds on item.TypeProdId equals item2.TypeProdId
                                               where item.TipoClienteId == 0 && item.UnidadId == 0 && item.TypeProdId != -1 && item.TypeProdId != 0
                                               && item.Estado == 1 && item.Finalizado == 0
                                               select new DescComAux
                                               {
                                                   UnidadId = item.UnidadId,
                                                   Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                   Descuento = item.Descuento,
                                                   Observaciones = item.Descripcion,
                                                   Estado = item.Estado,
                                                   Finalizado = item.Finalizado,
                                               });
            return listDesc;
        }
        #endregion

        //Categoria
        #region Categorias en Oferta, se toma para todos los clientes
        public async Task<IQueryable<DescComImpro>> FindAllCategoryOfferImproAsync()
        {
            IQueryable<DescComImpro> listDesc = (from item in dbImproContext.DescuentoComercials
                                                 join item2 in dbImproContext.Categories on item.CategoryId equals item2.CategoryId
                                                 where item.TipoClienteId == 0 && item.UnidadId == 0 && item.CategoryId != -1 && item.CategoryId != 0
                                                 && item.Estado == 1 && item.Finalizado == 0
                                                 select new DescComImpro
                                                 {
                                                     UnidadId = item.UnidadId,
                                                     Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                     Descuento = item.Descuento,
                                                     Observaciones = item.Descripcion,
                                                     Estado = item.Estado,
                                                     Finalizado = item.Finalizado,
                                                 });
            return listDesc;
        }

        public async Task<IQueryable<DescComHipo>> FindAllCategoryOfferHipoAsync()
        {
            IQueryable<DescComHipo> listDesc = (from item in dbHipoContext.DescuentoComercials
                                                join item2 in dbHipoContext.Categories on item.CategoryId equals item2.CategoryId
                                                where item.TipoClienteId == 0 && item.UnidadId == 0 && item.CategoryId != -1 && item.CategoryId != 0
                                                && item.Estado == 1 && item.Finalizado == 0
                                                select new DescComHipo
                                                {
                                                    UnidadId = item.UnidadId,
                                                    Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                    Descuento = item.Descuento,
                                                    Observaciones = item.Descripcion,
                                                    Estado = item.Estado,
                                                    Finalizado = item.Finalizado,
                                                });
            return listDesc;
        }

        public async Task<IQueryable<DescComAux>> FindAllCategoryOfferAuxAsync()
        {
            IQueryable<DescComAux> listDesc = (from item in dbAuxContext.DescuentoComercials
                                               join item2 in dbAuxContext.Categories on item.CategoryId equals item2.CategoryId
                                               where item.TipoClienteId == 0 && item.UnidadId == 0 && item.CategoryId != -1 && item.CategoryId != 0
                                               && item.Estado == 1 && item.Finalizado == 0
                                               select new DescComAux
                                               {
                                                   UnidadId = item.UnidadId,
                                                   Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                   Descuento = item.Descuento,
                                                   Observaciones = item.Descripcion,
                                                   Estado = item.Estado,
                                                   Finalizado = item.Finalizado,
                                               });
            return listDesc;
        }
        #endregion

        //Marca
        #region Marcas en Oferta, se toma para todos los clientes
        public async Task<IQueryable<DescComImpro>> FindAllMarkProdOfferImproAsync()
        {
            IQueryable<DescComImpro> listDesc = (from item in dbImproContext.DescuentoComercials
                                                 join item2 in dbImproContext.Marks on item.MarkId equals item2.MarkId
                                                 where item.TipoClienteId == 0 && item.UnidadId == 0 && item.MarkId != -1 && item.MarkId != 0
                                                 && item.Estado == 1 && item.Finalizado == 0
                                                 select new DescComImpro
                                                 {
                                                     UnidadId = item.UnidadId,
                                                     Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                     Descuento = item.Descuento,
                                                     Observaciones = item.Descripcion,
                                                     Estado = item.Estado,
                                                     Finalizado = item.Finalizado,
                                                 });
            return listDesc;
        }

        public async Task<IQueryable<DescComHipo>> FindAllMarkProdOfferHipoAsync()
        {
            IQueryable<DescComHipo> listDesc = (from item in dbHipoContext.DescuentoComercials
                                                join item2 in dbHipoContext.Marks on item.MarkId equals item2.MarkId
                                                where item.TipoClienteId == 0 && item.UnidadId == 0 && item.MarkId != -1 && item.MarkId != 0
                                                && item.Estado == 1 && item.Finalizado == 0
                                                select new DescComHipo
                                                {
                                                    UnidadId = item.UnidadId,
                                                    Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                    Descuento = item.Descuento,
                                                    Observaciones = item.Descripcion,
                                                    Estado = item.Estado,
                                                    Finalizado = item.Finalizado,
                                                });
            return listDesc;
        }

        public async Task<IQueryable<DescComAux>> FindAllMarkProdOfferAuxAsync()
        {
            IQueryable<DescComAux> listDesc = (from item in dbAuxContext.DescuentoComercials
                                               join item2 in dbAuxContext.Marks on item.MarkId equals item2.MarkId
                                               where item.TipoClienteId == 0 && item.UnidadId == 0 && item.MarkId != -1 && item.MarkId != 0
                                               && item.Estado == 1 && item.Finalizado == 0
                                               select new DescComAux
                                               {
                                                   UnidadId = item.UnidadId,
                                                   Descripcion = item2.Descripcion, //OJO se esta cambiando por la DESC de CLASE
                                                   Descuento = item.Descuento,
                                                   Observaciones = item.Descripcion,
                                                   Estado = item.Estado,
                                                   Finalizado = item.Finalizado,
                                               });
            return listDesc;
        }
        #endregion

        //Prod
        public async Task<IQueryable<DescComImpro>> FindAllProdOfferImproAsync()
        {
            IQueryable<DescComImpro> listDesc = (from item in dbImproContext.DescuentoComercials
                                                 join item2 in dbImproContext.Prods on item.ProdId equals item2.ProdId
                                                 where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ProdId != -1 && item.ProdId != 0
                                                 && item.Estado == 1 && item.Finalizado == 0
                                                 select new DescComImpro
                                                 {
                                                     UnidadId = item.UnidadId,
                                                     Descripcion = item2.DescripcionCorta, //OJO se esta cambiando por la DESC de CLASE
                                                     Descuento = item.Descuento,
                                                     Observaciones = item.Descripcion,
                                                     Estado = item.Estado,
                                                     Finalizado = item.Finalizado,
                                                 });
            return listDesc;
        }

        public async Task<IQueryable<DescComHipo>> FindAllProdOfferHipoAsync()
        {
            IQueryable<DescComHipo> listDesc = (from item in dbHipoContext.DescuentoComercials
                                                join item2 in dbHipoContext.Prods on item.ProdId equals item2.ProdId
                                                where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ProdId != -1 && item.ProdId != 0
                                                && item.Estado == 1 && item.Finalizado == 0
                                                select new DescComHipo
                                                {
                                                    UnidadId = item.UnidadId,
                                                    Descripcion = item2.DescripcionCorta, //OJO se esta cambiando por la DESC de CLASE
                                                    Descuento = item.Descuento,
                                                    Observaciones = item.Descripcion,
                                                    Estado = item.Estado,
                                                    Finalizado = item.Finalizado,
                                                });
            return listDesc;
        }

        public async Task<IQueryable<DescComAux>> FindAllProdOfferAuxAsync()
        {
            IQueryable<DescComAux> listDesc = (from item in dbAuxContext.DescuentoComercials
                                               join item2 in dbAuxContext.Prods on item.ProdId equals item2.ProdId
                                               where item.TipoClienteId == 0 && item.UnidadId == 0 && item.ProdId != -1 && item.ProdId != 0
                                               && item.Estado == 1 && item.Finalizado == 0
                                               select new DescComAux
                                               {
                                                   UnidadId = item.UnidadId,
                                                   Descripcion = item2.DescripcionCorta, //OJO se esta cambiando por la DESC de CLASE
                                                   Descuento = item.Descuento,
                                                   Observaciones = item.Descripcion,
                                                   Estado = item.Estado,
                                                   Finalizado = item.Finalizado,
                                               });
            return listDesc;
        }
    }
}
