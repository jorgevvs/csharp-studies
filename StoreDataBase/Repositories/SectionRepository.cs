using StoreDataBase.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace StoreDataBase.Repositories
{
    public class SectionRepository
    {
        protected DbContext _dbContext;

        public SectionRepository()
        {
            _dbContext = new DbContext();
        }


        public SectionProduct Add(SectionProduct section)
        {
            section.Id = _dbContext.SqlConnection.QuerySingle<int>($"INSERT INTO Section OUTPUT inserted.Id VALUES ('{section.Name}')");

            return section;

            //_dbContext.Conectar();

            //string command = $"INSERT INTO Section OUTPUT inserted.Id VALUES ('{section.Name}')";
            //SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            //section.Id = (int)cmd.ExecuteScalar();

            //_dbContext.Desconectar();

            //return section;
        }
        public void Remove(int id)
        {
            _dbContext.SqlConnection.Query($"REMOVE * FROM Section where ID = {id}");

            //_dbContext.Conectar();

            //string command = $"REMOVE * FROM Section where ID = {id}";
            //SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            //cmd.ExecuteScalar();

            //_dbContext.Desconectar();
        }

        public SectionProduct GetSectionById(int id)
        {
            return _dbContext.SqlConnection.QuerySingle<SectionProduct>($"Select * FROM Section where ID = {id}");
        }
    }
}
