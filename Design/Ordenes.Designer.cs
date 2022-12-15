namespace SmartGardenP
{
    partial class Ordenes
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Arreglo_clienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArregloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_DeadLine = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_Fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.cbx_EmpID = new System.Windows.Forms.ComboBox();
            this.cbx_Cliente = new System.Windows.Forms.ComboBox();
            this.cbx_Arreglo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.smartGardenDataSet1 = new SmartGardenP.SmartGardenDataSet1();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new SmartGardenP.SmartGardenDataSet1TableAdapters.EmpleadoTableAdapter();
            this.ordenesFlorales_ClienteID = new SmartGardenP.OrdenesFlorales_ClienteID();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SmartGardenP.OrdenesFlorales_ClienteIDTableAdapters.ClienteTableAdapter();
            this.ordenesFlorales_ArregloFloral = new SmartGardenP.OrdenesFlorales_ArregloFloral();
            this.arregloFloralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arregloFloralTableAdapter = new SmartGardenP.OrdenesFlorales_ArregloFloralTableAdapters.ArregloFloralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartGardenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesFlorales_ClienteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesFlorales_ArregloFloral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arregloFloralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(346, 817);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(156, 57);
            this.btn_Eliminar.TabIndex = 37;
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
            this.btn_Actualizar.Location = new System.Drawing.Point(182, 817);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(156, 57);
            this.btn_Actualizar.TabIndex = 36;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(18, 817);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(156, 57);
            this.btn_Limpiar.TabIndex = 35;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registrar.Location = new System.Drawing.Point(699, 334);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 57);
            this.btn_Registrar.TabIndex = 34;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arreglo_clienteID,
            this.EmpID,
            this.ClienteID,
            this.ArregloID,
            this.Fecha_Inicial,
            this.DeadLine,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(18, 414);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1584, 372);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Arreglo_clienteID
            // 
            this.Arreglo_clienteID.DataPropertyName = "Arreglo_clienteID";
            this.Arreglo_clienteID.HeaderText = "Arreglo_clienteID";
            this.Arreglo_clienteID.MinimumWidth = 8;
            this.Arreglo_clienteID.Name = "Arreglo_clienteID";
            this.Arreglo_clienteID.ReadOnly = true;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 8;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "ClienteID";
            this.ClienteID.MinimumWidth = 8;
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            // 
            // ArregloID
            // 
            this.ArregloID.DataPropertyName = "ArregloID";
            this.ArregloID.HeaderText = "ArregloID";
            this.ArregloID.MinimumWidth = 8;
            this.ArregloID.Name = "ArregloID";
            this.ArregloID.ReadOnly = true;
            // 
            // Fecha_Inicial
            // 
            this.Fecha_Inicial.DataPropertyName = "Fecha_Inicial";
            this.Fecha_Inicial.HeaderText = "Fecha_Inicial";
            this.Fecha_Inicial.MinimumWidth = 8;
            this.Fecha_Inicial.Name = "Fecha_Inicial";
            this.Fecha_Inicial.ReadOnly = true;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.MinimumWidth = 8;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(648, 312);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 2);
            this.panel5.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_DeadLine);
            this.panel6.Location = new System.Drawing.Point(644, 269);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 45);
            this.panel6.TabIndex = 31;
            // 
            // text_DeadLine
            // 
            this.text_DeadLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_DeadLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_DeadLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_DeadLine.Location = new System.Drawing.Point(15, 12);
            this.text_DeadLine.Name = "text_DeadLine";
            this.text_DeadLine.Size = new System.Drawing.Size(314, 19);
            this.text_DeadLine.TabIndex = 3;
            this.text_DeadLine.Text = "TIEMPO LIMITE";
            this.text_DeadLine.Enter += new System.EventHandler(this.text_DeadLine_Enter);
            this.text_DeadLine.Leave += new System.EventHandler(this.text_DeadLine_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(261, 312);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_Fecha);
            this.panel3.Location = new System.Drawing.Point(266, 269);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 45);
            this.panel3.TabIndex = 29;
            // 
            // text_Fecha
            // 
            this.text_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Fecha.Location = new System.Drawing.Point(15, 12);
            this.text_Fecha.Name = "text_Fecha";
            this.text_Fecha.Size = new System.Drawing.Size(314, 19);
            this.text_Fecha.TabIndex = 3;
            this.text_Fecha.Text = "FECHA";
            this.text_Fecha.Enter += new System.EventHandler(this.text_Fecha_Enter);
            this.text_Fecha.Leave += new System.EventHandler(this.text_Fecha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(477, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "REGISTRAR ORDENES FLORALES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Location = new System.Drawing.Point(1022, 312);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 2);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.text_Cantidad);
            this.panel2.Location = new System.Drawing.Point(1017, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 45);
            this.panel2.TabIndex = 38;
            // 
            // text_Cantidad
            // 
            this.text_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Cantidad.Location = new System.Drawing.Point(15, 12);
            this.text_Cantidad.Name = "text_Cantidad";
            this.text_Cantidad.Size = new System.Drawing.Size(314, 19);
            this.text_Cantidad.TabIndex = 3;
            this.text_Cantidad.Text = "CANTIDAD";
            this.text_Cantidad.Enter += new System.EventHandler(this.text_Cantidad_Enter);
            this.text_Cantidad.Leave += new System.EventHandler(this.text_Cantidad_Leave);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mostrar.Location = new System.Drawing.Point(512, 817);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(156, 57);
            this.btn_Mostrar.TabIndex = 40;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // cbx_EmpID
            // 
            this.cbx_EmpID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "EmpID", true));
            this.cbx_EmpID.DataSource = this.empleadoBindingSource;
            this.cbx_EmpID.DisplayMember = "EmpID";
            this.cbx_EmpID.FormattingEnabled = true;
            this.cbx_EmpID.Location = new System.Drawing.Point(266, 215);
            this.cbx_EmpID.Name = "cbx_EmpID";
            this.cbx_EmpID.Size = new System.Drawing.Size(342, 28);
            this.cbx_EmpID.TabIndex = 41;
            this.cbx_EmpID.ValueMember = "EmpID";
            // 
            // cbx_Cliente
            // 
            this.cbx_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "ClienteID", true));
            this.cbx_Cliente.DataSource = this.clienteBindingSource;
            this.cbx_Cliente.DisplayMember = "ClienteID";
            this.cbx_Cliente.FormattingEnabled = true;
            this.cbx_Cliente.Location = new System.Drawing.Point(644, 215);
            this.cbx_Cliente.Name = "cbx_Cliente";
            this.cbx_Cliente.Size = new System.Drawing.Size(342, 28);
            this.cbx_Cliente.TabIndex = 42;
            this.cbx_Cliente.ValueMember = "ClienteID";
            // 
            // cbx_Arreglo
            // 
            this.cbx_Arreglo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arregloFloralBindingSource, "ArregloID", true));
            this.cbx_Arreglo.DataSource = this.arregloFloralBindingSource;
            this.cbx_Arreglo.DisplayMember = "ArregloID";
            this.cbx_Arreglo.FormattingEnabled = true;
            this.cbx_Arreglo.Location = new System.Drawing.Point(1017, 215);
            this.cbx_Arreglo.Name = "cbx_Arreglo";
            this.cbx_Arreglo.Size = new System.Drawing.Size(342, 28);
            this.cbx_Arreglo.TabIndex = 43;
            this.cbx_Arreglo.ValueMember = "ArregloID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(266, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Empleado Asignado";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(648, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 23);
            this.textBox2.TabIndex = 44;
            this.textBox2.Text = "Cliente";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(1017, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 23);
            this.textBox3.TabIndex = 45;
            this.textBox3.Text = "Arreglo Seleccionado";
            // 
            // smartGardenDataSet1
            // 
            this.smartGardenDataSet1.DataSetName = "SmartGardenDataSet1";
            this.smartGardenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.smartGardenDataSet1;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ordenesFlorales_ClienteID
            // 
            this.ordenesFlorales_ClienteID.DataSetName = "OrdenesFlorales_ClienteID";
            this.ordenesFlorales_ClienteID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.ordenesFlorales_ClienteID;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ordenesFlorales_ArregloFloral
            // 
            this.ordenesFlorales_ArregloFloral.DataSetName = "OrdenesFlorales_ArregloFloral";
            this.ordenesFlorales_ArregloFloral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arregloFloralBindingSource
            // 
            this.arregloFloralBindingSource.DataMember = "ArregloFloral";
            this.arregloFloralBindingSource.DataSource = this.ordenesFlorales_ArregloFloral;
            // 
            // arregloFloralTableAdapter
            // 
            this.arregloFloralTableAdapter.ClearBeforeFill = true;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1620, 942);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbx_Arreglo);
            this.Controls.Add(this.cbx_Cliente);
            this.Controls.Add(this.cbx_EmpID);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartGardenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesFlorales_ClienteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesFlorales_ArregloFloral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arregloFloralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_DeadLine;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_Cantidad;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.ComboBox cbx_EmpID;
        private System.Windows.Forms.ComboBox cbx_Cliente;
        private System.Windows.Forms.ComboBox cbx_Arreglo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arreglo_clienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArregloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private SmartGardenDataSet1 smartGardenDataSet1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private SmartGardenDataSet1TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private OrdenesFlorales_ClienteID ordenesFlorales_ClienteID;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private OrdenesFlorales_ClienteIDTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private OrdenesFlorales_ArregloFloral ordenesFlorales_ArregloFloral;
        private System.Windows.Forms.BindingSource arregloFloralBindingSource;
        private OrdenesFlorales_ArregloFloralTableAdapters.ArregloFloralTableAdapter arregloFloralTableAdapter;
    }
}