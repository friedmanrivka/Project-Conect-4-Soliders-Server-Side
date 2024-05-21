using AutoMapper;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DAL.Do.Volunteer, Volunteer>()
           .ForMember(dest => dest.FullName, source => source.MapFrom(src => src.FirstName + " " + src.LastName));
           
           //.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => GetFirstName(src)))
           //.ForMember(dest=>dest.LastName,opt=>opt.MapFrom(src=))
        }


        //CreateMap<Dal.Do.Singer, Singer>()
        //        .ForMember(dest => dest.FullName, source => source.MapFrom(src => src.FirstName + " " + src.LastName))
        //        .ForMember(dest => dest.Age, source => source.MapFrom(src => src.Age* 10));
        //private string GetFullName(Volunteer volunteer)
        //{
        //    return "unknown";
        //}
    }
}
