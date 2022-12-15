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
    public partial class Glosario : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Glosario CD_Client = new SmartGardenP.CRUD.CD_Glosario();

        public Glosario()
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
            text_NombreGlo.Text = String.Empty;
            text_Informacion.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Tipo objeto = CD_Client.obtener(key);
            text_NombreGlo.Text = objeto.Nombre;
            text_Informacion.Text = objeto.Informaciones;

        }

        private void Glosario_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Tipo objeregistrado = new Tipo();

            objeregistrado.Nombre = text_NombreGlo.Text;
            objeregistrado.Informaciones = text_Informacion.Text;

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
            Tipo objeregistrado = new Tipo();

            objeregistrado.TipoID = key;
            objeregistrado.Nombre = text_NombreGlo.Text;
            objeregistrado.Informaciones = text_Informacion.Text;

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

        private void text_NombreGlo_Enter(object sender, EventArgs e)
        {
            if (text_NombreGlo.Text == "NOMBRE")
            {
                text_NombreGlo.Text = "";
                text_NombreGlo.ForeColor = Color.LightGray;
            }
        }

        private void text_NombreGlo_Leave(object sender, EventArgs e)
        {
            if (text_NombreGlo.Text == "")
            {
                text_NombreGlo.Text = "NOMBRE";
                text_NombreGlo.ForeColor = Color.LightGray;
            }
        }

        private void text_Informacion_Enter(object sender, EventArgs e)
        {
            if (text_Informacion.Text == "INFORMACION")
            {
                text_Informacion.Text = "";
                text_Informacion.ForeColor = Color.LightGray;
            }
        }

        private void text_Informacion_Leave(object sender, EventArgs e)
        {
            if (text_Informacion.Text == "")
            {
                text_Informacion.Text = "INFORMACION";
                text_Informacion.ForeColor = Color.LightGray;
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
