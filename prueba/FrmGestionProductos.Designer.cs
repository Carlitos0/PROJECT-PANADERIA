namespace prueba
{
    partial class FrmGestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadKg = new System.Windows.Forms.TextBox();
            this.txtCodReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAñadirIngrediente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvIngredienteTemp = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.btnMantenimientoProd = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.INSUMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DROP = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredienteTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.txtCantidadKg);
            this.groupBox1.Controls.Add(this.txtCodReceta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 217);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txtCantidadKg
            // 
            this.txtCantidadKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadKg.Location = new System.Drawing.Point(219, 153);
            this.txtCantidadKg.Name = "txtCantidadKg";
            this.txtCantidadKg.Size = new System.Drawing.Size(87, 26);
            this.txtCantidadKg.TabIndex = 16;
            // 
            // txtCodReceta
            // 
            this.txtCodReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodReceta.Location = new System.Drawing.Point(219, 59);
            this.txtCodReceta.Name = "txtCodReceta";
            this.txtCodReceta.ReadOnly = true;
            this.txtCodReceta.Size = new System.Drawing.Size(110, 26);
            this.txtCodReceta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad de insumo (Kg) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código de Receta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAñadirIngrediente);
            this.groupBox2.Location = new System.Drawing.Point(467, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 129);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBCONTRLES";
            // 
            // btnAñadirIngrediente
            // 
            this.btnAñadirIngrediente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirIngrediente.Location = new System.Drawing.Point(46, 36);
            this.btnAñadirIngrediente.Name = "btnAñadirIngrediente";
            this.btnAñadirIngrediente.Size = new System.Drawing.Size(148, 55);
            this.btnAñadirIngrediente.TabIndex = 12;
            this.btnAñadirIngrediente.Text = "Añadir Ingrediente";
            this.btnAñadirIngrediente.UseVisualStyleBackColor = true;
            this.btnAñadirIngrediente.Click += new System.EventHandler(this.btnAñadirIngrediente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Location = new System.Drawing.Point(825, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 410);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONTROLES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(26, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 67);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(26, 223);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 67);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(26, 129);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 67);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(26, 40);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 67);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMantenimientoProd);
            this.groupBox4.Controls.Add(this.dgvReceta);
            this.groupBox4.Controls.Add(this.dgvIngredienteTemp);
            this.groupBox4.Controls.Add(this.dgvProductos);
            this.groupBox4.Controls.Add(this.dgvInsumos);
            this.groupBox4.Location = new System.Drawing.Point(52, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 536);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VISTAS";
            // 
            // dgvIngredienteTemp
            // 
            this.dgvIngredienteTemp.AllowUserToResizeColumns = false;
            this.dgvIngredienteTemp.AllowUserToResizeRows = false;
            this.dgvIngredienteTemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvIngredienteTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredienteTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INSUMO,
            this.CANTIDAD,
            this.DROP});
            this.dgvIngredienteTemp.Location = new System.Drawing.Point(405, 32);
            this.dgvIngredienteTemp.Name = "dgvIngredienteTemp";
            this.dgvIngredienteTemp.ReadOnly = true;
            this.dgvIngredienteTemp.ShowCellErrors = false;
            this.dgvIngredienteTemp.Size = new System.Drawing.Size(320, 165);
            this.dgvIngredienteTemp.TabIndex = 22;
            this.dgvIngredienteTemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredienteTemp_CellContentClick);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(10, 303);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(231, 215);
            this.dgvProductos.TabIndex = 21;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToResizeColumns = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(25, 32);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.Size = new System.Drawing.Size(301, 165);
            this.dgvInsumos.TabIndex = 20;
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(219, 107);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(151, 28);
            this.cbProducto.TabIndex = 17;
            // 
            // btnMantenimientoProd
            // 
            this.btnMantenimientoProd.Location = new System.Drawing.Point(10, 227);
            this.btnMantenimientoProd.Name = "btnMantenimientoProd";
            this.btnMantenimientoProd.Size = new System.Drawing.Size(231, 51);
            this.btnMantenimientoProd.TabIndex = 24;
            this.btnMantenimientoProd.Text = "MANTEMIENTO PRODUCTO";
            this.btnMantenimientoProd.UseVisualStyleBackColor = true;
            this.btnMantenimientoProd.Click += new System.EventHandler(this.btnMantenimientoProd_Click);
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.AllowUserToResizeColumns = false;
            this.dgvReceta.AllowUserToResizeRows = false;
            this.dgvReceta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Location = new System.Drawing.Point(278, 227);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.Size = new System.Drawing.Size(447, 291);
            this.dgvReceta.TabIndex = 23;
            // 
            // INSUMO
            // 
            this.INSUMO.Frozen = true;
            this.INSUMO.HeaderText = "INGREDIENTE";
            this.INSUMO.Name = "INSUMO";
            this.INSUMO.ReadOnly = true;
            this.INSUMO.Width = 106;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 87;
            // 
            // DROP
            // 
            this.DROP.FillWeight = 50F;
            this.DROP.HeaderText = "QUITAR";
            this.DROP.Image = ((System.Drawing.Image)(resources.GetObject("DROP.Image")));
            this.DROP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DROP.Name = "DROP";
            this.DROP.ReadOnly = true;
            this.DROP.ToolTipText = "ELIMINA UN INGREDIENTE";
            this.DROP.Width = 54;
            // 
            // FrmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 795);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredienteTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadKg;
        private System.Windows.Forms.TextBox txtCodReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAñadirIngrediente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvIngredienteTemp;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Button btnMantenimientoProd;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSUMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewImageColumn DROP;
    }
}