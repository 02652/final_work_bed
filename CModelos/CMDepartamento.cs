using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CModelos
{
    public class CMDepartamento
    {
        private string cod_dept;
        private string nombre_dept;
        private string locacion;

        public string Cod_dept { get => cod_dept; set => cod_dept = value; }
        public string Nombre_dept { get => nombre_dept; set => nombre_dept = value; }
        public string Locacion { get => locacion; set => locacion = value; }
    }
}
