using Business.Concrete;
using DataAcces.Concrete.InMemory;
using DataAcces.Concrete.EntityFramework;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
