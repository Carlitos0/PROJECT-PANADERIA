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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            FuncionesBtn(btnCerrar);
            FuncionesBtn(btnMinimizar);

        }
        String user ;
        String pws ;
        private void FuncionesBtn(IconPictureBox btn)
        {
            void btn_MouseDown(object sender, MouseEventArgs e)
            {
                btn.IconColor = Color.Black;
            }
            void btn_MouseLeave(object sender, MouseEventArgs e)
            {
                btn.IconColor = Color.Black;
            }
            void btn_MouseMove(object sender, MouseEventArgs e)
            {
                btn.IconColor = Color.White;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text.Trim();
            pws = txtPws.Text.Trim();
            //DialogResult rpta;
            if (user.Equals("admin") && pws.Equals("123"))
            {
                this.Hide();
                VentanaCarga welcome = new VentanaCarga();
                welcome.ShowDialog();
                VentanaPrincipal vp = new VentanaPrincipal();
                vp.Show();
            }
            else
            {
                lblMensaje.Text = "Usuario y/o contraseña incorrecta";
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter)){
                txtPws.Focus();
            }
        }

        private void txtPws_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                user = txtUser.Text.Trim();
                pws = txtPws.Text.Trim();
                //DialogResult rpta;
                if (user.Equals("admin") && pws.Equals("123"))
                {
                    this.Hide();
                    VentanaCarga welcome = new VentanaCarga();
                    welcome.ShowDialog();
                    VentanaPrincipal vp = new VentanaPrincipal();
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Message", MessageBoxButtons.OK);
                }
            }
        }
    }
}
