using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi;

internal interface IIDFbasisRepoBl
{
    public List<Idfbasis> GetSomeDetailOfIDFbasis();
    public Idfbasis GetSomeDetailOfSpecificIDFbasis(int id);
    public Idfbasis UpdateIDFbasis(Idfbasis idfbasis, int id);
    public Idfbasis CreateNewIDFbasis(Idfbasis idfbasis);
    public bool DeleteIDFbasis(int id);

}
