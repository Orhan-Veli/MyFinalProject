using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product {ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 }, 
                new Product {ProductId=2,CategoryId=1,ProductName="kamera",UnitPrice=500,UnitsInStock=3 }, 
                new Product {ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 }, 
                new Product {ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 }, 
                new Product {ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }, 
            
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(x=> x.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            var categoryIdToList=_products.Where(x => x.CategoryId == categoryId).ToList();
            return categoryIdToList;
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            
        }
    }
}
