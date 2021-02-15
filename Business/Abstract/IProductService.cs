using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategory(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);

        IDataResult<List<ProductDetailDTO>> GetProductDetails();

        IResult Add(Product product);

        IDataResult<Product> GetById(int productId);
    }
}
