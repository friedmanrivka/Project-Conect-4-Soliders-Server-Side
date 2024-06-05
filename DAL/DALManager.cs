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

namespace DAL;

public class DALManager
{
    public IIDFbasisRepo IDFbase { get; set; }
    public IVolunteerRepo volunteer { get; set; }
 
    public ICityRepo city { get; set; }
    public DALManager(string connStr)
    {
        ServiceCollection collections = new ServiceCollection();
        collections.AddSingleton<EquipmentForSoldiersContext>();
        collections.AddScoped<IVolunteerRepo, DAL.VolunteerRepo.VolunteerRepo>();
      
        collections.AddScoped<ICityRepo,DAL.CityRepo.CityRepo>();
        //collections.AddScoped<IStreetRepo, DAL.StreetRepo.StreerRepo>();
        collections.AddDbContext<EquipmentForSoldiersContext>(opt=>opt.UseSqlServer(connStr));
        ServiceProvider provider = collections.BuildServiceProvider();

        volunteer = provider.GetRequiredService<IVolunteerRepo>();
  
        city=provider.GetRequiredService<ICityRepo>();  
    }
}
