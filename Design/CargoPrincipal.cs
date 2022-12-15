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
    public partial class CargoPrincipal : Form
    {
        private static int key = 0;
        private CD_CargoP CD_CP =  new CD_CargoP(); 

        public CargoPrincipal()
        {
            InitializeComponent();
        }

        private void CargoPrincipal_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_CP.listar();
        }

        private void text_NombreCargo_Enter(object sender, EventArgs e)
        {
            if (text_NombreCargo.Text == "NOMBRE DEL CARGO")
            {
                text_NombreCargo.Text = "";
                text_NombreCargo.ForeColor = Color.LightGray;
            }
        }

        private void text_NombreCargo_Leave(object sender, EventArgs e)
        {
            if (text_NombreCargo.Text == "")
            {
                text_NombreCargo.Text = "NOMBRE DEL CARGO";
                text_NombreCargo.ForeColor = Color.LightGray;
            }
        }

        private void text_Descripcion_Enter(object sender, EventArgs e)
        {
            if (text_Descripcion.Text == "DESCRIPCION")
            {
                text_Descripcion.Text = "";
                text_Descripcion.ForeColor = Color.LightGray;
            }
        }

        private void text_Beneficios_Enter(object sender, EventArgs e)
        {
            if (text_Beneficios.Text == "BENEFICIOS")
            {
                text_Beneficios.Text = "";
                text_Beneficios.ForeColor = Color.LightGray;
            }
        }

        private void text_Beneficios_Leave(object sender, EventArgs e)
        {
            if (text_Beneficios.Text == "")
            {
                text_Beneficios.Text = "BENEFICIOS";
                text_Beneficios.ForeColor = Color.LightGray;
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

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Cargo objeregistrado = new Cargo();

            objeregistrado.Cargo1 = text_NombreCargo.Text;
            objeregistrado.Beneficios = text_Beneficios.Text;
            objeregistrado.Descripcion = text_Descripcion.Text;

            CD_CP.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void limpiar()
        {
            text_NombreCargo.Text = String.Empty;
            text_Beneficios.Text = String.Empty;
            text_Descripcion.Text = String.Empty;
            key = 0;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void obtener(int key)
        {
            Cargo objeto = CD_CP.obtener(key);
            text_NombreCargo.Text = objeto.Cargo1;
            text_Beneficios.Text = objeto.Beneficios;
            text_Descripcion.Text = objeto.Descripcion;
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

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cargo objeregistrado = new Cargo();

            objeregistrado.CargoID = key;
            objeregistrado.Cargo1 = text_NombreCargo.Text;
            objeregistrado.Beneficios = text_Beneficios.Text;
            objeregistrado.Descripcion = text_Descripcion.Text;

            CD_CP.actualizar(objeregistrado);
            MessageBox.Show("Registro Actualizado");
            listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                CD_CP.eliminar(key);
                limpiar();
                MessageBox.Show("Registro eliminado");
                listar();
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
