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
    public partial class RegistrarT : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_RegistrarT CD_Client = new SmartGardenP.CRUD.CD_RegistrarT();

        public RegistrarT()
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
            text_Descripcion.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Tarea objeto = CD_Client.obtener(key);
            text_Descripcion.Text = objeto.Descripcion;

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Tarea objeregistrado = new Tarea();

            objeregistrado.Descripcion = text_Descripcion.Text;

            CD_Client.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void RegistrarT_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Tarea objeregistrado = new Tarea();

            objeregistrado.TareaID = key;
            objeregistrado.Descripcion = text_Descripcion.Text;


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
