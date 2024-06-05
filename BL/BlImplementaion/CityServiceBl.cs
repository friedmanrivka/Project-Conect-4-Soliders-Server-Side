using AutoMapper;
using BL.BlApi;
using BL.Bo;
using DAL;
using DAL.DalApi;
using DAL.VolunteerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementaion;

internal class CityServiceBl : ICityRepoBl
{
    ICityRepo cityRepo;
    IMapper map;
    public CityServiceBl(DALManager cityRepo, IMapper map)
    {
        this.cityRepo = cityRepo.city;
        this.map = map;
    }
    public City Add(City something)
    {
        throw new NotImplementedException();
    }

    public City Delete(int code)
    {
        throw new NotImplementedException();
    }

    public City Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<City> GetAll()
    {
        List<City> listCityBl = new();
        var data = cityRepo.GetAll();
        data.ForEach(city => listCityBl.Add(map.Map<City>(city)));
        return listCityBl;
    }

   
    public City Update(City something, int somethimgCode)
    {
        throw new NotImplementedException();
    }
    public int? GetCityIdByName(string cityName) 
    {
        return cityRepo.GetCityIdByName(cityName);
    }
}
