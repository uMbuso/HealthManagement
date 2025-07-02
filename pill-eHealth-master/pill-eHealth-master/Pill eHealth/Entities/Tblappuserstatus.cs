using System;
using System.Collections.Generic;

namespace Pill_eHealth.Entities;

public partial class Tblappuserstatus
{
    public int AppUserStatusId { get; set; }

    public string AppUserStatus { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public int ModifiedByUserId { get; set; }
}
