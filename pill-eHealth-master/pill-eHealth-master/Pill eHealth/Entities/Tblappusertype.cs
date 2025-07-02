using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblappusertype
{
    public int AppUserTypeId { get; set; }

    public string AppUserType { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
