﻿using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Volunteer
{
    public int VolunteerId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? MaleOrFemale { get; set; }

    public string Email { get; set; } = null!;

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<VolunteersKindOfVolunteering> VolunteersKindOfVolunteerings { get; set; } = new List<VolunteersKindOfVolunteering>();
}
