using CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDReportes
    {
        private CDConexion cn = new CDConexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable MostrarEmpleadosSinComision()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EMPLEADOS_SIN_COMISION";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

        public DataTable MostrarEmpleadosConSuDepartamento()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EMPLEADOS_CON_SU_DEPARTAMENTO";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
        public DataTable MostrarEmpleadosPorCadaDepartamento()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EMPLEADOS_POR_CADA_DEPARTAMENTO";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
        public DataTable MotrarDepartamentoConMayorComision()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DEPARTAMENTO_CON_MAYOR_COMISION";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
        public DataTable MostrarTotalPorDepartamento()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_TOTAL_POR_DEPARTAMENTO";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

        public DataTable MostrarEdadEmfermoAntes2010()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EDAD_ENFERMO_ANTES_2010";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

    }

}
