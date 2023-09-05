using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class SolicitudVendedor
{
    public int SolicitudVendedorId { get; set; }

    public string? UsuarioEmail { get; set; }

    public string? UsuarioNombreCompleto { get; set; }

    public string? Pedido { get; set; }

    public string? FacturaComercial { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? FechaComercializacionInicio { get; set; }

    public DateTime? FechaComercializacionFin { get; set; }

    public int? Estado { get; set; }

    public int? UnidadId { get; set; }

    public int TipoSolicitudVendedorId { get; set; }

    public int Finalizado { get; set; }

    public virtual ICollection<DetalleSolicitudVendedor> DetalleSolicitudVendedors { get; set; } = new List<DetalleSolicitudVendedor>();

    public virtual TipoSolicitudVendedor TipoSolicitudVendedor { get; set; } = null!;
}
