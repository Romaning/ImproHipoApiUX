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


using Domain.Entities.Common;

namespace Application.Gateways
{
    public interface ITypeProdGateway
    {
        /* $$$$$$$$$$$$$$$$$$$$$ START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/
        // TODO: FIND ALL TYPES ------------------------------> COMMON
        Task<List<TypeProdImpro>> FindAllImproAsync();
        Task<List<TypeProdHipo>> FindAllHipoAsync();
        Task<List<TypeProdAux>> FindAllAuxAsync();
        // TODO: FIND BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        Task<TypeProdImpro> FindByIdImproAsync(int id);
        Task<TypeProdHipo> FindByIdHipoAsync(int id);
        Task<TypeProdAux> FindByIdAuxAsync(int id);

        // TODO: SAVE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        /* $$$$$$$$$$$$$$$$$$$$$ END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/

        /* $&&&&&&&&&&&&&&&&&&&& START DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
        // TODO: FIND ALL TYPES ------------------------------> COMMON
        Task<List<TypeProdImpro>> FindAllDistinctImproAsync();
        Task<List<TypeProdHipo>> FindAllDistinctHipoAsync();
        Task<List<TypeProdAux>> FindAllDistinctAuxAsync();

        //      TODO: FIND BY ID AND ESTATE
        //      los 3 ewuivalen a 1
        Task<TypeProdImpro> FindByIdAndEstadoImproAsync(int estado);
        Task<TypeProdHipo> FindByIdAndEstadoHipoAsync(int estado);
        Task<TypeProdAux> FindByIdAndEstadoAuxAsync(int estado);

        //      TODO: FIND BY ID AND ESTATE AND DESCRIPTION
        //      los 3 ewuivalen a 1
        Task<TypeProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion);
        Task<TypeProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion);
        Task<TypeProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion);

        // TODO: FIND ALL BY DESCRIPCION
        // los 3 ewuivalen a 1
        Task<List<TypeProdImpro>> FindAllByDescripcionImproAsync(string descripcion);
        Task<List<TypeProdHipo>> FindAllByDescripcionHipoAsync(string descripcion);
        Task<List<TypeProdAux>> FindAllByDescripcionAuxAsync(string descripcion);

        // TODO: FIND All BY ESTADO
        // los 3 ewuivalen a 1
        Task<List<TypeProdImpro>> FindAllByEstadoImproAsync(int estado);
        Task<List<TypeProdHipo>> FindAllByEstadoHipoAsync(int estado);
        Task<List<TypeProdAux>> FindAllByEstadoAuxAsync(int estado);

        //      TODO: FIND ALL BY DESCRIPCION AND ESTATE
        //      los 3 ewuivalen a 1
        Task<List<TypeProdImpro>> FindAllByDescripcionAndEstadoImproAsync(string descripcion, int estado);
        Task<List<TypeProdHipo>> FindAllByDescripcionAndEstadoHipoAsync(string descripcion, int estado);
        Task<List<TypeProdAux>> FindAllByDescripcionAndEstadoAuxAsync(string descripcion, int estado);

        // TODO: FIND ALL BY (CLASS PROD su DESCRIPCION)
        //      los 3 ewuivalen a 1
        #region FindAllByClassProd_Descripcion[EMPRESA]
        Task<List<TypeProdImpro>> FindAllByClassProd_DescripcionImproAsync(string descripcionClase);
        Task<List<TypeProdHipo>> FindAllByClassProd_DescripcionHipoAsync(string descripcionClase);
        Task<List<TypeProdAux>> FindAllByClassProd_DescripcionAuxAsync(string descripcionClase);
        #endregion


        #region FindAllByClassProd_Descripcion[$$$$$ EMPRESA $$$$$] [$$$$$ WebPage $$$$$]Async
        Task<List<TypeProdImpro>> FindAllByClassProd_DescripcionImproWebPageAsync(string descripcionClase);
        Task<List<TypeProdHipo>> FindAllByClassProd_DescripcionHipoWebPageAsync(string descripcionClase);
        Task<List<TypeProdAux>> FindAllByClassProd_DescripcionAuxWebPageAsync(string descripcionClase);
        #endregion
        
        //      los 3 ewuivalen a 1
        #region FindAllDescripcionDistinctByClassProd_Descripcion[EMPRESA]
        Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionImproAsync(string descripcionClase);
        Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionHipoAsync(string descripcionClase);
        Task<IQueryable<string>> FindAllDescripcionDistinctByClassProd_DescripcionAuxAsync(string descripcionClase);
        #endregion

        // TODO: FIND ALL BY ESTATE AND (CLASS PROD DESCRIPCION)
        //      los 3 ewuivalen a 1
        Task<List<TypeProdImpro>> FindAllByEstadoAndClassProd_DescripcionImproAsync(int estado, string descripcionClase);
        Task<List<TypeProdHipo>> FindAllByEstadoAndClassProd_DescripcionHipoAsync(int estado, string descripcionClase);
        Task<List<TypeProdAux>> FindAllByEstadoAndClassProd_DescripcionAuxAsync(int estado, string descripcionClase);
        /* $&&&&&&&&&&&&&&&&&&&& END DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
    }
}
