using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescComImpro = Domain.Entities.Improcons.DescuentoComercial;
using DescComHipo = Domain.Entities.Hipotina.DescuentoComercial;
using DescComAux = Domain.Entities.Auxiliar.DescuentoComercial;
using Domain.Entities.Common;
namespace Application.Gateways
{
    public interface IDescuentoComercialGateway
    {
        Task<IQueryable<DescComImpro>> FindAllImproAsync();
        Task<IQueryable<DescComHipo>> FindAllHipoAsync();
        Task<IQueryable<DescComAux>> FindAllAuxAsync();

        Task<IQueryable<DescComImpro>> FindAllClassProdOfferImproAsync();
        Task<IQueryable<DescComHipo>> FindAllClassProdOfferHipoAsync();
        Task<IQueryable<DescComAux>> FindAllClassProdOfferAuxAsync();
        Task<IQueryable<DescComImpro>> FindAllTypeProdOfferImproAsync();
        Task<IQueryable<DescComHipo>> FindAllTypeProdOfferHipoAsync();
        Task<IQueryable<DescComAux>> FindAllTypeProdOfferAuxAsync();
        Task<IQueryable<DescComImpro>> FindAllCategoryOfferImproAsync();
        Task<IQueryable<DescComHipo>> FindAllCategoryOfferHipoAsync();
        Task<IQueryable<DescComAux>> FindAllCategoryOfferAuxAsync();
        Task<IQueryable<DescComImpro>> FindAllMarkProdOfferImproAsync();
        Task<IQueryable<DescComHipo>> FindAllMarkProdOfferHipoAsync();
        Task<IQueryable<DescComAux>> FindAllMarkProdOfferAuxAsync();
        Task<IQueryable<DescComImpro>> FindAllProdOfferImproAsync();
        Task<IQueryable<DescComHipo>> FindAllProdOfferHipoAsync();
        Task<IQueryable<DescComAux>> FindAllProdOfferAuxAsync();
    }
}
