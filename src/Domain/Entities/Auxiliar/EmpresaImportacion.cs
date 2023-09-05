using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class EmpresaImportacion
{
    public int EmpresaImportacionId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public string? Correo { get; set; }

    public int? TipoEmpresaImportacionId { get; set; }

    public int? Estado { get; set; }

    public string? Propietario { get; set; }

    public string? Nit { get; set; }

    public virtual ICollection<CostoImportacion> CostoImportacions { get; set; } = new List<CostoImportacion>();

    public virtual TipoEmpresaImportacion? TipoEmpresaImportacion { get; set; }
}
