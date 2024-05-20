using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi;

public interface IIDFbasisRepo
{
    public List<Idfbasis> GetAll();
    public Idfbasis Get(int id);
    public Idfbasis Add(Idfbasis idfbasis);
    public Idfbasis Delete(int id);
    public Idfbasis Update(Idfbasis idfbasis, int id);
}
