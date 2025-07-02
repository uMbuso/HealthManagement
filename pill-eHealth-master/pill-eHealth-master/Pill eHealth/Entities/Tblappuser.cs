using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblappuser
{
    public int AppUserId { get; set; }

    public int AppUserTypeId { get; set; }

    public string AppUserName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? MiddleNames { get; set; }

    public string FirstName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PrimaryTel { get; set; } = null!;

    public int AppUserStatusId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
