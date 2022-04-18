using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class VentanaPrincipal : Form
    {
        private IconButton botonActual;
        private Panel bordeIzquierdo;
        public VentanaPrincipal()
        {
            InitializeComponent();
            bordeIzquierdo = new Panel();//inicializamos el panel izquierdo del btn
            bordeIzquierdo.Size = new Size(13, 77);// le damos un tamaño
            //agregamos el boder a los bordes de los botones en el panel
            panelMenu.Controls.Add(bordeIzquierdo);
            AbrirFormHijo(new FrmInicial());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private struct RGbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(100, 255, 150);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            //colores referentes a la panderia
            public static Color color01 = Color.FromArgb(255, 192, 128);
            public static Color color02 = Color.FromArgb(144, 93, 42);
            public static Color color03 = Color.FromArgb(50, 31, 12);
        }
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarResaltado();
                botonActual = (IconButton)senderBtn;// convertimos el objeto actual al mismo tipo de boton que tenemos
                botonActual.BackColor = Color.FromArgb(255, 128, 0);//cambiamos su color de fondo 
                botonActual.ForeColor = color;//cambiamos el color de fuente
                botonActual.TextAlign = ContentAlignment.MiddleCenter;// centramos el texto
                botonActual.IconColor = color;//cambiamos el color del icono
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;//le damos el valor  de orden del icono y texto del boton
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //configuramos el borde izquierdo del boton
                bordeIzquierdo.BackColor = color;//cambiamos de color al borde 
                bordeIzquierdo.Location = new Point(0, botonActual.Location.Y);//modificamos su posicion, le damos la posicion del eje y del boton actual
                bordeIzquierdo.Visible = true;//lo mostramos
                bordeIzquierdo.BringToFront();//lo llevamos al frente
                //configuramos barra de titulo
                //iconoFrmHijoActual.IconChar = botonActual.IconChar;
                //iconoFrmHijoActual.IconColor = color;
            }
        }
        private void DesactivarResaltado()
        {
            if (botonActual != null)
            {//regresemanos el boton a sus valores principales
                botonActual.BackColor = Color.FromArgb(255, 192, 128);
                botonActual.ForeColor = Color.Black;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.SaddleBrown;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void AbrirFormHijo(object formHijo)
        {
            if (this.Contenedor.Controls.Count > 0)// PREGUNTAMOS SI EXISTE ALGUN CONTROL
            {
                this.Contenedor.Controls.RemoveAt(0);//SI ES VERDAD LO ELIMINAMOS
            }
            Form formulario = formHijo as Form; //SE CREA UN FRM, Y EL PARAMETRO INGRESADO TIENE QUE SER TOMADO COMO OTRO FORM
            formulario.TopLevel = false; //AQUI LE DECIMOS QUE ES UN FOMRLARIO SECUNDARIO
            formulario.Dock = DockStyle.Fill;//HARA QUE EL FORMULARIO HIJO SE ACOPLE A TODO EL PANEL CONTENEDOR
            this.Contenedor.Controls.Add(formulario);//AGREGAMOS AL PANEL CONTENEDOR
            this.Contenedor.Tag = formulario;//lLE ASGINAMOS QUE ES LO QUE VA A RECIBIR EL CONTENEDOR
            formulario.Show();

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
            AbrirFormHijo(new FrmGestionProductos());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
            AbrirFormHijo(new GestiónInsumos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
            AbrirFormHijo(new FrmVentaMayor());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
            AbrirFormHijo(new FrmVentaMenor());
        }

        private void bntCalculos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
            AbrirFormHijo(new FrmFinanzas());
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGbColors.color03);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void btnMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinimizar.IconColor = Color.Black; //Color.FromArgb(51,51,51);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.IconColor = Color.White; //Color.FromArgb(51,51,51);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.IconColor = Color.Black; //Color.FromArgb(51,51,51);
        }

        private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnCerrar.IconColor = Color.Black;
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.IconColor = Color.White;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.IconColor = Color.Black;
        }

        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
            AbrirFormHijo(new FrmInicial());
        }

        private void Reset()
        {
            DesactivarResaltado();
            bordeIzquierdo.Visible = false;
        }
    }
}
