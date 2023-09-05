using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Cotizacion
{
    public int CotizacionId { get; set; }

    public int? Codigo { get; set; }

    public int Tipo { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Telefono { get; set; }

    public string? DireccionEntrega { get; set; }

    public DateTime? FechaPedido { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int Plazo { get; set; }

    public DateTime Validez { get; set; }

    public int UsuarioId { get; set; }

    public decimal TipoCambio { get; set; }

    public int Moneda { get; set; }

    public int PersonaContacto { get; set; }

    public int PersonaResponsable { get; set; }

    public int PersonaRecomendador { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }

    public decimal TotalMoneda1 { get; set; }

    public decimal TotalMoneda2 { get; set; }

    public decimal DescuentoValor { get; set; }

    public int DescuentoPorcentaje { get; set; }

    public decimal PrecioOferta { get; set; }

    public decimal DescuentoFraccion { get; set; }

    public int ClientId { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string? Observaciones { get; set; }

    public int UnidadId { get; set; }

    public string? UsuarioEmail { get; set; }

    public string? UsuarioNombreCompleto { get; set; }

    public int? PredId { get; set; }

    public int ProyectoId { get; set; }

    public DateTime FechaCierre { get; set; }

    public int? ProformaId { get; set; }

    public string? OpenedBy { get; set; }

    public int CanalDistribucionId { get; set; }

    public decimal DiferenciaTc { get; set; }

    public DateTime FechaEntrega { get; set; }

    public virtual ICollection<CotizacionProyecto> CotizacionProyectos { get; set; } = new List<CotizacionProyecto>();
}
