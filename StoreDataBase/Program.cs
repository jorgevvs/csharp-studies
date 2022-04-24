using StoreDataBase.Entities;
using StoreDataBase.Repositories;
using System;

namespace StoreDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepo = new ProductRepository();
            SectionRepository sectionRepo = new SectionRepository();
            SaleRepository saleRepo= new SaleRepository();

            SectionProduct section  = sectionRepo.Add(new SectionProduct("Tools"));
            SectionProduct section2 = sectionRepo.Add(new SectionProduct("Gadgets"));
            SectionProduct section3 = sectionRepo.Add(new SectionProduct("Notebooks"));

            Product product = productRepo.Add(new Product("Axe", 9, 90.50, section));
            Product product2 = productRepo.Add(new Product("Air Pod", 3, 190.50, section2));
            Product product3 = productRepo.Add(new Product("Aspire", 9, 390.50, section3));

           
            Sale sale = saleRepo.Add(new Sale(product, 3));
            Sale sale2 = saleRepo.Add(new Sale(product2, 2));
            Sale sale3 = saleRepo.Add(new Sale(product3, 5));

            Product resposta = productRepo.GetProductById(50);
            Sale respost = saleRepo.GetSaleById(5);
            Console.WriteLine(resposta.Name);
            Console.WriteLine(respost.Quantity);
        }

        
    }
}
