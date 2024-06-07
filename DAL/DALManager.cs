using DAL.DalApi;
using DAL.VolunteerRepo;
using DAL.CityRepo;
using DAL.Do;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IDFBaseRepo;

namespace DAL;

public class DALManager
{
    public IIDFBaseRepo IDFBase { get; set; }
    public IVolunteerRepo volunteer { get; set; }
    public ICityRepo city { get; set; }
    public DALManager(string connStr)
    {
        ServiceCollection collections = new ServiceCollection();
        collections.AddSingleton<EquipmentForSoldiersContext>();
        collections.AddScoped<IVolunteerRepo, DAL.VolunteerRepo.VolunteerRepo>();
        collections.AddScoped<ICityRepo, DAL.CityRepo.CityRepo>();
        collections.AddScoped<IIDFBaseRepo, DAL.IDFBaseRepo.IDFBaseRepo>();
        collections.AddDbContext<EquipmentForSoldiersContext>(opt => opt.UseSqlServer(connStr));
        ServiceProvider provider = collections.BuildServiceProvider();

        volunteer = provider.GetRequiredService<IVolunteerRepo>();

        city = provider.GetRequiredService<ICityRepo>();
        IDFBase = provider.GetRequiredService<IIDFBaseRepo>();
    }
}
