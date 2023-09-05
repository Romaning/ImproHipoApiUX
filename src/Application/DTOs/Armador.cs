using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Armador
{
    public int ArmadorId { get; set; }

    public string? Nombre { get; set; }

    public string? Descricpion { get; set; }

    public int? ProdId { get; set; }

    public virtual ICollection<ItemsArmador> ItemsArmadors { get; set; } = new List<ItemsArmador>();
}
