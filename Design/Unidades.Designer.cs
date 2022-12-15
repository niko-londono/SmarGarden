namespace SmartGardenP
{
    partial class Unidades
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbx_TipoID = new System.Windows.Forms.ComboBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.text_Condicion = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnidadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeExpirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Presupuesto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.text_FechaExpirado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unidades_TipoID = new SmartGardenP.Unidades_TipoID();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTableAdapter = new SmartGardenP.Unidades_TipoIDTableAdapters.TipoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidades_TipoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(868, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 23);
            this.textBox3.TabIndex = 80;
            this.textBox3.Text = "Tipo de Unidad";
            // 
            // cbx_TipoID
            // 
            this.cbx_TipoID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoBindingSource, "TipoID", true));
            this.cbx_TipoID.DataSource = this.tipoBindingSource;
            this.cbx_TipoID.DisplayMember = "TipoID";
            this.cbx_TipoID.FormattingEnabled = true;
            this.cbx_TipoID.Location = new System.Drawing.Point(868, 213);
            this.cbx_TipoID.Name = "cbx_TipoID";
            this.cbx_TipoID.Size = new System.Drawing.Size(342, 28);
            this.cbx_TipoID.TabIndex = 79;
            this.cbx_TipoID.ValueMember = "TipoID";
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mostrar.Location = new System.Drawing.Point(516, 786);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(156, 57);
            this.btn_Mostrar.TabIndex = 78;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.text_Condicion);
            this.panel9.Location = new System.Drawing.Point(371, 198);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(342, 45);
            this.panel9.TabIndex = 77;
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
            // text_Condicion
            // 
            this.text_Condicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Condicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Condicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Condicion.Location = new System.Drawing.Point(15, 12);
            this.text_Condicion.Name = "text_Condicion";
            this.text_Condicion.Size = new System.Drawing.Size(314, 19);
            this.text_Condicion.TabIndex = 3;
            this.text_Condicion.Text = "CONDICION";
            this.text_Condicion.Enter += new System.EventHandler(this.text_Condicion_Enter);
            this.text_Condicion.Leave += new System.EventHandler(this.text_Condicion_Leave);
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
            this.btn_Eliminar.TabIndex = 76;
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
            this.btn_Actualizar.TabIndex = 75;
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
            this.btn_Limpiar.TabIndex = 74;
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
            this.btn_Registrar.Location = new System.Drawing.Point(680, 289);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(266, 57);
            this.btn_Registrar.TabIndex = 73;
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
            this.UnidadID,
            this.TipoID,
            this.FeExpirado,
            this.Condicion,
            this.Precio_Unidad});
            this.dataGridView1.Location = new System.Drawing.Point(6, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1584, 372);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UnidadID
            // 
            this.UnidadID.DataPropertyName = "UnidadID";
            this.UnidadID.HeaderText = "UnidadID";
            this.UnidadID.MinimumWidth = 8;
            this.UnidadID.Name = "UnidadID";
            this.UnidadID.ReadOnly = true;
            // 
            // TipoID
            // 
            this.TipoID.DataPropertyName = "TipoID";
            this.TipoID.HeaderText = "TipoID";
            this.TipoID.MinimumWidth = 8;
            this.TipoID.Name = "TipoID";
            this.TipoID.ReadOnly = true;
            // 
            // FeExpirado
            // 
            this.FeExpirado.DataPropertyName = "FeExpirado";
            this.FeExpirado.HeaderText = "FeExpirado";
            this.FeExpirado.MinimumWidth = 8;
            this.FeExpirado.Name = "FeExpirado";
            this.FeExpirado.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.MinimumWidth = 8;
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Precio_Unidad
            // 
            this.Precio_Unidad.DataPropertyName = "Precio_Unidad";
            this.Precio_Unidad.HeaderText = "Precio_Unidad";
            this.Precio_Unidad.MinimumWidth = 8;
            this.Precio_Unidad.Name = "Precio_Unidad";
            this.Precio_Unidad.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(872, 157);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 2);
            this.panel5.TabIndex = 71;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Presupuesto);
            this.panel6.Location = new System.Drawing.Point(868, 114);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 45);
            this.panel6.TabIndex = 70;
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
            this.panel4.Location = new System.Drawing.Point(367, 157);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 69;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel7.Controls.Add(this.text_FechaExpirado);
            this.panel7.Location = new System.Drawing.Point(371, 114);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 45);
            this.panel7.TabIndex = 68;
            // 
            // text_FechaExpirado
            // 
            this.text_FechaExpirado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_FechaExpirado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_FechaExpirado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_FechaExpirado.Location = new System.Drawing.Point(15, 12);
            this.text_FechaExpirado.Name = "text_FechaExpirado";
            this.text_FechaExpirado.Size = new System.Drawing.Size(314, 19);
            this.text_FechaExpirado.TabIndex = 3;
            this.text_FechaExpirado.Text = "FECHA EXPIRADO";
            this.text_FechaExpirado.Enter += new System.EventHandler(this.text_FechaExpirado_Enter);
            this.text_FechaExpirado.Leave += new System.EventHandler(this.text_FechaExpirado_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(560, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 54);
            this.label1.TabIndex = 67;
            this.label1.Text = "REGISTRAR UNIDADES";
            // 
            // unidades_TipoID
            // 
            this.unidades_TipoID.DataSetName = "Unidades_TipoID";
            this.unidades_TipoID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "Tipo";
            this.tipoBindingSource.DataSource = this.unidades_TipoID;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 882);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Unidades";
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.Unidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidades_TipoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox text_Condicion;
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
        private System.Windows.Forms.TextBox text_FechaExpirado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeExpirado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unidad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbx_TipoID;
        private Unidades_TipoID unidades_TipoID;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private Unidades_TipoIDTableAdapters.TipoTableAdapter tipoTableAdapter;
    }
}