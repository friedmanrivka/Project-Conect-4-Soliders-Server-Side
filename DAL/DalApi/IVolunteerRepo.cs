using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface IVolunteerRepo
    {
        public List<Volunteer> GetAll();
        public Volunteer Get(int id);
        public Volunteer Add(Volunteer volunteer);
        public Volunteer Delete(int id);
        public Volunteer Update(Volunteer volunteer, int Id);
    }
}
