
namespace SmartGardenP
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbx_EmpCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.text_Cargo = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.text_Apellido = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Salario = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.text_Correo = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.text_Cedula = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.text_Telefono = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.text_FechaNac = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.text_Genero = new System.Windows.Forms.TextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDeEmpleado = new SmartGardenP.CargoDeEmpleado();
            this.cargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cargoTableAdapter = new SmartGardenP.CargoDeEmpleadoTableAdapters.CargoTableAdapter();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDeEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(567, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRAR EMPLEADO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_Nombre);
            this.panel3.Location = new System.Drawing.Point(270, 186);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 45);
            this.panel3.TabIndex = 4;
            // 
            // text_Nombre
            // 
            this.text_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Nombre.Location = new System.Drawing.Point(15, 12);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(314, 19);
            this.text_Nombre.TabIndex = 3;
            this.text_Nombre.Text = "NOMBRE";
            this.text_Nombre.Enter += new System.EventHandler(this.text_Nombre_Enter);
            this.text_Nombre.Leave += new System.EventHandler(this.text_Nombre_Leave);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registrar.Location = new System.Drawing.Point(678, 423);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 57);
            this.btn_Registrar.TabIndex = 5;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(274, 229);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel8.Controls.Add(this.cbx_EmpCargo);
            this.panel8.Controls.Add(this.text_Cargo);
            this.panel8.Location = new System.Drawing.Point(270, 352);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 78);
            this.panel8.TabIndex = 7;
            // 
            // cbx_EmpCargo
            // 
            this.cbx_EmpCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cargoBindingSource1, "Cargo", true));
            this.cbx_EmpCargo.DataSource = this.cargoBindingSource1;
            this.cbx_EmpCargo.DisplayMember = "Cargo";
            this.cbx_EmpCargo.FormattingEnabled = true;
            this.cbx_EmpCargo.Location = new System.Drawing.Point(15, 43);
            this.cbx_EmpCargo.Name = "cbx_EmpCargo";
            this.cbx_EmpCargo.Size = new System.Drawing.Size(314, 28);
            this.cbx_EmpCargo.TabIndex = 28;
            this.cbx_EmpCargo.ValueMember = "Cargo";
            // 
            // text_Cargo
            // 
            this.text_Cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Cargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Cargo.Location = new System.Drawing.Point(15, 12);
            this.text_Cargo.Name = "text_Cargo";
            this.text_Cargo.ReadOnly = true;
            this.text_Cargo.Size = new System.Drawing.Size(314, 19);
            this.text_Cargo.TabIndex = 3;
            this.text_Cargo.Text = "CARGO";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel10.Controls.Add(this.text_Apellido);
            this.panel10.Location = new System.Drawing.Point(270, 242);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(342, 45);
            this.panel10.TabIndex = 9;
            // 
            // text_Apellido
            // 
            this.text_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Apellido.Location = new System.Drawing.Point(15, 12);
            this.text_Apellido.Name = "text_Apellido";
            this.text_Apellido.Size = new System.Drawing.Size(314, 19);
            this.text_Apellido.TabIndex = 3;
            this.text_Apellido.Text = "APELLIDO";
            this.text_Apellido.Enter += new System.EventHandler(this.text_Apellido_Enter);
            this.text_Apellido.Leave += new System.EventHandler(this.text_Apellido_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel9.Location = new System.Drawing.Point(274, 285);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(330, 2);
            this.panel9.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Salario);
            this.panel6.Location = new System.Drawing.Point(657, 186);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 45);
            this.panel6.TabIndex = 11;
            // 
            // text_Salario
            // 
            this.text_Salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Salario.Location = new System.Drawing.Point(15, 12);
            this.text_Salario.Name = "text_Salario";
            this.text_Salario.Size = new System.Drawing.Size(314, 19);
            this.text_Salario.TabIndex = 3;
            this.text_Salario.Text = "SALARIO";
            this.text_Salario.Enter += new System.EventHandler(this.text_Salario_Enter);
            this.text_Salario.Leave += new System.EventHandler(this.text_Salario_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(662, 229);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 2);
            this.panel5.TabIndex = 12;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel12.Controls.Add(this.text_Correo);
            this.panel12.Location = new System.Drawing.Point(657, 240);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(342, 45);
            this.panel12.TabIndex = 13;
            // 
            // text_Correo
            // 
            this.text_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Correo.Location = new System.Drawing.Point(15, 12);
            this.text_Correo.Name = "text_Correo";
            this.text_Correo.Size = new System.Drawing.Size(314, 19);
            this.text_Correo.TabIndex = 3;
            this.text_Correo.Text = "CORREO";
            this.text_Correo.Enter += new System.EventHandler(this.text_Correo_Enter);
            this.text_Correo.Leave += new System.EventHandler(this.text_Correo_Leave);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel11.Location = new System.Drawing.Point(662, 285);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 2);
            this.panel11.TabIndex = 14;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel14.Controls.Add(this.text_Cedula);
            this.panel14.Location = new System.Drawing.Point(270, 297);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(342, 45);
            this.panel14.TabIndex = 15;
            // 
            // text_Cedula
            // 
            this.text_Cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Cedula.Location = new System.Drawing.Point(15, 12);
            this.text_Cedula.Name = "text_Cedula";
            this.text_Cedula.Size = new System.Drawing.Size(314, 19);
            this.text_Cedula.TabIndex = 3;
            this.text_Cedula.Text = "CEDULA";
            this.text_Cedula.Enter += new System.EventHandler(this.text_Cedula_Enter);
            this.text_Cedula.Leave += new System.EventHandler(this.text_Cedula_Leave);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel13.Location = new System.Drawing.Point(274, 340);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(330, 2);
            this.panel13.TabIndex = 16;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel16.Controls.Add(this.text_Telefono);
            this.panel16.Location = new System.Drawing.Point(657, 295);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(342, 45);
            this.panel16.TabIndex = 17;
            // 
            // text_Telefono
            // 
            this.text_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Telefono.Location = new System.Drawing.Point(15, 12);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.Size = new System.Drawing.Size(314, 19);
            this.text_Telefono.TabIndex = 3;
            this.text_Telefono.Text = "TELEFONO";
            this.text_Telefono.Enter += new System.EventHandler(this.text_Telefono_Enter);
            this.text_Telefono.Leave += new System.EventHandler(this.text_Telefono_Leave);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel15.Location = new System.Drawing.Point(662, 338);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(330, 2);
            this.panel15.TabIndex = 18;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel18.Controls.Add(this.text_FechaNac);
            this.panel18.Location = new System.Drawing.Point(657, 352);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(342, 45);
            this.panel18.TabIndex = 19;
            // 
            // text_FechaNac
            // 
            this.text_FechaNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_FechaNac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_FechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_FechaNac.Location = new System.Drawing.Point(15, 12);
            this.text_FechaNac.Name = "text_FechaNac";
            this.text_FechaNac.Size = new System.Drawing.Size(314, 19);
            this.text_FechaNac.TabIndex = 3;
            this.text_FechaNac.Text = "FECHA DE NACIMIENTO";
            this.text_FechaNac.Enter += new System.EventHandler(this.text_FechaNac_Enter);
            this.text_FechaNac.Leave += new System.EventHandler(this.text_FechaNac_Leave);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel17.Location = new System.Drawing.Point(662, 395);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(330, 2);
            this.panel17.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel19);
            this.panel2.Controls.Add(this.btn_Mostrar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btn_Actualizar);
            this.panel2.Controls.Add(this.btn_Limpiar);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.panel18);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_Registrar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1620, 942);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Location = new System.Drawing.Point(1012, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 2);
            this.panel1.TabIndex = 27;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel19.Controls.Add(this.text_Genero);
            this.panel19.Location = new System.Drawing.Point(1008, 186);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(342, 45);
            this.panel19.TabIndex = 26;
            // 
            // text_Genero
            // 
            this.text_Genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Genero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Genero.Location = new System.Drawing.Point(15, 12);
            this.text_Genero.Name = "text_Genero";
            this.text_Genero.Size = new System.Drawing.Size(314, 19);
            this.text_Genero.TabIndex = 3;
            this.text_Genero.Text = "GENERO";
            this.text_Genero.Enter += new System.EventHandler(this.text_Genero_Enter);
            this.text_Genero.Leave += new System.EventHandler(this.text_Genero_Leave);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mostrar.Location = new System.Drawing.Point(516, 868);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(156, 57);
            this.btn_Mostrar.TabIndex = 25;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(351, 868);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(156, 57);
            this.btn_Eliminar.TabIndex = 24;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Actualizar.Location = new System.Drawing.Point(186, 868);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(156, 57);
            this.btn_Actualizar.TabIndex = 23;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpiar.Location = new System.Drawing.Point(22, 868);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(156, 57);
            this.btn_Limpiar.TabIndex = 22;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.FechaNac,
            this.Cedula,
            this.Correo,
            this.Telefono,
            this.Genero,
            this.Salario,
            this.Cargo});
            this.dataGridView1.Location = new System.Drawing.Point(22, 512);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1582, 337);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "EmpID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "FechaNac";
            this.FechaNac.HeaderText = "FechaNac";
            this.FechaNac.MinimumWidth = 8;
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 8;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 8;
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 8;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // cargoDeEmpleado
            // 
            this.cargoDeEmpleado.DataSetName = "CargoDeEmpleado";
            this.cargoDeEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoBindingSource1
            // 
            this.cargoBindingSource1.DataMember = "Cargo";
            this.cargoBindingSource1.DataSource = this.cargoDeEmpleado;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1620, 942);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.productos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDeEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox text_Cargo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox text_Apellido;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_Salario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox text_Correo;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox text_Cedula;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox text_Telefono;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox text_FechaNac;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox text_Genero;
        private System.Windows.Forms.ComboBox cbx_EmpCargo;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private CargoDeEmpleado cargoDeEmpleado;
        private System.Windows.Forms.BindingSource cargoBindingSource1;
        private CargoDeEmpleadoTableAdapters.CargoTableAdapter cargoTableAdapter;
    }
}