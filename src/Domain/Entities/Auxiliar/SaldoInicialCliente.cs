using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class SaldoInicialCliente
{
    public int SaldoInicialClienteId { get; set; }

    public int ClienteId { get; set; }

    public decimal Afavor { get; set; }

    public decimal EnContra { get; set; }

    public int RelacionadorClienteId { get; set; }

    public DateTime FechaInicial { get; set; }

    public int UnidadId { get; set; }
}
