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
using Domain.Entities.Common;

namespace Application.Gateways
{
    public interface IProdGateway
    {
        /* $$$$$$$$$$$$$$$$$$$$$ START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/
        // TODO: FIND ALL ------------------------------> COMMON
        Task<List<ProdImpro>> FindAllImproAsync();
        Task<List<ProdHipo>> FindAllHipoAsync();
        Task<List<ProdAux>> FindAllAuxAsync();
        // TODO: FIND BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        Task<ProdImpro> FindByIdImproAsync(int id);
        Task<ProdHipo> FindByIdHipoAsync(int id);
        Task<ProdAux> FindByIdAuxAsync(int id);

        // TODO: SAVE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE ------------------------------> COMMON
        // los 3 ewuivalen a 1

        //TODO: DELETE BY ID ------------------------------> COMMON
        // los 3 ewuivalen a 1
        /* $$$$$$$$$$$$$$$$$$$$$ END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD $$$$$$$$$$$$$$$*/

        /* $&&&&&&&&&&&&&&&&&&&& START DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
        // TODO: FIND ALL ------------------------------> COMMON
        Task<List<ProdImpro>> FindAllPARAMSImproAsync();
        Task<List<ProdHipo>> FindAllPARAMSHipoAsync();
        Task<List<ProdAux>> FindAllPARAMSAuxAsync();
        //      TODO: FIND BY ID AND ESTATE
        //      los 3 ewuivalen a 1
        Task<ProdImpro> FindByIdAndEstadoImproAsync(int estado);
        Task<ProdHipo> FindByIdAndEstadoHipoAsync(int estado);
        Task<ProdAux> FindByIdAndEstadoAuxAsync(int estado);

        //      TODO: FIND BY ID AND ESTATE AND DESCRIPTION completa
        //      los 3 ewuivalen a 1
        Task<ProdImpro> FindByIdAndEstadoAndDescripcionImproAsync(int id, int estado, string descripcion);
        Task<ProdHipo> FindByIdAndEstadoAndDescripcionHipoAsync(int id, int estado, string descripcion);
        Task<ProdAux> FindByIdAndEstadoAndDescripcionAuxAsync(int id, int estado, string descripcion);

        // TODO: FIND ALL BY DESCRIPCION completa
        // los 3 ewuivalen a 1
        Task<List<ProdImpro>> FindAllByDescripcionCompletaImproAsync(string descripcion);
        Task<List<ProdHipo>> FindAllByDescripcionCompletaHipoAsync(string descripcion);
        Task<List<ProdAux>> FindAllByDescripcionCompletaAuxAsync(string descripcion);

        // TODO: FIND All BY ESTADO
        // los 3 ewuivalen a 1
        Task<List<ProdImpro>> FindAllByEstadoImproAsync(int estado);
        Task<List<ProdHipo>> FindAllByEstadoHipoAsync(int estado);
        Task<List<ProdAux>> FindAllByEstadoAuxAsync(int estado);

        //      TODO: FIND ALL BY DESCRIPCION completa AND ESTATE
        //      los 3 ewuivalen a 1
        Task<List<ProdImpro>> FindAllByDescripcionCompletaAndEstadoImproAsync(string descripcion, int estado);
        Task<List<ProdHipo>> FindAllByDescripcionCompletaAndEstadoHipoAsync(string descripcion, int estado);
        Task<List<ProdAux>> FindAllByDescripcionCompletaAndEstadoAuxAsync(string descripcion, int estado);

        // TODO: FIND ALL BY (Type PROD su DESCRIPCION)
        //      los 3 ewuivalen a 1
        #region FindAllByTypeProd_Descripcion[EMPRESA]Async
        Task<List<ProdImpro>> FindAllByTypeProd_DescripcionImproAsync(string descripcionTipo);
        Task<List<ProdHipo>> FindAllByTypeProd_DescripcionHipoAsync(string descripcionTipo);
        Task<List<ProdAux>> FindAllByTypeProd_DescripcionAuxAsync(string descripcionTipo);
        #endregion

        //equivalent, with consults personalized
        #region FindAllByTypeProd_Descripcion[$$$$$$$ EMPRESA $$$$$$] [$$$$$ WebPage $$$$$$]Async
        Task<List<ProdImpro>> FindAllByTypeProd_DescripcionImproWebPageAsync(string descripcionTipo);
        Task<List<ProdHipo>> FindAllByTypeProd_DescripcionHipoWebPageAsync(string descripcionTipo);
        Task<List<ProdAux>> FindAllByTypeProd_DescripcionAuxWebPageAsync(string descripcionTipo);
        #endregion

        //equivalent, with consults personalized
        #region FindAllByTypeProd_Descripcion[$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionImproAsync(string descripcionTipo);
        Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionHipoAsync(string descripcionTipo);
        Task<IQueryable<string>> FindAllDescripcionDistinctByTypeProd_DescripcionAuxAsync(string descripcionTipo);
        #endregion

        //CARACTERISTICAS DE PRODCUTO PARA WEB
        #region PROPIEDADES DE PRODUCTO
        #region Fin all DESCRIPCION CORTAS by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllDescriptionCompletByDescripcionCortaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all PRICES by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllPricesByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllPricesByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllPricesByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all COLORS by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllColorsByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllColorsByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllColorsByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all IMAGES by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllImagesByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllImagesByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllImagesByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all MARCAS by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllMarkByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllMarkByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllMarkByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all CATEGORIAS by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllCategoriesByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion

        #region Fin all ATRIBUTOS DefaultATTRIBS da, DefaultVALUE dv, DefaultDOMAIN dd by Descripcion [$$$$$$$ EMPRESA $$$$$$]Async
        Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaImproAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaHipoAsync(string descripcionCompleta);
        Task<IQueryable<string>> FindAllAttribsByDescripcionCompletaAuxAsync(string descripcionCompleta);
        #endregion
        #endregion
        // TODO: FIND ALL BY ESTATE AND (Type PROD DESCRIPCION)
        //      los 3 ewuivalen a 1

        #region LOS 30 MAS VENDIDOS POR EMPRESA
        Task<List<ProdImpro>> FindTheBestSalesImproAsync();
        Task<List<ProdHipo>> FindTheBestSalesHipoAsync();
        Task<List<ProdAux>> FindTheBestSalesAuxAsync();
        #endregion
        Task<List<ProdImpro>> FindAllByEstadoAndClassProd_DescripcionImproAsync(int estado, string descripcionTipo);
        Task<List<ProdHipo>> FindAllByEstadoAndClassProd_DescripcionHipoAsync(int estado, string descripcionTípo);
        Task<List<ProdAux>> FindAllByEstadoAndClassProd_DescripcionAuxAsync(int estado, string descripcionTipo);
        /* $&&&&&&&&&&&&&&&&&&&& END DIFERENTS &&&&&&&&&&&&&&&&&&&&*/
    }
}
