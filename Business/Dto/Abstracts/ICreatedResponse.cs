using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Abstracts;

public interface ICreateResponse<TId>
{
  
    public TId Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

}
