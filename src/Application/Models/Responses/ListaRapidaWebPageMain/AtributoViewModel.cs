using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public class AtributoViewModel
    {
        public int? DefValueId { get; set; }
        public string? DefDomain { get; set; }

        public string? DefAttrib { get; set; }

        public List<string>? DefAttribs { get; set;}
    }
}
