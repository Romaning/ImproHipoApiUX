using Application.Gateways;
using Infrastructure.Gateways.Injections;
using Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoreAux = Domain.Entities.Auxiliar.Colore;
using ColoreHipo = Domain.Entities.Hipotina.Colore;
using ColoreImpro = Domain.Entities.Improcons.Colore;
using Domain.Entities.Common;
namespace Infrastructure.Gateways
{
    public class ColorDsGatImpl : DependencyInjectContext, IColorGateway
    {
        public ColorDsGatImpl(ApplicationDbImproContext dbImproContexts, ApplicationDbHipoContext dbHipoContexts, ApplicationDbAuxContext dbAuxContexts)
            : base(dbImproContexts, dbHipoContexts, dbAuxContexts)
        {
        }
        public async Task<IQueryable<ColoreImpro>> FindAllImproAsync()
        {
            try
            {
                IQueryable<ColoreImpro> colors = dbImproContext.Colores;
                return colors;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<ColoreHipo>> FindAllHipoAsync()
        {
            try
            {
                IQueryable<ColoreHipo> colors = dbHipoContext.Colores;
                return colors;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<ColoreAux>> FindAllAuxAsync()
        {
            try
            {
                IQueryable<ColoreAux> colors = dbAuxContext.Colores;
                return colors;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
