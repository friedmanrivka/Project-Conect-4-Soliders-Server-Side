using AutoMapper;
using BL.BlApi;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DalApi;
using System.Reflection;

namespace BL.BlImplementaion
{
    public class AdressServiceBl : IAddressRepoBl
    {

        IAddressRepo addressRepo;

        IMapper map;
        public AdressServiceBl(DALManager addressRepo, IMapper map)
        {
            this.addressRepo = addressRepo.address;
            this.map = map;
        }
        public Address Add(Address address)
        {
            DAL.Do.Address address1 = map.Map<DAL.Do.Address>(address);
            addressRepo.Add(address1);
            //TODO
            Bo.Address address2 = map.Map<Bo.Address>(address1);
            return address2;
        }

        public Address Delete(int code)
        {
            throw new NotImplementedException();
        }

        public Address Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address Update(Address something, int somethimgCode)
        {
            throw new NotImplementedException();
        }
    }
}
