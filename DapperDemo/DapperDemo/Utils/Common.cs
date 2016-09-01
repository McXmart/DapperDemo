using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DapperDemo.Utils
{
    public class Common
    {
        public enum Type
        {
            A,
            B,
            C
        }

        public static IDbConnection OpenConnection()
        {
            IDbConnection connection = new SqlConnection("Data Source=10.10.10.2;Initial Catalog=FxDemoDB;Persist Security Info=True;User ID=fxdemouser;Password=fxdemouser2016");
            connection.Open();
            return connection;
        }
    }
}
