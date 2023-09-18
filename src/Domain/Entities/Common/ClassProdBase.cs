using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common
{
    public /*abstract*/ class ClassProdBase
    {
        public int ClassProdId { get; set; }

        public string? Descripcion { get; set; }

        public string? DescripcionCorta { get; set; }

        public string? Codificacion { get; set; }

        public int Estado { get; set; }

        public int? Valor { get; set; }

        public int? Util { get; set; }

        [NotMapped]
        //[JsonIgnore]
        public virtual ICollection<TypeProdBase> TypeProdBases { get; set; } = new List<TypeProdBase>();
        //ADICIONADO PARA LA BASE DE DATOS
        //public char? Database { get; set; } = char.MinValue;
    }
}
