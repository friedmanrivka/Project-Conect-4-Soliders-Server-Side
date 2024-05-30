//using Microsoft.AspNetCore.Mvc;
//using BL.BlApi;
//using BL.Bo;
//using DAL.DalApi;
//using BL;
//namespace Server.Controllers;
//[ApiController]
//[Route("api/[controller]")]
//public class VolunteersController:ControllerBase
//{
//    IVolunteerRepoBl volunteerRepoBl;
    
//    public VolunteersController(BLManager bLManager)
//    {
//        this.volunteerRepoBl = bLManager.volunteer;
//    }
//    [HttpGet]
//    public ActionResult<List<Volunteer>> Get()
//    {
//        if (volunteerRepoBl.GetAll() == null)
//            return NotFound();
//        return volunteerRepoBl.GetAll();

//    }
//    [HttpGet("{volunteerId}")]
//    public ActionResult <Volunteer> Get(int volunteerId)
//    {
//        if(volunteerId == null)
//        {
//            return NotFound();
//        }
//        return volunteerRepoBl.Get(volunteerId);
//    }
   
//    [HttpPost]
//    public ActionResult<Volunteer> Post(Volunteer volunteer)
//    {
//        if(volunteer == null)
//        {
//            return BadRequest();
//        }
//        if (DoesVolunteerExist(volunteer.VolunteerId))
//        {
//            return Conflict("Volunteer with this ID already exists.");
//        }
//        try
//        {
//            return volunteerRepoBl.Add(volunteer);
//        }
//        catch (Exception ex)
//        {
//            return Conflict(ex.Message);
//        }
       
//    }
//    private bool DoesVolunteerExist(int volunteerId)
//    {
//        return volunteerRepoBl.GetAll().Any(v => v.VolunteerId== volunteerId);
//    }
//}
// //[HttpPut("{volunteerId}")]
//    //public ActionResult<Volunteer> Update(Volunteer volunteer, int Id)
//    //{
//    //    if(volunteer == null)
//    //    {
//    //        return BadRequest();
//    //    }
//    //    return volunteerRepoBl.Update(volunteer , Id);
//    //}

//    //[HttpDelete("{volunteerId}")]
//    //public ActionResult<bool> Delete(int volunteerId)
//    //{
//    //    if (volunteerId == null)
//    //    {
//    //        return BadRequest();
//    //    }
//    //    return volunteerRepoBl.Delete(volunteerId);
//    //}