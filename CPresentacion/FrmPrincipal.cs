using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMaximize.Visible = false;
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestore.Visible = false;
            iconMaximize.Visible = true;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WindowsOpcionPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenFormInPanel(object FormChild)
        {
           if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);

            Form fh = FormChild as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(fh);
            this.ContainerPanel.Tag = fh;
            fh.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmDepartamento());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmEmpleado());
        }

        private void btnEnfermos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmEnfermo());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmReportes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmReportes());

        }
    }
}
