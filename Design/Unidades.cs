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
    public partial class Unidades : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Unidades CD_Client = new SmartGardenP.CRUD.CD_Unidades();

        public Unidades()
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
            text_FechaExpirado.Text = String.Empty;
            text_Presupuesto.Text = String.Empty;
            text_Condicion.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Unidad objeto = CD_Client.obtener(key);
            text_FechaExpirado.Text = objeto.FeExpirado.ToString();
            text_Presupuesto.Text = objeto.Precio_Unidad.ToString();
            text_Condicion.Text = objeto.Condicion;

            cbx_TipoID.Text = objeto.TipoID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unidades_TipoID.Tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.unidades_TipoID.Tipo);
            listar();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Unidad objeregistrado = new Unidad();

            objeregistrado.FeExpirado = Convert.ToDateTime(text_FechaExpirado.Text);
            objeregistrado.Precio_Unidad = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Condicion = text_Condicion.Text;

            objeregistrado.TipoID = Convert.ToInt32(cbx_TipoID.Text);

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
            Unidad objeregistrado = new Unidad();

            objeregistrado.UnidadID = key;
            objeregistrado.FeExpirado = Convert.ToDateTime(text_FechaExpirado.Text);
            objeregistrado.Precio_Unidad = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Condicion = text_Condicion.Text;

            objeregistrado.TipoID = Convert.ToInt32(cbx_TipoID.Text);


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

        private void text_FechaExpirado_Enter(object sender, EventArgs e)
        {
            if (text_FechaExpirado.Text == "FECHA EXPIRADO")
            {
                text_FechaExpirado.Text = "";
                text_FechaExpirado.ForeColor = Color.LightGray;
            }
        }

        private void text_FechaExpirado_Leave(object sender, EventArgs e)
        {
            if (text_FechaExpirado.Text == "")
            {
                text_FechaExpirado.Text = "FECHA EXPIRADO";
                text_FechaExpirado.ForeColor = Color.LightGray;
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

        private void text_Condicion_Enter(object sender, EventArgs e)
        {
            if (text_Condicion.Text == "CONDICION")
            {
                text_Condicion.Text = "";
                text_Condicion.ForeColor = Color.LightGray;
            }
        }

        private void text_Condicion_Leave(object sender, EventArgs e)
        {
            if (text_Condicion.Text == "")
            {
                text_Condicion.Text = "CONDICION";
                text_Condicion.ForeColor = Color.LightGray;
            }
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
    }
}
