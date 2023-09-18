using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public /*abstract*/ class TypeProdViewModel
    {
        public string? Descripcion { get; set; }
        //[NotMapped]
        //[JsonIgnore]
        //public virtual ClassProdViewModel ClassProd { get; set; } = null!;

        //[NotMapped]
        //[JsonIgnore]
        public virtual ICollection<ProdViewModel> Prods { get; set; } = new List<ProdViewModel>();

        public int ? TotalItemsProd { get; set; }
        public int ? TotalPagesProd { get; set; }
        public int ? PageProd { get; set; }
        public int ? NextPageProd { get; set; }
        public int ? PageSizeProd { get; set; }
    }
}
