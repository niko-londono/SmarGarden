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
    public partial class AsignacionT : Form
    {
        private static int key = 0;
        private SmartGardenP.CRUD.CD_AsignacionT CD_Client = new SmartGardenP.CRUD.CD_AsignacionT();

        public AsignacionT()
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
            cbx_TareaEmpID.Text = String.Empty;
            cbx_TareaID.Text = String.Empty;
            text_Horario.Text = String.Empty;
            text_Localizacion.Text = String.Empty;
            key = 0;
        }

        private void obtener(int key)
        {
            Tarea_Empleado objeto = CD_Client.obtener(key);
            string Horario1 = objeto.Horario.ToString();
            cbx_TareaID.Text = Convert.ToInt32(objeto.TareaID).ToString();
            cbx_TareaEmpID.Text = Convert.ToInt32(objeto.EmpID).ToString();

            text_Horario.Text = Horario1;
            text_Localizacion.Text = objeto.Localizacion;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Tarea_Empleado objeregistrado = new Tarea_Empleado();

            objeregistrado.Horario = TimeSpan.Parse(text_Horario.Text.ToString());
            objeregistrado.Localizacion = text_Localizacion.Text;

            objeregistrado.TareaID = Convert.ToInt32(cbx_TareaID.Text);
            objeregistrado.EmpID = Convert.ToInt32(cbx_TareaEmpID.Text);

            CD_Client.registrar(objeregistrado);
            limpiar();
            MessageBox.Show("Registro realizado");
            listar();
        }

        private void AsignacionT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asignacionTareas_EmpID.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.asignacionTareas_EmpID.Empleado);
            // TODO: This line of code loads data into the 'asignarTarea_IDTarea.Tarea' table. You can move, or remove it, as needed.
            this.tareaTableAdapter.Fill(this.asignarTarea_IDTarea.Tarea);
            listar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Tarea_Empleado objeregistrado = new Tarea_Empleado();

            objeregistrado.Tarea_empID = key;
            objeregistrado.Horario = TimeSpan.Parse(text_Horario.Text);
            objeregistrado.Localizacion = text_Localizacion.Text;

            objeregistrado.TareaID = Convert.ToInt32(cbx_TareaID.Text.ToString());
            objeregistrado.EmpID = Convert.ToInt32(cbx_TareaEmpID.Text.ToString());

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

        private void text_Horario_Enter(object sender, EventArgs e)
        {
            if (text_Horario.Text == "HORARIO")
            {
                text_Horario.Text = "";
                text_Horario.ForeColor = Color.LightGray;
            }
        }

        private void text_Horario_Leave(object sender, EventArgs e)
        {
            if (text_Horario.Text == "")
            {
                text_Horario.Text = "HORARIO";
                text_Horario.ForeColor = Color.LightGray;
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
