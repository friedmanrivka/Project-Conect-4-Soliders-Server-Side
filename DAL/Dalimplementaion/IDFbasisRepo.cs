using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dalimplementaion;

public class IDFbasisRepo : IIDFbasisRepo
{
    EquipmentForSoldiersContext Equipment4SoldiersContext;
    public IDFbasisRepo(EquipmentForSoldiersContext Equipment4SoldiersContext)
    {
        this.Equipment4SoldiersContext = Equipment4SoldiersContext;
    }
    public Idfbasis Add(Idfbasis idfbasis)
    {
        Equipment4SoldiersContext.Add(idfbasis);
        Equipment4SoldiersContext.SaveChanges();
        return idfbasis;
    }

    public Idfbasis Delete(int id)
    {
        Idfbasis idfbasisToDelete = Equipment4SoldiersContext.Idfbases.FirstOrDefault(x => x.Id == id);
        if (idfbasisToDelete != null)
        {
            Equipment4SoldiersContext.Idfbases.Remove(idfbasisToDelete);
            Equipment4SoldiersContext.SaveChanges();
            return idfbasisToDelete;
        }
        return null;
    }

    public Idfbasis Get(int id)
    {
        Idfbasis getIdfbasis = Equipment4SoldiersContext.Idfbases.FirstOrDefault(i => i.Id == id);
        if (getIdfbasis != null)
        {
            return getIdfbasis;
        }
        throw new Exception("There is not a IDFbasis that has this ID");


    }

    public List<Idfbasis> GetAll()
    {
        IEnumerable<Idfbasis> getIDFbasisList = Equipment4SoldiersContext.Idfbases;
        return getIDFbasisList.ToList();
    }

    public Idfbasis Update(Idfbasis idfbasis, int id)
    {
        throw new NotImplementedException();
    }
}

