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

        // mapping --> bu işlemler için automapper kullanacağız.
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
        List<Brand> brands = _brandDal.GetAll();
        List<IBaseResponse<int>> getAllBrandResponses = new List<IBaseResponse<int>>();

        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Name =brand.Name;
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.CreatedDate = brand.CreatedDate;
            getAllBrandResponses.Add(getAllBrandResponse);

        }
        return getAllBrandResponses;


    }

    public IBaseResponse<int> Update(IBaseRequest entity)
    {
        throw new NotImplementedException();
    }
}
