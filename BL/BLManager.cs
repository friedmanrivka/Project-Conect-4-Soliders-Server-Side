using AutoMapper;
using BL.AutoMapper;
using BL.BlApi;
using BL.BlImplementaion;
using DAL;
using DAL.DalApi;

using DAL.Do;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;
public class BLManager
{

    public ICityRepoBl city { get; set; }
    public IVolunteerRepoBl volunteer { get; set; }
    public IIDFBaseRepoBl IDFbase { get; set; }
    public BLManager(string constStr)
    {
        ServiceCollection services = new ServiceCollection();
        services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
        services.AddSingleton<DALManager>(x => new DALManager(constStr));
        services.AddScoped<BL.BlApi.IVolunteerRepoBl, BL.BlImplementaion.VolunteerServiceBl>();

        services.AddScoped<BL.BlApi.ICityRepoBl, BL.BlImplementaion.CityServiceBl>();

        // Inject ICityRepoBl into AutoMapperProfile
        services.AddSingleton(provider =>
        {
            var cityRepoBl = provider.GetRequiredService<ICityRepoBl>();
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile(cityRepoBl));
            });
            return configuration.CreateMapper();
        });

        services.AddScoped<BL.BlApi.IIDFBaseRepoBl,BL.BlImplementaion.IDFbasisServiceBl>();
       
        ServiceProvider servicesProvider = services.BuildServiceProvider();
        volunteer = servicesProvider.GetRequiredService<IVolunteerRepoBl>();

        city = servicesProvider.GetRequiredService<ICityRepoBl>();
        IDFbase = servicesProvider.GetRequiredService<IIDFBaseRepoBl>();

    }
}
