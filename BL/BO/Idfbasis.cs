using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    internal class Idfbasis
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int AddressId { get; set; }

      

        public virtual ICollection<IdfbaseKindOfVolunteering> IdfbaseKindOfVolunteerings { get; set; } = new List<IdfbaseKindOfVolunteering>();
    }
}
