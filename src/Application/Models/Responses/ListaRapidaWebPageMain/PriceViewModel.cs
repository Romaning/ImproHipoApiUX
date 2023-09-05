using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public class PriceViewModel
    {
        //Default value
        public int ProdId { get; set; }
        public int DefaultValueID { get; set; }
        //propio
        public decimal ? Precio { get; set; }
        public virtual ICollection<AtributoViewModel>? Atributos { get; set; } = new List<AtributoViewModel>();
    }
}
