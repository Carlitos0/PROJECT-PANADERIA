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
    public partial class FrmGestionProductos : Form
    {
        public FrmGestionProductos()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------
        public class EstructuraReceta
        {
            public int IDRECETA { get; set; }
            public string PRODUCTO { get; set; }
            public string INSUMOS { get; set; }
            public Nullable<double> CANTIDAD { get; set; }
        }
        //----------------------------------------------------------
        public class ProductoDto
        {
            public int IDPRODUCTO { get; set; }
            public string DESCRIPCION { get; set; }
        }
        //---------------------------------------------------------
        public class InsumoDto
        {
            public int IDINSUMOS { get; set; }
            public string INSUMO { get; set; }
        }
        //---------------------------------------------------------
        public class codProducto
        {
            public int idproducto { get; set; }
        }
        //---------------------------------------------------------
        public void NombreProducto()
        {
            List<ProductoDto> prod = new List<ProductoDto>();
            using (BD_PANADERIA BD = new BD_PANADERIA())
            {
                prod = (from p in BD.PRODUCTO
                        orderby p.IDPRODUCTO
                        select new ProductoDto
                        {
                            IDPRODUCTO = p.IDPRODUCTO,
                            DESCRIPCION = p.DESCRIPCION
                        }).ToList();
            }
            cbProducto.DataSource = prod;
            cbProducto.DisplayMember = "DESCRIPCION";
            cbProducto.ValueMember = "DESCRIPCION";
        }
        //---------------------------------------------------------
        public void InsertarReceta(RECETA receta)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    BD.RECETA.Add(receta);
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public void ActualizarReceta(RECETA receta)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from ar in BD.RECETA where ar.IDRECETA == receta.IDRECETA select ar;
                    foreach(RECETA rt in sql)
                    {
                        rt.IDRECETA = receta.IDRECETA;
                        rt.IDPRODUCTO = receta.IDPRODUCTO;
                        rt.IDINSUMOS = receta.IDINSUMOS;
                        rt.CANTIDAD = receta.CANTIDAD;
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public void EliminarReceta(RECETA receta)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = from er in BD.RECETA where er.IDRECETA == receta.IDRECETA select er;
                    foreach(RECETA rt in sql)
                    {
                        BD.RECETA.Remove(rt);
                    }
                    BD.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public int ObtenerCodigoProducto(string nombreprod)
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var sql = (from o in BD.PRODUCTO
                               where o.DESCRIPCION == nombreprod
                               orderby o.IDPRODUCTO
                               select new codProducto
                               {
                                   idproducto = o.IDPRODUCTO
                               }).First();
                    return sql.idproducto;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public bool Validar()
        {
            bool validator = false;
            string cantidad = txtCantidadKg.Text.Trim();
            if (cantidad.Length > 0 )
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
            txtCantidadKg.Text = "";
            txtCantidadKg.Focus();
            cbProducto.SelectedIndex = 0;
            dgvIngredienteTemp.Rows.Remove(dgvIngredienteTemp.CurrentRow);
        }
        //---------------------------------------------------------
        public List<EstructuraReceta> ObtenerReceta()
        {
            try
            {
                using (BD_PANADERIA Bd = new BD_PANADERIA())
                {
                    var consult = (from r in Bd.RECETA
                                   join p in Bd.PRODUCTO on r.IDPRODUCTO equals p.IDPRODUCTO
                                   join i in Bd.INSUMOS on r.IDINSUMOS equals i.IDINSUMOS
                                   orderby r.IDPRODUCTO
                                   select new EstructuraReceta
                                   {
                                       IDRECETA = r.IDRECETA,
                                       INSUMOS = i.INSUMO,
                                       CANTIDAD = r.CANTIDAD,
                                       PRODUCTO = p.DESCRIPCION
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public List<InsumoDto> ObtenerInsumo()
        {
            try
            {
                using(BD_PANADERIA BD = new BD_PANADERIA())
                {
                    var consult = (from i in BD.INSUMOS
                                   orderby i.IDINSUMOS
                                   select new InsumoDto
                                   {
                                       IDINSUMOS = i.IDINSUMOS,
                                       INSUMO = i.INSUMO
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //---------------------------------------------------------
        public List<ProductoDto> ObtenerProducto()
        {
            try
            {
                using(BD_PANADERIA Bd = new BD_PANADERIA())
                {
                    var consult = (from p in Bd.PRODUCTO
                                   orderby p.IDPRODUCTO
                                   select new ProductoDto
                                   {
                                       IDPRODUCTO = p.IDPRODUCTO,
                                       DESCRIPCION = p.DESCRIPCION
                                   }).ToList();
                    return consult;
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ObtenerProducto();
            dgvInsumos.DataSource = ObtenerInsumo();
            dgvReceta.DataSource = ObtenerReceta();
            NombreProducto();
        }

        private void btnAñadirIngrediente_Click(object sender, EventArgs e)
        {
            if(txtCantidadKg.Text.Length > 0)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvIngredienteTemp);
                fila.Cells[0].Value = dgvInsumos.CurrentRow.Cells["INSUMO"].Value.ToString();
                fila.Cells[1].Value = txtCantidadKg.Text;

                dgvIngredienteTemp.Rows.Add(fila);
                //txtCantidadKg.Text = "";
            }
            else
            {
                MessageBox.Show("DEBE INSERTAR UNA CANTIDAD(KG)!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidadKg.Focus();
            }
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            dgvIngredienteTemp.Rows.Remove(dgvIngredienteTemp.CurrentRow);
        }
        public void LlenarGrid()
        {
            dgvProductos.DataSource = ObtenerProducto();
        }

        private void AdProd_UdapteEventHandler(object sender, MantenimientoProducto.UpdateEventArgs args)
        {
            LlenarGrid();
        }

        private void btnMantenimientoProd_Click(object sender, EventArgs e)
        {
            MantenimientoProducto mantenimientoprod = new MantenimientoProducto(this);
            mantenimientoprod.UpdateEventHandler += AdProd_UdapteEventHandler;
            mantenimientoprod.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                RECETA receta = new RECETA();
                receta.IDRECETA = 0;
                receta.IDINSUMOS = Convert.ToInt32(dgvInsumos.CurrentRow.Cells["IDINSUMOS"].Value.ToString());
                int codigoProd = ObtenerCodigoProducto(cbProducto.Text);
                receta.IDPRODUCTO = codigoProd;
                receta.CANTIDAD = Convert.ToDouble(txtCantidadKg.Text);


                //if(txtCantidadKg.Text.Trim().Length > 0)
                //{
                //    receta.IDRECETA = Convert.ToInt32(txtCodReceta.Text);
                //    ActualizarReceta(receta);
                //}
                //else
                //{
                    InsertarReceta(receta);
                //}
                Clear();
                MessageBox.Show("DATOS GUARDADOS SATISFACTORIAMENTE", "MESSAGE", MessageBoxButtons.OK);
                dgvReceta.DataSource = ObtenerReceta();
                NombreProducto();
            }
        }

        private void dgvIngredienteTemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                dgvIngredienteTemp.Rows.Remove(dgvIngredienteTemp.CurrentRow);
            }
        }
    }
}
