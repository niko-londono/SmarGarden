using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartGardenP
{
    public partial class LOGIN : Form
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public LOGIN()
        {
            InitializeComponent();
        }

        //Para poder mover la ventana a voluntad 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //.

        private void text_Usuario_Enter(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "USUARIO")
            {
                text_Usuario.Text = "";
                text_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void text_Usuario_Leave(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "")
            {
                text_Usuario.Text = "USUARIO";
                text_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void text_Contraseña_Enter(object sender, EventArgs e)
        {
            if (text_Contraseña.Text == "CONTRASEÑA")
            {
                text_Contraseña.Text = "";
                text_Contraseña.ForeColor = Color.LightGray;
                text_Contraseña.UseSystemPasswordChar = true;

            }
        }

        private void text_Contraseña_Leave(object sender, EventArgs e)
        {
            if (text_Contraseña.Text == "")
            {
                text_Contraseña.Text = "CONTRASEÑA";
                text_Contraseña.ForeColor = Color.LightGray;
                text_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == string.Empty & text_Contraseña.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                if ((from Usuario in db.Usuario
                     where Usuario.usuario1 == text_Usuario.Text
                     select Usuario).Count() > 0)
                {
                    var result = db.ValidarUsuario(text_Usuario.Text, text_Contraseña.Text);

                    if (result.Count() > 0)
                    {
                        this.Hide();
                        Form1 mainMenu = new Form1();
                        mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                }
            }
            /*var user = (from s in db.Usuario where s.usuario1 == text_Usuario.Text select s).First();

            if (user.contrase == text_Contraseña.Text)
            {
                this.Hide();
                Form1 mainMenu = new Form1();
                mainMenu.Show();                
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            } 
            */
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SmartGardenP.Design.SignUp mainMenu = new SmartGardenP.Design.SignUp();
            mainMenu.Show();
        }
    }
}
