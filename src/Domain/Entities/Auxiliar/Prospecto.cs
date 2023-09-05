using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Prospecto
{
    public int ProspectoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string CelularTeléfono { get; set; } = null!;

    public string? Dirección { get; set; }

    public string? Correo { get; set; }

    public string? Recomendador { get; set; }

    public string? ProductoInteres { get; set; }

    public int Tipo { get; set; }

    public DateTime FechaVisita { get; set; }

    public string? NombreRazonSocial { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
