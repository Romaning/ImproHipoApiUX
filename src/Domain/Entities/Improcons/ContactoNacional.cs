﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ContactoNacional
{
    public int ContactoNacionalId { get; set; }

    public string? Nombre { get; set; }

    public string? Cargo { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public int? NacionalId { get; set; }

    public virtual Nacional? Nacional { get; set; }
}
