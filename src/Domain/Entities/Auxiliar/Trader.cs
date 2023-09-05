using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Trader
{
    public int TraderId { get; set; }

    public string? Nombre { get; set; }

    public int? Estado { get; set; }

    public int? PaisId { get; set; }

    public string? PaginaWeb { get; set; }

    public virtual ICollection<BancoProveedor> BancoProveedors { get; set; } = new List<BancoProveedor>();

    public virtual ICollection<ContactoProveedor> ContactoProveedors { get; set; } = new List<ContactoProveedor>();

    public virtual ICollection<DireccionProveedor> DireccionProveedors { get; set; } = new List<DireccionProveedor>();

    public virtual ICollection<FabricaTrader> FabricaTraders { get; set; } = new List<FabricaTrader>();

    public virtual ICollection<ProveedorTrader> ProveedorTraders { get; set; } = new List<ProveedorTrader>();
}
