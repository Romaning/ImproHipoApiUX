using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassProdAux = Domain.Entities.Auxiliar.ClassProd;
using ClassProdHipo = Domain.Entities.Hipotina.ClassProd;
using ClassProdImpro = Domain.Entities.Improcons.ClassProd;
using Domain.Entities.Common;
using Application.DTOs;

namespace Application.Boundaries
{
    public interface IClassProdBoundary
    {
        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD*/
        Task<List<ClassProdImpro>> GetAllImproAsync();
        //TODO: list impro to List DTO
        Task<List<ClassProd>> GetAllDTOImproAsync();
        Task<List<ClassProdHipo>> GetAllHipoAsync();
        Task<List<ClassProdAux>> GetAllAuxAsync();
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
        //refactorizacion con
        Task<List<ClassProdBase>> GetAllRefactorEnterprisesAsync();
        Task<List<ClassProdBase>> GetAllDiferentsRefactorEnterprisesAsync();
        Task<List<string>> GetAllDescriocionDiferentsRefactorEnterprisesAsync();
        //refactorizacion con varios dentro DTO
        Task<List<ClassProd>> GetAllRefactorDTOEnterprisesAsync();
        //get all with Type AND with Class
        Task<List<ClassProdImpro>> GetAllWithTypeAndWithClassImproAsync();
        Task<List<ClassProdHipo>> GetAllWithTypeAndWithClassHipoAsync();
        Task<List<ClassProdAux>> GetAllWithTypeAndWithClassAuxAsync();
        /* $&&&&&&&&&&&&&&&&&&&& END PROPIOS &&&&&&&&&&&&&&&&&&&&*/
    }
}
