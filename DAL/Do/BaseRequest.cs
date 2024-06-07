using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class BaseRequest
{
    public int RequestId { get; set; }

    public int IdfbaseId { get; set; }

    public int KindOfVolunteeringId { get; set; }

    public DateTime RequestDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Idfbasis Idfbase { get; set; } = null!;

    public virtual KindOfVolunteering KindOfVolunteering { get; set; } = null!;
}
