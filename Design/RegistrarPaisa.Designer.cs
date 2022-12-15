namespace SmartGardenP
{
    partial class RegistrarPaisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.text_PrecioCliente = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.text_TiempoLim = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_DescripcionP = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaisaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Presupuesto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.text_FechaPaisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbx_ClienteID = new System.Windows.Forms.ComboBox();
            this.paisajismo_Cliente = new SmartGardenP.Paisajismo_Cliente();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SmartGardenP.Paisajismo_ClienteTableAdapters.ClienteTableAdapter();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisajismo_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.cbx_ClienteID);
            this.panel1.Controls.Add(this.btn_Mostrar);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 882);
            this.panel1.TabIndex = 1;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mostrar.Location = new System.Drawing.Point(500, 786);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(156, 57);
            this.btn_Mostrar.TabIndex = 54;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.text_PrecioCliente);
            this.panel8.Location = new System.Drawing.Point(1140, 115);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 45);
            this.panel8.TabIndex = 53;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel11.Location = new System.Drawing.Point(15, 40);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 2);
            this.panel11.TabIndex = 45;
            // 
            // text_PrecioCliente
            // 
            this.text_PrecioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_PrecioCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_PrecioCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_PrecioCliente.Location = new System.Drawing.Point(15, 12);
            this.text_PrecioCliente.Name = "text_PrecioCliente";
            this.text_PrecioCliente.Size = new System.Drawing.Size(314, 19);
            this.text_PrecioCliente.TabIndex = 3;
            this.text_PrecioCliente.Text = "PRECIO CLIENTE";
            this.text_PrecioCliente.Enter += new System.EventHandler(this.text_PrecioCliente_Enter);
            this.text_PrecioCliente.Leave += new System.EventHandler(this.text_PrecioCliente_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.text_TiempoLim);
            this.panel9.Location = new System.Drawing.Point(762, 115);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(342, 45);
            this.panel9.TabIndex = 52;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel10.Location = new System.Drawing.Point(15, 40);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 2);
            this.panel10.TabIndex = 45;
            // 
            // text_TiempoLim
            // 
            this.text_TiempoLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_TiempoLim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_TiempoLim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_TiempoLim.Location = new System.Drawing.Point(15, 12);
            this.text_TiempoLim.Name = "text_TiempoLim";
            this.text_TiempoLim.Size = new System.Drawing.Size(314, 19);
            this.text_TiempoLim.TabIndex = 3;
            this.text_TiempoLim.Text = "TIEMPOMLIMITE";
            this.text_TiempoLim.Enter += new System.EventHandler(this.text_TiempoLim_Enter);
            this.text_TiempoLim.Leave += new System.EventHandler(this.text_TiempoLim_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel2.Location = new System.Drawing.Point(22, 232);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 2);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_DescripcionP);
            this.panel3.Location = new System.Drawing.Point(18, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 45);
            this.panel3.TabIndex = 50;
            // 
            // text_DescripcionP
            // 
            this.text_DescripcionP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_DescripcionP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_DescripcionP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_DescripcionP.Location = new System.Drawing.Point(15, 12);
            this.text_DescripcionP.Name = "text_DescripcionP";
            this.text_DescripcionP.Size = new System.Drawing.Size(314, 19);
            this.text_DescripcionP.TabIndex = 3;
            this.text_DescripcionP.Text = "DESCRIPCION";
            this.text_DescripcionP.Enter += new System.EventHandler(this.text_DescripcionP_Enter);
            this.text_DescripcionP.Leave += new System.EventHandler(this.text_DescripcionP_Leave);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(334, 786);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(156, 57);
            this.btn_Eliminar.TabIndex = 49;
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
            this.btn_Actualizar.Location = new System.Drawing.Point(170, 786);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(156, 57);
            this.btn_Actualizar.TabIndex = 48;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(6, 786);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(156, 57);
            this.btn_Limpiar.TabIndex = 47;
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
            this.btn_Registrar.Location = new System.Drawing.Point(687, 278);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 57);
            this.btn_Registrar.TabIndex = 46;
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
            this.PaisaID,
            this.ClienteID,
            this.Descripcion,
            this.Precio_Cliente,
            this.Presupuesto,
            this.DeadLine});
            this.dataGridView1.Location = new System.Drawing.Point(6, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1584, 372);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PaisaID
            // 
            this.PaisaID.DataPropertyName = "PaisaID";
            this.PaisaID.HeaderText = "PaisaID";
            this.PaisaID.MinimumWidth = 8;
            this.PaisaID.Name = "PaisaID";
            this.PaisaID.ReadOnly = true;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "ClienteID";
            this.ClienteID.MinimumWidth = 8;
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio_Cliente
            // 
            this.Precio_Cliente.DataPropertyName = "Precio_Cliente";
            this.Precio_Cliente.HeaderText = "Precio_Cliente";
            this.Precio_Cliente.MinimumWidth = 8;
            this.Precio_Cliente.Name = "Precio_Cliente";
            this.Precio_Cliente.ReadOnly = true;
            // 
            // Presupuesto
            // 
            this.Presupuesto.DataPropertyName = "Presupuesto";
            this.Presupuesto.HeaderText = "Presupuesto";
            this.Presupuesto.MinimumWidth = 8;
            this.Presupuesto.Name = "Presupuesto";
            this.Presupuesto.ReadOnly = true;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.MinimumWidth = 8;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(400, 158);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 2);
            this.panel5.TabIndex = 44;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Presupuesto);
            this.panel6.Location = new System.Drawing.Point(396, 115);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 45);
            this.panel6.TabIndex = 43;
            // 
            // text_Presupuesto
            // 
            this.text_Presupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Presupuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Presupuesto.Location = new System.Drawing.Point(15, 12);
            this.text_Presupuesto.Name = "text_Presupuesto";
            this.text_Presupuesto.Size = new System.Drawing.Size(314, 19);
            this.text_Presupuesto.TabIndex = 3;
            this.text_Presupuesto.Text = "PRESUPUESTO";
            this.text_Presupuesto.Enter += new System.EventHandler(this.text_Presupuesto_Enter);
            this.text_Presupuesto.Leave += new System.EventHandler(this.text_Presupuesto_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(14, 158);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel7.Controls.Add(this.text_FechaPaisa);
            this.panel7.Location = new System.Drawing.Point(18, 115);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 45);
            this.panel7.TabIndex = 41;
            // 
            // text_FechaPaisa
            // 
            this.text_FechaPaisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_FechaPaisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_FechaPaisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_FechaPaisa.Location = new System.Drawing.Point(15, 12);
            this.text_FechaPaisa.Name = "text_FechaPaisa";
            this.text_FechaPaisa.Size = new System.Drawing.Size(314, 19);
            this.text_FechaPaisa.TabIndex = 3;
            this.text_FechaPaisa.Text = "FECHA INICIAL";
            this.text_FechaPaisa.Enter += new System.EventHandler(this.text_FechaPaisa_Enter);
            this.text_FechaPaisa.Leave += new System.EventHandler(this.text_FechaPaisa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(548, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 54);
            this.label1.TabIndex = 40;
            this.label1.Text = "REGISTRAR PAISAJISMO";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(765, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 23);
            this.textBox3.TabIndex = 71;
            this.textBox3.Text = "Cliente";
            // 
            // cbx_ClienteID
            // 
            this.cbx_ClienteID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "ClienteID", true));
            this.cbx_ClienteID.DataSource = this.clienteBindingSource;
            this.cbx_ClienteID.DisplayMember = "ClienteID";
            this.cbx_ClienteID.FormattingEnabled = true;
            this.cbx_ClienteID.Location = new System.Drawing.Point(765, 209);
            this.cbx_ClienteID.Name = "cbx_ClienteID";
            this.cbx_ClienteID.Size = new System.Drawing.Size(717, 28);
            this.cbx_ClienteID.TabIndex = 70;
            this.cbx_ClienteID.ValueMember = "ClienteID";
            // 
            // paisajismo_Cliente
            // 
            this.paisajismo_Cliente.DataSetName = "Paisajismo_Cliente";
            this.paisajismo_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.paisajismo_Cliente;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // RegistrarPaisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 882);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarPaisa";
            this.Text = "RegistrarPaisa";
            this.Load += new System.EventHandler(this.RegistrarPaisa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisajismo_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_DescripcionP;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_Presupuesto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox text_FechaPaisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox text_PrecioCliente;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox text_TiempoLim;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbx_ClienteID;
        private Paisajismo_Cliente paisajismo_Cliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Paisajismo_ClienteTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}