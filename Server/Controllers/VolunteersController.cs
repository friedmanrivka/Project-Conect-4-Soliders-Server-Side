using Microsoft.AspNetCore.Mvc;
using BL.BlApi;
using BL.Bo;
using DAL.DalApi;
using BL;
namespace Server.Controllers;
[ApiController]
[Route("api/[controller]")]
public class VolunteersController:ControllerBase
{
    IVolunteerRepoBl volunteerRepoBl;
    
    public VolunteersController(BLManager bLManager)
    {
        this.volunteerRepoBl = bLManager.volunteer;
    }
    [HttpGet]
    public ActionResult<List<Volunteer>> Get()
    {
        if (volunteerRepoBl.GetAll() == null)
            return NotFound();
        return volunteerRepoBl.GetAll();

    }
    [HttpGet("{volunteerId}")]
    public ActionResult <Volunteer> Get(int volunteerId)
    {
        if(volunteerId == null)
        {
            return NotFound();
        }
        return volunteerRepoBl.Get(volunteerId);
    }
    //[HttpPut("{volunteerId}")]
    //public ActionResult<Volunteer> Update(Volunteer volunteer, int Id)
    //{
    //    if(volunteer == null)
    //    {
    //        return BadRequest();
    //    }
    //    return volunteerRepoBl.Update(volunteer , Id);
    //}

    //[HttpDelete("{volunteerId}")]
    //public ActionResult<bool> Delete(int volunteerId)
    //{
    //    if (volunteerId == null)
    //    {
    //        return BadRequest();
    //    }
    //    return volunteerRepoBl.Delete(volunteerId);
    //}
    [HttpPost]
    public ActionResult<Volunteer> Post(Volunteer volunteer)
    {
        if(volunteer == null)
        {
            return BadRequest();
        }
        return volunteerRepoBl.Add(volunteer);
    }
}
