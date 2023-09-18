using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class IndustryBase
    {
        public int IndustryId { get; set; }

        public string? Descripcion { get; set; }

        public int Estado { get; set; }
        [NotMapped]
        //[JsonIgnore]
        public virtual ICollection<ProdBase> ProdBases { get; set; } = new List<ProdBase>();
    }
}
