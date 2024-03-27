using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;

public interface IBaseService<T>
{
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetAll();
}
