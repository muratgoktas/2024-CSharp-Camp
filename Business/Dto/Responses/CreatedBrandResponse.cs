using Business.Dto.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Responses
{
    public class CreatedBrandResponse : IBaseResponse<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

       
    }
}
