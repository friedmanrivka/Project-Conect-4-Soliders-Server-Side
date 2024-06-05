using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo;
public partial class Volunteer
{
    public int VolunteerId { get; set; }
  
    public string CityName { get; set; }

    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public int? CityId { get; set; }
    public string Email { get; set; }

    
    public int Age { get; set; }
  //public string LastName { get; set; } = null!;

    //public string FirstName { get; set; } = null!;
    //public int Age { set => Age = DateTime.Now.Year - BirthDate.Year; }
}


