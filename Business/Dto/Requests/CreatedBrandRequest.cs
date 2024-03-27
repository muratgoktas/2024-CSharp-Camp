using Business.Dto.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Requests
{
    public class CreatedBrandRequest : IBaseRequest
    {
        public string Name { get; set; }
    }
}
