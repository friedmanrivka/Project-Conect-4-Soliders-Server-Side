using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi;

public interface IRepo<T>
{
    public List<T> GetAll();
    public T Add(T something);
    public T Update(T something, int somethimg);
    public T Delete(int code);

}
