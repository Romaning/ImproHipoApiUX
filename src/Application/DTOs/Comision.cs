using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Comision
{
    public int ComisionId { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public decimal VentaCompleta { get; set; }

    public decimal VentaPendiente { get; set; }

    public decimal TotalMes { get; set; }

    public decimal MesAnterior { get; set; }

    public decimal MesAnteriorDos { get; set; }

    public decimal MesAnteriorTres { get; set; }

    public decimal TotalComision { get; set; }

    public decimal BaseCalculo { get; set; }

    public decimal Bono { get; set; }

    public int MetaVendedorId { get; set; }
}
