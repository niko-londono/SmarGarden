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
    public partial class Floral : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Floral CD_Floral = new SmartGardenP.CRUD.CD_Floral();

        public Floral()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_Floral.listar();
        }
        private void obtener(int key)
        {
            ArregloFloral objeto = CD_Floral.obtener(key);
            text_Descripcion.Text = objeto.Descripcion;
            text_Precio.Text = Convert.ToDecimal(objeto.Precio_de_Complejidad).ToString();
        }

        private void limpiar()
        {
            text_Descripcion.Text = String.Empty;
            text_Precio.Text = String.Empty;
            key = 0;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            ArregloFloral objeregistrado = new ArregloFloral();

            objeregistrado.Descripcion = text_Descripcion.Text;
            objeregistrado.Precio_de_Complejidad = Convert.ToDecimal(text_Precio.Text);


            CD_Floral.registrar(objeregistrado);
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
            ArregloFloral objeregistrado = new ArregloFloral();

            objeregistrado.ArregloID = key;
            objeregistrado.Descripcion = text_Descripcion.Text;
            objeregistrado.Precio_de_Complejidad = Convert.ToDecimal(text_Precio.Text);

            CD_Floral.actualizar(objeregistrado);
            MessageBox.Show("Registro Actualizado");
            listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                CD_Floral.eliminar(key);
                limpiar();
                MessageBox.Show("Registro eliminado");
                listar();
            }
        }

        private void Floral_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void text_Descripcion_Enter(object sender, EventArgs e)
        {
            if (text_Descripcion.Text == "DESCRIPCION")
            {
                text_Descripcion.Text = "";
                text_Descripcion.ForeColor = Color.LightGray;
            }
        }

        private void text_Descripcion_Leave(object sender, EventArgs e)
        {
            if (text_Descripcion.Text == "")
            {
                text_Descripcion.Text = "DESCRIPCION";
                text_Descripcion.ForeColor = Color.LightGray;
            }
        }

        private void text_Precio_Enter(object sender, EventArgs e)
        {
            if (text_Precio.Text == "PRECIO")
            {
                text_Precio.Text = "";
                text_Precio.ForeColor = Color.LightGray;
            }
        }

        private void text_Precio_Leave(object sender, EventArgs e)
        {
            if (text_Precio.Text == "")
            {
                text_Precio.Text = "PRECIO";
                text_Precio.ForeColor = Color.LightGray;
            }
        }
    }
}
