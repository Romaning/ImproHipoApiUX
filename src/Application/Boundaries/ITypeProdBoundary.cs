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
namespace Application.Boundaries
{
    public interface ITypeProdBoundary
    {
        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/
        // GET ALL (BUSCAR) -------------------> COMMON
        Task<List<TypeProdImpro>> GetAllImproAsync();
        Task<List<TypeProdHipo>> GetAllHipoAsync();
        Task<List<TypeProdAux>> GetAllAuxAsync();
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
        //get all distincts TypeProd
        Task<List<TypeProdBase>> GetAllRefactorDistinctEnterprisesAsync();

        //refactorizacion con varios dentro DTO
        Task<List<TypeProdBase>> GetAllByClassProd_DescripcionRefactorEnterprisesAsync(string descripcionClase);//Task<List<TypeProdBase>> GetAllByEstadoAndClassProd_DescripcionAndEstadoRefactorEnterprisesAsync(string descripcionClase);
        Task<List<string>> GetAllDescripcionDistinctByClassProd_DescripcionRefactorEnterprisesAsync(string descripcionClase);//Task<List<TypeProdBase>> GetAllByEstadoAndClassProd_DescripcionAndEstadoRefactorEnterprisesAsync(string descripcionClase);
        /* $&&&&&&&&&&&&&&&&&&&& END PROPIOS &&&&&&&&&&&&&&&&&&&&*/
    }
}
