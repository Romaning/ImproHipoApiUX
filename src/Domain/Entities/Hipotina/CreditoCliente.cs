using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CreditoCliente
{
    public int CreditoClienteId { get; set; }

    public decimal VolumenCredito { get; set; }

    public decimal LimiteCredito { get; set; }

    public decimal DisponibleCredito { get; set; }

    public int ClienteId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public DateTime FechaGracia { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int Validez { get; set; }

    public int Estado { get; set; }

    public int Alta { get; set; }

    public int FijoRenovable { get; set; }

    public string? UnidadEmisionCredito { get; set; }

    public int Finalizado { get; set; }

    public int UnidadId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
