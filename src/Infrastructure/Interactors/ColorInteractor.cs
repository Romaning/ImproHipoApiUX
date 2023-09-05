using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entities Improcons
using ColoreImpro = Domain.Entities.Improcons.Colore;
//Entities Hipotina
using ColoreHipo = Domain.Entities.Hipotina.Colore;
//Entities Auxiliar
using ColoreAux = Domain.Entities.Auxiliar.Colore;
using Domain.Entities.Common;

using Application.Gateways;
using Application.Boundaries;

namespace Infrastructure.Interactors
{
    public class ColorInteractor : IColorIBoundary
    {
        protected readonly IColorGateway iColorGateway;

        public ColorInteractor(IColorGateway colorGateway)
        {
            iColorGateway = colorGateway;
        }
        public async Task<List<ColoreBase>> GetAllWitoutRefactEnterpriseAsync()
        {
			try
			{
                IEnumerable<ColoreImpro> listImpro = await iColorGateway.FindAllImproAsync();
                //List<ColoreHipo> listHipo = await iColorGateway.FindAllHipoAsync();
                //List<ColoreAux> listAux = await iColorGateway.FindAllAuxAsync();
                List<ColoreBase> list = new List<ColoreBase>();
                list.AddRange(listImpro);
                //list.AddRange(listHipo);
                //list.AddRange(listAux);
                return list.ToList();
			}
			catch (Exception ex)
			{
                throw new Exception(ex.Message);
            }
        }
    }
}
