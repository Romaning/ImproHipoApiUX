using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Proyecto
{
    public int ProyectoId { get; set; }

    public string NombreProyecto { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string? Responsable { get; set; }

    public string? Supervisor { get; set; }

    public decimal Descuento { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int Estado { get; set; }

    public int PrecioDiferenciadoId { get; set; }

    public string? Usuario { get; set; }

    public int UnidadId { get; set; }

    public string? DescripcionCerrado { get; set; }

    public string? Departamento { get; set; }

    public virtual ICollection<ClienteProyecto> ClienteProyectos { get; set; } = new List<ClienteProyecto>();

    public virtual ICollection<CotizacionProyecto> CotizacionProyectos { get; set; } = new List<CotizacionProyecto>();

    public virtual ICollection<ProyectoDetallePedido> ProyectoDetallePedidos { get; set; } = new List<ProyectoDetallePedido>();
}
