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
    public IVolunteerRepo volunteer { get; set; }
    public IAddressRepo address { get; set; }
    public DALManager(string connStr)
    {
        ServiceCollection collections = new ServiceCollection();
        collections.AddSingleton<EquipmentForSoldiersContext>();
        collections.AddScoped<IVolunteerRepo, DAL.VolunteerRepo.VolunteerRepo>();
        collections.AddScoped<IAddressRepo, DAL.AdressRepo.AddressRepo>();
        collections.AddDbContext<EquipmentForSoldiersContext>(opt=>opt.UseSqlServer(connStr));
        ServiceProvider provider = collections.BuildServiceProvider();

        volunteer = provider.GetRequiredService<IVolunteerRepo>();
    }
}
