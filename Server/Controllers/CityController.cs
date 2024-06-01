using Microsoft.AspNetCore.Mvc;
using BL.BlApi;
using BL.Bo;
using DAL.DalApi;
using BL;
using DAL.VolunteerRepo;
namespace Server.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CityController:ControllerBase
    {
    ICityRepoBl cityRepoBl;
    public CityController(BLManager bLManager)
    {
        this.cityRepoBl = bLManager.city;
    }
    [HttpGet]
    public ActionResult<List<City>> Get()
    {
        if (cityRepoBl.GetAll() == null)
            return NotFound();
        return cityRepoBl.GetAll();

    }
}

