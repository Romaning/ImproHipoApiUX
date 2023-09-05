﻿using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class RegistroBiometrico
{
    public int RegistroBiometricoId { get; set; }

    public string? Registro { get; set; }

    public int? BiometricoId { get; set; }

    public virtual Biometrico? Biometrico { get; set; }
}
