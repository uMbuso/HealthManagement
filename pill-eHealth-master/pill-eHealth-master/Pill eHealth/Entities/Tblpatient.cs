using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblpatient
{
    public int PatientId { get; set; }

    public string Surname { get; set; } = null!;

    public string? MiddleNames { get; set; }

    public string FirstName { get; set; } = null!;

    public string PrimaryTel { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Occupation { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
