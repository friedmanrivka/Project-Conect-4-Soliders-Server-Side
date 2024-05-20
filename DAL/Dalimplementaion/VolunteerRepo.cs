using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VolunteerRepo;
public class VolunteerRepo : IVolunteerRepo
{
    EquipmentForSoldiersContext Equipment4SoldiersContext;
    public VolunteerRepo(EquipmentForSoldiersContext Equipment4SoldiersContext)
    {
        this.Equipment4SoldiersContext = Equipment4SoldiersContext;
    }
    //get
    public List<Volunteer> GetAll()
    {
        IEnumerable<Volunteer> Volunteer = Equipment4SoldiersContext.Volunteers;
        return Volunteer.ToList();
    }

    //post
    public Volunteer Add(Volunteer volunteer)
    {
        Equipment4SoldiersContext.Add(volunteer);
        Equipment4SoldiersContext.SaveChanges();
        return volunteer;
    }
    //delete
    public Volunteer Delete(int id)
    {
        Volunteer volunteerToDelete = Equipment4SoldiersContext.Volunteers.FirstOrDefault(v => v.VolunteerId == id);
        if (volunteerToDelete != null)
        {
            Equipment4SoldiersContext.Volunteers.Remove(volunteerToDelete);
            Equipment4SoldiersContext.SaveChanges();
            return volunteerToDelete;

        }
        return null;
    }



    public Volunteer Update(Volunteer volunteer, int Id)
    {
        Volunteer volunteerToUpdate = Equipment4SoldiersContext.Volunteers.FirstOrDefault(v => v.VolunteerId == Id);
        if (volunteerToUpdate != null)
        {
            volunteerToUpdate.PhoneNumber = volunteer.PhoneNumber;
            Equipment4SoldiersContext.SaveChanges();
            return volunteerToUpdate;

        }
        return null;

    }

    public Volunteer Get(int id)
    {
        Volunteer getVolunteer = Equipment4SoldiersContext.Volunteers.FirstOrDefault(v => v.VolunteerId == id);
        if (getVolunteer != null)
        {
            return getVolunteer;
        }
        throw new Exception("There is not a volunteer that have this Id");

    }
}
