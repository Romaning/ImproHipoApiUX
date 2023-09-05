using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

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

    public string? CodigoAsegurado { get; set; }

    public int? ProfesionId { get; set; }

    public int AfpId { get; set; }

    public int SeguroSocialId { get; set; }

    public int? NivelAcademicoId { get; set; }

    public string? Expedido { get; set; }

    public virtual Afp Afp { get; set; } = null!;

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<EmpleadoBiometrico> EmpleadoBiometricos { get; set; } = new List<EmpleadoBiometrico>();

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();

    public virtual ICollection<Garante> Garantes { get; set; } = new List<Garante>();

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    public virtual ICollection<IncrementoVacacion> IncrementoVacacions { get; set; } = new List<IncrementoVacacion>();

    public virtual NivelAcademico? NivelAcademico { get; set; }

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    public virtual Profesion? Profesion { get; set; }

    public virtual ICollection<Sancion> Sancions { get; set; } = new List<Sancion>();

    public virtual SeguroSocial SeguroSocial { get; set; } = null!;

    public virtual ICollection<Vacacion> Vacacions { get; set; } = new List<Vacacion>();
}
