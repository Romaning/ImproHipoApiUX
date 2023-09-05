using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EmpleadoAux
{
    public int EmpleadoAuxId { get; set; }

    public int Ci { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Nombre1 { get; set; }

    public string? Nombre2 { get; set; }

    public string? Genero { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Foto { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }

    public int Celular { get; set; }

    public string? Email { get; set; }

    public string? Nua { get; set; }

    public decimal? Dias { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string? CoordenadaGeografica { get; set; }

    public int Activo { get; set; }

    public string? Expedido { get; set; }

    public string? CodigoAsegurado { get; set; }

    public int? ProfesionId { get; set; }

    public int AfpId { get; set; }

    public int SeguroSocialId { get; set; }

    public int? NivelAcademicoId { get; set; }
}
