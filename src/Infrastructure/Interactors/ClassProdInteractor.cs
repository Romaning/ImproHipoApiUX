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

using Domain.Entities.Common;
using Application.Boundaries;
using Application.Gateways;
using Application.DTOs;
using AutoMapper;

namespace Infrastructure.Interactors
{
    public class ClassProdInteractor : IClassProdBoundary
    {
        protected readonly IClassProdGateway iClassProdGateway;
        protected readonly ITypeProdGateway iTypeProdGateway;
        protected readonly IProdGateway iProdGateway;
        protected readonly IMapper iMapper;
        public ClassProdInteractor(IClassProdGateway _iClassProdGateway, ITypeProdGateway _iTypeProdGateway, IProdGateway _iProdGateway, IMapper _iMapper)
        {
            iClassProdGateway = _iClassProdGateway;
            iTypeProdGateway = _iTypeProdGateway;
            iProdGateway = _iProdGateway;
            this.iMapper = _iMapper;
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/
        public async Task<List<ClassProdAux>> GetAllAuxAsync()
        {
            try
            {
                List<ClassProdAux> list = new List<ClassProdAux>();
                list = await iClassProdGateway.FindAllAuxAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdHipo>> GetAllHipoAsync()
        {
            try
            {
                List<ClassProdHipo> list = new List<ClassProdHipo>();
                list = await iClassProdGateway.FindAllHipoAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdImpro>> GetAllImproAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = await iClassProdGateway.FindAllImproAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ClassProd>> GetAllDTOImproAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = await iClassProdGateway.FindAllImproAsync();
                List<ClassProd> listDTO = new List<ClassProd>();

                list.ForEach(classeImpro =>
                {
                    ClassProd classProd = new ClassProd();
                    classProd = iMapper.Map<ClassProd>(classeImpro);
                    //{
                    //    ClassProdId = classeImpro.ClassProdId,
                    //    Descripcion = classeImpro.Descripcion,
                    //    DescripcionCorta = classeImpro.DescripcionCorta,
                    //    Codificacion = classeImpro.Codificacion,
                    //    Estado = classeImpro.Estado,
                    //    Valor = classeImpro.Valor,
                    //    Util = classeImpro.Util
                    //};
                    listDTO.Add(classProd);
                });

                return listDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //todas las clases sin buscar por quien o de que DISTINCT from CLASSPROD all databases
        public async Task<List<ClassProdBase>> GetAllRefactorEnterprisesAsync()
        {
            try
            {
                List<ClassProdImpro> listClassProdImpro = await iClassProdGateway.FindAllImproAsync();
                List<ClassProdHipo> listClassProdHipo = await iClassProdGateway.FindAllHipoAsync();
                List<ClassProdAux> listClassProdAux = await iClassProdGateway.FindAllAuxAsync();
                var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();
                //combina dos listas
                var NewListImproDTO_ImproWith_NewListHipoNotInImpr = new List<ClassProdBase>();
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(listClassProdImpro);
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListHipoNotInImpr);
                var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();
                //combina dos listas
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListAuxNotIn_NewList1);
                var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr;
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //todas las clases sin buscar por quien o de que DISTINCT from CLASSPROD all databases
        public async Task<List<ClassProdBase>> GetAllDiferentsRefactorEnterprisesAsync()
        {
            try
            {
                List<ClassProdImpro> listClassProdImpro = await iClassProdGateway.FindAllImproWebPageAsync();
                List<ClassProdHipo> listClassProdHipo = await iClassProdGateway.FindAllHipoWebPageAsync();
                List<ClassProdAux> listClassProdAux = await iClassProdGateway.FindAllAuxWebPageAsync();
                var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();
                //combina dos listas
                var NewListImproDTO_ImproWith_NewListHipoNotInImpr = new List<ClassProdBase>();
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(listClassProdImpro);
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListHipoNotInImpr);
                var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();
                //combina dos listas
                NewListImproDTO_ImproWith_NewListHipoNotInImpr.AddRange(newListAuxNotIn_NewList1);
                var list = NewListImproDTO_ImproWith_NewListHipoNotInImpr;
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //todas las clases sin buscar por quien o de que DISTINCT from CLASSPROD all databases
        public async Task<List<string>> GetAllDescriocionDiferentsRefactorEnterprisesAsync()
        {
            try
            {
                IQueryable<string> listImpro = await iClassProdGateway.FindAllDescipcionDistinctImproAsync();
                IQueryable<string> listHipo = await iClassProdGateway.FindAllDescipcionDistinctHipoAsync();
                IQueryable<string> listAux = await iClassProdGateway.FindAllDescipcionDistinctAuxAsync();
                List<string> list = new List<string>();
                list.AddRange(listImpro);
                list.AddRange(listHipo);
                list.AddRange(listAux);
                return list.Distinct().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProd>> GetAllRefactorDTOEnterprisesAsync()
        {
            try
            {
                List<ClassProdImpro> listClassProdImpro = await iClassProdGateway.FindAllImproAsync();
                List<ClassProdHipo> listClassProdHipo = await iClassProdGateway.FindAllHipoAsync();
                List<ClassProdAux> listClassProdAux = await iClassProdGateway.FindAllAuxAsync();

                var newListHipoNotInImpr = (listClassProdHipo.Where(x => !listClassProdImpro.Any(y => y.Descripcion == x.Descripcion))).ToList();

                //combina dos listas
                //var NewList1_ImproWith_NewListHipoNotInImpr = listClassProdImpro
                //    .Cast<ClassProdBase>()
                //    .Concat(newListHipoNotInImpr.Cast<ClassProdBase>())
                //    .ToList();
                var NewListImproDTO_ImproWith_NewListHipoNotInImpr = GetCombinedDTOListImproNewHipo(listClassProdImpro, newListHipoNotInImpr);

                var newListAuxNotIn_NewList1 = (listClassProdAux.Where(x => !NewListImproDTO_ImproWith_NewListHipoNotInImpr.Any(y => y.Descripcion == x.Descripcion))).ToList();

                //combine dos listas

                //var list = NewList1_ImproWith_NewListHipoNotInImpr
                //    .Cast<ClassProdBase>()
                //    .Concat(newListAuxNotIn_NewList1.Cast<ClassProdBase>())
                //    .ToList();
                var list = GetCombinedDTOListNewImproDTOWithNewAux(NewListImproDTO_ImproWith_NewListHipoNotInImpr, newListAuxNotIn_NewList1);

                //var verificarLista = list.Select(x => x.Descripcion).ToList();
                //foreach (var item in verificarLista)
                //{
                //    Console.WriteLine(item);
                //}
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClassProd> GetCombinedDTOListImproNewHipo(List<ClassProdImpro> listFromDb1, List<ClassProdHipo> listFromDb2)
        {
            var combinedDTOList = new List<ClassProd>();

            combinedDTOList.AddRange(iMapper.Map<List<ClassProd>>(listFromDb1));
            combinedDTOList.AddRange(iMapper.Map<List<ClassProd>>(listFromDb2));

            return combinedDTOList;
        }

        public List<ClassProd> GetCombinedDTOListNewImproDTOWithNewAux(List<ClassProd> listFromDb1, List<ClassProdAux> listFromDb3)
        {
            var combinedDTOList = new List<ClassProd>();

            combinedDTOList.AddRange(iMapper.Map<List<ClassProd>>(listFromDb1));
            combinedDTOList.AddRange(iMapper.Map<List<ClassProd>>(listFromDb3));

            return combinedDTOList;
        }

        //realciones
        public async Task<List<ClassProdAux>> GetAllWithTypeAndWithClassAuxAsync()
        {
            try
            {
                List<ClassProdAux> list = new List<ClassProdAux>();
                list = await iClassProdGateway.FindAllWith_TypeProdAndWith_ProdAuxAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdHipo>> GetAllWithTypeAndWithClassHipoAsync()
        {
            try
            {
                List<ClassProdHipo> list = new List<ClassProdHipo>();
                list = await iClassProdGateway.FindAllWith_TypeProdAndWith_ProdHipoAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ClassProdImpro>> GetAllWithTypeAndWithClassImproAsync()
        {
            try
            {
                List<ClassProdImpro> list = new List<ClassProdImpro>();
                list = await iClassProdGateway.FindAllWith_TypeProdAndWith_ProdImproAsync();
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
