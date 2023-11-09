using CDatos;
using CModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio
{
    public class CNEmpleado
    {
        private CDEmpleado cdEmpleado = new CDEmpleado();

        public DataTable ShowEmpleados()
        {
            return cdEmpleado.ShowEmpleados();
        }

        public DataTable SearchEmpleado(CMEmpleado empleado)
        {
            return cdEmpleado.SearchEmpleado(empleado);
        }

        public void InsertEmpleado(CMEmpleado empleado)
        {
            cdEmpleado.InsertEmpleado(empleado);
        }

        public void DeleteEmpleado(CMEmpleado empleado)
        {
            cdEmpleado.DeleteEmpleado(empleado);
        }

        public void UpdateEmpleado(CMEmpleado empleado)
        {
            cdEmpleado.UpdateEmpleado(empleado);
        }
    }
}
