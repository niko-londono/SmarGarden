namespace SmartGardenP
{
    partial class Suministros
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxSuminEmpID = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbx_TipoID = new System.Windows.Forms.ComboBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.text_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Presupuesto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.text_FechaSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smartGardenDataSet = new SmartGardenP.SmartGardenDataSet();
            this.suministroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suministroTableAdapter = new SmartGardenP.SmartGardenDataSetTableAdapters.SuministroTableAdapter();
            this.suministro_Empleado = new SmartGardenP.Suministro_Empleado();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new SmartGardenP.Suministro_EmpleadoTableAdapters.EmpleadoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartGardenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministro_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbxSuminEmpID);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.cbx_TipoID);
            this.panel1.Controls.Add(this.btn_Mostrar);
            this.panel1.Controls.Add(this.panel9);
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
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(862, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 23);
            this.textBox1.TabIndex = 70;
            this.textBox1.Text = "Empleado Asignado";
            // 
            // cbxSuminEmpID
            // 
            this.cbxSuminEmpID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "EmpID", true));
            this.cbxSuminEmpID.DataSource = this.empleadoBindingSource;
            this.cbxSuminEmpID.DisplayMember = "EmpID";
            this.cbxSuminEmpID.FormattingEnabled = true;
            this.cbxSuminEmpID.Location = new System.Drawing.Point(862, 237);
            this.cbxSuminEmpID.Name = "cbxSuminEmpID";
            this.cbxSuminEmpID.Size = new System.Drawing.Size(342, 28);
            this.cbxSuminEmpID.TabIndex = 71;
            this.cbxSuminEmpID.ValueMember = "EmpID";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(317, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 23);
            this.textBox3.TabIndex = 69;
            this.textBox3.Text = "Tipo de Suministro";
            // 
            // cbx_TipoID
            // 
            this.cbx_TipoID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suministroBindingSource, "SumID", true));
            this.cbx_TipoID.DataSource = this.suministroBindingSource;
            this.cbx_TipoID.DisplayMember = "SumID";
            this.cbx_TipoID.FormattingEnabled = true;
            this.cbx_TipoID.Location = new System.Drawing.Point(317, 237);
            this.cbx_TipoID.Name = "cbx_TipoID";
            this.cbx_TipoID.Size = new System.Drawing.Size(342, 28);
            this.cbx_TipoID.TabIndex = 68;
            this.cbx_TipoID.ValueMember = "SumID";
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
            this.btn_Mostrar.TabIndex = 67;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.text_Cantidad);
            this.panel9.Location = new System.Drawing.Point(1085, 121);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(342, 45);
            this.panel9.TabIndex = 66;
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
            this.btn_Eliminar.TabIndex = 63;
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
            this.btn_Actualizar.TabIndex = 62;
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
            this.btn_Limpiar.TabIndex = 61;
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
            this.btn_Registrar.Location = new System.Drawing.Point(646, 306);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 57);
            this.btn_Registrar.TabIndex = 60;
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
            this.SumID,
            this.TipoID,
            this.EmpID,
            this.Presupuesto,
            this.Fecha_de_Salida,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(6, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1584, 372);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SumID
            // 
            this.SumID.DataPropertyName = "SumID";
            this.SumID.HeaderText = "SumID";
            this.SumID.MinimumWidth = 8;
            this.SumID.Name = "SumID";
            this.SumID.ReadOnly = true;
            // 
            // TipoID
            // 
            this.TipoID.DataPropertyName = "TipoID";
            this.TipoID.HeaderText = "TipoID";
            this.TipoID.MinimumWidth = 8;
            this.TipoID.Name = "TipoID";
            this.TipoID.ReadOnly = true;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 8;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // Presupuesto
            // 
            this.Presupuesto.DataPropertyName = "Presupuesto";
            this.Presupuesto.HeaderText = "Presupuesto";
            this.Presupuesto.MinimumWidth = 8;
            this.Presupuesto.Name = "Presupuesto";
            this.Presupuesto.ReadOnly = true;
            // 
            // Fecha_de_Salida
            // 
            this.Fecha_de_Salida.DataPropertyName = "Fecha_de_Salida";
            this.Fecha_de_Salida.HeaderText = "Fecha_de_Salida";
            this.Fecha_de_Salida.MinimumWidth = 8;
            this.Fecha_de_Salida.Name = "Fecha_de_Salida";
            this.Fecha_de_Salida.ReadOnly = true;
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
            this.panel5.Location = new System.Drawing.Point(651, 172);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 2);
            this.panel5.TabIndex = 58;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Presupuesto);
            this.panel6.Location = new System.Drawing.Point(646, 121);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 45);
            this.panel6.TabIndex = 57;
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
            this.panel4.Location = new System.Drawing.Point(188, 172);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 56;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel7.Controls.Add(this.text_FechaSalida);
            this.panel7.Location = new System.Drawing.Point(192, 121);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 45);
            this.panel7.TabIndex = 55;
            // 
            // text_FechaSalida
            // 
            this.text_FechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_FechaSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_FechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_FechaSalida.Location = new System.Drawing.Point(15, 12);
            this.text_FechaSalida.Name = "text_FechaSalida";
            this.text_FechaSalida.Size = new System.Drawing.Size(314, 19);
            this.text_FechaSalida.TabIndex = 3;
            this.text_FechaSalida.Text = "FECHA DE SALIDA";
            this.text_FechaSalida.Enter += new System.EventHandler(this.text_FechaSalida_Enter);
            this.text_FechaSalida.Leave += new System.EventHandler(this.text_FechaSalida_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(530, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 54);
            this.label1.TabIndex = 54;
            this.label1.Text = "REGISTRAR SUMINISTROS";
            // 
            // smartGardenDataSet
            // 
            this.smartGardenDataSet.DataSetName = "SmartGardenDataSet";
            this.smartGardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suministroBindingSource
            // 
            this.suministroBindingSource.DataMember = "Suministro";
            this.suministroBindingSource.DataSource = this.smartGardenDataSet;
            // 
            // suministroTableAdapter
            // 
            this.suministroTableAdapter.ClearBeforeFill = true;
            // 
            // suministro_Empleado
            // 
            this.suministro_Empleado.DataSetName = "Suministro_Empleado";
            this.suministro_Empleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.suministro_Empleado;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // Suministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 882);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Suministros";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Suministros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartGardenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministro_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox text_Cantidad;
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
        private System.Windows.Forms.TextBox text_FechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbx_TipoID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxSuminEmpID;
        private SmartGardenDataSet smartGardenDataSet;
        private System.Windows.Forms.BindingSource suministroBindingSource;
        private SmartGardenDataSetTableAdapters.SuministroTableAdapter suministroTableAdapter;
        private Suministro_Empleado suministro_Empleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private Suministro_EmpleadoTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}