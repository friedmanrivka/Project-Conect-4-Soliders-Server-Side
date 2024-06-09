using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.BlImplementaion;
using BL.BlApi;
namespace BL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        private readonly ICityRepoBl _cityRepoBl;
        public AutoMapperProfile(ICityRepoBl cityRepoBl)
        {
            CreateMap<DAL.Do.City,BL.Bo.City>(); //??
            CreateMap<BL.Bo.City, DAL.Do.City>(); //??
            CreateMap<DAL.Do.Volunteer, Volunteer>()
             .ForMember(dest => dest.FullName,
                 opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
             .ForMember(dest => dest.CityName,
                 opt => opt.MapFrom(src => src.City != null ? src.City.Name : null))
             .ForMember(dest => dest.Age,
                 opt => opt.MapFrom(src => CalculateAge(src.DateOfBirth)));

            CreateMap<BL.Bo.Volunteer, DAL.Do.Volunteer>()
                .ForMember(dest => dest.FirstName,
                           opt => opt.MapFrom(src => GetFirstName(src.FullName)))
                .ForMember(dest => dest.LastName,
                           opt => opt.MapFrom(src => GetLastName(src.FullName)))
                .ForMember(dest => dest.DateOfBirth,
                           opt => opt.MapFrom(src => DateTime.Today.AddYears(-src.Age)))
                .ForMember(dest => dest.City,
                           opt => opt.Ignore()) // לא למפות את ה-City ישירות

                .ForMember(dest => dest.CityId,
                           opt => opt.MapFrom(src => GetCityIdByName(src.CityName)));
            
            
        }
        private int CalculateAge(DateTime? dateOfBirth)
        {
            if (!dateOfBirth.HasValue)
                return 0;

            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Value.Year;

            if (dateOfBirth.Value.Date > today.AddYears(-age)) age--;

            return age;
        }
        private string GetFirstName(string fullName)
        {
            var names = fullName.Split(' ');
            return names[0];
        }

        private string GetLastName(string fullName)
        {
            var names = fullName.Split(' ');
            return names.Length > 1 ? names[1] : string.Empty;
        }

        private int? GetCityIdByName(string cityName)
        {
            var city = _cityRepoBl.GetAll().FirstOrDefault(c => c.Name == cityName);
            return city?.Id;
        }

    }
}

