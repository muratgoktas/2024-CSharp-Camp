using Business.Abstracts;
using Business.Dto.Abstracts;
using Business.Dto.Responses;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandServices
{ // Not: Response ve request kullanımındaki amaç veritabanını son kullanıcıya açmamak. 1.18 de video
  // Eğitim video link:  https://www.youtube.com/watch?v=xeWXxOYFPbQ
    private readonly IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {   
        this._brandDal = brandDal;
        
    }

    public IBaseResponse<int> Add(IBaseRequest baseRequest)
    { 
        //Business Rules 
       // Burada yapılan işleme Mapping deniyor
        Brand brand = new Brand();
        brand.Name = baseRequest.Name;
        brand.CreatedDate = DateTime.Now;
        _brandDal.Add(brand);

        // mapping
        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
        createdBrandResponse.Name =brand.Name;
        createdBrandResponse.CreatedDate=brand.CreatedDate;
        createdBrandResponse.Id = 4;
        return createdBrandResponse;
        // IBaseRequest ve IBaseResponse oluşturmamak gerekiyormuş video 1:13 de Engin Hoca açıklıyor.
        // Yarın Id yi çıkar denirse yeniden bir base oluşturup tekrardan iş çıkarmış oluyoruz. 
    }

    public IBaseResponse<int> Delete(IBaseRequest entity)
    {
        throw new NotImplementedException();
    }

    public List<IBaseResponse<int>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IBaseResponse<int> Update(IBaseRequest entity)
    {
        throw new NotImplementedException();
    }
}
