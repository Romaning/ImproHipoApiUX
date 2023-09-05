using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DireccionNacional
{
    public int DireccionNacionalId { get; set; }

    public string? Nombre { get; set; }

    public string? Coordenadas { get; set; }

    public int? TipoDireccionId { get; set; }

    public int? NacionalId { get; set; }

    public int? ProvinciaId { get; set; }

    public int? CiudadId { get; set; }

    public virtual Ciudad? Ciudad { get; set; }

    public virtual Nacional? Nacional { get; set; }

    public virtual Provincium? Provincia { get; set; }

    public virtual TipoDireccion? TipoDireccion { get; set; }
}
