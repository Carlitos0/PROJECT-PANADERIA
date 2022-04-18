namespace prueba
{
    partial class FrmVentaMayor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAcutalizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnAñadirProd = new System.Windows.Forms.Button();
            this.dgvTemporal = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.cbCodigoCliente = new System.Windows.Forms.ComboBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.dt_Entrega = new System.Windows.Forms.DateTimePicker();
            this.dt_Encargo = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DROP = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemporal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 798);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CLIENTE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvClientes);
            this.groupBox3.Location = new System.Drawing.Point(36, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VISTA";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(19, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(962, 285);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAcutalizar);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Location = new System.Drawing.Point(660, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 340);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROLES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(101, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 46);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(101, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(197, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAcutalizar
            // 
            this.btnAcutalizar.Location = new System.Drawing.Point(101, 127);
            this.btnAcutalizar.Name = "btnAcutalizar";
            this.btnAcutalizar.Size = new System.Drawing.Size(197, 46);
            this.btnAcutalizar.TabIndex = 1;
            this.btnAcutalizar.Text = "Actualizar";
            this.btnAcutalizar.UseVisualStyleBackColor = true;
            this.btnAcutalizar.Click += new System.EventHandler(this.btnAcutalizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 65);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(197, 46);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDistrito);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtRazon);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(226, 254);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(224, 29);
            this.txtDistrito.TabIndex = 5;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(226, 205);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(224, 29);
            this.txtdireccion.TabIndex = 5;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(226, 157);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(224, 29);
            this.txtRuc.TabIndex = 5;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(226, 110);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(224, 29);
            this.txtRazon.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(226, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(224, 29);
            this.txtCodigo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Distrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDetalle);
            this.tabPage2.Controls.Add(this.dgvPedido);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PEDIDO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(541, 512);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(498, 242);
            this.dgvDetalle.TabIndex = 6;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(23, 512);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(498, 242);
            this.dgvPedido.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(727, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 490);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CONTROLES";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEliminarProd);
            this.groupBox5.Controls.Add(this.btnAñadirProd);
            this.groupBox5.Controls.Add(this.dgvTemporal);
            this.groupBox5.Controls.Add(this.dgvProductos);
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(23, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(688, 252);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OPERACION";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Location = new System.Drawing.Point(503, 15);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(164, 52);
            this.btnEliminarProd.TabIndex = 15;
            this.btnEliminarProd.Text = "Eliminar Producto";
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnAñadirProd
            // 
            this.btnAñadirProd.Location = new System.Drawing.Point(328, 15);
            this.btnAñadirProd.Name = "btnAñadirProd";
            this.btnAñadirProd.Size = new System.Drawing.Size(164, 52);
            this.btnAñadirProd.TabIndex = 4;
            this.btnAñadirProd.Text = "Añadir Producto";
            this.btnAñadirProd.UseVisualStyleBackColor = true;
            this.btnAñadirProd.Click += new System.EventHandler(this.btnAñadirProd_Click);
            // 
            // dgvTemporal
            // 
            this.dgvTemporal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTemporal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTemporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemporal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.DROP});
            this.dgvTemporal.Location = new System.Drawing.Point(328, 75);
            this.dgvTemporal.MultiSelect = false;
            this.dgvTemporal.Name = "dgvTemporal";
            this.dgvTemporal.ReadOnly = true;
            this.dgvTemporal.ShowCellErrors = false;
            this.dgvTemporal.ShowEditingIcon = false;
            this.dgvTemporal.ShowRowErrors = false;
            this.dgvTemporal.Size = new System.Drawing.Size(339, 156);
            this.dgvTemporal.TabIndex = 14;
            this.dgvTemporal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemporal_CellContentClick);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(20, 75);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(283, 156);
            this.dgvProductos.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(103, 28);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 29);
            this.txtCantidad.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cantidad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNombreCliente);
            this.groupBox4.Controls.Add(this.cbCodigoCliente);
            this.groupBox4.Controls.Add(this.txtCodigoProducto);
            this.groupBox4.Controls.Add(this.dt_Entrega);
            this.groupBox4.Controls.Add(this.dt_Encargo);
            this.groupBox4.Controls.Add(this.txtCodigoPedido);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(23, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 232);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATOS";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(404, 88);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(16, 25);
            this.lblNombreCliente.TabIndex = 13;
            this.lblNombreCliente.Text = ".";
            // 
            // cbCodigoCliente
            // 
            this.cbCodigoCliente.FormattingEnabled = true;
            this.cbCodigoCliente.Location = new System.Drawing.Point(187, 88);
            this.cbCodigoCliente.Name = "cbCodigoCliente";
            this.cbCodigoCliente.Size = new System.Drawing.Size(200, 29);
            this.cbCodigoCliente.TabIndex = 12;
            this.cbCodigoCliente.SelectedIndexChanged += new System.EventHandler(this.cbCodigoCliente_SelectedIndexChanged);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(187, 183);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(200, 29);
            this.txtCodigoProducto.TabIndex = 11;
            // 
            // dt_Entrega
            // 
            this.dt_Entrega.Location = new System.Drawing.Point(428, 180);
            this.dt_Entrega.Name = "dt_Entrega";
            this.dt_Entrega.Size = new System.Drawing.Size(200, 29);
            this.dt_Entrega.TabIndex = 9;
            // 
            // dt_Encargo
            // 
            this.dt_Encargo.CustomFormat = "dd;MM;yyyy";
            this.dt_Encargo.Location = new System.Drawing.Point(187, 137);
            this.dt_Encargo.Name = "dt_Encargo";
            this.dt_Encargo.Size = new System.Drawing.Size(200, 29);
            this.dt_Encargo.TabIndex = 8;
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(187, 37);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.ReadOnly = true;
            this.txtCodigoPedido.Size = new System.Drawing.Size(200, 29);
            this.txtCodigoPedido.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha de Entrega:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Codigo de Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha de Encargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Código de Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Código de Pedido:";
            // 
            // producto
            // 
            this.producto.Frozen = true;
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.producto.Width = 117;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 111;
            // 
            // DROP
            // 
            this.DROP.HeaderText = "QUITAR";
            this.DROP.Name = "DROP";
            this.DROP.ReadOnly = true;
            this.DROP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DROP.Width = 70;
            // 
            // FrmVentaMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 795);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentaMayor";
            this.Text = "FrmVentaMayor";
            this.Load += new System.EventHandler(this.FrmVentaMayor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemporal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAcutalizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.DateTimePicker dt_Encargo;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.DateTimePicker dt_Entrega;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvTemporal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAñadirProd;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.ComboBox cbCodigoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewImageColumn DROP;
    }
}