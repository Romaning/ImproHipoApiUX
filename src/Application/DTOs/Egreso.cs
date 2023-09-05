using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Egreso
{
    public int EgresoId { get; set; }

    public int CobranzaId { get; set; }

    public int CobranzaNumero { get; set; }

    public int DocumentoAutorizacionId { get; set; }

    public int UnidadId { get; set; }

    public int CustomerId { get; set; }

    public DateTime Fecha { get; set; }

    public int UsuarioId { get; set; }

    public decimal SaldoFavor { get; set; }

    public decimal Importe { get; set; }

    public int Moneda { get; set; }

    public decimal TipoCambio { get; set; }

    public string? Observaciones { get; set; }

    public int Estado { get; set; }

    public int Activo { get; set; }

    public int Util { get; set; }

    public decimal SaldoDeudor { get; set; }

    public decimal ImporteSus { get; set; }

    public decimal TotalSus { get; set; }

    public decimal CambioSus { get; set; }

    public decimal VarSus { get; set; }

    public decimal ImporteBs { get; set; }

    public decimal TotalBs { get; set; }

    public decimal CambioBs { get; set; }

    public decimal CambioSusBs { get; set; }

    public decimal VarBs { get; set; }

    public int TipoLiquidacion { get; set; }

    public string? ImporteLit { get; set; }

    public int DevolverBs { get; set; }

    public int ConfUtil { get; set; }

    public decimal ValUtil { get; set; }

    public string? IdUsuario { get; set; }

    public DateTime FechaCierre { get; set; }
}
