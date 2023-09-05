using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Biometrico
{
    public int BiometricoId { get; set; }

    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? UnidadId { get; set; }

    public virtual ICollection<EmpleadoBiometrico> EmpleadoBiometricos { get; set; } = new List<EmpleadoBiometrico>();

    public virtual ICollection<RegistroBiometrico> RegistroBiometricos { get; set; } = new List<RegistroBiometrico>();
}
