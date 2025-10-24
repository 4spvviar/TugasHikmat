using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TugasHikmat
{
    internal class Connection
    {
        private const string ConnectionString = "Data Source=MYPCPRO\\MyPC PRO;Initial Catalog=db_login;Integrated Security=True;TrustServerCertificate=Tru";

        public SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }
    }
}
