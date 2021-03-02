using Businees.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager producManager = new ProductManager(new InMemoryDal());
            
            foreach (var p in producManager.GetAll())
            {
                Console.WriteLine(p.BrandId + " " + p.Id + " " + p.Description);
            }
            Console.WriteLine("*******");
            producManager.Add(new Product {BrandId=5, ColorId=7,DailyPrice=5000,Description="Ultra Lüks",Id=8,ModelYear=2021 });
            foreach (var p in producManager.GetAll())
            {
                Console.WriteLine(p.BrandId + " " + p.Id + " " + p.Description);
            }

            Console.WriteLine("*******");

            producManager.Delete(new Product { Id = 3 });
            foreach (var p in producManager.GetAll())
            {
                Console.WriteLine(p.BrandId + " " + p.Id + " " + p.Description);
            }

            Console.WriteLine("*******");
            producManager.Update(new Product {Id=8, Description="değişti"});
            foreach (var p in producManager.GetAll())
            {
                Console.WriteLine(p.BrandId + " " + p.Id + " " + p.Description);
            }

            Console.WriteLine("*******");
            foreach (var p in producManager.GetByBrandId(2))
            {
                Console.WriteLine(p.BrandId+ " "+p.Id + " " + p.Description);
            }
        }
        
    }
}
