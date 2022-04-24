using StoreDataBase.Entities;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace StoreDataBase.Repositories
{
    public class ProductRepository
    {
        protected DbContext _dbContext;

        public ProductRepository()
        {
            _dbContext = new DbContext();
        }


        public Product Add(Product product)
        {
            product.Id = _dbContext.SqlConnection.QuerySingle<int>($"INSERT INTO Product OUTPUT inserted.Id VALUES ('{product.Name}', {product.Stock}, {product.Price},(Select Id from Section where Id = {product.Section.Id}) )");
            return product;

        }
        public void Remove(int id)
        {
            _dbContext.SqlConnection.Query($"REMOVE * FROM Product where ID = {id}");
        }

        public Product GetProductById(int id)
        {
            return _dbContext.SqlConnection.QuerySingle<Product>($"Select * from Product where ID = {id}");
        }
    }
}
