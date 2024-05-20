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
        services.AddScoped<DALManager>();
        services.AddScoped<BL.BlApi.IVolunteerRepoBl, BL.BlImplementaion.VolunteerServiceBl>();

        //services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
        ServiceProvider servicesProvider = services.BuildServiceProvider();

        volunteer = servicesProvider.GetRequiredService<VolunteerServiceBl>();
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
