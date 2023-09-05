using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Empresa
{
    public int EmpresaId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono1 { get; set; }

    public int? Telefono2 { get; set; }

    public string? Propietario { get; set; }

    public int Estado { get; set; }

    public string? Nit { get; set; }

    public int TipoEmpresaId { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();

    public virtual TipoEmpresa TipoEmpresa { get; set; } = null!;
}
