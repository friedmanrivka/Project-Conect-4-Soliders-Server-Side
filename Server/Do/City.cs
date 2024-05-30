using System;
using System.Collections.Generic;

namespace Server.Do;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();

    public virtual ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
}
