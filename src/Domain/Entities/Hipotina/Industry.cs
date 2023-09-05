using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Hipotina
{
    public class Industry : IndustryBase
    {
        //atributos
        public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
    }
}
