using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOsOwn
{
    public class CaracteristicasFilterModelDTO
    {
        public decimal? PrecioB { get; set; }
        public int ProdId { get; set; }
        //public List<int>? DefaultValueBase.ProdId { get; set; }
        public ICollection<DefaultValueBase>? DefaultValueBases { get; set; }
        public MarkBase? MarkBase { get; set; }
        public CategoryBase? Category { get; set; }
        public IndustryBase? IndustryBase { get; set; }
        public ICollection<ArchivosProductoBase>? ArchivosProductoBases { get; set; }
    }
}
