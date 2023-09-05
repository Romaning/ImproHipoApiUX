using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common
{
    public /*abstract*/ class TypeProdBase
    {
        public int TypeProdId { get; set; }

        public int ClassProdId { get; set; }

        public string? Descripcion { get; set; }

        public string? DescripcionCorta { get; set; }

        public string? Codificacion { get; set; }

        public int Estado { get; set; }

        public int? Valor { get; set; }

        public int? Util { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ClassProdBase ClassProdBase { get; set; } = null!;

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<ProdBase> ProdBases { get; set; } = new List<ProdBase>();
        
        //ADICIONADO PARA LA BASE DE DATOS
        //public char? Database { get; set; } = char.MinValue;
    }
}
