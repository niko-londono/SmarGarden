namespace SmartGardenP
{
    partial class Floral
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Precio = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.ArregloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(558, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 1);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel6.Controls.Add(this.text_Precio);
            this.panel6.Location = new System.Drawing.Point(555, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 29);
            this.panel6.TabIndex = 16;
            // 
            // text_Precio
            // 
            this.text_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Precio.Location = new System.Drawing.Point(10, 8);
            this.text_Precio.Margin = new System.Windows.Forms.Padding(2);
            this.text_Precio.Name = "text_Precio";
            this.text_Precio.Size = new System.Drawing.Size(209, 13);
            this.text_Precio.TabIndex = 3;
            this.text_Precio.Text = "PRECIO";
            this.text_Precio.Enter += new System.EventHandler(this.text_Precio_Enter);
            this.text_Precio.Leave += new System.EventHandler(this.text_Precio_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(300, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_Descripcion);
            this.panel3.Location = new System.Drawing.Point(297, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 29);
            this.panel3.TabIndex = 14;
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.text_Descripcion.Location = new System.Drawing.Point(10, 8);
            this.text_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(209, 13);
            this.text_Descripcion.TabIndex = 3;
            this.text_Descripcion.Text = "DESCRIPCION";
            this.text_Descripcion.Enter += new System.EventHandler(this.text_Descripcion_Enter);
            this.text_Descripcion.Leave += new System.EventHandler(this.text_Descripcion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(383, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRAR ARREGLOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArregloID,
            this.Descripcion,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 242);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registrar.Location = new System.Drawing.Point(466, 220);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(177, 37);
            this.btn_Registrar.TabIndex = 19;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(231, 550);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(104, 37);
            this.btn_Eliminar.TabIndex = 27;
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
            this.btn_Actualizar.Location = new System.Drawing.Point(121, 550);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(104, 37);
            this.btn_Actualizar.TabIndex = 26;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(12, 550);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(104, 37);
            this.btn_Limpiar.TabIndex = 25;
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
            this.btn_Mostrar.Location = new System.Drawing.Point(341, 550);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(104, 37);
            this.btn_Mostrar.TabIndex = 28;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArregloID
            // 
            this.ArregloID.DataPropertyName = "ArregloID";
            this.ArregloID.HeaderText = "ArregloID";
            this.ArregloID.Name = "ArregloID";
            this.ArregloID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio_de_Complejidad";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Floral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btn_Mostrar);
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
            this.Name = "Floral";
            this.Text = "Floral";
            this.Load += new System.EventHandler(this.Floral_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_Precio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArregloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}