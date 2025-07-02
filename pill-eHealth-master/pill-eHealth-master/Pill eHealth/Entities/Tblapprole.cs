using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblapprole
{
    public int AppRoleId { get; set; }

    public string AppRole { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
