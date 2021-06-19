using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KurshachKorepi4.utils.database_api
{
    class Database
    {
        public SqlConnection sqlConnection;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\LORD2\source\repos\KurshachKorepi4\KurshachKorepi4\bin\Debug\Vehicle.mdf';Integrated Security=True;";
        public void ConnectSql()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
    }
}
