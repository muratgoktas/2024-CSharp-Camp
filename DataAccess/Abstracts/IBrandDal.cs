using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IBrandDal
{
    void Add(Brand brand);
    List<Brand> GetAll();
    void Delete(Brand brand);
    void Update(Brand brand);
}
