using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CModelos
{
    public class CMEmpleado
    {
        private string cod_emp;
        private string apellido_emp;
        private string oficio;
        private string direccion_emp;
        private DateTime fecha_alta;
        private DateTime fecha_nacimiento;
        private float salario;
        private float comision;
        private string cod_dept;

        public string Cod_emp { get => cod_emp; set => cod_emp = value; }
        public string Apellido_emp { get => apellido_emp; set => apellido_emp = value; }
        public string Oficio { get => oficio; set => oficio = value; }
        public string Direccion_emp { get => direccion_emp; set => direccion_emp = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public float Salario { get => salario; set => salario = value; }
        public float Comision { get => comision; set => comision = value; }
        public string Cod_dept { get => cod_dept; set => cod_dept = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }
}
