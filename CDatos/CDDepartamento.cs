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
    public class CDDepartamento
    {
        private CDConexion cn = new CDConexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable ShowDepartamentos()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MOSTRAR_DEPARTAMENTOS";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

        public void InsertDepartamento(CMDepartamento departamento)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_INSERTAR_DEPARTAMENTO";
            cmd.Parameters.AddWithValue("@cod_dept", departamento.Cod_dept);
            cmd.Parameters.AddWithValue("@nombre_dept", departamento.Nombre_dept);
            cmd.Parameters.AddWithValue("@locacion", departamento.Locacion);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public void DeleteDepartamento(CMDepartamento departamento)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ELIMINAR_DEPARTAMENTO";
            cmd.Parameters.AddWithValue("@cod_dept", departamento.Cod_dept);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }
        public void UpdateDepartamento(CMDepartamento departamento)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ACTUALIZAR_DEPARTAMENTO";
            cmd.Parameters.AddWithValue("@cod_dept", departamento.Cod_dept);
            cmd.Parameters.AddWithValue("@nombre_dept", departamento.Nombre_dept);
            cmd.Parameters.AddWithValue("@locacion", departamento.Locacion);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public DataTable SearchDepartamento(CMDepartamento departamento)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_BUSCAR_DEPARTAMENTO";
            cmd.Parameters.AddWithValue("@cod_dept", departamento.Cod_dept);

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
    }
}
