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
    public partial class FrmVentaMenor : Form
    {
        public FrmVentaMenor()
        {
            InitializeComponent();
        }
        //------------------------------------------------
        public class Estructura
        {
            public int ID { get; set; }
            public String CODPRODUCTO { get; set; }
            public Nullable<int> CANTIDAD { get; set; }
        }
        //------------------------------------------------
        public class ProductoDto
        {
            public int IDPRODUCTO { get; set; }
            public string DESCRIPCION { get; set; }
        }
        //------------------------------------------------
        public class nombreProducto
        {
            public string nomProducto { get; set; }
        }
        //------------------------------------------------
        public class codigoProducto
        {
            public int codProducto { get; set; }
        }
        //------------------------------------------------
        public List<Estructura> Visualizar()
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from v in BD.VENTA_MENOR
                                   join p in BD.PRODUCTO on v.IDPRODUCTO equals p.IDPRODUCTO
                                   orderby v.ID
                                   select new Estructura
                                   {
                                       ID = v.ID,
                                       CANTIDAD = v.CANTIDAD,
                                       CODPRODUCTO = p.DESCRIPCION
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //------------------------------------------------
        public void LlenarComboProducto()
        {
            List<ProductoDto> prod = new List<ProductoDto>();
            using(BD_PANADERIA Bd = new BD_PANADERIA())
            {
                prod = (from v in Bd.PRODUCTO
                         orderby v.IDPRODUCTO
                         select new ProductoDto
                         {
                             IDPRODUCTO = v.IDPRODUCTO,
                             DESCRIPCION = v.DESCRIPCION
                         }).ToList();
            }
            cbProducto.DataSource = prod;
            cbProducto.ValueMember = "DESCRIPCION";
            cbProducto.DisplayMember = "DESCRIPCION";
        }
        //------------------------------------------------
        public int ObtenerCodigoProducto(string nombreProducto)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from c in BD.PRODUCTO
                               where c.DESCRIPCION == nombreProducto
                               select new codigoProducto
                               {
                                   codProducto = c.IDPRODUCTO
                               }).First();
                    return sql.codProducto;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //------------------------------------------------
        public bool Validar()
        {
            bool validator = false;
            string cantidad = txtCantidad.Text.Trim();
            if(cantidad.Length > 0)
            {
                validator = true;
            }
            return validator;
        }
        //------------------------------------------------
        public void Clear()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            txtCantidad.Focus();
            cbProducto.SelectedIndex = 0;
        }
        //------------------------------------------------
        public void AñadirVenta(VENTA_MENOR venta)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    BD.VENTA_MENOR.Add(venta);
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //------------------------------------------------
        public void ActualizarVenta(VENTA_MENOR venta)
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from v in BD.VENTA_MENOR where v.ID == venta.ID select v;
                    foreach (VENTA_MENOR vt in sql)
                    {
                        vt.IDPRODUCTO = venta.IDPRODUCTO;
                        vt.CANTIDAD = venta.CANTIDAD;
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //------------------------------------------------
        public void EliminarVenta(VENTA_MENOR venta)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from ev in BD.VENTA_MENOR where ev.ID == venta.ID select ev;
                    foreach(VENTA_MENOR vt in sql)
                    {
                        BD.VENTA_MENOR.Remove(vt);
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //------------------------------------------------
        //public Estructura UltimaVenta()
        //{
        //    try
        //    {
        //        using(BD_PANADERIA BD = new BD_PANADERIA())
        //        {
        //            var last = (from uv in BD.VENTA_MENOR
        //                        orderby uv.ID descending
        //                        select new Estructura
        //                        {
        //                            ID = uv.ID,
        //                            CANTIDAD = uv.CANTIDAD,
        //                        }).ToList();
        //            Estructura et = last.First();
        //            return et;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //------------------------------------------------
        private void FrmVentaMenor_Load(object sender, EventArgs e)
        {
            dgvVentaMenor.DataSource = Visualizar();
            LlenarComboProducto();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                VENTA_MENOR venta = new VENTA_MENOR();
                venta.ID = 0;
                int ccc = ObtenerCodigoProducto(cbProducto.Text);
                venta.IDPRODUCTO = ccc;
                venta.CANTIDAD = Convert.ToInt32(txtCantidad.Text);

                if(txtCodigoVenta.Text.Trim().Length > 0)
                {
                    venta.ID = Convert.ToInt32(txtCodigoVenta.Text);
                    ActualizarVenta(venta);
                }
                else
                {
                    AñadirVenta(venta);
                }
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvVentaMenor.DataSource = Visualizar();
            }
            else
            {
                MessageBox.Show("TODOS LOS DATOS SON OBLIGATORIOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                VENTA_MENOR venta = new VENTA_MENOR();
                venta.ID = Convert.ToInt32(txtCodigoVenta.Text);
                int ccc = ObtenerCodigoProducto(cbProducto.Text);
                venta.IDPRODUCTO = ccc;
                venta.CANTIDAD = Convert.ToInt32(txtCantidad.Text);

                ActualizarVenta(venta);
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvVentaMenor.DataSource = Visualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtCodigoVenta.Text.Trim().Length > 0)
            {
                DialogResult rpta = DialogResult.OK;
                rpta = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL REGISTRO?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rpta == DialogResult.Yes)
                {
                    VENTA_MENOR venta = new VENTA_MENOR();
                    venta.ID = Convert.ToInt32(txtCodigoVenta.Text);

                    EliminarVenta(venta);
                    dgvVentaMenor.DataSource = Visualizar();

                    Clear();
                    MessageBox.Show("SE ELIMINO EL REGISTRO", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvVentaMenor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvVentaMenor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvVentaMenor.CurrentRow.Selected = true;
                txtCodigoVenta.Text = dgvVentaMenor.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtCantidad.Text = dgvVentaMenor.Rows[e.RowIndex].Cells["CANTIDAD"].FormattedValue.ToString();
                cbProducto.Text = dgvVentaMenor.Rows[e.RowIndex].Cells["CODPRODUCTO"].FormattedValue.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
