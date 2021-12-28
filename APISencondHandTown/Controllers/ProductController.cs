using APISencondHandTown.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using APISencondHandTown.unitOfWork.Repositories;
using APISencondHandTown.Dto;
using APISencondHandTown.unitOfWork;

namespace APISencondHandTown.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IProductRepository _ProductRepositoryMoreMethod;
       
        public ProductController(IUnitOfWork unitOfWork, IProductRepository _ProductRepositoryMoreMethod, IRepository<Product> _productRepository)
        {
            this.unitOfWork = unitOfWork;
           this._ProductRepositoryMoreMethod = _ProductRepositoryMoreMethod;
        }
        [HttpPost("getProducList")]
        public IActionResult getProductList(ProductPageDto productPage)
        {          
            var sort = new
            {
                productPage.filedName,
                productPage.sortType,
            };
            var payload = _ProductRepositoryMoreMethod.GetProductsList(productPage);
            return Ok(new
            {
                productPage.Page,
                productPage.PageSize,
                sort,
                payload
            }
                    );
        }
        [HttpGet("getlist")]
        public IActionResult getlist()
        {
            return Ok(new { Enumerable = unitOfWork.ProductRepository.All()
        });
        }
       
    }
}
