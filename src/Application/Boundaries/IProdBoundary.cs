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
using Application.DTOsOwn;
using Application.Models.Responses.ListaRapidaWebPageMain;

namespace Application.Boundaries
{
    public interface IProdBoundary
    {
        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/
        Task<List<ProdImpro>> GetAllImproAsync();
        Task<List<ProdHipo>> GetAllHipoAsync();
        Task<List<ProdAux>> GetAllAuxAsync();
        // GET BY ID (BUSCAR POR ID) -------------------> COMMON
        // los 3 ewuivalen a 1

        // CREATE (MANDAR PARAMS PARA CREAR NUEVO) -------------------> COMMON
        // los 3 ewuivalen a 1

        // STORE (GUARDAR NUEVO) -------------------> COMMON
        // los 3 ewuivalen a 1

        // EDIT (MANDAR PARAMS PARA ACTUALIZAR LOS PROP POR ID) -------------------> COMMON
        // los 3 ewuivalen a 1

        // UPDATE (ACTUALIZAR POR ID)-------------------> COMMON
        // los 3 ewuivalen a 1

        // DESTROY (ELIMNAR POR ID)-------------------> COMMON
        // los 3 ewuivalen a 1
        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/

        /* $&&&&&&&&&&&&&&&&&&&& START PROPIOS &&&&&&&&&&&&&&&&&&&&*/
        Task<List<ProdBase>> GetAllWitoutRefactEnterpriseAsync();

        Task<List<ProdBase>> GetTheBestSalesEnterpriseAsync();

        Task<List<string>> GetAllShortDescriptionsDistinctByDescripcionCompletaEnterpriseAsync(string descripcionCompleta);

        Task<List<ProdBase>> GetAllByTypeProd_DescripcionRefactorEnterprisesAsync(string descripcionTipo);//Task<List<TypeProdBase>> GetAllByEstadoAndClassProd_DescripcionAndEstadoRefactorEnterprisesAsync(string descripcionClase);

        Task<List<string>> GetAllDescripionDistinctByTypeProd_DescripcionRefactorEnterprisesAsync(string descripcionTipo);//Task<List<TypeProdBase>> GetAllByEstadoAndClassProd_DescripcionAndEstadoRefactorEnterprisesAsync(string descripcionClase);
        /* $&&&&&&&&&&&&&&&&&&&& END PROPIOS &&&&&&&&&&&&&&&&&&&&*/
        //RENDERS
        Task<IEnumerable<string?>> RenderModel(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<CategoryViewModel?>> RenderModels(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<string?>> RenderMarca(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<MarkViewModel?>> RenderMarcas(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<ArchivosImagenViewModel>> RenderArchivosImagenes(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<IndustryViewModel>> RenderIndustrias(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        //Task<bool> OfertaActiva(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionCrotaProdBy, string descripcionClassBy, string descripcionTypeBy);

        Task<IEnumerable<AtributoViewModel?>> RenderAtributos(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<PriceViewModel?>> RenderProdsEspecYPrecios(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
        Task<IEnumerable<ColoresProdViewModel?>> RenderColores(IEnumerable<CaracteristicasFilterModelDTO> carateristicas, IEnumerable<ColoreBase> coloresBases, string? descripcionProdBy, string descripcionClassBy, string descripcionTypeBy);
    }
}
