using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoBancoProveedor
{
    public int TipoBancoProveedorId { get; set; }

    public string? Nombre { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<BancoProveedor> BancoProveedors { get; set; } = new List<BancoProveedor>();
}
