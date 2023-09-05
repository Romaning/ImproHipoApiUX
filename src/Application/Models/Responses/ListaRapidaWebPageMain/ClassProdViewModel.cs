using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public /*abstract*/ class ClassProdViewModel
    {
        public string? Descripcion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<TypeProdViewModel> TypeProds { get; set; } = new List<TypeProdViewModel>();
    }
}
