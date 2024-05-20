using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class IdfbaseKindOfVolunteering
{
    public int JunctionId { get; set; }

    public int IdfbaseId { get; set; }

    public int KindOfVolunteeringId { get; set; }

    public virtual Idfbasis Idfbase { get; set; } = null!;
}
