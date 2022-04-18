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
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto(FrmGestionProductos productos)
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object serder, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        public class ProductoDto
        {
            public int IDPRODUCTO { get; set; }
            public string DESCRIPCION { get; set; }
        }
        //----------------------------------------------
        public List<ProductoDto> Visualizar()
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from p in BD.PRODUCTO
                                   orderby p.IDPRODUCTO
                                   select new ProductoDto
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
        //----------------------------------------------
        public void InsetarProducto(PRODUCTO producto)
        {
            try
            {
                using(BD_PANADERIA Bd = new BD_PANADERIA())
                {
                    Bd.PRODUCTO.Add(producto);
                    Bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //----------------------------------------------
        public void ActualizarProducto(PRODUCTO producto)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from ap in BD.PRODUCTO where ap.IDPRODUCTO == producto.IDPRODUCTO select ap;
                    foreach(PRODUCTO pr in sql)
                    {
                        pr.IDPRODUCTO = producto.IDPRODUCTO;
                        pr.DESCRIPCION = producto.DESCRIPCION;
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //----------------------------------------------
        public void EliminarProducto(PRODUCTO producto)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from ep in BD.PRODUCTO where ep.IDPRODUCTO == producto.IDPRODUCTO select ep;
                    foreach(PRODUCTO pr in sql)
                    {
                        BD.PRODUCTO.Remove(pr);
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //----------------------------------------------
        public void Clear()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            txtDescripcion.Focus();
        }
        //----------------------------------------------
        public bool Validar()
        {
            bool validator = false;
            string descripcion = txtDescripcion.Text.Trim();

            if(descripcion.Length > 0)
            {
                validator = true;
            }
            return validator;
        }
        //----------------------------------------------
        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = Visualizar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                PRODUCTO producto = new PRODUCTO();
                producto.IDPRODUCTO = 0;
                producto.DESCRIPCION = txtDescripcion.Text.Trim();

                if(txtCodigoProd.Text.Trim().Length > 0)
                {
                    producto.IDPRODUCTO = Convert.ToInt32(txtCodigoProd.Text);
                    ActualizarProducto(producto);
                }
                else
                {
                    InsetarProducto(producto);
                }
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvProductos.DataSource = Visualizar();
                Agregar();
            }
            else
            {
                MessageBox.Show("TODOS LOS DATOS SON OBLIGATORIOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Validar()== true)
            {
                PRODUCTO producto = new PRODUCTO();
                producto.IDPRODUCTO = Convert.ToInt32(txtCodigoProd.Text);
                producto.DESCRIPCION = txtDescripcion.Text;

                ActualizarProducto(producto);
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvProductos.DataSource = Visualizar();
                Agregar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtCodigoProd.Text.Trim().Length > 0)
            {
                DialogResult rpta = DialogResult.OK;
                rpta = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL REGISTRO?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    PRODUCTO producto = new PRODUCTO();
                    producto.IDPRODUCTO = Convert.ToInt32(txtCodigoProd.Text);

                    EliminarProducto(producto);
                    Clear();
                    MessageBox.Show("SE ELIMINO EL REGISTRO", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = Visualizar();
                    Agregar();
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductos.CurrentRow.Selected = true;
                txtCodigoProd.Text = dgvProductos.Rows[e.RowIndex].Cells["IDPRODUCTO"].FormattedValue.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["DESCRIPCION"].FormattedValue.ToString();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void MantenimientoProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
