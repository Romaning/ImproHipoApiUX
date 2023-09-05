using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Talonario
{
    public int TalonarioId { get; set; }

    public int Tipo { get; set; }

    public int UnidadId { get; set; }

    public string? NroAutorizacion { get; set; }

    public string? NroInicio { get; set; }

    public string? NroFin { get; set; }

    public DateTime FechaLimite { get; set; }

    public string? CodDosificacion { get; set; }

    public int Activo { get; set; }

    public string? ConfNitEmisor { get; set; }

    public string? ConfEstadoImpre { get; set; }

    public string? ConfRubro1 { get; set; }

    public string? ConfRubro2 { get; set; }

    public string? ConfRubro3 { get; set; }

    public string? ConfSucursalNro { get; set; }

    public string? ConfSucursalDir1 { get; set; }

    public string? ConfSucursalDir2 { get; set; }

    public string? ConfSucursalCiudad { get; set; }

    public string? ConfCiudad { get; set; }

    public string? ConfLeyenda1 { get; set; }

    public string? ConfLeyenda2 { get; set; }

    public int? Numero { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActivacion { get; set; }

    public DateTime? FechaDesactivacion { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public DateTime? FechaInicioUso { get; set; }

    public DateTime? FechaFinUso { get; set; }

    public int? Util { get; set; }

    public string? NroTramite { get; set; }

    public string? Tag { get; set; }
}
