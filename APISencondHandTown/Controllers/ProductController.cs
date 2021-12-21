using APISencondHandTown.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using APISencondHandTown.Repositories;
using APISencondHandTown.Dto;

namespace APISencondHandTown.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IProductRepository _ProductRepositoryMoreMethod;
       
        public ProductController(IProductRepository _ProductRepositoryMoreMethod, IRepository<Product> _productRepository)
        {
            this._productRepository = _productRepository;
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
       
    }
}
