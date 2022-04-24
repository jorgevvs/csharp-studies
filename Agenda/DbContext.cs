﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Contacts
{
    public class DbContext
    {
        // https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=net-6.0

        const string strCon = @"Data Source=(LocalDb)\MSSQLLocalDB; Initial Catalog=ContactsList;Integrated Security=SSPI;";

        public DbContext()
        {
            SqlConnection = new SqlConnection(strCon);
        }

        public SqlConnection SqlConnection { get; set; }

    }
}
