using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Contrato
{
    public class connDB
    {
        string conn = "Data Source=192.168.1.3;Initial Catalog=froma;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014";
        public SqlConnection conndb = new SqlConnection();

        public connDB()
        {
            conndb.ConnectionString = conn;
        }

        public void openConn()
        {
            try
            {
                conndb.Open();
                Console.WriteLine("Conetado a la base de datos");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conectar con la base de datos " + e.Message);
            }
        }

        public void closeConn()
        {
            conndb.Close();
        }
    }
}