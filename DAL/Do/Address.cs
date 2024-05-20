using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Address
{
    public int Id { get; set; }

    public int StreetId { get; set; }

    public int BuildingNumber { get; set; }

    public int? ApartmentNumber { get; set; }

    public virtual ICollection<Idfbasis> Idfbases { get; set; } = new List<Idfbasis>();

    public virtual Street Street { get; set; } = null!;
}
