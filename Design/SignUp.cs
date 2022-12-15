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
namespace SmartGardenP.Design
{
    public partial class SignUp : Form
    {
        private SmartGardenP.CRUD.CD_SignUp CD_SU = new SmartGardenP.CRUD.CD_SignUp();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Usuario objeregistrado = new Usuario();

            objeregistrado.usuario1 = text_Usuario.Text;
            objeregistrado.contrase = text_Contraseña.Text;

            CD_SU.registrar(objeregistrado);
            this.Hide();
            LOGIN mainMenu = new LOGIN();
            mainMenu.Show();
        }

        //Para poder mover la ventana a voluntad 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //.
    }
}
