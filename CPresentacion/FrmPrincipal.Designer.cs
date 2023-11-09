namespace CPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VerticalMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEnfermos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.WindowsOpcionPanel = new System.Windows.Forms.Panel();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.VerticalMenu.SuspendLayout();
            this.WindowsOpcionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // VerticalMenu
            // 
            this.VerticalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.VerticalMenu.Controls.Add(this.btnReportes);
            this.VerticalMenu.Controls.Add(this.btnEnfermos);
            this.VerticalMenu.Controls.Add(this.btnEmpleados);
            this.VerticalMenu.Controls.Add(this.btnDepartamentos);
            this.VerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalMenu.Location = new System.Drawing.Point(0, 0);
            this.VerticalMenu.Name = "VerticalMenu";
            this.VerticalMenu.Size = new System.Drawing.Size(250, 650);
            this.VerticalMenu.TabIndex = 1;
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = true;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(3, 153);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnReportes.Size = new System.Drawing.Size(247, 85);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnEnfermos
            // 
            this.btnEnfermos.AutoSize = true;
            this.btnEnfermos.BackColor = System.Drawing.Color.Transparent;
            this.btnEnfermos.FlatAppearance.BorderSize = 0;
            this.btnEnfermos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnEnfermos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnfermos.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.btnEnfermos.ForeColor = System.Drawing.Color.White;
            this.btnEnfermos.Image = ((System.Drawing.Image)(resources.GetObject("btnEnfermos.Image")));
            this.btnEnfermos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnfermos.Location = new System.Drawing.Point(0, 426);
            this.btnEnfermos.Name = "btnEnfermos";
            this.btnEnfermos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnEnfermos.Size = new System.Drawing.Size(247, 85);
            this.btnEnfermos.TabIndex = 2;
            this.btnEnfermos.Text = "Enfermos";
            this.btnEnfermos.UseVisualStyleBackColor = false;
            this.btnEnfermos.Click += new System.EventHandler(this.btnEnfermos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = true;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 335);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnEmpleados.Size = new System.Drawing.Size(247, 85);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.AutoSize = true;
            this.btnDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.btnDepartamentos.ForeColor = System.Drawing.Color.White;
            this.btnDepartamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartamentos.Image")));
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.Location = new System.Drawing.Point(0, 244);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnDepartamentos.Size = new System.Drawing.Size(247, 85);
            this.btnDepartamentos.TabIndex = 0;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // WindowsOpcionPanel
            // 
            this.WindowsOpcionPanel.Controls.Add(this.iconMaximize);
            this.WindowsOpcionPanel.Controls.Add(this.iconClose);
            this.WindowsOpcionPanel.Controls.Add(this.iconRestore);
            this.WindowsOpcionPanel.Controls.Add(this.iconMinimize);
            this.WindowsOpcionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowsOpcionPanel.Location = new System.Drawing.Point(250, 0);
            this.WindowsOpcionPanel.Name = "WindowsOpcionPanel";
            this.WindowsOpcionPanel.Size = new System.Drawing.Size(1050, 50);
            this.WindowsOpcionPanel.TabIndex = 4;
            this.WindowsOpcionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowsOpcionPanel_MouseDown);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximize.Image")));
            this.iconMaximize.Location = new System.Drawing.Point(974, 12);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(24, 24);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconMaximize.TabIndex = 3;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1012, 12);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(24, 24);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconClose.TabIndex = 5;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // iconRestore
            // 
            this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestore.Image = ((System.Drawing.Image)(resources.GetObject("iconRestore.Image")));
            this.iconRestore.Location = new System.Drawing.Point(974, 12);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(24, 24);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconRestore.TabIndex = 3;
            this.iconRestore.TabStop = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(936, 12);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(24, 24);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(250, 50);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1050, 600);
            this.ContainerPanel.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.WindowsOpcionPanel);
            this.Controls.Add(this.VerticalMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.VerticalMenu.ResumeLayout(false);
            this.VerticalMenu.PerformLayout();
            this.WindowsOpcionPanel.ResumeLayout(false);
            this.WindowsOpcionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel VerticalMenu;
        private System.Windows.Forms.Panel WindowsOpcionPanel;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.Button btnEnfermos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Button btnReportes;
    }
}