namespace SmartGardenP
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.text_Contraseña = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_Usuario = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel7.Location = new System.Drawing.Point(404, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 1);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel8.Controls.Add(this.text_Contraseña);
            this.panel8.Location = new System.Drawing.Point(401, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(228, 29);
            this.panel8.TabIndex = 11;
            // 
            // text_Contraseña
            // 
            this.text_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.text_Contraseña.Location = new System.Drawing.Point(10, 8);
            this.text_Contraseña.Margin = new System.Windows.Forms.Padding(2);
            this.text_Contraseña.Name = "text_Contraseña";
            this.text_Contraseña.Size = new System.Drawing.Size(209, 13);
            this.text_Contraseña.TabIndex = 2;
            this.text_Contraseña.Text = "CONTRASEÑA";
            this.text_Contraseña.Enter += new System.EventHandler(this.text_Contraseña_Enter);
            this.text_Contraseña.Leave += new System.EventHandler(this.text_Contraseña_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(404, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.text_Usuario);
            this.panel3.Location = new System.Drawing.Point(401, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 29);
            this.panel3.TabIndex = 9;
            // 
            // text_Usuario
            // 
            this.text_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.text_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.text_Usuario.Location = new System.Drawing.Point(10, 8);
            this.text_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.text_Usuario.Name = "text_Usuario";
            this.text_Usuario.Size = new System.Drawing.Size(209, 13);
            this.text_Usuario.TabIndex = 1;
            this.text_Usuario.Text = "USUARIO";
            this.text_Usuario.Enter += new System.EventHandler(this.text_Usuario_Enter);
            this.text_Usuario.Leave += new System.EventHandler(this.text_Usuario_Leave);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.label_Login.Location = new System.Drawing.Point(462, 39);
            this.label_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(105, 36);
            this.label_Login.TabIndex = 13;
            this.label_Login.Text = "LOGIN";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Login.Location = new System.Drawing.Point(330, 209);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(180, 40);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "ACCEDER";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(753, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(15, 15);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(732, 12);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(15, 15);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 17;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_signUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.ForeColor = System.Drawing.Color.LightGray;
            this.btn_signUp.Location = new System.Drawing.Point(516, 209);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(180, 40);
            this.btn_signUp.TabIndex = 18;
            this.btn_signUp.Text = "SIGN UP";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LOGIN_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox text_Contraseña;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.Button btn_signUp;
    }
}