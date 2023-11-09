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
    public class CNDepartamento
    {
        private CDDepartamento cdDepartamento = new CDDepartamento();

        public DataTable ShowDepartamentos()
        {
            return cdDepartamento.ShowDepartamentos();
        }

        public DataTable SearchDepartamento(CMDepartamento departamento)
        {
            return cdDepartamento.SearchDepartamento(departamento);
        }

        public void InsertDepartamento(CMDepartamento departamento)
        {
            cdDepartamento.InsertDepartamento(departamento);
        }

        public void DeleteDepartamento(CMDepartamento departamento)
        {
            cdDepartamento.DeleteDepartamento(departamento);
        }

        public void UpdateDepartamento(CMDepartamento departamento)
        {
            cdDepartamento.UpdateDepartamento(departamento);
        }
    }
}
