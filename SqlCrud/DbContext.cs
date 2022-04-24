using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlCrud
{
    public class DbContext
    {
        // https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=net-6.0

        const string strCon = @"Data Source=(LocalDb)\MSSQLLocalDB; Initial Catalog=SqlCrud;Integrated Security=SSPI;";
        //const string strCon = @"Server=(LocalDb)\\MSSqlLocalDb;Initial Catalog=SqlCrud;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbContext()
        {
            SqlConnection = new SqlConnection(strCon);
        }

        public SqlConnection SqlConnection { get; set; }

        public SqlConnection Conectar()
        {
            if (SqlConnection != null)
            {
                SqlConnection.Open();
            }

            return SqlConnection;
        }

        public void Desconectar()
        {
            if (SqlConnection != null)
            {
                SqlConnection.Close();
            }
        }
    }
}
