using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Abstracts;

public interface IBaseRequest
{
    public string Name { get; set; }
}
