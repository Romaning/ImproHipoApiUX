using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Ci { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public DateTime Validity { get; set; }

    public string? Password { get; set; }

    public bool ChangePassword { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<RegistroCliente> RegistroClientes { get; set; } = new List<RegistroCliente>();

    public virtual ICollection<UnitUser> UnitUsers { get; set; } = new List<UnitUser>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
