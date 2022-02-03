namespace Ventas_ERG
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnEditPro = new System.Windows.Forms.Button();
            this.btnNuevoPro = new System.Windows.Forms.Button();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnEditUs = new System.Windows.Forms.Button();
            this.btnNuevoUs = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirDocumentoToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.TsmSalir});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // emitirDocumentoToolStripMenuItem
            // 
            this.emitirDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.notaDeCréditoToolStripMenuItem});
            this.emitirDocumentoToolStripMenuItem.Name = "emitirDocumentoToolStripMenuItem";
            this.emitirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.emitirDocumentoToolStripMenuItem.Text = "Emitir Documento";
            // 
            // boletaToolStripMenuItem
            // 
            this.boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            this.boletaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.boletaToolStripMenuItem.Text = "Boleta";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // notaDeCréditoToolStripMenuItem
            // 
            this.notaDeCréditoToolStripMenuItem.Name = "notaDeCréditoToolStripMenuItem";
            this.notaDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.notaDeCréditoToolStripMenuItem.Text = "Nota de Crédito";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // TsmSalir
            // 
            this.TsmSalir.Name = "TsmSalir";
            this.TsmSalir.Size = new System.Drawing.Size(171, 22);
            this.TsmSalir.Text = "Salir";
            this.TsmSalir.Click += new System.EventHandler(this.TsmSalir_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnEliminarPro);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnEditPro);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnNuevoPro);
            this.panel1.Controls.Add(this.btnNuevaVenta);
            this.panel1.Controls.Add(this.btnEliminarUs);
            this.panel1.Controls.Add(this.btnNuevoUs);
            this.panel1.Controls.Add(this.btnEditUs);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 744);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(151, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 744);
            this.panel2.TabIndex = 2;
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarPro.Location = new System.Drawing.Point(3, 451);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(146, 42);
            this.btnEliminarPro.TabIndex = 5;
            this.btnEliminarPro.Text = "Eliminar Producto";
            this.btnEliminarPro.UseVisualStyleBackColor = false;
            // 
            // btnEditPro
            // 
            this.btnEditPro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditPro.Location = new System.Drawing.Point(3, 412);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(146, 42);
            this.btnEditPro.TabIndex = 4;
            this.btnEditPro.Text = "Editar Producto";
            this.btnEditPro.UseVisualStyleBackColor = false;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // btnNuevoPro
            // 
            this.btnNuevoPro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoPro.Location = new System.Drawing.Point(3, 373);
            this.btnNuevoPro.Name = "btnNuevoPro";
            this.btnNuevoPro.Size = new System.Drawing.Size(146, 42);
            this.btnNuevoPro.TabIndex = 3;
            this.btnNuevoPro.Text = "Nuevo Producto";
            this.btnNuevoPro.UseVisualStyleBackColor = false;
            this.btnNuevoPro.Click += new System.EventHandler(this.btnNuevoPro_Click);
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarUs.Location = new System.Drawing.Point(2, 364);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(146, 42);
            this.btnEliminarUs.TabIndex = 2;
            this.btnEliminarUs.Text = "Eliminar Usuario";
            this.btnEliminarUs.UseVisualStyleBackColor = false;
            // 
            // btnEditUs
            // 
            this.btnEditUs.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditUs.Location = new System.Drawing.Point(2, 325);
            this.btnEditUs.Name = "btnEditUs";
            this.btnEditUs.Size = new System.Drawing.Size(146, 42);
            this.btnEditUs.TabIndex = 1;
            this.btnEditUs.Text = "Editar Usuario";
            this.btnEditUs.UseVisualStyleBackColor = false;
            // 
            // btnNuevoUs
            // 
            this.btnNuevoUs.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoUs.Location = new System.Drawing.Point(2, 286);
            this.btnNuevoUs.Name = "btnNuevoUs";
            this.btnNuevoUs.Size = new System.Drawing.Size(146, 42);
            this.btnNuevoUs.TabIndex = 0;
            this.btnNuevoUs.Text = "Nuevo Usuario";
            this.btnNuevoUs.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::Ventas_ERG.Properties.Resources.atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Indigo;
            this.btnAtras.Location = new System.Drawing.Point(2, 656);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(146, 74);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Tag = "";
            this.toolTip1.SetToolTip(this.btnAtras, "Usuarios");
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Blue;
            this.btnUsuarios.BackgroundImage = global::Ventas_ERG.Properties.Resources.usuario1;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Indigo;
            this.btnUsuarios.Location = new System.Drawing.Point(2, 206);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(146, 74);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Tag = "";
            this.toolTip1.SetToolTip(this.btnUsuarios, "Usuarios");
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Blue;
            this.btnProductos.BackgroundImage = global::Ventas_ERG.Properties.Resources.Venta_Nueva;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Indigo;
            this.btnProductos.Location = new System.Drawing.Point(2, 286);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(146, 74);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Tag = "";
            this.toolTip1.SetToolTip(this.btnProductos, "Productos");
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevaVenta.BackgroundImage = global::Ventas_ERG.Properties.Resources.Ventas;
            this.btnNuevaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevaVenta.Location = new System.Drawing.Point(2, 35);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(146, 74);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Tag = "";
            this.toolTip1.SetToolTip(this.btnNuevaVenta, "Venta Nueva");
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmSalir;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Button btnEditUs;
        private System.Windows.Forms.Button btnNuevoUs;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnEditPro;
        private System.Windows.Forms.Button btnNuevoPro;
        private System.Windows.Forms.Button btnAtras;
    }
}

