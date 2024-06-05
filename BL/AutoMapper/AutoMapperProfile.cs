using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace BL.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DAL.Do.City,BL.Bo.City>();
            CreateMap<DAL.Do.Volunteer, Volunteer>()
           .ForMember(dest => dest.FullName, source => source.MapFrom(src => src.FirstName + " " + src.LastName))
           .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City != null ? src.City.Name : null))
           .ForMember(dest => dest.Age, opt => opt.MapFrom(src => CalculateAge(src.DateOfBirth)));

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
                           opt => opt.MapFrom(src => src.CityId));

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
        //CreateMap<BL.Bo.Volunteer, Volunteer>()

        //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FullName.Contains(' ') ? src.FullName.Substring(src.FullName.IndexOf(' ') + 1) : string.Empty));

        //    CreateMap<Volunteer, DAL.Do.Volunteer>()
        //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => GetComposerName(src)))
        //    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => GetDescription(src)))
        //    .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => GetProcessorName(src)))
        //    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => GetSongWriter(src)))
        //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => LastName(src)))
        //    .ForMember(dest => dest.AddressId, opt => opt.MapFrom(src => AddressId(src)));
        //    //.ForMember(dest => dest., opt => opt.MapFrom(src => GetSongWriter(src)))
        //    //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => GetSongWriter(src)))



        //}
        //private string GetComposerName(Volunteer volunteer)
        //{
        //    return "Unknown";
        //}
        //private string GetDescription(Volunteer volunteer)
        //{
        //    return "Unknown Song";
        //}
        //private string GetProcessorName(Volunteer volunteer)
        //{
        //    return "Unknown";
        //}
        //private string GetSongWriter(Volunteer volunteer)
        //{
        //    return "Unknown";
        //}
        //private string AddressId(Volunteer volunteer)
        //{
        //    return "Unknown";
        //}
        //private string LastName(Volunteer volunteer)
        //{
        //    return "Unknown";
        //}


        //    CreateMap<Volunteer, DAL.Do.Volunteer>()
        //        .ForMember(dest => dest.FirstName, source => source.MapFrom(src => src.FullName.Split(' ')[0]))
        //        .ForMember(dest => dest.LastName, source => source.MapFrom(src => src.FullName.Split(' ')[1]))
        //        .ForMember(dest => dest.DateOfBirth, source => source.Ignore()); // assuming date of birth is not provided in BL model
        //}


        //.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => GetFirstName(src)))
        //.ForMember(dest=>dest.LastName,opt=>opt.MapFrom(src=))

        //CreateMap<Dal.Do.Singer, Singer>()
        //        .ForMember(dest => dest.FullName, source => source.MapFrom(src => src.FirstName + " " + src.LastName))
        //        .ForMember(dest => dest.Age, source => source.MapFrom(src => src.Age* 10));
        //private string GetFullName(Volunteer volunteer)
        //{
        //    return "unknown";
        //}
    }
}


//CreateMap<Volunteer, DAL.Do.Volunteer>()
//    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(' ')[0]))
//.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FullName.Contains(' ') ? src.FullName.Substring(src.FullName.IndexOf(' ') + 1) : string.Empty));

//CreateMap<DAL.Do.Volunteer, Volunteer>()
//    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(' ')[0]))
//    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FullName.Contains(' ') ? src.FullName.Substring(src.FullName.IndexOf(' ') + 1) : string.Empty));
