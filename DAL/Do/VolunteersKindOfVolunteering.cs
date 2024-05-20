using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class VolunteersKindOfVolunteering
{
    public int JunctionId { get; set; }

    public int VolunteersId { get; set; }

    public int KindOfVolunteeringId { get; set; }

    public virtual Volunteer Volunteers { get; set; } = null!;
}
