﻿using AutoMapper;
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

internal class BLManager
{
    public IVolunteerRepoBl volunteer { get; set; }

    public BLManager(string constStr)
    {
        ServiceCollection services = new ServiceCollection();
        services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
        services.AddSingleton<DALManager>(x=>new DALManager(constStr));
        services.AddScoped<BL.BlApi.IVolunteerRepoBl, BL.BlImplementaion.VolunteerServiceBl>();
       

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        //volunteer = servicesProvider.GetRequiredService<VolunteerServiceBl>();
        volunteer = servicesProvider.GetRequiredService<IVolunteerRepoBl>();
    }
    //  public IVolunteerRepo volunteer { get; }

    //    public DALManager()
    //    {
    //        ServiceCollection collections = new ServiceCollection();
    //        collections.AddDbContext<Equipment4SoldiersContext>();
    //        collections.AddScoped<IVolunteerRepo, VolunteerRepo>();

    //        ServiceProvider provider = collections.BuildServiceProvider();

    //        volunteer = provider.GetRequiredService<VolunteerRepo>();
    //    }
    //}
}
