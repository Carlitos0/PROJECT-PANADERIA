namespace prueba
{
    partial class GestiónInsumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetInsumo = new System.Windows.Forms.DataGridView();
            this.msjRegistrar = new System.Windows.Forms.ToolTip(this.components);
            this.msgActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.msgEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.msgCancelar = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dt_Produccion = new System.Windows.Forms.DateTimePicker();
            this.dt_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.cbnombreProveedor = new System.Windows.Forms.ComboBox();
            this.cbNombreInsumo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetInsumo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetInsumo
            // 
            this.dgvDetInsumo.AllowUserToResizeColumns = false;
            this.dgvDetInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetInsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetInsumo.Location = new System.Drawing.Point(81, 399);
            this.dgvDetInsumo.Name = "dgvDetInsumo";
            this.dgvDetInsumo.Size = new System.Drawing.Size(931, 368);
            this.dgvDetInsumo.TabIndex = 9;
            this.dgvDetInsumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetInsumo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoDetalle);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.dt_Produccion);
            this.groupBox1.Controls.Add(this.dt_Vencimiento);
            this.groupBox1.Controls.Add(this.cbnombreProveedor);
            this.groupBox1.Controls.Add(this.cbNombreInsumo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(81, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 365);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCodigoDetalle.Location = new System.Drawing.Point(274, 5);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.ReadOnly = true;
            this.txtCodigoDetalle.Size = new System.Drawing.Size(147, 29);
            this.txtCodigoDetalle.TabIndex = 31;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPrecio.Location = new System.Drawing.Point(274, 310);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 29);
            this.txtPrecio.TabIndex = 30;
            // 
            // dt_Produccion
            // 
            this.dt_Produccion.CustomFormat = "dd-MM-yyyy";
            this.dt_Produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dt_Produccion.Location = new System.Drawing.Point(274, 155);
            this.dt_Produccion.Name = "dt_Produccion";
            this.dt_Produccion.Size = new System.Drawing.Size(290, 26);
            this.dt_Produccion.TabIndex = 28;
            // 
            // dt_Vencimiento
            // 
            this.dt_Vencimiento.CustomFormat = "dd-MM-yyyy";
            this.dt_Vencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dt_Vencimiento.Location = new System.Drawing.Point(274, 206);
            this.dt_Vencimiento.Name = "dt_Vencimiento";
            this.dt_Vencimiento.Size = new System.Drawing.Size(290, 26);
            this.dt_Vencimiento.TabIndex = 29;
            // 
            // cbnombreProveedor
            // 
            this.cbnombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbnombreProveedor.FormattingEnabled = true;
            this.cbnombreProveedor.Location = new System.Drawing.Point(274, 49);
            this.cbnombreProveedor.Name = "cbnombreProveedor";
            this.cbnombreProveedor.Size = new System.Drawing.Size(147, 32);
            this.cbnombreProveedor.TabIndex = 26;
            // 
            // cbNombreInsumo
            // 
            this.cbNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbNombreInsumo.FormattingEnabled = true;
            this.cbNombreInsumo.Location = new System.Drawing.Point(274, 98);
            this.cbNombreInsumo.Name = "cbNombreInsumo";
            this.cbNombreInsumo.Size = new System.Drawing.Size(147, 32);
            this.cbNombreInsumo.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCantidad.Location = new System.Drawing.Point(274, 257);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 29);
            this.txtCantidad.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cantidad(Kg):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(38, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de Vencimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Producción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre de Insumo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(100, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de Proveedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Location = new System.Drawing.Point(756, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 360);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROLES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(44, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 44);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(44, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 44);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(44, 116);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 44);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(44, 42);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 44);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // GestiónInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetInsumo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestiónInsumos";
            this.Text = "GestiónInsumos";
            this.Load += new System.EventHandler(this.GestiónInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetInsumo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetInsumo;
        private System.Windows.Forms.ToolTip msjRegistrar;
        private System.Windows.Forms.ToolTip msgActualizar;
        private System.Windows.Forms.ToolTip msgEliminar;
        private System.Windows.Forms.ToolTip msgCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dt_Produccion;
        private System.Windows.Forms.DateTimePicker dt_Vencimiento;
        private System.Windows.Forms.ComboBox cbnombreProveedor;
        private System.Windows.Forms.ComboBox cbNombreInsumo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}