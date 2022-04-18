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
    public partial class GestiónInsumos : Form
    {
        public GestiónInsumos()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        public class ComboProveedor
        {
            public string nombreProve { get; set; }
        }
        //---------------------------------------------------------------
        public class ComboInsumo
        {
            public string nombreInsumo { get; set; }
        }
        //---------------------------------------------------------------
        public class CodigoProveedor
        {
            public int IdProveedor { get; set; }
        }
        //---------------------------------------------------------------
        public class CodigoInsumo
        {
            public int IdInsumo { get; set; }
        }
        //---------------------------------------------------------------
        public class Estructura
        {
            public int IDDETALLE { get; set; }
            public Nullable<double> STOCK_kg { get; set; }
            public Nullable<double> PRECIO { get; set; }
            public Nullable<System.DateTime> FECHA_PRODUCCION { get; set; }
            public Nullable<System.DateTime> FECHA_VENCIMIENTO { get; set; }
            public int IDPROVEEDOR { get; set; }
            public int IDINSUMOS { get; set; }
        }
        //---------------------------------------------------------------
        public List<Estructura> Visualizar()
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from e in BD.DETALLE_INSUMO_PROVEEDOR
                                   orderby e.IDDETALLE
                                   select new Estructura
                                   {
                                       IDDETALLE = e.IDDETALLE,
                                       PRECIO = e.PRECIO,
                                       FECHA_PRODUCCION = e.FECHA_PRODUCCION,
                                       FECHA_VENCIMIENTO = e.FECHA_VENCIMIENTO,
                                       IDINSUMOS = e.IDINSUMOS,
                                       IDPROVEEDOR = e.IDPROVEEDOR,
                                       STOCK_kg = e.STOCK_Kg_
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public void AgregarDetalle(DETALLE_INSUMO_PROVEEDOR detail)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    BD.DETALLE_INSUMO_PROVEEDOR.Add(detail);
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }
        //---------------------------------------------------------------
        public void ELiminarDetalle(DETALLE_INSUMO_PROVEEDOR detail)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from d in BD.DETALLE_INSUMO_PROVEEDOR where d.IDDETALLE == detail.IDDETALLE select d;
                    foreach(DETALLE_INSUMO_PROVEEDOR dt in sql)
                    {
                        BD.DETALLE_INSUMO_PROVEEDOR.Remove(dt);
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public void ActualizarDetalle(DETALLE_INSUMO_PROVEEDOR detail)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from d in BD.DETALLE_INSUMO_PROVEEDOR where d.IDDETALLE == detail.IDDETALLE select d;
                    foreach (DETALLE_INSUMO_PROVEEDOR dt in sql)
                    {
                        dt.STOCK_Kg_ = detail.STOCK_Kg_;
                        dt.IDPROVEEDOR = detail.IDPROVEEDOR;
                        dt.IDINSUMOS = detail.IDINSUMOS;
                        dt.PRECIO = detail.PRECIO;
                        dt.FECHA_PRODUCCION = detail.FECHA_PRODUCCION;
                        dt.FECHA_VENCIMIENTO = detail.FECHA_VENCIMIENTO;
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public Estructura UltimoDetalle()
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var last = (from u in BD.DETALLE_INSUMO_PROVEEDOR
                                orderby u.IDDETALLE descending
                                select new Estructura
                                {
                                    IDDETALLE = u.IDDETALLE,
                                    FECHA_VENCIMIENTO = u.FECHA_VENCIMIENTO,
                                    FECHA_PRODUCCION = u.FECHA_PRODUCCION,
                                    IDINSUMOS = u.IDINSUMOS,
                                    IDPROVEEDOR = u.IDPROVEEDOR,
                                    PRECIO = u.PRECIO,
                                    STOCK_kg = u.STOCK_Kg_
                                }).ToList();
                    Estructura detail = last.First();

                    return detail;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public int BuscarCodigoProveedor(string nomProveedor)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from cp in BD.PROVEEDOR
                               where cp.PROVEEDOR1 == nomProveedor
                               orderby cp.IDPROVEEDOR
                               select new CodigoProveedor
                               {
                                   IdProveedor = cp.IDPROVEEDOR
                               }).First();
                    return sql.IdProveedor;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public int BuscarCodigoInsumo(string nomInsumo)
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from ci in BD.INSUMOS
                               where ci.INSUMO == nomInsumo
                               orderby ci.IDINSUMOS
                               select new CodigoInsumo
                               {
                                   IdInsumo = ci.IDINSUMOS
                               }).First();
                    return sql.IdInsumo;
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }
        //---------------------------------------------------------------
        public string ObtenerNombreProveedor(int codCombo)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from x in BD.PROVEEDOR
                               where x.IDPROVEEDOR == codCombo
                               select new ComboProveedor
                               {
                                   nombreProve = x.PROVEEDOR1
                               }).First();
                    return sql.nombreProve;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public string ObtenerNombreInsumos(int codCombo)
        {
            try
            {
                using (BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from x in BD.INSUMOS
                               where x.IDINSUMOS== codCombo
                               select new ComboInsumo
                               {
                                   nombreInsumo = x.INSUMO
                               }).First();
                    return sql.nombreInsumo;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public List<ComboInsumo> CmbInsumo()
        {
            try
            {
                using (BD_PANADERIA Bd = new BD_PANADERIA())
                {
                    var consult = (from cp in Bd.INSUMOS
                                   orderby cp.IDINSUMOS
                                   select new ComboInsumo
                                   {
                                       nombreInsumo = cp.INSUMO
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public List<ComboProveedor> CmbProveedor()
        {
            try
            {
                using(BD_PANADERIA Bd = new BD_PANADERIA())
                {
                    var consult = (from cp in Bd.PROVEEDOR
                                   orderby cp.IDPROVEEDOR
                                   select new ComboProveedor
                                   {
                                       nombreProve = cp.PROVEEDOR1
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------------
        public void LimpiarCasillas()
        {
            //this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        //---------------------------------------------------------------
        public void Clear()
        {
            LimpiarCasillas();
            txtCantidad.Focus();
            cbNombreInsumo.SelectedIndex = 0;
            cbnombreProveedor.SelectedIndex = 0;
        } 
        public Boolean Validar()
        {
            bool validator = false;
            string cantidad = txtCantidad.Text.Trim();
            string precio = txtPrecio.Text.Trim();

            if ( cantidad.Length > 0 && precio.Length > 0)
            {
                validator = true;
            }
            return validator;
        }
        //---------------------------------------------------------------
        public void msgAyuda(ToolTip tool, Button btn, string msg)
        {
            tool.SetToolTip(btn, msg);
        }
        public void Mnjs()
        {
            msgAyuda(msjRegistrar, btnRegistrar, "AÑADE UN NUEVO REGISTRO");
            msgAyuda(msgActualizar, btnActualizar, "ACTUALIZA/CAMBIA LOS DATOS DE UN REGISTRO");
            msgAyuda(msgEliminar, btnEliminar, "ELIMINA UN REGISTRO SELECCIONADO");
            msgAyuda(msgCancelar, btnCancelar, "LIMPIA LAS CASILLAS PARA AGREGAR OTRO REGISTRO");
        }
        //---------------------------------------------------------------
        private void GestiónInsumos_Load(object sender, EventArgs e)
        {
            Mnjs();
            cbNombreInsumo.DataSource = CmbInsumo();
            cbNombreInsumo.DisplayMember = "nombreInsumo";
            cbnombreProveedor.DataSource = CmbProveedor();
            cbnombreProveedor.DisplayMember = "nombreProve";
            dgvDetInsumo.DataSource = Visualizar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                DETALLE_INSUMO_PROVEEDOR detalle = new DETALLE_INSUMO_PROVEEDOR();
                detalle.IDDETALLE = 0;
                detalle.STOCK_Kg_ = Convert.ToDouble(txtCantidad.Text);
                detalle.PRECIO = Convert.ToDouble(txtPrecio.Text);
                detalle.FECHA_PRODUCCION = dt_Produccion.Value;
                detalle.FECHA_VENCIMIENTO = dt_Vencimiento.Value;
                int ii = BuscarCodigoInsumo(cbNombreInsumo.Text);
                int pp = BuscarCodigoProveedor(cbnombreProveedor.Text);
                detalle.IDINSUMOS = ii;
                detalle.IDPROVEEDOR = pp;


                if (txtCodigoDetalle.Text.Trim().Length > 0)
                {
                    detalle.IDDETALLE = Convert.ToInt32(txtCodigoDetalle.Text);
                    ActualizarDetalle(detalle);
                }
                else
                {
                    AgregarDetalle(detalle);
                    txtCodigoDetalle.Text = UltimoDetalle().IDDETALLE.ToString();
                }
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvDetInsumo.DataSource = Visualizar();
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

        private void dgvDetInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDetInsumo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDetInsumo.CurrentRow.Selected = true;
                txtCodigoDetalle.Text = dgvDetInsumo.Rows[e.RowIndex].Cells["IDDETALLE"].FormattedValue.ToString();
                txtCantidad.Text = dgvDetInsumo.Rows[e.RowIndex].Cells["STOCK_kg"].FormattedValue.ToString();
                txtPrecio.Text = dgvDetInsumo.Rows[e.RowIndex].Cells["PRECIO"].FormattedValue.ToString();
                dt_Produccion.Text = dgvDetInsumo.Rows[e.RowIndex].Cells["FECHA_PRODUCCION"].FormattedValue.ToString();
                dt_Vencimiento.Text = dgvDetInsumo.Rows[e.RowIndex].Cells["FECHA_VENCIMIENTO"].FormattedValue.ToString();
                int proveedor = Convert.ToInt32(dgvDetInsumo.Rows[e.RowIndex].Cells["IDPROVEEDOR"].FormattedValue.ToString());
                int insumos = Convert.ToInt32(dgvDetInsumo.Rows[e.RowIndex].Cells["IDINSUMOS"].FormattedValue.ToString());
                cbNombreInsumo.Text = ObtenerNombreInsumos(insumos);
                cbnombreProveedor.Text = ObtenerNombreProveedor(proveedor);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                DETALLE_INSUMO_PROVEEDOR detalle = new DETALLE_INSUMO_PROVEEDOR();
                detalle.IDDETALLE = 0;
                detalle.STOCK_Kg_ = Convert.ToDouble(txtCantidad.Text);
                detalle.PRECIO = Convert.ToDouble(txtPrecio.Text);
                detalle.FECHA_PRODUCCION = dt_Produccion.Value;
                detalle.FECHA_VENCIMIENTO = dt_Vencimiento.Value;
                int ii = BuscarCodigoInsumo(cbNombreInsumo.Text);
                int pp = BuscarCodigoProveedor(cbnombreProveedor.Text);
                detalle.IDINSUMOS = ii;
                detalle.IDPROVEEDOR = pp;

                detalle.IDDETALLE = Convert.ToInt32(txtCodigoDetalle.Text);
                ActualizarDetalle(detalle);
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvDetInsumo.DataSource = Visualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoDetalle.Text.Trim().Length > 0)
            {
                DialogResult rpta = DialogResult.OK;
                rpta = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL REGISTRO?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == DialogResult.Yes)
                {
                    DETALLE_INSUMO_PROVEEDOR detail = new DETALLE_INSUMO_PROVEEDOR();
                    detail.IDDETALLE = Convert.ToInt32(txtCodigoDetalle.Text);

                    ELiminarDetalle(detail);
                    dgvDetInsumo.DataSource = Visualizar();

                    Clear();
                    MessageBox.Show("SE ELIMINO EL REGISTRO", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR EL REGISTRO QUE DESEA ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
