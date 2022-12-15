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
    public partial class Suministros : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_Suministros CD_Client = new SmartGardenP.CRUD.CD_Suministros();

        public Suministros()
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
            text_FechaSalida.Text = String.Empty;
            text_Presupuesto.Text = String.Empty;
            text_Cantidad.Text = String.Empty;
            cbx_TipoID.Text = String.Empty;
            cbxSuminEmpID.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Suministro objeto = CD_Client.obtener(key);

            string FDS = objeto.Fecha_de_Salida.ToString();
            string Presu = objeto.Presupuesto.ToString();
            string Canti = objeto.Cantidad.ToString();

            text_FechaSalida.Text = FDS;
            text_Presupuesto.Text = Presu;
            text_Cantidad.Text = Canti;

            cbx_TipoID.Text = objeto.TipoID.ToString();
            cbxSuminEmpID.Text = objeto.EmpID.ToString();

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Suministro objeregistrado = new Suministro();

            objeregistrado.Fecha_de_Salida = Convert.ToDateTime(text_FechaSalida.Text);
            objeregistrado.Presupuesto = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Cantidad = Convert.ToInt32(text_Cantidad.Text);

            objeregistrado.TipoID = Convert.ToInt32(cbx_TipoID.Text);
            objeregistrado.EmpID = Convert.ToInt32(cbxSuminEmpID.Text);


            CD_Client.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void Suministros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suministro_Empleado.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.suministro_Empleado.Empleado);
            // TODO: This line of code loads data into the 'smartGardenDataSet.Suministro' table. You can move, or remove it, as needed.
            this.suministroTableAdapter.Fill(this.smartGardenDataSet.Suministro);
            listar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Suministro objeregistrado = new Suministro();

            objeregistrado.SumID = key;

            objeregistrado.TipoID = Convert.ToInt32(cbx_TipoID.Text.ToString());
            objeregistrado.EmpID = Convert.ToInt32(cbxSuminEmpID.Text.ToString());

            objeregistrado.Fecha_de_Salida = Convert.ToDateTime(text_FechaSalida.Text);
            objeregistrado.Presupuesto = Convert.ToDecimal(text_Presupuesto.Text);
            objeregistrado.Cantidad = Convert.ToInt32(text_Cantidad.Text);

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

        private void text_FechaSalida_Enter(object sender, EventArgs e)
        {
            if (text_FechaSalida.Text == "FECHA DE SALIDA")
            {
                text_FechaSalida.Text = "";
                text_FechaSalida.ForeColor = Color.LightGray;
            }
        }

        private void text_FechaSalida_Leave(object sender, EventArgs e)
        {
            if (text_FechaSalida.Text == "")
            {
                text_FechaSalida.Text = "FECHA DE SALIDA";
                text_FechaSalida.ForeColor = Color.LightGray;
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
