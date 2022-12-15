using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartGardenP
{
    public partial class Empleados : Form
    {
        private static int key = 0;
        private CD_Empleados CD_Products = new CD_Empleados();

        public Empleados()
        {
            InitializeComponent();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cargoDeEmpleado.Cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.cargoDeEmpleado.Cargo);
            // TODO: This line of code loads data into the 'smartGardenDataSet.Cargo' table. You can move, or remove it, as needed.
            listar();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_Products.listar();
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

        private void text_Apellido_Enter(object sender, EventArgs e)
        {
            if (text_Apellido.Text == "APELLIDO")
            {
                text_Apellido.Text = "";
                text_Apellido.ForeColor = Color.LightGray;
            }
        }

        private void text_Apellido_Leave(object sender, EventArgs e)
        {
            if (text_Apellido.Text == "")
            {
                text_Apellido.Text = "APELLIDO";
                text_Apellido.ForeColor = Color.LightGray;
            }
        }

        private void text_Cedula_Enter(object sender, EventArgs e)
        {
            if (text_Cedula.Text == "CEDULA")
            {
                text_Cedula.Text = "";
                text_Cedula.ForeColor = Color.LightGray;
            }
        }

        private void text_Cedula_Leave(object sender, EventArgs e)
        {
            if (text_Cedula.Text == "")
            {
                text_Cedula.Text = "CEDULA";
                text_Cedula.ForeColor = Color.LightGray;
            }
        }

        private void text_Salario_Enter(object sender, EventArgs e)
        {
            if (text_Salario.Text == "SALARIO")
            {
                text_Salario.Text = "";
                text_Salario.ForeColor = Color.LightGray;
            }
        }

        private void text_Salario_Leave(object sender, EventArgs e)
        {
            if (text_Salario.Text == "")
            {
                text_Salario.Text = "SALARIO";
                text_Salario.ForeColor = Color.LightGray;
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

        private void text_FechaNac_Enter(object sender, EventArgs e)
        {
            if (text_FechaNac.Text == "FECHA DE NACIMIENTO")
            {
                text_FechaNac.Text = "";
                text_FechaNac.ForeColor = Color.LightGray;
            }
        }

        private void text_FechaNac_Leave(object sender, EventArgs e)
        {
            if (text_FechaNac.Text == "")
            {
                text_FechaNac.Text = "FECHA DE NACIMIENTO";
                text_FechaNac.ForeColor = Color.LightGray;
            }
        }

        private void text_Genero_Enter(object sender, EventArgs e)
        {
            if (text_Genero.Text == "GENERO")
            {
                text_Genero.Text = "";
                text_Genero.ForeColor = Color.LightGray;
            }
        }

        private void text_Genero_Leave(object sender, EventArgs e)
        {
            if (text_Genero.Text == "")
            {
                text_Genero.Text = "GENERO";
                text_Genero.ForeColor = Color.LightGray;
            }
        }
        //Botones 
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Empleado objeregistrado = new Empleado();
            objeregistrado.Nombre = text_Nombre.Text;
            objeregistrado.Apellido = text_Apellido.Text;
            objeregistrado.FechaNac = Convert.ToDateTime(text_FechaNac.Text);
            objeregistrado.Cedula = text_Cedula.Text;
            objeregistrado.Correo = text_Correo.Text;
            objeregistrado.Telefono = text_Telefono.Text;
            objeregistrado.Genero = text_Genero.Text;
            objeregistrado.Salario = Convert.ToDecimal(text_Salario.Text);
            objeregistrado.Cargo = cbx_EmpCargo.Text;

            CD_Products.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            text_Nombre.Text = String.Empty;
            text_Apellido.Text = String.Empty;
            text_Cedula.Text = String.Empty;
            text_Correo.Text = String.Empty;
            text_Telefono.Text = String.Empty;
            cbx_EmpCargo.Text = String.Empty;
            text_Salario.Text = String.Empty;
            text_Genero.Text = String.Empty;
            text_FechaNac.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Empleado objeto  = CD_Products.obtener(key);
            text_Nombre.Text = objeto.Nombre;
            text_Apellido.Text = objeto.Apellido;
            text_Cedula.Text = objeto.Cedula;
            text_Correo.Text = objeto.Correo;
            text_Telefono.Text = objeto.Telefono;
            cbx_EmpCargo.Text = objeto.Cargo;
            text_Salario.Text = objeto.Salario.ToString();
            text_Genero.Text = objeto.Genero;
            text_FechaNac.Text = objeto.FechaNac.ToString();
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
            if (key != 0)
            {
                Empleado objeregistrado = new Empleado();
                objeregistrado.EmpID = key;
                objeregistrado.Nombre = text_Nombre.Text;
                objeregistrado.Apellido = text_Apellido.Text;
                objeregistrado.FechaNac = Convert.ToDateTime(text_FechaNac.Text);
                objeregistrado.Cedula = text_Cedula.Text;
                objeregistrado.Correo = text_Correo.Text;
                objeregistrado.Telefono = text_Telefono.Text;
                objeregistrado.Genero = text_Genero.Text;
                objeregistrado.Salario = Convert.ToDecimal(text_Salario.Text);
                objeregistrado.Cargo = cbx_EmpCargo.Text;
                CD_Products.actualizar(objeregistrado);
                MessageBox.Show("Registro Actualizado");
                listar();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                CD_Products.eliminar(key);
                limpiar();
                MessageBox.Show("Registro eliminado");
                listar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listar();
        }



        //
    }
}
