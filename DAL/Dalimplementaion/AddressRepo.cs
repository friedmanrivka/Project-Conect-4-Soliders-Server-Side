using DAL.DalApi;
using DAL.Do;
using Dal;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdressRepo;

public class AddressRepo : IAddressRepo
{
   
        EquipmentForSoldiersContext Equipment4SoldiersContext;
        public AddressRepo(EquipmentForSoldiersContext Equipment4SoldiersContext)
        {
            this.Equipment4SoldiersContext = Equipment4SoldiersContext;
        }
        public Address Add(Address something)
    {
        // TODO 
        throw new NotImplementedException();
    }

    public Address Delete(int code)
    {
        throw new NotImplementedException();
    }

    public List<Address> GetAll()
    {
        throw new NotImplementedException();
    }

    public Address Update(Address something, int somethimg)
    {
        throw new NotImplementedException();
    }
}
