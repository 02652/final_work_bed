using CModelos;
using CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FrmEnfermo : Form
    {
        public FrmEnfermo()
        {
            InitializeComponent();
        }

        private void FrmEnfermo_Load(object sender, EventArgs e)
        {
            ShowEnfermos();
        }

        private CNEnfermo objEnfermo = new CNEnfermo();
        private CNDepartamento objDepartamento = new CNDepartamento();

        private void ShowEnfermos()
        {

            dgvEnfermos.DataSource = objEnfermo.ShowEnfermos();

        }

        Char gender;
        private void Save()
        {
            try
            {

                //private char sexo;
                CMEnfermo enfermo = new CMEnfermo();
                enfermo.Cod_enf = txtCodEnf.Text;
                enfermo.Apellido_enf = txtApellidoEnf.Text;
                enfermo.Direccion_enf = txtDireccionEnf.Text;
                enfermo.Fecha_incripcion = dtpFechaInscripcion.Value;
                enfermo.Fecha_nacimiento = dtpFechaNacimiento.Value;
                enfermo.Nss = txtNss.Text;

                if (rbMale.Checked)
                {
                    gender = 'M';
                }
                if (rbFemale.Checked)
                {
                    gender = 'F';
                }
                enfermo.Sexo = gender;


                objEnfermo.InsertEnfermo(enfermo);
                Clean();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de guardar al enfermo?", "Guardar enfermo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Save();
                MessageBox.Show("Enfermo Guardado");
                ShowEnfermos();
                Clean();
            }
        }

        private void Edit()
        {
            try
            {
                CMEnfermo enfermo = new CMEnfermo();
                enfermo.Cod_enf = txtCodEnf.Text;
                enfermo.Apellido_enf = txtApellidoEnf.Text;
                enfermo.Direccion_enf = txtDireccionEnf.Text;
                enfermo.Fecha_incripcion = dtpFechaInscripcion.Value;
                enfermo.Fecha_nacimiento = dtpFechaNacimiento.Value;
                enfermo.Nss = txtNss.Text;

                if (rbMale.Checked)
                {
                    gender = 'M';
                }
                if (rbFemale.Checked)
                {
                    gender = 'F';
                }
                enfermo.Sexo = gender;


                objEnfermo.UpdateEnfermo(enfermo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de editar al enfermo?", "Editar enfermo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Edit();
                MessageBox.Show("Enfermo Editado");
                ShowEnfermos();
            }
        }
        private void Delete()
        {
            CMEnfermo enfermo = new CMEnfermo();
            enfermo.Cod_enf = txtCodEnf.Text;
            objEnfermo.DeleteEnfermo(enfermo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el enfermo?", "Eliminar enfermo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Delete();
                MessageBox.Show("Empleado Eliminado");
                ShowEnfermos();
            }
        }

        private void Search()
        {
            CMEnfermo enfermo = new CMEnfermo();
            enfermo.Cod_enf = txtCodEnf.Text;
            CNEnfermo objSearchEnfermo = new CNEnfermo();
            dgvEnfermos.DataSource = objSearchEnfermo.SearchEnfermo(enfermo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Clean()
        {
            Thread hilo = new Thread(CleanInThread);
            hilo.Start();
            dgvEnfermos.DataSource = null;
            dgvEnfermos.DataSource = objEnfermo.ShowEnfermos();

        }

        private void CleanInThread()
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (Control i in this.Controls)
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
            });

            txtCodEnf.Invoke((MethodInvoker)delegate
            {
                txtCodEnf.Focus();
            });

            dtpFechaInscripcion.Invoke((MethodInvoker)delegate
            {
                dtpFechaInscripcion.Value = DateTime.Now;
            });

            dtpFechaNacimiento.Invoke((MethodInvoker)delegate
            {
                dtpFechaNacimiento.Value = DateTime.Now;
            });
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar todo el contenido?", "Limpiar contenido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Clean();
            }
        }

        private void dgvEnfermosCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodEnf.Text = dgvEnfermos.CurrentRow.Cells["cod_enf"].Value.ToString();
            txtApellidoEnf.Text = dgvEnfermos.CurrentRow.Cells["apellido_enf"].Value.ToString();
            txtDireccionEnf.Text = dgvEnfermos.CurrentRow.Cells["direccion_enf"].Value.ToString();
            dtpFechaInscripcion.Value = Convert.ToDateTime(dgvEnfermos.CurrentRow.Cells["fecha_incripcion"].Value.ToString());
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvEnfermos.CurrentRow.Cells["fecha_nacimiento"].Value.ToString());
            txtNss.Text = dgvEnfermos.CurrentRow.Cells["nss"].Value.ToString();
            if (dgvEnfermos.CurrentRow.Cells["sexo"].Value.ToString() == "M") {
                rbMale.Checked = true;
            }
            if (dgvEnfermos.CurrentRow.Cells["sexo"].Value.ToString() == "F")
            {
                rbFemale.Checked = true;
            }



        }

        

        
    }
}
