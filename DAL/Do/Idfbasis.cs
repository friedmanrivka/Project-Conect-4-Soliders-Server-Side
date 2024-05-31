using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Idfbasis
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<IdfbaseKindOfVolunteering> IdfbaseKindOfVolunteerings { get; set; } = new List<IdfbaseKindOfVolunteering>();
}
