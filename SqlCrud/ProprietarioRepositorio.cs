using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlCrud
{
    public class ProprietarioRepositorio
    {
        protected DbContext _dbContext;

        public ProprietarioRepositorio()
        {
            _dbContext = new DbContext();
        }

        public Proprietario Adicionar(Proprietario proprietario)
        {
            _dbContext.Conectar();

            string command = $"INSERT INTO Proprietario OUTPUT inserted.Id VALUES ('{proprietario.Nome}', {proprietario.Telefone})";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            proprietario.Id = (int)cmd.ExecuteScalar();

            _dbContext.Desconectar();

            return proprietario;
        }

        public void Remover(int id)
        {
            _dbContext.Conectar();

            string command = $"delete from Proprietario where ID= {id}";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            cmd.ExecuteScalar();

            _dbContext.Desconectar();
        }

        public Proprietario GetProprietarioById(int id)
        {
            _dbContext.Conectar();

            string command = $"select * from Proprietario where ID= {id}";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            SqlDataReader retorno = cmd.ExecuteReader();

            Proprietario proprietario = new Proprietario();

            while(retorno.Read()){
                proprietario.Nome = retorno.GetString(1);
                proprietario.Telefone = retorno.GetString(2);
                proprietario.Id = retorno.GetInt32(0);
            }

            _dbContext.Desconectar();

            return proprietario;
        }

    }
}
