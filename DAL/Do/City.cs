using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Idfbasis> Idfbases { get; set; } = new List<Idfbasis>();

    public virtual ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
}
