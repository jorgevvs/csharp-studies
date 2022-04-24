using StoreDataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDataBase.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }

        private ProductRepository productRepository = new ProductRepository();

        public Sale(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            TotalValue = product.Price * Quantity;
        }
        public Sale(int id, int productId, int quantity, double value)
        {
            Id = id;
            Product = productRepository.GetProductById(productId);
            Quantity = quantity;
            TotalValue = value;
        }
    }
}
