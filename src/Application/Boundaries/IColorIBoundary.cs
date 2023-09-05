using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoreImpro = Domain.Entities.Improcons.Colore;
using ColoreHipo = Domain.Entities.Hipotina.Colore;
using ColoreAux = Domain.Entities.Auxiliar.Colore;
using Domain.Entities.Common;

namespace Application.Boundaries
{
    public interface IColorIBoundary
    {
        Task<List<ColoreBase>> GetAllWitoutRefactEnterpriseAsync();
    }
}
