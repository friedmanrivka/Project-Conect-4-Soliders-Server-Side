//using BL.BlApi;
//using DAL.Do;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Server.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class IDFbasisController : ControllerBase
//{
//    IIDFBasisRepoBl IDFBasisRepoBl;
//    public IDFbasisController(IIDFBasisRepoBl IDFBasisRepoBl)
//    {
//        this.IDFBasisRepoBl = IDFBasisRepoBl;
//    }

//    [HttpGet]

//    public ActionResult<List<Idfbasis> Get()
//    {
//        if(IDFBasisRepoBl.GetSomeDetailsOfIDFBasis == null)
//           return NotFoundResult()
//        return IDFBasisRepoBl.GetSomeDetailsOfIDFBasis();
//     }
//[HttpGet("{ IDFbasisId}")]

//public ActionResult<Idfbasis> Get()
//{

//}
     

//    }

  
//    [HttpGet("{volunteerId}")]
//public ActionResult<Volunteer> Get(int volunteerId)
//{
//    if (volunteerId == null)
//    {
//        return NotFound();
//    }
//    return volunteerRepoBl.GetSomeDetailOfSpecificVolunteer(volunteerId);
//}
//[HttpPut("{volunteerId}")]
//public ActionResult<Volunteer> Update(Volunteer volunteer, int Id)
//{
//    if (volunteer == null)
//    {
//        return BadRequest();
//    }
//    return volunteerRepoBl.UpdateVolunteer(volunteer, Id);
//}

//[HttpDelete("{volunteerId}")]
//public ActionResult<bool> Delete(int volunteerId)
//{
//    if (volunteerId == null)
//    {
//        return BadRequest();
//    }
//    return volunteerRepoBl.DeleteVolunteer(volunteerId);
//}
//[HttpPost]

//public ActionResult<Volunteer> Post(Volunteer volunteer)
//{
//    if (volunteer == null)
//    {
//        return BadRequest();
//    }
//    return volunteerRepoBl.CreateNewVolunteer(volunteer);
//}

//}
