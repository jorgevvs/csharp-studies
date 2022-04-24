using StoreDataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDataBase.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public SectionProduct Section { get; set; }

        private SectionRepository sectionRepository = new SectionRepository();

        public Product(string name, int stock, double price, SectionProduct section)
        {
            Name = name;
            Stock = stock;
            Price = price;
            Section = section;
        }
        public Product(int id, string name, int stock, double price, int Section)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Price = price;
            this.Section = sectionRepository.GetSectionById(Section);
        }
    }
}
