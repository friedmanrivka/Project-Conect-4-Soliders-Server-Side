using AutoMapper;
using BL.BlApi;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DalApi;
//using DAL.Do;
//using Volunteer = BL.Bo.Volunteer;

namespace BL.BlImplementaion;

public class VolunteerServiceBl : IVolunteerRepoBl
{
    IVolunteerRepo volunteerRepo;

    IMapper map;
    public VolunteerServiceBl(DALManager volunteerRepo, IMapper map)
    {
        this.volunteerRepo = volunteerRepo.volunteer;
        this.map = map;
    }


    public List<Volunteer> GetAll()
    {
        List<Volunteer> listVolunteersBl = new();
        var data = volunteerRepo.GetAll();
        data.ForEach(volunteer => listVolunteersBl.Add(map.Map<Volunteer>(volunteer)));
        return listVolunteersBl;
    }

    public Volunteer Get(int id)
    {
        return new Volunteer();
      

    }

    //how he know automatic that he will recive something from type volunteer
    public Volunteer Add(Volunteer volunteer)
    {
        DAL.Do.Volunteer volunteer1 = map.Map<DAL.Do.Volunteer>(volunteer);
        volunteerRepo.Add(volunteer1);
        Bo.Volunteer volunteer2 = map.Map<Bo.Volunteer>(volunteer1);
        return volunteer2;

    }

    public Volunteer Update(Volunteer volunteer, int volunteerId)
    {
        DAL.Do.Volunteer dalVolunteer = map.Map<DAL.Do.Volunteer>(volunteer);
        volunteerRepo.Update(dalVolunteer, volunteerId);
        Bo.Volunteer volunteerBl=map.Map<Bo.Volunteer>(dalVolunteer);
        return volunteerBl;
    }

    public Volunteer Delete(int id)
    {
        DAL.Do.Volunteer dalVolunteer = volunteerRepo.Delete(id);
        Volunteer volunteer = map.Map<Volunteer>(dalVolunteer);
        return volunteer;
    }
}


//public List<Bo.Volunteer> GetSomeDetailOfVolunteer()
//{
//    List<Bo.Volunteer> volunteerBLList = new();
//    var data = VolunteerRepo.GetAll();
//    foreach (var item in data)
//    {
//        Bo.Volunteer volunteer = new Bo.Volunteer();
//        volunteer.FirstName = item.FirstName;
//        volunteer.LastName = item.LastName;
//        volunteer.PhoneNumber = item.PhoneNumber;
//        volunteer.AddressId = item.AddressId;
//        volunteer.MaleOrFemale = item.MaleOrFemale;
//        volunteer.Email = item.Email;
//        volunteerBLList.Add(volunteer);

//    }
//    return volunteerBLList;
//}
//public Bo.Volunteer GetSomeDetailOfSpecificVolunteer(int id)
//{
//    Bo.Volunteer specificVolunteerDetails = new();
//    var data = VolunteerRepo.GetAll();
//    DAL.Do.Volunteer volunteer = data.FirstOrDefault(v => v.VolunteerId == id);


//    specificVolunteerDetails.FirstName = volunteer.FirstName;
//    specificVolunteerDetails.LastName = volunteer.LastName;
//    specificVolunteerDetails.PhoneNumber = volunteer.PhoneNumber;
//    specificVolunteerDetails.AddressId = volunteer.AddressId;
//    specificVolunteerDetails.MaleOrFemale = volunteer.MaleOrFemale;
//    specificVolunteerDetails.Email = volunteer.Email;


//    if (specificVolunteerDetails != null)
//    {
//        return specificVolunteerDetails;
//    }
//    throw new Exception("There is not a volunteer that have this Id");

//}

//public Bo.Volunteer UpdateVolunteer(Bo.Volunteer volunteer, int id)
//{
//    var data = VolunteerRepo.GetAll();

//    DAL.Do.Volunteer tempVolunteerDetails = data.FirstOrDefault(v => v.VolunteerId == id);
//    tempVolunteerDetails.AddressId = volunteer.AddressId;
//    tempVolunteerDetails.PhoneNumber = volunteer.PhoneNumber;
//    tempVolunteerDetails.LastName = volunteer.LastName;
//    tempVolunteerDetails.Email = volunteer.Email;

//    if (tempVolunteerDetails == null)
//        throw new Exception("There is not a volunteer that have this Id");
//    return volunteer;


//}

//public bool DeleteVolunteer(int id)
//{
//    var data = VolunteerRepo.GetAll();

//    DAL.Do.Volunteer tempVolunteerDetails = data.FirstOrDefault(v => v.VolunteerId == id);
//    if (tempVolunteerDetails == null)
//    {
//        data.Remove(tempVolunteerDetails);
//        return true;
//    }
//    return false;

//}

//public Volunteer CreateNewVolunteer(Volunteer volunteer)
//{

//}
//to move it to auto mapper
//Bo.Volunteer specificVolunteerDetails = new();
//var data = volunteerRepo.GetAll();
//DAL.Do.Volunteer volunteer = data.FirstOrDefault(v => v.VolunteerId == id);
//specificVolunteerDetails.FirstName = volunteer.FirstName;
//specificVolunteerDetails.LastName = volunteer.LastName;
//specificVolunteerDetails.PhoneNumber = volunteer.PhoneNumber;
//specificVolunteerDetails.AddressId = volunteer.AddressId;
//specificVolunteerDetails.MaleOrFemale = volunteer.MaleOrFemale;
//specificVolunteerDetails.Email = volunteer.Email;
//if (specificVolunteerDetails != null)
//{
//    return specificVolunteerDetails;
//}
//throw new Exception("There is not a volunteer that have this Id");
