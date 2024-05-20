using DAL.DalApi;
using DAL.Dalimplementaion;
using DAL.Do;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class DALManager
{
    public IVolunteerRepo volunteer { get; }

    public DALManager()
    {
        ServiceCollection collections = new ServiceCollection();
        collections.AddDbContext<EquipmentForSoldiersContext>();
        collections.AddScoped<IVolunteerRepo, DAL.VolunteerRepo.VolunteerRepo>();

        ServiceProvider provider = collections.BuildServiceProvider();

        volunteer = provider.GetRequiredService<DAL.VolunteerRepo.VolunteerRepo>();
    }
}
