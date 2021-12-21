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
        private readonly IRepository<ProductDetail> _productDetailRepository;
       
        public ProductController(IProductRepository _ProductRepositoryMoreMethod, IRepository<Product> _productRepository, IRepository<ProductDetail> _productDetailRepository)
        {
            this._productRepository = _productRepository;
            this._ProductRepositoryMoreMethod = _ProductRepositoryMoreMethod;
            this._productDetailRepository = _productDetailRepository;
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
       
       [HttpPost("addProduct")]
        public IActionResult addProduct(ProdductModelDto productDto)
        {
            try
            {
                var product = new Product()
                {
                    Price = productDto.Price1,
                    PriceSale = productDto.PriceSale1,
                    Amount = productDto.Amount1,

                };
                
                var productDetail = new ProductDetail()
                {

                    NameProduct = productDto.NameProduct1,
                    SourceOrigin = productDto.SourceOrigin1,
                    Descriptions = productDto.Descriptions1,

                };
                

                _productDetailRepository.Add(productDetail);
                _productDetailRepository.SaveChanges();
                _productRepository.Add(product);
                _productRepository.SaveChanges();

                return Ok(new
                {
                    Message = "success addProduct",
                    product,
                    productDetail
                });
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

    }
}
