namespace SmartGardenP
{
    partial class AsignacionT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarea_empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Horario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_Localizacion = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbx_TareaEmpID = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbx_TareaID = new System.Windows.Forms.ComboBox();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignarTarea_IDTarea = new SmartGardenP.AsignarTarea_IDTarea();
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new SmartGardenP.AsignarTarea_IDTareaTableAdapters.TareaTableAdapter();
            this.asignacionTareas_EmpID = new SmartGardenP.AsignacionTareas_EmpID();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new SmartGardenP.AsignacionTareas_EmpIDTableAdapters.EmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignarTarea_IDTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionTareas_EmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarea_empID,
            this.TareaID,
            this.EmpID,
            this.Horario,
            this.Localizacion});
            this.dataGridView1.Location = new System.Drawing.Point(78, 520);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1449, 282);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Tarea_empID
            // 
            this.Tarea_empID.DataPropertyName = "Tarea_empID";
            this.Tarea_empID.HeaderText = "Tarea_empID";
            this.Tarea_empID.MinimumWidth = 8;
            this.Tarea_empID.Name = "Tarea_empID";
            this.Tarea_empID.ReadOnly = true;
            // 
            // TareaID
            // 
            this.TareaID.DataPropertyName = "TareaID";
            this.TareaID.HeaderText = "TareaID";
            this.TareaID.MinimumWidth = 8;
            this.TareaID.Name = "TareaID";
            this.TareaID.ReadOnly = true;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 8;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.MinimumWidth = 8;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Localizacion
            // 
            this.Localizacion.DataPropertyName = "Localizacion";
            this.Localizacion.HeaderText = "Localizacion";
            this.Localizacion.MinimumWidth = 8;
            this.Localizacion.Name = "Localizacion";
            this.Localizacion.ReadOnly = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registrar.Location = new System.Drawing.Point(736, 395);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 72);
            this.btn_Registrar.TabIndex = 30;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(231, 279);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 2);
            this.panel5.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Horario);
            this.panel6.Location = new System.Drawing.Point(227, 237);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(405, 45);
            this.panel6.TabIndex = 28;
            // 
            // text_Horario
            // 
            this.text_Horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Horario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Horario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Horario.Location = new System.Drawing.Point(15, 12);
            this.text_Horario.Name = "text_Horario";
            this.text_Horario.Size = new System.Drawing.Size(314, 19);
            this.text_Horario.TabIndex = 3;
            this.text_Horario.Text = "HORARIO";
            this.text_Horario.Enter += new System.EventHandler(this.text_Horario_Enter);
            this.text_Horario.Leave += new System.EventHandler(this.text_Horario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(396, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "REGISTRAR ASIGNACION DE LA TAREA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Location = new System.Drawing.Point(231, 378);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 2);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.text_Localizacion);
            this.panel2.Location = new System.Drawing.Point(227, 336);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 45);
            this.panel2.TabIndex = 32;
            // 
            // text_Localizacion
            // 
            this.text_Localizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Localizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Localizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Localizacion.Location = new System.Drawing.Point(15, 12);
            this.text_Localizacion.Name = "text_Localizacion";
            this.text_Localizacion.Size = new System.Drawing.Size(314, 19);
            this.text_Localizacion.TabIndex = 3;
            this.text_Localizacion.Text = "LOCALIZACION";
            this.text_Localizacion.Enter += new System.EventHandler(this.text_Localizacion_Enter);
            this.text_Localizacion.Leave += new System.EventHandler(this.text_Localizacion_Leave);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(405, 840);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(156, 57);
            this.btn_Eliminar.TabIndex = 36;
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
            this.btn_Actualizar.Location = new System.Drawing.Point(242, 840);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(156, 57);
            this.btn_Actualizar.TabIndex = 35;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(78, 840);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(156, 57);
            this.btn_Limpiar.TabIndex = 34;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mostrar.Location = new System.Drawing.Point(585, 840);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(156, 57);
            this.btn_Mostrar.TabIndex = 37;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(1102, 336);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 23);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "EmpleadoID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(1098, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 23);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "TareaID";
            // 
            // cbx_TareaEmpID
            // 
            this.cbx_TareaEmpID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource1, "EmpID", true));
            this.cbx_TareaEmpID.DataSource = this.empleadoBindingSource1;
            this.cbx_TareaEmpID.DisplayMember = "EmpID";
            this.cbx_TareaEmpID.FormattingEnabled = true;
            this.cbx_TareaEmpID.Location = new System.Drawing.Point(1098, 365);
            this.cbx_TareaEmpID.Name = "cbx_TareaEmpID";
            this.cbx_TareaEmpID.Size = new System.Drawing.Size(342, 28);
            this.cbx_TareaEmpID.TabIndex = 47;
            this.cbx_TareaEmpID.ValueMember = "EmpID";
            // 
            // cbx_TareaID
            // 
            this.cbx_TareaID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tareaBindingSource1, "TareaID", true));
            this.cbx_TareaID.DataSource = this.tareaBindingSource1;
            this.cbx_TareaID.DisplayMember = "TareaID";
            this.cbx_TareaID.FormattingEnabled = true;
            this.cbx_TareaID.Location = new System.Drawing.Point(1098, 266);
            this.cbx_TareaID.Name = "cbx_TareaID";
            this.cbx_TareaID.Size = new System.Drawing.Size(342, 28);
            this.cbx_TareaID.TabIndex = 46;
            this.cbx_TareaID.ValueMember = "TareaID";
            // 
            // asignarTarea_IDTarea
            // 
            this.asignarTarea_IDTarea.DataSetName = "AsignarTarea_IDTarea";
            this.asignarTarea_IDTarea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataMember = "Tarea";
            this.tareaBindingSource1.DataSource = this.asignarTarea_IDTarea;
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // asignacionTareas_EmpID
            // 
            this.asignacionTareas_EmpID.DataSetName = "AsignacionTareas_EmpID";
            this.asignacionTareas_EmpID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.asignacionTareas_EmpID;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // AsignacionT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1620, 942);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbx_TareaEmpID);
            this.Controls.Add(this.cbx_TareaID);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AsignacionT";
            this.Text = "AsignacionT";
            this.Load += new System.EventHandler(this.AsignacionT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignarTarea_IDTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionTareas_EmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_Horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_Localizacion;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea_empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbx_TareaEmpID;
        private System.Windows.Forms.ComboBox cbx_TareaID;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private AsignarTarea_IDTarea asignarTarea_IDTarea;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private AsignarTarea_IDTareaTableAdapters.TareaTableAdapter tareaTableAdapter;
        private AsignacionTareas_EmpID asignacionTareas_EmpID;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private AsignacionTareas_EmpIDTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}