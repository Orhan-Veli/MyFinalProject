using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDTO> GetProductDetails()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var result = from p in northwindContext.Products
                             join c in northwindContext.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDTO {ProductId=p.ProductId,ProductName=p.ProductName,CategoryName=c.CategoryName,UnitInStock=p.UnitsInStock };
                return result.ToList();
            }
          
        }
    }
}
