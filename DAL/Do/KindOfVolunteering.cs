using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class KindOfVolunteering
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<BaseRequest> BaseRequests { get; set; } = new List<BaseRequest>();
}
