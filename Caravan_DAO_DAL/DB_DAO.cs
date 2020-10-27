using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Usuario_DAO_DAL
{
    public class DB_DAO
    {
        private static MySqlConnection objConnection;

        public static MySqlConnection gettObjConnection()
        {
            if (objConnection == null)
            {
                objConnection = new MySqlConnection();
                objConnection.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            }
            return objConnection;
        }

        public static void AbreConn()
        {
            if (gettObjConnection().State == ConnectionState.Closed)
            {
                objConnection.Open();
            }
        }

        public static void FechaConn()
        {
            if (gettObjConnection().State == ConnectionState.Open)
            {
                objConnection.Close();
                objConnection.Dispose();
                objConnection = null;
            }
        }

    }
}
