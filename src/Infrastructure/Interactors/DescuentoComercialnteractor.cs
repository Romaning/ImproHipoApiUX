using Application.Boundaries;
using Application.DTOsOwn;
using Application.Gateways;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescComImpro = Domain.Entities.Improcons.DescuentoComercial;
using DescComHipo = Domain.Entities.Hipotina.DescuentoComercial;
using DescComAux = Domain.Entities.Auxiliar.DescuentoComercial;
using Domain.Entities.Common;
namespace Infrastructure.Interactors
{
    public class DescuentoComercialnteractor : IDescuentoComercialBoundary
    {
        protected readonly IDescuentoComercialGateway iDescuentoComercialGateway;

        public DescuentoComercialnteractor(IDescuentoComercialGateway _iDescuentoComercialGateway )
        {
            iDescuentoComercialGateway = _iDescuentoComercialGateway;
        }

        public async Task<List<OfertaModelDTO>> GetAllClassProdInOfferRefactorEnterpriseAsync()
        {
            //findAll Impro
            //findAll Hipo
            //findAll Aux
            IEnumerable<DescComImpro> listImpro = await iDescuentoComercialGateway.FindAllClassProdOfferImproAsync();
            IEnumerable<DescComHipo> listHipo = await iDescuentoComercialGateway.FindAllClassProdOfferHipoAsync();
            IEnumerable<DescComAux> listAux = await iDescuentoComercialGateway.FindAllClassProdOfferAuxAsync();

            List<DescuentoComercialBase> list = new List<DescuentoComercialBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);

            var listImproRefact = (from i in list
                                   group new { Descuento = i.Descuento, DescuentoComercialId = i.DescuentoComercialId } by i.Descripcion into grupo
                                   select new OfertaModelDTO
                                   {
                                       id = grupo.ToList().Select(item => item.DescuentoComercialId).FirstOrDefault(), //cualquiera ID Descuento comercial
                                       nombre = grupo.Key,
                                       porcentaje = grupo.ToList().Select(item => item.Descuento).Max(),
                                   }).ToList();
            //mandar la lista de categorias como mmodelo
            return listImproRefact;
        }

        public async Task<List<OfertaModelDTO>> GetAllTypeProdInOfferRefactorEnterpriseAsync()
        {
            //findAll Impro
            //findAll Hipo
            //findAll Aux
            IEnumerable<DescComImpro> listImpro = await iDescuentoComercialGateway.FindAllTypeProdOfferImproAsync();
            IEnumerable<DescComHipo> listHipo = await iDescuentoComercialGateway.FindAllTypeProdOfferHipoAsync();
            IEnumerable<DescComAux> listAux = await iDescuentoComercialGateway.FindAllTypeProdOfferAuxAsync();

            List<DescuentoComercialBase> list = new List<DescuentoComercialBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);

