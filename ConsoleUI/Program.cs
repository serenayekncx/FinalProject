using Business.Concrete;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll()) 
            {
              
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
