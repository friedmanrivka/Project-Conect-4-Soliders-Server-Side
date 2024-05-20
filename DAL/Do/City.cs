using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
