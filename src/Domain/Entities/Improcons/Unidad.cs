using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Unidad
{
    public int UnidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreCorto { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string Ip { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public int? Sucursal { get; set; }

    public virtual ICollection<AddressIp> AddressIps { get; set; } = new List<AddressIp>();

    public virtual ICollection<Almacen> Almacens { get; set; } = new List<Almacen>();

    public virtual ICollection<Despachante> Despachantes { get; set; } = new List<Despachante>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();

    public virtual ICollection<FechaEspecial> FechaEspecials { get; set; } = new List<FechaEspecial>();

    public virtual ICollection<NumeroDocumentoActivo> NumeroDocumentoActivos { get; set; } = new List<NumeroDocumentoActivo>();

    public virtual ICollection<NumeroDocumento> NumeroDocumentos { get; set; } = new List<NumeroDocumento>();

    public virtual ICollection<SolicitanteActivo> SolicitanteActivos { get; set; } = new List<SolicitanteActivo>();

    public virtual ICollection<Solicitante> Solicitantes { get; set; } = new List<Solicitante>();

    public virtual ICollection<UnitUser> UnitUsers { get; set; } = new List<UnitUser>();
}
