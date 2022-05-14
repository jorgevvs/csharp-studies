using StoreDataBase.Entities;

using Dapper;

namespace StoreDataBase.Repositories
{
    public class SaleRepository
    {
        protected DbContext _dbContext;

        public SaleRepository()
        {
            _dbContext = new DbContext();
        }


        public Sale Add(Sale sale)
        {
            sale.Id = _dbContext.SqlConnection.QuerySingle<int>($"INSERT INTO Sale OUTPUT inserted.Id VALUES ((Select Id from Product where Id = {sale.Product.Id}), {sale.Quantity}, {sale.TotalValue})");

            return sale;
            
        }
        public void Remove(int id)
        {
            _dbContext.SqlConnection.Query($"Delete FROM Sale where ID = {id}");
        }

        public Sale GetSaleById(int id)
        {
            return _dbContext.SqlConnection.QuerySingle<Sale>($"Select * from Sale where ID = {id}");
        }
    }
}
