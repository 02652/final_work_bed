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
    public class CDEnfermo
    {
        private CDConexion cn = new CDConexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable ShowEnfermos()
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MOSTRAR_ENFERMOS";

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }

        public void InsertEnfermo(CMEnfermo enfermo)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_INSERTAR_ENFERMO";
            cmd.Parameters.AddWithValue("@cod_enf", enfermo.Cod_enf);
            cmd.Parameters.AddWithValue("@apellido_enf", enfermo.Apellido_enf);
            cmd.Parameters.AddWithValue("@direccion_enf", enfermo.Direccion_enf);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", enfermo.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@fecha_incripcion", enfermo.Fecha_incripcion);
            cmd.Parameters.AddWithValue("@sexo", enfermo.Sexo);
            cmd.Parameters.AddWithValue("@nss", enfermo.Nss);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public void DeleteEnfermo(CMEnfermo enfermo)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ELIMINAR_ENFERMO";
            cmd.Parameters.AddWithValue("@cod_enf", enfermo.Cod_enf);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }
        public void UpdateEnfermo(CMEnfermo enfermo)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_ACTUALIZAR_ENFERMO";
            cmd.Parameters.AddWithValue("@cod_enf", enfermo.Cod_enf);
            cmd.Parameters.AddWithValue("@apellido_enf", enfermo.Apellido_enf);
            cmd.Parameters.AddWithValue("@direccion_enf", enfermo.Direccion_enf);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", enfermo.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@fecha_incripcion", enfermo.Fecha_incripcion);
            cmd.Parameters.AddWithValue("@sexo", enfermo.Sexo);
            cmd.Parameters.AddWithValue("@nss", enfermo.Nss);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Disconnect();
        }

        public DataTable SearchEnfermo(CMEnfermo enfermo)
        {
            cmd.Connection = cn.Connect();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SP_BUSCAR_ENFERMO";
            cmd.Parameters.AddWithValue("@cod_enf", enfermo.Cod_enf);

            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dr.Close();
            cn.Disconnect();
            return dt;
        }
    }
}
