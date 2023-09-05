using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public int TipoClienteId { get; set; }

    public string? NombreRazonSocial { get; set; }

    public string? NitCi { get; set; }

    public string? DireccionFiscal { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Nombres { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? NombreComercial { get; set; }

    public string? TelefonoTrabajoFijo { get; set; }

    public string? TelefonoTrabajoCelular { get; set; }

    public string? TelefonoDomicilioFijo { get; set; }

    public string? TelefonoPersonalCelular { get; set; }

    public string? TelefonoWhatsapp { get; set; }

    public string? Departamento { get; set; }

    public string? Provincia { get; set; }

    public string? Municipio { get; set; }

    public string? AreaZona { get; set; }

    public string? CoordenadaGeoDirFiscal { get; set; }

    public int? EstadoCliente { get; set; }

    public string? Genero { get; set; }

    public string? ProductosInteres { get; set; }

    public string? FacebookPersonal { get; set; }

    public string? FacebookComercial { get; set; }

    public int? Unidad { get; set; }

    public int? Condicion { get; set; }

    public int? Util { get; set; }

    public int ProfesionOficioId { get; set; }

    public int? ProspectoId { get; set; }

    public decimal Meta { get; set; }

    public decimal VolumenMaximo { get; set; }

    public decimal VolumenMinimo { get; set; }

    public int? RubroComercialId { get; set; }

    public int? TecnicoClienteId { get; set; }

    public string? RegistroProfesional { get; set; }

    public string? ComplementoCi { get; set; }

    public int TipoDocId { get; set; }

    public int ExcepcionNit { get; set; }

    public virtual ICollection<Categorizacion> Categorizacions { get; set; } = new List<Categorizacion>();

    public virtual ICollection<ClienteProyecto> ClienteProyectos { get; set; } = new List<ClienteProyecto>();

    public virtual ICollection<CreditoCliente> CreditoClientes { get; set; } = new List<CreditoCliente>();

    public virtual ICollection<DireccionEntrega> DireccionEntregas { get; set; } = new List<DireccionEntrega>();

    public virtual ProfesionOficio ProfesionOficio { get; set; } = null!;

    public virtual Prospecto? Prospecto { get; set; }

    public virtual ICollection<RegistroCliente> RegistroClientes { get; set; } = new List<RegistroCliente>();

    public virtual ICollection<RegistroMetaCliente> RegistroMetaClientes { get; set; } = new List<RegistroMetaCliente>();

    public virtual ICollection<Relacionador> Relacionadors { get; set; } = new List<Relacionador>();

    public virtual RubroComercial? RubroComercial { get; set; }

    public virtual TecnicoCliente? TecnicoCliente { get; set; }

    public virtual TipoCliente TipoCliente { get; set; } = null!;
}