            var listImproRefact = (from i in list
                                   group new { Descuento = i.Descuento, DescuentoComercialId = i.DescuentoComercialId } by i.Descripcion into grupo
                                   select new OfertaModelDTO
                                   {
                                       id = grupo.ToList().Select(item => item.DescuentoComercialId).FirstOrDefault(), //cualquiera ID Descuento comercial
                                       nombre = grupo.Key,
                                       porcentaje = grupo.ToList().Select(item => item.Descuento).Max(),
                                   }).ToList();
            //mandar la lista de categorias como mmodelo
            return listImproRefact;
        }

        public async Task<List<OfertaModelDTO>> GetAllCategoryProdInOfferRefactorEnterpriseAsync()
        {
            //findAll Impro
            //findAll Hipo
            //findAll Aux
            IEnumerable<DescComImpro> listImpro = await iDescuentoComercialGateway.FindAllCategoryOfferImproAsync();
            IEnumerable<DescComHipo> listHipo = await iDescuentoComercialGateway.FindAllCategoryOfferHipoAsync();
            IEnumerable<DescComAux> listAux = await iDescuentoComercialGateway.FindAllCategoryOfferAuxAsync();

            List<DescuentoComercialBase> list = new List<DescuentoComercialBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);

            var listImproRefact = (from i in list
                                   group new { Descuento = i.Descuento, DescuentoComercialId = i.DescuentoComercialId } by i.Descripcion into grupo
                                   select new OfertaModelDTO
                                   {
                                       id = grupo.ToList().Select(item => item.DescuentoComercialId).FirstOrDefault(), //cualquiera ID Descuento comercial
                                       nombre = grupo.Key,
                                       porcentaje = grupo.ToList().Select(item => item.Descuento).Max(),
                                   }).ToList();
            //mandar la lista de categorias como mmodelo
            return listImproRefact;
        }

        public async Task<List<OfertaModelDTO>> GetAllMarkProdInOfferRefactorEnterpriseAsync()
        {
            //findAll Impro
            //findAll Hipo
            //findAll Aux
            IEnumerable<DescComImpro> listImpro = await iDescuentoComercialGateway.FindAllMarkProdOfferImproAsync();
            IEnumerable<DescComHipo> listHipo = await iDescuentoComercialGateway.FindAllMarkProdOfferHipoAsync();
            IEnumerable<DescComAux> listAux = await iDescuentoComercialGateway.FindAllMarkProdOfferAuxAsync();

            List<DescuentoComercialBase> list = new List<DescuentoComercialBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);

            var listImproRefact = (from i in list
                                   group new { Descuento = i.Descuento, DescuentoComercialId = i.DescuentoComercialId } by i.Descripcion into grupo
                                   select new OfertaModelDTO
                                   {
                                       id = grupo.ToList().Select(item => item.DescuentoComercialId).FirstOrDefault(), //cualquiera ID Descuento comercial
                                       nombre = grupo.Key,
                                       porcentaje = grupo.ToList().Select(item => item.Descuento).Max(),
                                   }).ToList();
            //mandar la lista de categorias como mmodelo
            return listImproRefact;
        }

        public async Task<List<OfertaModelDTO>> GetAllProdInOfferRefactorEnterpriseAsync()
        {
            //findAll Impro
            //findAll Hipo
            //findAll Aux
            IEnumerable<DescComImpro> listImpro = await iDescuentoComercialGateway.FindAllProdOfferImproAsync();
            IEnumerable<DescComHipo> listHipo = await iDescuentoComercialGateway.FindAllProdOfferHipoAsync();
            IEnumerable<DescComAux> listAux = await iDescuentoComercialGateway.FindAllProdOfferAuxAsync();

            List<DescuentoComercialBase> list = new List<DescuentoComercialBase>();
            list.AddRange(listImpro);
            list.AddRange(listHipo);
            list.AddRange(listAux);

            var listImproRefact = (from i in list
                                   group new { Descuento = i.Descuento, DescuentoComercialId = i.DescuentoComercialId } by i.Descripcion into grupo
                                   select new OfertaModelDTO
                                   {
                                       id = grupo.ToList().Select(item => item.DescuentoComercialId).FirstOrDefault(), //cualquiera ID Descuento comercial
                                       nombre = grupo.Key,
                                       porcentaje = grupo.ToList().Select(item => item.Descuento).Max(),
                                   }).ToList();
            //mandar la lista de categorias como mmodelo
            return listImproRefact;
        }

        public async Task<bool> GetBoolComercialDiscountToAllProductsAsync()
        {
            var TodasLasClases = new OfertaModelDTO { id = 1, nombre = "true", porcentaje = 31 };
            var TodosLosTipos = new OfertaModelDTO { id = 1, nombre = "true", porcentaje = 23 };
            var TodasLasMarcas = new OfertaModelDTO { id = 1, nombre = "true", porcentaje = 5 };
            var TodosLosModelos = new OfertaModelDTO { id = 1, nombre = "true", porcentaje = 50 };
            return false;
        }
    }
}
