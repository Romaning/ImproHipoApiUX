using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entities Improcons
using ClassProdImpro = Domain.Entities.Improcons.ClassProd;
//Entities Hipotina
using ClassProdHipo = Domain.Entities.Hipotina.ClassProd;
//Entities Auxiliar
using ClassProdAux = Domain.Entities.Auxiliar.ClassProd;
using Domain.Entities.Common;

namespace Application.Gateways
{
    public interface IClassProdGateway
    {
        /* $$$$$$$$$$$$$$$$$$$$$ START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/
        // TODO: FIND ALL ------------------------------> COMMON
        Task<List<ClassProdImpro>> FindAllImproAsync();
        Task<List<ClassProdHipo>> FindAllHipoAsync();
        Task<List<ClassProdAux>> FindAllAuxAsync();

        // TODO: FIND BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        Task<ClassProdImpro> FindByIdImproAsync(int id);
        Task<ClassProdHipo> FindByIdHipoAsync(int id);
        Task<ClassProdAux> FindByIdAuxAsync(int id);

        // TODO: SAVE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        /* $$$$$$$$$$$$$$$$$$$$$ END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/

        /* $&&&&&&&&&&&&&&&&&&&& START DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
        // TODO: FIND ALL ------------------------------> COMMON
        #region FindAll[Empreas]WebPageAsync
        Task<List<ClassProdImpro>> FindAllImproWebPageAsync();
        Task<List<ClassProdHipo>> FindAllHipoWebPageAsync();
        Task<List<ClassProdAux>> FindAllAuxWebPageAsync();
        #endregion
        
        // TODO: FIND ALL DESCPRIPCIONS DISCTINT
        #region FindAll[Empreas]WebPageAsync
        Task<IQueryable<string>> FindAllDescipcionDistinctImproAsync();
        Task<IQueryable<string>> FindAllDescipcionDistinctHipoAsync();
        Task<IQueryable<string>> FindAllDescipcionDistinctAuxAsync();
        #endregion

        //      TODO: FIND BY ID AND ESTATE
        //      los 3 ewuivalen a 1
        Task<ClassProdImpro> FindByIdAndEstadoImproAsync(int estado);
        Task<ClassProdHipo> FindByIdAndEstadoHipoAsync(int estado);
        Task<ClassProdAux> FindByIdAndEstadoAuxAsync(int estado);

        //      TODO: FIND BY ID AND ESTATE AND DESCRIPTION
        //      los 3 ewuivalen a 1
        Task<ClassProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion);
        Task<ClassProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion);
        Task<ClassProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion);

        // TODO: FIND ALL BY DESCRIPCION
        // los 3 ewuivalen a 1
        Task<List<ClassProdImpro>> FindAllByDescripcionImproAsync(string descripcion);
        Task<List<ClassProdHipo>> FindAllByDescripcionHipoAsync(string descripcion);
        Task<List<ClassProdAux>> FindAllByDescripcionAuxAsync(string descripcion);

        // TODO: FIND All BY ESTADO
        // los 3 ewuivalen a 1
        Task<List<ClassProdImpro>> FindAllByEstadoImproAsync(int estado);
        Task<List<ClassProdHipo>> FindAllByEstadoHipoAsync(int estado);
        Task<List<ClassProdAux>> FindAllByEstadoAuxAsync(int estado);

        //      TODO: FIND ALL BY DESCRIPCION AND ESTATE
        //      los 3 ewuivalen a 1
        Task<List<ClassProdImpro>> FindAllByDescripcionAndEstadoImproAsync(string descripcion, int estado);
        Task<List<ClassProdHipo>> FindAllByDescripcionAndEstadoHipoAsync(string descripcion, int estado);
        Task<List<ClassProdAux>> FindAllByDescripcionAndEstadoAuxAsync(string descripcion, int estado);

        //      TODO: FIND ALL WITH TYPE AND PRODS
        //      los 3 ewuivalen a 1
        Task<List<ClassProdImpro>> FindAllWith_TypeProdAndWith_ProdImproAsync();
        Task<List<ClassProdHipo>> FindAllWith_TypeProdAndWith_ProdHipoAsync();
        Task<List<ClassProdAux>> FindAllWith_TypeProdAndWith_ProdAuxAsync();

        //aqui buscamos en caso de que se exista por relaciones a otras clases
        /* $&&&&&&&&&&&&&&&&&&&& END DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
    }
}
