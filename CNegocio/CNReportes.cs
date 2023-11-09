using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    public class CNReportes
    {
        private CDReportes cdReportes = new CDReportes();

        public DataTable MostrarEmpleadosSinComision()
        {
            return cdReportes.MostrarEmpleadosSinComision();
        }

        public DataTable MostrarEmpleadosConSuDepartamento()
        {
            return cdReportes.MostrarEmpleadosConSuDepartamento();
        }
        public DataTable MostrarEmpleadosPorCadaDepartamento()
        {
            return cdReportes.MostrarEmpleadosPorCadaDepartamento();
        }
        public DataTable MotrarDepartamentoConMayorComision()
        {
            return cdReportes.MotrarDepartamentoConMayorComision();
        }
        public DataTable MostrarTotalPorDepartamento()
        {
            return cdReportes.MostrarTotalPorDepartamento();
        }

        public DataTable MostrarEdadEmfermoAntes2010()
        {
            return cdReportes.MostrarEdadEmfermoAntes2010();
        }
    }
}
