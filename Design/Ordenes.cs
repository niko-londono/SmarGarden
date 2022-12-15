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
    public partial class Ordenes : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Ordenes CD_Ordenes = new SmartGardenP.CRUD.CD_Ordenes();

        public Ordenes()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = CD_Ordenes.listar();
        }

        private void obtener(int key)
        {
            ArregloFloral_Cliente objeto = CD_Ordenes.obtener(key);
            cbx_EmpID.Text = objeto.EmpID.ToString();
            cbx_Cliente.Text = objeto.ClienteID.ToString();
            cbx_Arreglo.Text = objeto.ArregloID.ToString();

            text_Fecha.Text = Convert.ToDateTime(objeto.Fecha_Inicial).ToString();
            text_DeadLine.Text = Convert.ToDateTime(objeto.DeadLine).ToString();
            text_Cantidad.Text = Convert.ToDecimal(objeto.Cantidad).ToString();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            ArregloFloral_Cliente objeregistrado = new ArregloFloral_Cliente();

            objeregistrado.Fecha_Inicial = Convert.ToDateTime(text_Fecha.Text);
            objeregistrado.DeadLine = Convert.ToDateTime(text_DeadLine.Text);
            objeregistrado.Cantidad = Convert.ToInt32(text_Cantidad.Text);

            objeregistrado.EmpID = Convert.ToInt32(cbx_EmpID.Text);
            objeregistrado.ClienteID = Convert.ToInt32(cbx_Cliente.Text);
            objeregistrado.ArregloID = Convert.ToInt32(cbx_Arreglo.Text);

            CD_Ordenes.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ArregloFloral_Cliente objeregistrado = new ArregloFloral_Cliente();

            objeregistrado.Arreglo_clienteID = key;
            objeregistrado.Fecha_Inicial = Convert.ToDateTime(text_Fecha.Text.ToString());
            objeregistrado.DeadLine = Convert.ToDateTime(text_DeadLine.Text.ToString());
            objeregistrado.Cantidad = Convert.ToInt32(text_Cantidad.Text.ToString());

            objeregistrado.EmpID = Convert.ToInt32(cbx_EmpID.Text.ToString());
            objeregistrado.ClienteID = Convert.ToInt32(cbx_Cliente.Text.ToString());
            objeregistrado.ArregloID = Convert.ToInt32(cbx_Arreglo.Text.ToString());


            CD_Ordenes.actualizar(objeregistrado);
            MessageBox.Show("Registro Actualizado");
            listar();
        }

        private void limpiar()
        {
            cbx_Cliente.Text = String.Empty;
            cbx_EmpID.Text = String.Empty;
            cbx_Arreglo.Text = String.Empty;

            text_Fecha.Text = String.Empty;
            text_DeadLine.Text = String.Empty;
            text_Cantidad.Text = String.Empty;
            key = 0;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            listar();
        }

        

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (key != 0)
            {
                CD_Ordenes.eliminar(key);
                limpiar();
                MessageBox.Show("Registro eliminado");
                listar();
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

        private void text_Fecha_Enter(object sender, EventArgs e)
        {
            if (text_Fecha.Text == "FECHA")
            {
                text_Fecha.Text = "";
                text_Fecha.ForeColor = Color.LightGray;
            }
        }

        private void text_Fecha_Leave(object sender, EventArgs e)
        {
            if (text_Fecha.Text == "")
            {
                text_Fecha.Text = "FECHA";
                text_Fecha.ForeColor = Color.LightGray;
            }
        }

        private void text_DeadLine_Enter(object sender, EventArgs e)
        {
            if (text_DeadLine.Text == "FECHA LIMITE")
            {
                text_DeadLine.Text = "";
                text_DeadLine.ForeColor = Color.LightGray;
            }
        }

        private void text_DeadLine_Leave(object sender, EventArgs e)
        {
            if (text_DeadLine.Text == "")
            {
                text_DeadLine.Text = "FECHA LIMITE";
                text_DeadLine.ForeColor = Color.LightGray;
            }
        }

        private void text_Cantidad_Enter(object sender, EventArgs e)
        {
            if (text_Cantidad.Text == "CANTIDAD")
            {
                text_Cantidad.Text = "";
                text_Cantidad.ForeColor = Color.LightGray;
            }
        }

        private void text_Cantidad_Leave(object sender, EventArgs e)
        {
            if (text_Cantidad.Text == "")
            {
                text_Cantidad.Text = "CANTIDAD";
                text_Cantidad.ForeColor = Color.LightGray;
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordenesFlorales_ArregloFloral.ArregloFloral' table. You can move, or remove it, as needed.
            this.arregloFloralTableAdapter.Fill(this.ordenesFlorales_ArregloFloral.ArregloFloral);
            // TODO: This line of code loads data into the 'ordenesFlorales_ClienteID.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.ordenesFlorales_ClienteID.Cliente);
            // TODO: This line of code loads data into the 'smartGardenDataSet1.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.smartGardenDataSet1.Empleado);

            listar();
        }
    }
}
