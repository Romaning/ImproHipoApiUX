using Application.DTOsOwn;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Boundaries
{
    public interface IDescuentoComercialBoundary
    {
        Task<bool> GetBoolComercialDiscountToAllProductsAsync();

        Task<List<OfertaModelDTO>> GetAllClassProdInOfferRefactorEnterpriseAsync();
        Task<List<OfertaModelDTO>> GetAllTypeProdInOfferRefactorEnterpriseAsync();
        Task<List<OfertaModelDTO>> GetAllMarkProdInOfferRefactorEnterpriseAsync();
        Task<List<OfertaModelDTO>> GetAllCategoryProdInOfferRefactorEnterpriseAsync();
        Task<List<OfertaModelDTO>> GetAllProdInOfferRefactorEnterpriseAsync();
    }
}
