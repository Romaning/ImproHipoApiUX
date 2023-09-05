﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class BeneficiarioProveedor
{
    public int BeneficiarioProveedorId { get; set; }

    public string? Nombre { get; set; }

    public string? Cuenta { get; set; }

    public string? ModalidadPago { get; set; }

    public int Estado { get; set; }

    public int? FabricaId { get; set; }

    public int? TraderId { get; set; }
}
