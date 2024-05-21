using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo;
public partial class Volunteer
{
    //this is that the volunteer will accept details of a solider without id
    public int Id { get; set; }
    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;
    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public int AddressId { get; set; }

    public DateTime BirthDate { get; set; }

    public string MaleOrFemale { get; set; }

    public string Email { get; set; }

    //public int Age { set => Age = DateTime.Now.Year - BirthDate.Year; }


    public int Age { get; set; }

}


