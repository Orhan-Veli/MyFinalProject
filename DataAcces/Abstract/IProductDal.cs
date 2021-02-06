using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
