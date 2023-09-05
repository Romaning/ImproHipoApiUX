using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public class ResumenAttribsViewModel
    {
        public virtual ICollection<AtributoViewModel>? Atributos { get; set; } = new List<AtributoViewModel>();
    }
}
