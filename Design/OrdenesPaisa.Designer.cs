namespace SmartGardenP
{
    partial class OrdenesPaisa
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_Localizacion = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaisaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxPaisaEmpID = new System.Windows.Forms.ComboBox();
            this.paisajismo_EmpID = new SmartGardenP.Paisajismo_EmpID();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new SmartGardenP.Paisajismo_EmpIDTableAdapters.EmpleadoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisajismo_EmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbxPaisaEmpID);
            this.panel1.Controls.Add(this.btn_Mostrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 882);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel2.Location = new System.Drawing.Point(81, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 2);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_Localizacion);
            this.panel3.Location = new System.Drawing.Point(76, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 45);
            this.panel3.TabIndex = 52;
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
            this.EmpID,
            this.Localizacion});
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
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 8;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // Localizacion
            // 
            this.Localizacion.DataPropertyName = "Localizacion";
            this.Localizacion.HeaderText = "Localizacion";
            this.Localizacion.MinimumWidth = 8;
            this.Localizacion.Name = "Localizacion";
            this.Localizacion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(424, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 54);
            this.label1.TabIndex = 40;
            this.label1.Text = "REGISTRAR ORDEN DEL PAISAJISMO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(828, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 23);
            this.textBox1.TabIndex = 72;
            this.textBox1.Text = "Empleado Asignado";
            // 
            // cbxPaisaEmpID
            // 
            this.cbxPaisaEmpID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "EmpID", true));
            this.cbxPaisaEmpID.DataSource = this.empleadoBindingSource;
            this.cbxPaisaEmpID.DisplayMember = "EmpID";
            this.cbxPaisaEmpID.FormattingEnabled = true;
            this.cbxPaisaEmpID.Location = new System.Drawing.Point(828, 171);
            this.cbxPaisaEmpID.Name = "cbxPaisaEmpID";
            this.cbxPaisaEmpID.Size = new System.Drawing.Size(713, 28);
            this.cbxPaisaEmpID.TabIndex = 73;
            this.cbxPaisaEmpID.ValueMember = "EmpID";
            // 
            // paisajismo_EmpID
            // 
            this.paisajismo_EmpID.DataSetName = "Paisajismo_EmpID";
            this.paisajismo_EmpID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.paisajismo_EmpID;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // OrdenesPaisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 882);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenesPaisa";
            this.Text = "OrdenesPaisa";
            this.Load += new System.EventHandler(this.OrdenesPaisa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisajismo_EmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Localizacion;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxPaisaEmpID;
        private Paisajismo_EmpID paisajismo_EmpID;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private Paisajismo_EmpIDTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}