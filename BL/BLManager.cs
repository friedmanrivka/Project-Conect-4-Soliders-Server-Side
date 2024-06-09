﻿using AutoMapper;
using BL.AutoMapper;
using BL.BlApi;
using BL.BlImplementaion;
using DAL;
using DAL.DalApi;
using DAL.Dalimplementaion;
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

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        //volunteer = servicesProvider.GetRequiredService<VolunteerServiceBl>();
        volunteer = servicesProvider.GetRequiredService<IVolunteerRepoBl>();

        city = servicesProvider.GetRequiredService<ICityRepoBl>();

    }
}
//    //  public IVolunteerRepo volunteer { get; }
//    //    public DALManager()
//    //    {
//    //        ServiceCollection collections = new ServiceCollection();
//    //        collections.AddDbContext<Equipment4SoldiersContext>();
//    //        collections.AddScoped<IVolunteerRepo, VolunteerRepo>();

//    //        ServiceProvider provider = collections.BuildServiceProvider();

//    //        volunteer = provider.GetRequiredService<VolunteerRepo>();
//    //    }
//    //}
//}
