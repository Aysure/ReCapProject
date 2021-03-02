using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : IProductDal
    {
        List<Product> _products;
        public InMemoryDal()
        {
            _products = new List<Product>
            {
                new Product {BrandId=1,ColorId=1,Id=1,DailyPrice= 200,ModelYear=2015,Description="Otomatik"},
                new Product { BrandId = 2, ColorId = 2, Id = 2, DailyPrice = 300, ModelYear = 2016, Description = "Dizel" },
                new Product { BrandId = 2, ColorId = 2, Id = 3, DailyPrice = 1000, ModelYear = 2020, Description = "Üstü Açık" },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByBrandId(int brandId)
        {
            return _products.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = productToUpdate.BrandId;
            productToUpdate.ModelYear = product.ModelYear;

        }
    }
}
