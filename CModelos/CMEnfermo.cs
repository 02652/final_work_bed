using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CModelos
{
    public class CMEnfermo
    {
        private string cod_enf;
        private string apellido_enf;
        private string direccion_enf;
        private DateTime fecha_nacimiento;
        private DateTime fecha_incripcion;
        private char sexo;
        private string nss;

        public string Cod_enf { get => cod_enf; set => cod_enf = value; }
        public string Apellido_enf { get => apellido_enf; set => apellido_enf = value; }
        public string Direccion_enf { get => direccion_enf; set => direccion_enf = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public DateTime Fecha_incripcion { get => fecha_incripcion; set => fecha_incripcion = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Nss { get => nss; set => nss = value; }
    }
}
