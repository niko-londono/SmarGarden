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
    public partial class Clientes : Form
    {        
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Clientes CD_Client = new SmartGardenP.CRUD.CD_Clientes();        

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_Client.listar();
        }

        private void limpiar()
        {
            text_Nombre.Text = String.Empty;
            text_Correo.Text = String.Empty;
            text_Telefono.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Cliente objeto = CD_Client.obtener(key);
            text_Nombre.Text = objeto.Nombre;
            text_Correo.Text = objeto.Correo;
            text_Telefono.Text=objeto.Telefono; 
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Cliente objeregistrado = new Cliente();

            objeregistrado.Telefono = text_Telefono.Text;
            objeregistrado.Correo = text_Correo.Text;
            objeregistrado.Nombre = text_Nombre.Text;

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
            Cliente objeregistrado = new Cliente();

            objeregistrado.ClienteID = key;
            objeregistrado.Nombre = text_Nombre.Text;
            objeregistrado.Telefono = text_Telefono.Text;
            objeregistrado.Correo = text_Correo.Text;

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

        private void text_Nombre_Enter(object sender, EventArgs e)
        {
            if (text_Nombre.Text == "NOMBRE")
            {
                text_Nombre.Text = "";
                text_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void text_Nombre_Leave(object sender, EventArgs e)
        {
            if (text_Nombre.Text == "")
            {
                text_Nombre.Text = "NOMBRE";
                text_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void text_Correo_Enter(object sender, EventArgs e)
        {
            if (text_Correo.Text == "CORREO")
            {
                text_Correo.Text = "";
                text_Correo.ForeColor = Color.LightGray;
            }
        }

        private void text_Correo_Leave(object sender, EventArgs e)
        {
            if (text_Correo.Text == "")
            {
                text_Correo.Text = "CORREO";
                text_Correo.ForeColor = Color.LightGray;
            }
        }

        private void text_Telefono_Enter(object sender, EventArgs e)
        {
            if (text_Telefono.Text == "TELEFONO")
            {
                text_Telefono.Text = "";
                text_Telefono.ForeColor = Color.LightGray;
            }
        }

        private void text_Telefono_Leave(object sender, EventArgs e)
        {
            if (text_Telefono.Text == "")
            {
                text_Telefono.Text = "TELEFONO";
                text_Telefono.ForeColor = Color.LightGray;
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
