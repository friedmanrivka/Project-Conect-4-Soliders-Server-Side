using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StreetRepo;

internal class StreetRepo : IStreetRepo
{
    EquipmentForSoldiersContext Equipment4SoldiersContext;
    public StreetRepo(EquipmentForSoldiersContext Equipment4SoldiersContext)
    {
        this.Equipment4SoldiersContext = Equipment4SoldiersContext;
    }
    //g
    public Street Add(Street something)
    {
        throw new NotImplementedException();
    }

    public Street Delete(int code)
    {
        throw new NotImplementedException();
    }

    public List<Street> GetAll()
    {
        throw new NotImplementedException();
    }

    public Street Update(Street something, int somethimg)
    {
        throw new NotImplementedException();
    }
}
