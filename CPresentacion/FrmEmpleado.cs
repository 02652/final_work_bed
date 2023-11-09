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
    public partial class FrmEmpleado : Form
    {
        private CNEmpleado objEmpleado = new CNEmpleado();
        private CNDepartamento objDepartamento = new CNDepartamento();

        public FrmEmpleado()
        {
            InitializeComponent();
        }


        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            ShowEmpleados();
            fillCmbDepartamentos();
        }

        private void ShowEmpleados()
        {

            dgvEmpleados.DataSource = objEmpleado.ShowEmpleados();
            
        }

        private void fillCmbDepartamentos()
        {
            cmbDepartamento.DataSource = objDepartamento.ShowDepartamentos();
            cmbDepartamento.DisplayMember = "cod_dept";
            cmbDepartamento.ValueMember = "cod_dept";  

        }

        private void Save()
        {
            try
            {
                CMEmpleado empleado = new CMEmpleado();
                empleado.Cod_emp = txtCodEmp.Text;
                empleado.Apellido_emp = txtApellidoEmp.Text;
                empleado.Oficio = txtOficio.Text;
                empleado.Fecha_alta = dtpFechaAlta.Value;
                empleado.Fecha_nacimiento = dtpFechaNacimiento.Value;
                empleado.Direccion_emp = txtDireccionEmp.Text;
                empleado.Salario = (float)Convert.ToDouble(txtSalario.Text);
                empleado.Comision = (float)Convert.ToDouble(txtComision.Text);
                empleado.Cod_dept = Convert.ToString(cmbDepartamento.SelectedValue);



                objEmpleado.InsertEmpleado(empleado);
                Clean();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de guardar el empleado?", "Guardar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Save();
                MessageBox.Show("Empleado Guardado");
                ShowEmpleados();
                Clean();
            }
        }

        private void Edit()
        {
            try
            {
                CMEmpleado empleado = new CMEmpleado();
                empleado.Cod_emp = txtCodEmp.Text;
                empleado.Apellido_emp = txtApellidoEmp.Text;
                empleado.Oficio = txtOficio.Text;
                empleado.Fecha_alta = dtpFechaAlta.Value;
                empleado.Fecha_nacimiento = dtpFechaNacimiento.Value;
                empleado.Direccion_emp = txtDireccionEmp.Text;
                empleado.Salario = (float)Convert.ToDouble(txtSalario.Text);
                empleado.Comision = (float)Convert.ToDouble(txtComision.Text);
                empleado.Cod_dept = Convert.ToString(cmbDepartamento.SelectedValue);



                objEmpleado.UpdateEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de editar el empleado?", "Guardar empleado editado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Edit();
                MessageBox.Show("Empleado Editado");
                ShowEmpleados();
            }
        }
        private void Delete()
        {
            CMEmpleado empleado = new CMEmpleado();
            empleado.Cod_emp = txtCodEmp.Text;
            objEmpleado.DeleteEmpleado(empleado);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el empleado?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Delete();
                MessageBox.Show("Empleado Eliminado");
                ShowEmpleados();
            }
        }

        private void Search()
        {
            CMEmpleado empleado = new CMEmpleado();
            empleado.Cod_emp = txtCodEmp.Text;
            CNEmpleado objSearchEmpleado = new CNEmpleado();
            dgvEmpleados.DataSource = objSearchEmpleado.SearchEmpleado(empleado);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Clean()
        {
            Thread hilo = new Thread(CleanInThread);
            hilo.Start();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = objEmpleado.ShowEmpleados();
            cmbDepartamento.SelectedIndex = -1;

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

            txtCodEmp.Invoke((MethodInvoker)delegate
            {
                txtCodEmp.Focus();
            });

            dtpFechaAlta.Invoke((MethodInvoker)delegate
            {
                dtpFechaAlta.Value = DateTime.Now;
            });
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar todo el contenido?", "Limpiar contenido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Clean();
            }
        }

        private void dgvEmpleados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodEmp.Text = dgvEmpleados.CurrentRow.Cells["cod_emp"].Value.ToString();
            txtApellidoEmp.Text = dgvEmpleados.CurrentRow.Cells["apellido_emp"].Value.ToString();
            txtOficio.Text = dgvEmpleados.CurrentRow.Cells["oficio"].Value.ToString();
            txtDireccionEmp.Text = dgvEmpleados.CurrentRow.Cells["direccion_emp"].Value.ToString();
            txtSalario.Text = dgvEmpleados.CurrentRow.Cells["salario"].Value.ToString();
            dtpFechaAlta.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fecha_alta"].Value.ToString());
            txtComision.Text = dgvEmpleados.CurrentRow.Cells["comision"].Value.ToString();
            cmbDepartamento.Text = dgvEmpleados.CurrentRow.Cells["cod_dept"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fecha_nacimiento"].Value.ToString());

        }

        
    }
}
