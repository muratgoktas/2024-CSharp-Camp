using Business.Dto.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;

public interface IBaseService<T,TId>
{
    IBaseResponse<TId> Add(IBaseRequest baseRequest);
    IBaseResponse<TId> Update(IBaseRequest baseRequest);
    IBaseResponse<TId> Delete(IBaseRequest baseRequest);
    List<IBaseResponse<TId>> GetAll();
}
