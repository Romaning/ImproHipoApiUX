using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class RegistroCambioLista
{
    public int RegistroCambioListasId { get; set; }

    public int ListaAnterior { get; set; }

    public int ListaActual { get; set; }

    public decimal PorcentajeAnterior { get; set; }

    public decimal PorcentajeActual { get; set; }

    public DateTime Fecha { get; set; }

    public string? NombreAnterior { get; set; }

    public string? NombreActual { get; set; }
}
