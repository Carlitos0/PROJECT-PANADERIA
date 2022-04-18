namespace prueba
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGestionFinanzas = new FontAwesome.Sharp.IconButton();
            this.btnVentaMenor = new FontAwesome.Sharp.IconButton();
            this.btnVentaMayor = new FontAwesome.Sharp.IconButton();
            this.btnGestionInsumos = new FontAwesome.Sharp.IconButton();
            this.btnGestionProductos = new FontAwesome.Sharp.IconButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(226, 233);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(12, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(199, 204);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btnGestionFinanzas);
            this.panelMenu.Controls.Add(this.btnVentaMenor);
            this.panelMenu.Controls.Add(this.btnVentaMayor);
            this.panelMenu.Controls.Add(this.btnGestionInsumos);
            this.panelMenu.Controls.Add(this.btnGestionProductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(226, 855);
            this.panelMenu.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(0, 717);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 77);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 602);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 77);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 77);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 77);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 77);
            this.panel3.TabIndex = 1;
            // 
            // btnGestionFinanzas
            // 
            this.btnGestionFinanzas.AllowDrop = true;
            this.btnGestionFinanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionFinanzas.FlatAppearance.BorderSize = 0;
            this.btnGestionFinanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGestionFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionFinanzas.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionFinanzas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnGestionFinanzas.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnGestionFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionFinanzas.IconSize = 55;
            this.btnGestionFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionFinanzas.Location = new System.Drawing.Point(0, 717);
            this.btnGestionFinanzas.Name = "btnGestionFinanzas";
            this.btnGestionFinanzas.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.btnGestionFinanzas.Size = new System.Drawing.Size(226, 77);
            this.btnGestionFinanzas.TabIndex = 6;
            this.btnGestionFinanzas.Text = "Gestión de Finanzas";
            this.btnGestionFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionFinanzas.UseVisualStyleBackColor = true;
            this.btnGestionFinanzas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnVentaMenor
            // 
            this.btnVentaMenor.AllowDrop = true;
            this.btnVentaMenor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaMenor.FlatAppearance.BorderSize = 0;
            this.btnVentaMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVentaMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaMenor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaMenor.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnVentaMenor.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnVentaMenor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentaMenor.IconSize = 55;
            this.btnVentaMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaMenor.Location = new System.Drawing.Point(0, 602);
            this.btnVentaMenor.Name = "btnVentaMenor";
            this.btnVentaMenor.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.btnVentaMenor.Size = new System.Drawing.Size(226, 77);
            this.btnVentaMenor.TabIndex = 4;
            this.btnVentaMenor.Text = "Venta al menor";
            this.btnVentaMenor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaMenor.UseVisualStyleBackColor = true;
            this.btnVentaMenor.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnVentaMayor
            // 
            this.btnVentaMayor.AllowDrop = true;
            this.btnVentaMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaMayor.FlatAppearance.BorderSize = 0;
            this.btnVentaMayor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVentaMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaMayor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaMayor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnVentaMayor.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnVentaMayor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentaMayor.IconSize = 55;
            this.btnVentaMayor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaMayor.Location = new System.Drawing.Point(0, 485);
            this.btnVentaMayor.Name = "btnVentaMayor";
            this.btnVentaMayor.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.btnVentaMayor.Size = new System.Drawing.Size(226, 77);
            this.btnVentaMayor.TabIndex = 3;
            this.btnVentaMayor.Text = "Venta al mayor";
            this.btnVentaMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaMayor.UseVisualStyleBackColor = true;
            this.btnVentaMayor.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnGestionInsumos
            // 
            this.btnGestionInsumos.AllowDrop = true;
            this.btnGestionInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionInsumos.FlatAppearance.BorderSize = 0;
            this.btnGestionInsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGestionInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionInsumos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionInsumos.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnGestionInsumos.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnGestionInsumos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionInsumos.IconSize = 55;
            this.btnGestionInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionInsumos.Location = new System.Drawing.Point(0, 370);
            this.btnGestionInsumos.Name = "btnGestionInsumos";
            this.btnGestionInsumos.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.btnGestionInsumos.Size = new System.Drawing.Size(226, 77);
            this.btnGestionInsumos.TabIndex = 2;
            this.btnGestionInsumos.Text = "Gestión de Insumos";
            this.btnGestionInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionInsumos.UseVisualStyleBackColor = true;
            this.btnGestionInsumos.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.AllowDrop = true;
            this.btnGestionProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.IconChar = FontAwesome.Sharp.IconChar.BreadSlice;
            this.btnGestionProductos.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnGestionProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionProductos.IconSize = 55;
            this.btnGestionProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.Location = new System.Drawing.Point(0, 258);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.btnGestionProductos.Size = new System.Drawing.Size(226, 77);
            this.btnGestionProductos.TabIndex = 1;
            this.btnGestionProductos.Text = "Gestión de Productos";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(226, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1094, 50);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 50;
            this.btnMinimizar.Location = new System.Drawing.Point(976, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(59, 50);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseDown);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Mixer;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 50;
            this.btnCerrar.Location = new System.Drawing.Point(1035, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 50);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseDown);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(1)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(226, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 10);
            this.panel1.TabIndex = 2;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Silver;
            this.Contenedor.Location = new System.Drawing.Point(226, 60);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1094, 795);
            this.Contenedor.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 855);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnGestionProductos;
        private FontAwesome.Sharp.IconButton btnGestionFinanzas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconButton btnVentaMenor;
        private FontAwesome.Sharp.IconButton btnVentaMayor;
        private FontAwesome.Sharp.IconButton btnGestionInsumos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}

