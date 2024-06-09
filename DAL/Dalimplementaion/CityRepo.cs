using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CityRepo;

internal class CityRepo:ICityRepo
{
    EquipmentForSoldiersContext Equipment4SoldiersContext;
    public CityRepo(EquipmentForSoldiersContext Equipment4SoldiersContext)
    {
        this.Equipment4SoldiersContext = Equipment4SoldiersContext;
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
        IEnumerable<City> City = Equipment4SoldiersContext.Cities;
        return City.ToList();
    }

    public City Update(City something, int somethimg)
    {
        throw new NotImplementedException();
    }
    public int? GetCityIdByName(string cityName) 
    {
        var city = Equipment4SoldiersContext.Cities.FirstOrDefault(c => c.Name == cityName);
        return city?.Id;
    }
}
