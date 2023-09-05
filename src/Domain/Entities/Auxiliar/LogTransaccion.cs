using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class LogTransaccion
{
    public int LogTransaccionId { get; set; }

    public string? Evento { get; set; }

    public string? Tabla { get; set; }

    public string? Pk { get; set; }

    public string? Campo { get; set; }

    public string? ValorOriginal { get; set; }

    public string? ValorNuevo { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Usuario { get; set; }

    public string? Aplicacion { get; set; }

    public string? Terminal { get; set; }

    public string? Dato { get; set; }

    public string? UserName { get; set; }
}
