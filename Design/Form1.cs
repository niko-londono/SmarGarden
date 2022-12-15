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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        //Desplegar el SubMenu
        private void customizeDesing()
        {
            SubMenuArreglos.Visible = false;
            SubMenuEmpleados.Visible = false; 
            SubMenuTareas.Visible = false;
            SubMenuPaisa.Visible = false;
            SubMenuInventario.Visible = false;
        }

        private void hideSubMenu()
        {
            if (SubMenuArreglos.Visible == true)
                SubMenuArreglos.Visible = false;
            if (SubMenuEmpleados.Visible == true)
                SubMenuEmpleados.Visible = false;
            if (SubMenuTareas.Visible == true)
                SubMenuTareas.Visible = false;
            if (SubMenuPaisa.Visible == true)
                SubMenuPaisa.Visible = false;
            if (SubMenuInventario.Visible == true)
                SubMenuInventario.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //.

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Codigo de navegacion
        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        //.

        //Para poder mover la ventana a voluntad 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //.

        //Para ocultar y mostrar SubMenu
        private void btnArreglos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(SubMenuArreglos);
        }

        private void btnArregloFloral_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Floral());
            hideSubMenu();
        }

        private void btnOrdenes_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Ordenes());
            hideSubMenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {            
            showSubMenu(SubMenuEmpleados);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuEmpleados);
            AbrirFormHija(new Empleados());
        }

        private void btn_Rango_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new CargoPrincipal());
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Clientes());
        }

        private void btn_Tareas_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuTareas);
        }

        private void btn_RegistrarTarea_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new RegistrarT());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new AsignacionT());
        }

        private void btnPaisajismo_Click_1(object sender, EventArgs e)
        {
            showSubMenu(SubMenuPaisa);
        }

        private void btn_RegistrarPaisa_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new RegistrarPaisa());
        }

        private void btm_OrdenesPaisa_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new OrdenesPaisa());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuInventario);
        }

        private void btn_Suministros_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new Suministros());
        }

        private void btn_Unidades_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new Unidades());
        }

        private void btnGlosario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Glosario());
        }
        //.

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new inicio());
        }

        //El programa iniciara con esta pagina
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            //btnInicio_Click(null, e);
        }
        //.

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LOGIN mainMenu = new LOGIN();
            mainMenu.Show();
            this.Hide();
        }

    }
}
