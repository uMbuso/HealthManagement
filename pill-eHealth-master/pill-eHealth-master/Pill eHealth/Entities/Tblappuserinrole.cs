using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblappuserinrole
{
    public int AppUserInRoleId { get; set; }

    public int AppUserId { get; set; }

    public int AppRoleId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
