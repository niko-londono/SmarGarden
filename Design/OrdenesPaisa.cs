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
    public partial class OrdenesPaisa : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_OrdenesPaisa CD_Client = new SmartGardenP.CRUD.CD_OrdenesPaisa();

        public OrdenesPaisa()
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
            text_Localizacion.Text = String.Empty;
            cbxPaisaEmpID.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Paisajismo_Empleado objeto = CD_Client.obtener(key);
            text_Localizacion.Text = objeto.Localizacion;
            cbxPaisaEmpID.Text = objeto.EmpID.ToString();

        }

        private void OrdenesPaisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paisajismo_EmpID.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.paisajismo_EmpID.Empleado);
            listar();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Paisajismo_Empleado objeregistrado = new Paisajismo_Empleado();

            objeregistrado.Localizacion = text_Localizacion.Text;
            objeregistrado.EmpID= Convert.ToInt32(cbxPaisaEmpID.Text);

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
            Paisajismo_Empleado objeregistrado = new Paisajismo_Empleado();

            objeregistrado.EmpID = Convert.ToInt32(cbxPaisaEmpID.Text.ToString());
            objeregistrado.PaisaID = key;
            objeregistrado.Localizacion = text_Localizacion.Text;

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

        private void text_Localizacion_Enter(object sender, EventArgs e)
        {
            if (text_Localizacion.Text == "LOCALIZACION")
            {
                text_Localizacion.Text = "";
                text_Localizacion.ForeColor = Color.LightGray;
            }
        }

        private void text_Localizacion_Leave(object sender, EventArgs e)
        {
            if (text_Localizacion.Text == "")
            {
                text_Localizacion.Text = "LOCALIZACION";
                text_Localizacion.ForeColor = Color.LightGray;
            }
        }
    }
}
