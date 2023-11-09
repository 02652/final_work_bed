using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CModelos;

namespace CDatos
{
    public class CDEmpleado
    {
        private CDConexion cn = new CDConexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable ShowEmpleados()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MOSTRAR_EMPLEADOS";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

        public void InsertEmpleado(CMEmpleado empleado)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_INSERTAR_EMPLEADO";
            cmd.Parameters.AddWithValue("@cod_emp", empleado.Cod_emp);
            cmd.Parameters.AddWithValue("@apellido_emp", empleado.Apellido_emp);
            cmd.Parameters.AddWithValue("@oficio", empleado.Oficio);
            cmd.Parameters.AddWithValue("@direccion_emp", empleado.Direccion_emp);
            cmd.Parameters.AddWithValue("@fecha_alta", empleado.Fecha_alta);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@salario", empleado.Salario);
            cmd.Parameters.AddWithValue("@comision", empleado.Comision);
            cmd.Parameters.AddWithValue("@cod_dept", empleado.Cod_dept);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public void DeleteEmpleado(CMEmpleado empleado)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ELIMINAR_EMPLEADO";
            cmd.Parameters.AddWithValue("@cod_emp", empleado.Cod_emp);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }
        public void UpdateEmpleado(CMEmpleado empleado)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ACTUALIZAR_EMPLEADO";
            cmd.Parameters.AddWithValue("@cod_emp", empleado.Cod_emp);
            cmd.Parameters.AddWithValue("@apellido_emp", empleado.Apellido_emp);
            cmd.Parameters.AddWithValue("@oficio", empleado.Oficio);
            cmd.Parameters.AddWithValue("@direccion_emp", empleado.Direccion_emp);
            cmd.Parameters.AddWithValue("@fecha_alta", empleado.Fecha_alta);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@salario", empleado.Salario);
            cmd.Parameters.AddWithValue("@comision", empleado.Comision);
            cmd.Parameters.AddWithValue("@cod_dept", empleado.Cod_dept);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public DataTable SearchEmpleado(CMEmpleado empleado)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_BUSCAR_EMPLEADO";
            cmd.Parameters.AddWithValue("@cod_emp", empleado.Cod_emp);

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
    }
}
