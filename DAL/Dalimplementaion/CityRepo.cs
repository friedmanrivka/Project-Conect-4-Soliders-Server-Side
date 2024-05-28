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

    public List<City> GetAll()
    {
        throw new NotImplementedException();
    }

    public City Update(City something, int somethimg)
    {
        throw new NotImplementedException();
    }
}
