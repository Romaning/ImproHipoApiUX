using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class BancoProveedor
{
    public int BancoProveedorId { get; set; }

    public string? Nombre { get; set; }

    public string? Swift { get; set; }

    public string? Cuenta { get; set; }

    public int PaisId { get; set; }

    public int Estado { get; set; }

    public int BeneficiarioProveedorId { get; set; }

    public int? TipoBancoProveedorId { get; set; }

    public int? FabricaId { get; set; }

    public int? TraderId { get; set; }

    public virtual Fabrica? Fabrica { get; set; }

    public virtual TipoBancoProveedor? TipoBancoProveedor { get; set; }

    public virtual Trader? Trader { get; set; }
}
