using System;
using System.Collections.Generic;

namespace Server.Do;

public partial class Idfbasis
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<IdfbaseKindOfVolunteering> IdfbaseKindOfVolunteerings { get; set; } = new List<IdfbaseKindOfVolunteering>();
}
