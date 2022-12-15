using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGardenP
{
    public partial class RegistrarPaisa : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_RegistrarPaisa CD_Client = new SmartGardenP.CRUD.CD_RegistrarPaisa();

        public RegistrarPaisa()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_Client.listar();
        }

        private void limpiar()
        {
            text_DescripcionP.Text = String.Empty;
            text_PrecioCliente.Text = String.Empty;
            text_TiempoLim.Text = String.Empty;
            text_Presupuesto.Text = String.Empty;
            text_FechaPaisa.Text = String.Empty;
            cbx_ClienteID.Text= String.Empty;

            key = 0;
        }

        private void obtener(int key)
        {
            Paisajismo objeto = CD_Client.obtener(key);
            text_DescripcionP.Text = objeto.Descripcion;
            text_PrecioCliente.Text = objeto.Precio_Cliente.ToString();
            text_TiempoLim.Text = Convert.ToDateTime(objeto.DeadLine).ToString();
            text_Presupuesto.Text = objeto.Presupuesto.ToString();
            text_FechaPaisa.Text = Convert.ToDateTime(objeto.Fecha_Inicial).ToString();

            cbx_ClienteID.Text = objeto.ClienteID.ToString();
        }

        private void RegistrarPaisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paisajismo_Cliente.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.paisajismo_Cliente.Cliente);
            listar();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Paisajismo objeregistrado = new Paisajismo();

            objeregistrado.Descripcion = text_DescripcionP.Text;
            objeregistrado.Precio_Cliente = Convert.ToInt32(text_PrecioCliente.Text);
            objeregistrado.DeadLine = Convert.ToDateTime(text_TiempoLim.Text);
            objeregistrado.Presupuesto = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Fecha_Inicial = Convert.ToDateTime(text_FechaPaisa.Text);

            objeregistrado.ClienteID = Convert.ToInt32(cbx_ClienteID.Text);


            CD_Client.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Paisajismo objeregistrado = new Paisajismo();

            objeregistrado.PaisaID = key;
            objeregistrado.Descripcion = text_DescripcionP.Text;
            objeregistrado.Precio_Cliente = Convert.ToInt32(text_PrecioCliente.Text);
            objeregistrado.DeadLine = Convert.ToDateTime(text_TiempoLim.Text);
            objeregistrado.Presupuesto = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Fecha_Inicial = Convert.ToDateTime(text_FechaPaisa.Text);

            objeregistrado.ClienteID = Convert.ToInt32(cbx_ClienteID.Text.ToString());

            CD_Client.actualizar(objeregistrado);
            MessageBox.Show("Registro Actualizado");
            listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                CD_Client.eliminar(key);
                limpiar();
                MessageBox.Show("Registro eliminado");
                listar();
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    key = int.Parse(row.Cells[0].Value.ToString());
                    obtener(key);
                }
            }
        }

        private void text_FechaPaisa_Enter(object sender, EventArgs e)
        {
            if (text_FechaPaisa.Text == "FECHA INICIAL")
            {
                text_FechaPaisa.Text = "";
                text_FechaPaisa.ForeColor = Color.LightGray;
            }
        }

        private void text_FechaPaisa_Leave(object sender, EventArgs e)
        {
            if (text_FechaPaisa.Text == "")
            {
                text_FechaPaisa.Text = "FECHA INICIAL";
                text_FechaPaisa.ForeColor = Color.LightGray;
            }
        }

        private void text_Presupuesto_Enter(object sender, EventArgs e)
        {
            if (text_Presupuesto.Text == "PRESUPUESTO")
            {
                text_Presupuesto.Text = "";
                text_Presupuesto.ForeColor = Color.LightGray;
            }
        }

        private void text_Presupuesto_Leave(object sender, EventArgs e)
        {
            if (text_Presupuesto.Text == "")
            {
                text_Presupuesto.Text = "PRESUPUESTO";
                text_Presupuesto.ForeColor = Color.LightGray;
            }
        }

        private void text_TiempoLim_Enter(object sender, EventArgs e)
        {
            if (text_TiempoLim.Text == "TIEMPOMLIMITE")
            {
                text_TiempoLim.Text = "";
                text_TiempoLim.ForeColor = Color.LightGray;
            }
        }

        private void text_TiempoLim_Leave(object sender, EventArgs e)
        {
            if (text_TiempoLim.Text == "")
            {
                text_TiempoLim.Text = "TIEMPOMLIMITE";
                text_TiempoLim.ForeColor = Color.LightGray;
            }
        }

        private void text_PrecioCliente_Enter(object sender, EventArgs e)
        {
            if (text_PrecioCliente.Text == "PRECIO CLIENTE")
            {
                text_PrecioCliente.Text = "";
                text_PrecioCliente.ForeColor = Color.LightGray;
            }
        }

        private void text_PrecioCliente_Leave(object sender, EventArgs e)
        {
            if (text_PrecioCliente.Text == "")
            {
                text_PrecioCliente.Text = "PRECIO CLIENTE";
                text_PrecioCliente.ForeColor = Color.LightGray;
            }
        }

        private void text_DescripcionP_Enter(object sender, EventArgs e)
        {
            if (text_DescripcionP.Text == "DESCRIPCION")
            {
                text_DescripcionP.Text = "";
                text_DescripcionP.ForeColor = Color.LightGray;
            }
        }

        private void text_DescripcionP_Leave(object sender, EventArgs e)
        {
            if (text_DescripcionP.Text == "")
            {
                text_DescripcionP.Text = "DESCRIPCION";
                text_DescripcionP.ForeColor = Color.LightGray;
            }
        }
    }
}
