using Application.Boundaries;
using Domain.Entities.Common;
using Infrastructure.Gateways.Injections;
using Persistence.DbContexts;
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
using Application.Gateways;

namespace Infrastructure.Interactors
{
    public class TypeProdInteractor : ITypeProdBoundary
    {
        protected readonly ITypeProdGateway iTypeProdGateway;
        public TypeProdInteractor(ITypeProdGateway _iTypeProdGateway)
        {
            iTypeProdGateway = _iTypeProdGateway;
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/

        public async Task<List<TypeProdAux>> GetAllAuxAsync()
        {
            try
            {
                List<TypeProdAux> list = new List<TypeProdAux>();
                list = await iTypeProdGateway.FindAllAuxAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdHipo>> GetAllHipoAsync()
        {
            try
            {
                List<TypeProdHipo> list = new List<TypeProdHipo>();
                list = await iTypeProdGateway.FindAllHipoAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TypeProdImpro>> GetAllImproAsync()
        {
            try
            {
                List<TypeProdImpro> list = new List<TypeProdImpro>();
                list = await iTypeProdGateway.FindAllImproAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CONCAT
        //todas las tipos sin buscar por quien o de que DISTINCT from TYPEPROD all databases
        public async Task<List<TypeProdBase>> GetAllRefactorDistinctEnterprisesAsync()
        {
            List<TypeProdImpro> listClassProdImpro = await iTypeProdGateway.FindAllDistinctImproAsync();
            List<TypeProdHipo> listClassProdHipo = await iTypeProdGateway.FindAllDistinctHipoAsync();
            List<TypeProdAux> listClassProdAux = await iTypeProdGateway.FindAllDistinctAuxAsync();
            var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();
            //combina dos listas
            var NewListImproDTO_ImproWith_NewListHipoNotInImpr = new List<TypeProdBase>();
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(listClassProdImpro);
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListHipoNotInImpr);
            var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();
            //combina lista
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListAuxNotIn_NewList1);
            //distinct 
            var ListTiposDescripcion = NewListImproDTO_ImproWith_NewListHipoNotInImpr.Select(x => x.Descripcion).Distinct();
            var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr;
            return list;

            //var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();

            ////combina dos listas
            //var NewListImproDTO_ImproWith_NewListHipoNotInImpr = listClassProdImpro
            //    .Cast<TypeProdBase>()
            //    .Concat(newListHipoNotInImpr.Cast<TypeProdBase>())
            //    .ToList();

            //var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();

            ////combine dos listas
            //var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr
            //    .Cast<TypeProdBase>()
            //    .Concat(newListAuxNotIn_NewList1.Cast<TypeProdBase>())
            //    .ToList();
            //return list;
        }

        //TODO: ADD RANGE
        //todas las typos  DISTINCT from TYPEPROD where CLASE DEscRIPCION = 'ALguna descripcion' all databases
        public async Task<List<TypeProdBase>> GetAllByClassProd_DescripcionRefactorEnterprisesAsync(string descripcionClase)
        {
            //List<TypeProdImpro> listClassProdImpro = await iTypeProdGateway.FindAllByClassProd_DescripcionImproWebPageAsync(descripcionClase);
            //List<TypeProdHipo> listClassProdHipo = await iTypeProdGateway.FindAllByClassProd_DescripcionHipoWebPageAsync(descripcionClase);
            //List<TypeProdAux> listClassProdAux = await iTypeProdGateway.FindAllByClassProd_DescripcionAuxWebPageAsync(descripcionClase);
            List<TypeProdImpro> listClassProdImpro = await iTypeProdGateway.FindAllByClassProd_DescripcionImproWebPageAsync(descripcionClase);
            List<TypeProdHipo> listClassProdHipo = await iTypeProdGateway.FindAllByClassProd_DescripcionHipoWebPageAsync(descripcionClase);
            List<TypeProdAux> listClassProdAux = await iTypeProdGateway.FindAllByClassProd_DescripcionAuxWebPageAsync(descripcionClase);
            var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();
            //combina dos listas
            var NewListImproDTO_ImproWith_NewListHipoNotInImpr = new List<TypeProdBase>();
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(listClassProdImpro);
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListHipoNotInImpr);
            var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();
            //combina lista
            NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListAuxNotIn_NewList1);
            var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr;
            return list;
        }

        public async Task<List<string>> GetAllDescripcionDistinctByClassProd_DescripcionRefactorEnterprisesAsync(string descripcionClase)
        {
            try
            {
                IQueryable<string> listImpro = await iTypeProdGateway.FindAllDescripcionDistinctByClassProd_DescripcionImproAsync(descripcionClase);
                IQueryable<string> listHipo = await iTypeProdGateway.FindAllDescripcionDistinctByClassProd_DescripcionHipoAsync(descripcionClase);
                IQueryable<string> listAux = await iTypeProdGateway.FindAllDescripcionDistinctByClassProd_DescripcionAuxAsync(descripcionClase);
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
    }
}
