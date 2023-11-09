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
    public class CNEnfermo
    {
        private CDEnfermo cdEnfermo = new CDEnfermo();

        public DataTable ShowEnfermos()
        {
            return cdEnfermo.ShowEnfermos();
        }

        public DataTable SearchEnfermo(CMEnfermo enfermo)
        {
            return cdEnfermo.SearchEnfermo(enfermo);
        }

        public void InsertEnfermo(CMEnfermo enfermo)
        {
            cdEnfermo.InsertEnfermo(enfermo);
        }

        public void DeleteEnfermo(CMEnfermo enfermo)
        {
            cdEnfermo.DeleteEnfermo(enfermo);
        }

        public void UpdateEnfermo(CMEnfermo enfermo)
        {
            cdEnfermo.UpdateEnfermo(enfermo);
        }
    }
}
