using Business.Abstracts;
using Business.Dto.Requests;
using Business.Dto.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandServices _brandServices;

        public BrandsController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpPost]
        public IActionResult Add(CreatedBrandRequest createdBrandRequest)
        {
           CreatedBrandResponse createdBrandResponse = (CreatedBrandResponse)_brandServices.Add(createdBrandRequest);
            return Ok (createdBrandResponse);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandServices.GetAll());
        }
    }
}
