using AutoMapper;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AutoMapper
{
    public class AutoMapperProfileclass:Profile
    {
        public AutoMapperProfileclass()
        {
         CreateMap<Volunteer, DAL.Do.Volunteer>().ReverseMap();

        
        }

    }
}
