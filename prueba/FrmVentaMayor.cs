using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class FrmVentaMayor : Form
    {
        public FrmVentaMayor()
        {
            InitializeComponent();
        }
        public class ClienteDto
        {
            public int IDCLIENTES { get; set; }
            public string RAZONSOCIAL { get; set; }
            public string RUC { get; set; }
            public string DIRECCION { get; set; }
            public string DISTRITO { get; set; }
        }
        //-----------------------------------------------------------
        public class Productodto
        {
            public int IDPRODUCTO { get; set; }
            public string DESCRIPCION { get; set; }
        }
        //-----------------------------------------------------------
        public class nombreCliente
        {
            public string nombrecli{ get; set; }
        }
        //-----------------------------------------------------------
        public class codigoCliente
        {
            public int codigo { get; set; }
        }
        //-----------------------------------------------------------
        public string ObtenerNombreCliente(int codigo)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from c in BD.CLIENTES
                               where c.IDCLIENTES == codigo
                               select new nombreCliente
                               {
                                   nombrecli = c.RAZONSOCIAL
                               }).First();
                    return sql.nombrecli;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public void LlenarCbCodigoCliente()
        {
            List<ClienteDto> cliente = new List<ClienteDto>();
            using(BD_PANADERIA BD = new BD_PANADERIA())
            {
                cliente = (from n in BD.CLIENTES
                           orderby n.IDCLIENTES
                           select new ClienteDto
                           {
                               IDCLIENTES = n.IDCLIENTES,
                               DIRECCION = n.DIRECCION,
                               DISTRITO = n.DISTRITO,
                               RAZONSOCIAL = n.RAZONSOCIAL,
                               RUC = n.RUC
                           }).ToList();
            }
            cbCodigoCliente.DataSource = cliente;
            cbCodigoCliente.DisplayMember = "IDCLIENTES";
            cbCodigoCliente.ValueMember = "IDCLIENTES";
        }
        //-----------------------------------------------------------
        public void MostrarRazon()
        {
            int codigo = Convert.ToInt32(cbCodigoCliente.SelectedValue);
            lblNombreCliente.Text = ObtenerNombreCliente(codigo);
        }
        public List<Productodto> CaptarProducto()
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from p in BD.PRODUCTO
                                   orderby p.IDPRODUCTO
                                   select new Productodto
                                   {
                                       IDPRODUCTO = p.IDPRODUCTO,
                                       DESCRIPCION = p.DESCRIPCION
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public List<ClienteDto> VisualizarCl()
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from v in BD.CLIENTES
                                   orderby v.IDCLIENTES
                                   select new ClienteDto
                                   {
                                       IDCLIENTES = v.IDCLIENTES,
                                       DIRECCION = v.DIRECCION,
                                       DISTRITO = v.DISTRITO,
                                       RAZONSOCIAL = v.RAZONSOCIAL,
                                       RUC = v.RUC
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public void InsertarCliente(CLIENTES cliente)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    BD.CLIENTES.Add(cliente);
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public void ActualizarCliente(CLIENTES clientes)
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from a in BD.CLIENTES where a.IDCLIENTES == clientes.IDCLIENTES select a;
                    foreach(CLIENTES cl in sql)
                    {
                        cl.IDCLIENTES = clientes.IDCLIENTES;
                        cl.DIRECCION = clientes.DIRECCION;
                        cl.DISTRITO = clientes.DISTRITO;
                        cl.RAZONSOCIAL = clientes.RAZONSOCIAL;
                        cl.RUC = clientes.RUC;
                    }
                    BD.SaveChanges();
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public void EliminarCliente(CLIENTES cliente)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from e in BD.CLIENTES where e.IDCLIENTES == cliente.IDCLIENTES select e;
                    foreach(CLIENTES cl in sql)
                    {
                        BD.CLIENTES.Remove(cl);
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------
        public bool Validar()
        {
            bool validator = false;
            string razon = txtRazon.Text.Trim();
            string ruc = txtRuc.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string distrito = txtDistrito.Text.Trim();
            if (razon.Length > 0 && ruc.Length > 0 && direccion.Length > 0 && distrito.Length > 0)
            {
                validator = true;
            }
            return validator;
        }
        //------------------------------------------------
        public void Clear()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            txtCodigo.Text = "";
            txtRazon.Focus();
            txtRazon.Text = "";
            txtRuc.Text = "";
            txtDistrito.Text = "";
            txtdireccion.Text = "";
        }
        //-----------------------------------------------------------
        //-----------------------------------------------------------
        private void FrmVentaMayor_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = VisualizarCl();
            dgvProductos.DataSource = CaptarProducto();
            LlenarCbCodigoCliente();
            MostrarRazon();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                CLIENTES cliente = new CLIENTES();
                cliente.IDCLIENTES = 0;
                cliente.RAZONSOCIAL = txtRazon.Text.Trim();
                cliente.RUC = txtRuc.Text.Trim();
                cliente.DISTRITO = txtDistrito.Text.Trim();
                cliente.DIRECCION = txtdireccion.Text.Trim();

                if(txtCodigo.Text.Trim().Length > 0)
                {
                    cliente.IDCLIENTES = Convert.ToInt32(txtCodigo.Text.Trim());
                    ActualizarCliente(cliente);
                }
                else
                {
                    InsertarCliente(cliente);
                }
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                LlenarCbCodigoCliente();
                dgvClientes.DataSource = VisualizarCl();
            }
            else
            {
                MessageBox.Show("TODOS LOS DATOS SON OBLIGATORIOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAcutalizar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                CLIENTES cliente = new CLIENTES();
                cliente.IDCLIENTES = Convert.ToInt32(txtCodigo.Text.Trim());
                cliente.RAZONSOCIAL = txtRazon.Text.Trim();
                cliente.RUC = txtRuc.Text.Trim();
                cliente.DISTRITO = txtDistrito.Text.Trim();
                cliente.DIRECCION = txtdireccion.Text.Trim();

                ActualizarCliente(cliente);
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                LlenarCbCodigoCliente();
                dgvClientes.DataSource = VisualizarCl();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Trim().Length > 0)
            {
                DialogResult rpta = DialogResult.OK;
                rpta = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL REGISTRO?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rpta == DialogResult.Yes)
                {
                    CLIENTES cliente = new CLIENTES();
                    cliente.IDCLIENTES = Convert.ToInt32(txtCodigo.Text.Trim());

                    EliminarCliente(cliente);
                    dgvClientes.DataSource = VisualizarCl();

                    Clear();
                    MessageBox.Show("SE ELIMINO EL REGISTRO", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarCbCodigoCliente();
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvClientes.CurrentRow.Selected = true;
                txtCodigo.Text = dgvClientes.Rows[e.RowIndex].Cells["IDCLIENTES"].FormattedValue.ToString();
                txtRazon.Text = dgvClientes.Rows[e.RowIndex].Cells["RAZONSOCIAL"].FormattedValue.ToString();
                txtRuc.Text = dgvClientes.Rows[e.RowIndex].Cells["RUC"].FormattedValue.ToString();
                txtdireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["DIRECCION"].FormattedValue.ToString();
                txtDistrito.Text = dgvClientes.Rows[e.RowIndex].Cells["DISTRITO"].FormattedValue.ToString();
            }
        }

        private void cbCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarRazon();
        }

        private void btnAñadirProd_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text != "")
            {
                //DataGridViewRow fila = new DataGridViewRow();
                //fila.CreateCells(dgvTemporal);
                //fila.Cells[0].Value = dgvProductos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                //fila.Cells[1].Value = txtCantidad.Text;
                string[] datos = new string[2];
                datos[0] = dgvProductos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                datos[1] = txtCantidad.Text;
                dgvTemporal.Rows.Add(datos);

                txtCantidad.Text = "";
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO E INGRESAR UNA CANTIDAD!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            dgvTemporal.Rows.Remove(dgvTemporal.CurrentRow);
        }

        private void dgvTemporal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                dgvTemporal.Rows.Remove(dgvTemporal.CurrentRow);
            }
        }
    }
}
