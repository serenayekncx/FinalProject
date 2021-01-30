using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId = 1, CategoryId = 1, ProductName="Bardak", UnitPrice = 15, UnıtsInStock = 15},
                new Product{ProductId = 2, CategoryId = 1, ProductName="Kamera", UnitPrice = 500, UnıtsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2, ProductName="Telefon", UnitPrice = 1500, UnıtsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName="Klavye", UnitPrice = 150, UnıtsInStock = 65},
                new Product{ProductId = 5, CategoryId = 2, ProductName="Fare", UnitPrice = 85, UnıtsInStock = 1}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LANguage ıntegrated query
          
           Product productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId);

            _products.Remove(productToDelete);
        }
       

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {  //gönderdiğim ürün id'sine sahip olan listedeki ürünü bul demek
           Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnıtsInStock = product.UnıtsInStock;

        }
    }
}
