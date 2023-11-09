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
using CNegocio;
using CModelos;

namespace CPresentacion
{
    public partial class FrmReportes : Form
    {
        CNDepartamento objDepartamento = new CNDepartamento();
        CNReportes objReportes = new CNReportes();

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }
        
        private void btnReportes1_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();

            formularioReporte.ConfigurarInforme(objR1.MostrarEmpleadosSinComision(), btnReportes1.Text);
            formularioReporte.ShowDialog();

        }

        private void btnReportes2_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();


            formularioReporte.ConfigurarInforme(objR1.MostrarEmpleadosConSuDepartamento(), btnReportes2.Text);
            formularioReporte.ShowDialog();
        }

        private void btnReportes3_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();

            formularioReporte.ConfigurarInforme(objR1.MostrarEmpleadosPorCadaDepartamento(), btnReportes3.Text);
            formularioReporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();

            formularioReporte.ConfigurarInforme(objR1.MotrarDepartamentoConMayorComision(), button1.Text);
            formularioReporte.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();

            formularioReporte.ConfigurarInforme(objR1.MostrarTotalPorDepartamento(), button2.Text);
            formularioReporte.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmReportView formularioReporte = new FrmReportView();
            CNReportes objR1 = new CNReportes();

            formularioReporte.ConfigurarInforme(objR1.MostrarEdadEmfermoAntes2010(), button3.Text);
            formularioReporte.ShowDialog();
        }
    }
}
