using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class DireccionProveedor
{
    public int DireccionProveedorId { get; set; }

    public string? Nombre { get; set; }

    public string? Coordenadas { get; set; }

    public int? TipoDireccionId { get; set; }

    public int? FabricaId { get; set; }

    public int? TraderId { get; set; }

    public int? ProvinciaId { get; set; }

    public int? CiudadId { get; set; }

    public virtual Ciudad? Ciudad { get; set; }

    public virtual Fabrica? Fabrica { get; set; }

    public virtual Provincium? Provincia { get; set; }

    public virtual TipoDireccion? TipoDireccion { get; set; }

    public virtual Trader? Trader { get; set; }
}
