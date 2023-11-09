using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    class CDConexion
    {
        static string connectionStr = "server=localhost;uid=sa;pwd=senati;database=db_clinica_buena_salud;";
        //static string connectionStr = "Data Source=.;Initial Catalog=db_clinica_buena_salud;Integrated Security=True";
        private SqlConnection cn = new SqlConnection(connectionStr);
        public SqlConnection Connect()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }

        public SqlConnection Disconnect()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }

    }
}
