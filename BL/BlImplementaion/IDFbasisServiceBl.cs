using BL.BlApi;
using BL.Bo;
using DAL.DalApi;
using DAL.Dalimplementaion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementaion;

internal class IDFbasisServiceBl : IIDFbasisRepoBl
{
    IIDFbasisRepo IDFbasisRepo;
    public IDFbasisServiceBl(IIDFbasisRepo IDFbasisRepo)
    {
        this.IDFbasisRepo = IDFbasisRepo;
    }
    public List<Bo.Idfbasis> GetSomeDetailOfIDFbasis()
    {
        List<Bo.Idfbasis> idfbasisBLList = new();
        var data = IDFbasisRepo.GetAll();
        foreach (var item in data)
        {
            Bo.Idfbasis idfbasis = new Bo.Idfbasis();
            idfbasis.Name = item.Name;

            idfbasisBLList.Add(idfbasis);

        }
        return idfbasisBLList;
    }
    public Bo.Idfbasis GetSomeDetailOfSpecificIDFbasis(int id)
    {
        Bo.Idfbasis specificVolunteerDetails = new();
        var data = IDFbasisRepo.GetAll();
        DAL.Do.Idfbasis idfbasis = data.FirstOrDefault(i => i.Id == id);


        specificVolunteerDetails.Name = idfbasis.Name;

        if (specificVolunteerDetails != null)
        {
            return specificVolunteerDetails;
        }
        throw new Exception("There is not a volunteer that have this Id");

    }

    public Bo.Idfbasis UpdateIDFbasis(Bo.Idfbasis volunteer, int id)
    {
        var data = IDFbasisRepo.GetAll();

        DAL.Do.Idfbasis tempidfbasisDetails = data.FirstOrDefault(v => v.Id == id);
        tempidfbasisDetails.Name = tempidfbasisDetails.Name;

        if (tempidfbasisDetails == null)
            throw new Exception("There is not a volunteer that have this Id");
        return volunteer;


    }

    public bool DeleteIDFbasis(int id)
    {
        var data = IDFbasisRepo.GetAll();

        DAL.Do.Idfbasis tempidfbasisDetails = data.FirstOrDefault(v => v.Id == id);
        if (tempidfbasisDetails == null)
        {
            data.Remove(tempidfbasisDetails);
            return true;
        }
        return false;

    }


    public Idfbasis CreateNewIDFbasis(Idfbasis idfbasis)
    {
        throw new NotImplementedException();
    }
}
