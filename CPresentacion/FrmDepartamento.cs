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
using CModelos;
using CNegocio;

namespace CPresentacion
{
    public partial class FrmDepartamento : Form
    {
        private CNDepartamento objDepartamento = new CNDepartamento();

        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            ShowDepartamentos();
        }

        private void ShowDepartamentos()
        {

            dgvDepartamentos.DataSource = objDepartamento.ShowDepartamentos();
        }

        private void Save()
        {
            try
            {
                CMDepartamento departamento = new CMDepartamento();
                departamento.Cod_dept = txtCodDept.Text;
                departamento.Nombre_dept = txtNombreDept.Text;
                departamento.Locacion = txtLocacion.Text;

                objDepartamento.InsertDepartamento(departamento);
                Clean();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de guardar el departamento?", "Guardar departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Save();
                MessageBox.Show("Departamento Guardado");
                ShowDepartamentos();
                Clean();
            }

        }

        private void Edit()
        {
            try
            {
                CMDepartamento departamento = new CMDepartamento();
                departamento.Cod_dept = txtCodDept.Text;
                departamento.Nombre_dept = txtNombreDept.Text;
                departamento.Locacion = txtLocacion.Text;

                objDepartamento.UpdateDepartamento(departamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de editar el departamento?", "Guardar departamento editado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Edit();
                MessageBox.Show("Departamento Editado");
                ShowDepartamentos();
            }
        }
        private void Delete()
        {
            CMDepartamento departamento = new CMDepartamento();
            departamento.Cod_dept = txtCodDept.Text;
            objDepartamento.DeleteDepartamento(departamento);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el departamento?", "Eliminar departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Delete();
                MessageBox.Show("Departamento Eliminado");
                ShowDepartamentos();
            }
        }

        private void Search()
        {
            CMDepartamento departamento = new CMDepartamento();
            departamento.Cod_dept = txtCodDept.Text;
            CNDepartamento objSearchDepartamento = new CNDepartamento();
            dgvDepartamentos.DataSource = objSearchDepartamento.SearchDepartamento(departamento);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Clean()
        {
            Thread hilo = new Thread(CleanInThread);
            hilo.Start();
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = objDepartamento.ShowDepartamentos();

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

            txtCodDept.Invoke((MethodInvoker)delegate
            {
                txtCodDept.Focus();
            });
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar todo el contenido?", "Limpiar contenido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Clean();
            }
        }

        private void dgvDepartamentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodDept.Text = dgvDepartamentos.CurrentRow.Cells["cod_dept"].Value.ToString();
            txtNombreDept.Text = dgvDepartamentos.CurrentRow.Cells["nombre_dept"].Value.ToString();
            txtLocacion.Text = dgvDepartamentos.CurrentRow.Cells["locacion"].Value.ToString();
        }

    }
}
