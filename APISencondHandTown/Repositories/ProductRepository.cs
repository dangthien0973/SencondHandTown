
using APISencondHandTown.Models;
using APISencondHandTown.Repositories;
using APISencondHandTown.Dto;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using PagedList;

namespace APISencondHandTown.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProductsList(ProductPageDto productPage);
    }
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(DB_TMDTContext context) : base(context)
        {
        }
        public IEnumerable<Product> GetProductsList(ProductPageDto productPage)
        {
            IEnumerable<Product> productslist = context.Products;
            if (productPage.filedName == "price" && productPage.sortType == "des")
            {
                productslist = productslist.OrderByDescending(s => s.Price);
            }
            else if (productPage.filedName == "price" && productPage.sortType == "asc")
            {
                productslist = productslist.OrderBy(s => s.Price);
            }
            var payload = productslist.ToPagedList(productPage.Page, productPage.PageSize);
            return payload;
        }

        public override Product Update(Product entity)
        {
            var product = context.Products
                .Single(p => p.ProductId == entity.ProductId);

            product.Price = entity.Price;


            return base.Update(product);
        }
     
    }
}
