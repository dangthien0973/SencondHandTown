
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
    public interface IProductDetailRepo
    {
        // public IEnumerable<ProductDetail> TestProductDetail(ProdductModelDto prodductDto);
    }
    public class ProductDetailRepo : GenericRepository<ProductDetail>, IProductDetailRepo
    {
        public ProductDetailRepo(DB_TMDTContext context) : base(context)
        {
        }

        // public IEnumerable<ProductDetail> TestProductDetail(ProdductModelDto prodductDto)
        // {
        //     return null;
        // }

    }
}
