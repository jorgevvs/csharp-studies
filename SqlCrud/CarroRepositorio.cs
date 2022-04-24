using System.Data.SqlClient;

namespace SqlCrud
{
    public class CarroRepositorio
    {
        protected DbContext _dbContext;
        private ProprietarioRepositorio _proprietarioRepositorio;

        public CarroRepositorio()
        {
            _dbContext = new DbContext();
            _proprietarioRepositorio = new ProprietarioRepositorio();
        }

        public Carro Adicionar(Carro carro)
        {
            _dbContext.Conectar();

            string command = $"INSERT INTO Carro OUTPUT inserted.Id VALUES ('{carro.Modelo}', {carro.Ano}, {carro.Proprietario.Id})";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            carro.Id = (int)cmd.ExecuteScalar(); 

            _dbContext.Desconectar();

            return carro;
        }

        public void Remover(int id)
        {
            _dbContext.Conectar();

            string command = $"delete from Carro where ID= {id};";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            cmd.ExecuteScalar();

            _dbContext.Desconectar();
        }

        public Carro Altera(Carro carro, int id)
        {
            _dbContext.Conectar();

            string command = $"update Carro set MODELO = '{carro.Modelo}', ANO = {carro.Ano}, PROPRIETARIO = {carro.Proprietario.Id} where ID = {id}";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            cmd.ExecuteScalar();

            _dbContext.Desconectar();

            return carro;
        }

        public Carro GetCarroById(int id)
        {
            _dbContext.Conectar();

            string command = $"select * from Carro where ID = {id}";
            SqlCommand cmd = new SqlCommand(command, _dbContext.SqlConnection);

            SqlDataReader retorno = cmd.ExecuteReader();

            Carro carro = new Carro();

            while (retorno.Read())
            {
                carro.Id = retorno.GetInt32(0);
                carro.Modelo = retorno.GetString(1);
                carro.Ano = retorno.GetInt32(2);
                carro.Proprietario = _proprietarioRepositorio.GetProprietarioById(retorno.GetInt32(3));
            }

            _dbContext.Desconectar(); 

            return carro;
        }




    }
}
