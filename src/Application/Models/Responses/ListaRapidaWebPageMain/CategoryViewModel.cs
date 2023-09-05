using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models.Responses.ListaRapidaWebPageMain;

public /*partial*/ class CategoryViewModel
{
    public string? Descripcion { get; set; }

    //[NotMapped]
    //public virtual ICollection<ProdViewModel> Prods { get; set; } = new List<ProdViewModel>();
}
