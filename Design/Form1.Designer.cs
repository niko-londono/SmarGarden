
namespace SmartGardenP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubMenuPaisa = new System.Windows.Forms.Panel();
            this.btm_OrdenesPaisa = new System.Windows.Forms.Button();
            this.btn_RegistrarPaisa = new System.Windows.Forms.Button();
            this.btnPaisajismo = new System.Windows.Forms.Button();
            this.SubMenuInventario = new System.Windows.Forms.Panel();
            this.btn_Unidades = new System.Windows.Forms.Button();
            this.btn_Suministros = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGlosario = new System.Windows.Forms.Button();
            this.SubMenuTareas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_RegistrarTarea = new System.Windows.Forms.Button();
            this.btn_Tareas = new System.Windows.Forms.Button();
            this.SubMenuArreglos = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnArregloFloral = new System.Windows.Forms.Button();
            this.btnArreglos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SubMenuEmpleados = new System.Windows.Forms.Panel();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Rango = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubMenuPaisa.SuspendLayout();
            this.SubMenuInventario.SuspendLayout();
            this.SubMenuTareas.SuspendLayout();
            this.SubMenuArreglos.SuspendLayout();
            this.SubMenuEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.BarraTitulo.Controls.Add(this.btn_Logout);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.pictureBox2);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(0, -1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(48, 40);
            this.btn_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1232, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1201, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1233, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1266, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.MenuVertical.Controls.Add(this.SubMenuPaisa);
            this.MenuVertical.Controls.Add(this.btnPaisajismo);
            this.MenuVertical.Controls.Add(this.SubMenuInventario);
            this.MenuVertical.Controls.Add(this.btnInventario);
            this.MenuVertical.Controls.Add(this.btnGlosario);
            this.MenuVertical.Controls.Add(this.SubMenuTareas);
            this.MenuVertical.Controls.Add(this.btn_Tareas);
            this.MenuVertical.Controls.Add(this.SubMenuArreglos);
            this.MenuVertical.Controls.Add(this.btnArreglos);
            this.MenuVertical.Controls.Add(this.btnCliente);
            this.MenuVertical.Controls.Add(this.SubMenuEmpleados);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.btnInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 605);
            this.MenuVertical.TabIndex = 1;
            // 
            // SubMenuPaisa
            // 
            this.SubMenuPaisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuPaisa.Controls.Add(this.btm_OrdenesPaisa);
            this.SubMenuPaisa.Controls.Add(this.btn_RegistrarPaisa);
            this.SubMenuPaisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPaisa.Location = new System.Drawing.Point(0, 629);
            this.SubMenuPaisa.Name = "SubMenuPaisa";
            this.SubMenuPaisa.Size = new System.Drawing.Size(203, 67);
            this.SubMenuPaisa.TabIndex = 27;
            this.SubMenuPaisa.Visible = false;
            // 
            // btm_OrdenesPaisa
            // 
            this.btm_OrdenesPaisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btm_OrdenesPaisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_OrdenesPaisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btm_OrdenesPaisa.FlatAppearance.BorderSize = 0;
            this.btm_OrdenesPaisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btm_OrdenesPaisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_OrdenesPaisa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_OrdenesPaisa.ForeColor = System.Drawing.SystemColors.Control;
            this.btm_OrdenesPaisa.Image = ((System.Drawing.Image)(resources.GetObject("btm_OrdenesPaisa.Image")));
            this.btm_OrdenesPaisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_OrdenesPaisa.Location = new System.Drawing.Point(0, 30);
            this.btm_OrdenesPaisa.Name = "btm_OrdenesPaisa";
            this.btm_OrdenesPaisa.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btm_OrdenesPaisa.Size = new System.Drawing.Size(203, 30);
            this.btm_OrdenesPaisa.TabIndex = 9;
            this.btm_OrdenesPaisa.Text = "Ordenes";
            this.btm_OrdenesPaisa.UseVisualStyleBackColor = true;
            this.btm_OrdenesPaisa.Click += new System.EventHandler(this.btm_OrdenesPaisa_Click_1);
            // 
            // btn_RegistrarPaisa
            // 
            this.btn_RegistrarPaisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RegistrarPaisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarPaisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegistrarPaisa.FlatAppearance.BorderSize = 0;
            this.btn_RegistrarPaisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_RegistrarPaisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarPaisa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarPaisa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RegistrarPaisa.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarPaisa.Image")));
            this.btn_RegistrarPaisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistrarPaisa.Location = new System.Drawing.Point(0, 0);
            this.btn_RegistrarPaisa.Name = "btn_RegistrarPaisa";
            this.btn_RegistrarPaisa.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_RegistrarPaisa.Size = new System.Drawing.Size(203, 30);
            this.btn_RegistrarPaisa.TabIndex = 7;
            this.btn_RegistrarPaisa.Text = "registrar ";
            this.btn_RegistrarPaisa.UseVisualStyleBackColor = true;
            this.btn_RegistrarPaisa.Click += new System.EventHandler(this.btn_RegistrarPaisa_Click_1);
            // 
            // btnPaisajismo
            // 
            this.btnPaisajismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaisajismo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaisajismo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaisajismo.FlatAppearance.BorderSize = 0;
            this.btnPaisajismo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnPaisajismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaisajismo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaisajismo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPaisajismo.Image = ((System.Drawing.Image)(resources.GetObject("btnPaisajismo.Image")));
            this.btnPaisajismo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaisajismo.Location = new System.Drawing.Point(0, 589);
            this.btnPaisajismo.Name = "btnPaisajismo";
            this.btnPaisajismo.Size = new System.Drawing.Size(203, 40);
            this.btnPaisajismo.TabIndex = 26;
            this.btnPaisajismo.Text = "Paisajismo";
            this.btnPaisajismo.UseVisualStyleBackColor = true;
            this.btnPaisajismo.Click += new System.EventHandler(this.btnPaisajismo_Click_1);
            // 
            // SubMenuInventario
            // 
            this.SubMenuInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuInventario.Controls.Add(this.btn_Unidades);
            this.SubMenuInventario.Controls.Add(this.btn_Suministros);
            this.SubMenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuInventario.Location = new System.Drawing.Point(0, 522);
            this.SubMenuInventario.Name = "SubMenuInventario";
            this.SubMenuInventario.Size = new System.Drawing.Size(203, 67);
            this.SubMenuInventario.TabIndex = 25;
            this.SubMenuInventario.Visible = false;
            // 
            // btn_Unidades
            // 
            this.btn_Unidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Unidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Unidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Unidades.FlatAppearance.BorderSize = 0;
            this.btn_Unidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_Unidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unidades.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unidades.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Unidades.Image = ((System.Drawing.Image)(resources.GetObject("btn_Unidades.Image")));
            this.btn_Unidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Unidades.Location = new System.Drawing.Point(0, 30);
            this.btn_Unidades.Name = "btn_Unidades";
            this.btn_Unidades.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_Unidades.Size = new System.Drawing.Size(203, 30);
            this.btn_Unidades.TabIndex = 9;
            this.btn_Unidades.Text = "Unidades";
            this.btn_Unidades.UseVisualStyleBackColor = true;
            this.btn_Unidades.Click += new System.EventHandler(this.btn_Unidades_Click);
            // 
            // btn_Suministros
            // 
            this.btn_Suministros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Suministros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Suministros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Suministros.FlatAppearance.BorderSize = 0;
            this.btn_Suministros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_Suministros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suministros.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suministros.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Suministros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suministros.Image")));
            this.btn_Suministros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Suministros.Location = new System.Drawing.Point(0, 0);
            this.btn_Suministros.Name = "btn_Suministros";
            this.btn_Suministros.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_Suministros.Size = new System.Drawing.Size(203, 30);
            this.btn_Suministros.TabIndex = 7;
            this.btn_Suministros.Text = "suministros";
            this.btn_Suministros.UseVisualStyleBackColor = true;
            this.btn_Suministros.Click += new System.EventHandler(this.btn_Suministros_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 482);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(203, 40);
            this.btnInventario.TabIndex = 22;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGlosario
            // 
            this.btnGlosario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGlosario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlosario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGlosario.FlatAppearance.BorderSize = 0;
            this.btnGlosario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnGlosario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlosario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlosario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGlosario.Image = ((System.Drawing.Image)(resources.GetObject("btnGlosario.Image")));
            this.btnGlosario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlosario.Location = new System.Drawing.Point(0, 442);
            this.btnGlosario.Name = "btnGlosario";
            this.btnGlosario.Size = new System.Drawing.Size(203, 40);
            this.btnGlosario.TabIndex = 21;
            this.btnGlosario.Text = "Glosario";
            this.btnGlosario.UseVisualStyleBackColor = true;
            this.btnGlosario.Click += new System.EventHandler(this.btnGlosario_Click);
            // 
            // SubMenuTareas
            // 
            this.SubMenuTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuTareas.Controls.Add(this.button1);
            this.SubMenuTareas.Controls.Add(this.btn_RegistrarTarea);
            this.SubMenuTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuTareas.Location = new System.Drawing.Point(0, 375);
            this.SubMenuTareas.Name = "SubMenuTareas";
            this.SubMenuTareas.Size = new System.Drawing.Size(203, 67);
            this.SubMenuTareas.TabIndex = 20;
            this.SubMenuTareas.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(203, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Asignacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RegistrarTarea
            // 
            this.btn_RegistrarTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RegistrarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegistrarTarea.FlatAppearance.BorderSize = 0;
            this.btn_RegistrarTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_RegistrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarTarea.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarTarea.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RegistrarTarea.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarTarea.Image")));
            this.btn_RegistrarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistrarTarea.Location = new System.Drawing.Point(0, 0);
            this.btn_RegistrarTarea.Name = "btn_RegistrarTarea";
            this.btn_RegistrarTarea.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_RegistrarTarea.Size = new System.Drawing.Size(203, 30);
            this.btn_RegistrarTarea.TabIndex = 7;
            this.btn_RegistrarTarea.Text = "registrar ";
            this.btn_RegistrarTarea.UseVisualStyleBackColor = true;
            this.btn_RegistrarTarea.Click += new System.EventHandler(this.btn_RegistrarTarea_Click);
            // 
            // btn_Tareas
            // 
            this.btn_Tareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tareas.FlatAppearance.BorderSize = 0;
            this.btn_Tareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_Tareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tareas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tareas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Tareas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tareas.Image")));
            this.btn_Tareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tareas.Location = new System.Drawing.Point(0, 335);
            this.btn_Tareas.Name = "btn_Tareas";
            this.btn_Tareas.Size = new System.Drawing.Size(203, 40);
            this.btn_Tareas.TabIndex = 16;
            this.btn_Tareas.Text = "Tareas";
            this.btn_Tareas.UseVisualStyleBackColor = true;
            this.btn_Tareas.Click += new System.EventHandler(this.btn_Tareas_Click);
            // 
            // SubMenuArreglos
            // 
            this.SubMenuArreglos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuArreglos.Controls.Add(this.btnOrdenes);
            this.SubMenuArreglos.Controls.Add(this.btnArregloFloral);
            this.SubMenuArreglos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuArreglos.Location = new System.Drawing.Point(0, 268);
            this.SubMenuArreglos.Name = "SubMenuArreglos";
            this.SubMenuArreglos.Size = new System.Drawing.Size(203, 67);
            this.SubMenuArreglos.TabIndex = 15;
            this.SubMenuArreglos.Visible = false;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 30);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(203, 30);
            this.btnOrdenes.TabIndex = 9;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click_1);
            // 
            // btnArregloFloral
            // 
            this.btnArregloFloral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArregloFloral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArregloFloral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArregloFloral.FlatAppearance.BorderSize = 0;
            this.btnArregloFloral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnArregloFloral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArregloFloral.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArregloFloral.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArregloFloral.Image = ((System.Drawing.Image)(resources.GetObject("btnArregloFloral.Image")));
            this.btnArregloFloral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArregloFloral.Location = new System.Drawing.Point(0, 0);
            this.btnArregloFloral.Name = "btnArregloFloral";
            this.btnArregloFloral.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnArregloFloral.Size = new System.Drawing.Size(203, 30);
            this.btnArregloFloral.TabIndex = 7;
            this.btnArregloFloral.Text = "Floral";
            this.btnArregloFloral.UseVisualStyleBackColor = true;
            this.btnArregloFloral.Click += new System.EventHandler(this.btnArregloFloral_Click_1);
            // 
            // btnArreglos
            // 
            this.btnArreglos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArreglos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArreglos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArreglos.FlatAppearance.BorderSize = 0;
            this.btnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArreglos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArreglos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArreglos.Image = ((System.Drawing.Image)(resources.GetObject("btnArreglos.Image")));
            this.btnArreglos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArreglos.Location = new System.Drawing.Point(0, 228);
            this.btnArreglos.Name = "btnArreglos";
            this.btnArreglos.Size = new System.Drawing.Size(203, 40);
            this.btnArreglos.TabIndex = 14;
            this.btnArreglos.Text = "Arreglos";
            this.btnArreglos.UseVisualStyleBackColor = true;
            this.btnArreglos.Click += new System.EventHandler(this.btnArreglos_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 188);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(203, 40);
            this.btnCliente.TabIndex = 13;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // SubMenuEmpleados
            // 
            this.SubMenuEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuEmpleados.Controls.Add(this.btn_Registrar);
            this.SubMenuEmpleados.Controls.Add(this.btn_Rango);
            this.SubMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuEmpleados.Location = new System.Drawing.Point(0, 119);
            this.SubMenuEmpleados.Name = "SubMenuEmpleados";
            this.SubMenuEmpleados.Size = new System.Drawing.Size(203, 69);
            this.SubMenuEmpleados.TabIndex = 12;
            this.SubMenuEmpleados.Visible = false;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registrar.Location = new System.Drawing.Point(0, 30);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_Registrar.Size = new System.Drawing.Size(203, 30);
            this.btn_Registrar.TabIndex = 10;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Rango
            // 
            this.btn_Rango.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Rango.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rango.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Rango.FlatAppearance.BorderSize = 0;
            this.btn_Rango.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btn_Rango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rango.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rango.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Rango.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rango.Image")));
            this.btn_Rango.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rango.Location = new System.Drawing.Point(0, 0);
            this.btn_Rango.Name = "btn_Rango";
            this.btn_Rango.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_Rango.Size = new System.Drawing.Size(203, 30);
            this.btn_Rango.TabIndex = 7;
            this.btn_Rango.Text = "Cargo";
            this.btn_Rango.UseVisualStyleBackColor = true;
            this.btn_Rango.Click += new System.EventHandler(this.btn_Rango_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 79);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(203, 40);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(203, 79);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(220, 38);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1080, 605);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 643);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubMenuPaisa.ResumeLayout(false);
            this.SubMenuInventario.ResumeLayout(false);
            this.SubMenuTareas.ResumeLayout(false);
            this.SubMenuArreglos.ResumeLayout(false);
            this.SubMenuEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.PictureBox btn_Logout;
        private System.Windows.Forms.Button btn_Tareas;
        private System.Windows.Forms.Panel SubMenuArreglos;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnArregloFloral;
        private System.Windows.Forms.Button btnArreglos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel SubMenuEmpleados;
        private System.Windows.Forms.Button btn_Rango;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGlosario;
        private System.Windows.Forms.Panel SubMenuTareas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_RegistrarTarea;
        private System.Windows.Forms.Panel SubMenuPaisa;
        private System.Windows.Forms.Button btm_OrdenesPaisa;
        private System.Windows.Forms.Button btn_RegistrarPaisa;
        private System.Windows.Forms.Button btnPaisajismo;
        private System.Windows.Forms.Panel SubMenuInventario;
        private System.Windows.Forms.Button btn_Unidades;
        private System.Windows.Forms.Button btn_Suministros;
    }
}

