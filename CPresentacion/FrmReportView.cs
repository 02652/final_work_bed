using CNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FrmReportView : Form
    {
        private CNEmpleado objEmpleado = new CNEmpleado(); //Objeto de la clase CFor
        public FrmReportView()
        {
            InitializeComponent();
        }

        private void FrmReportView_Load(object sender, EventArgs e)
        {

        }

        public void ConfigurarInforme(DataTable data, string title)
        {
            dataGridView1.DataSource = data;
            lblTitle.Text = title;
        }

    }
}
