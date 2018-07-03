namespace ExamenPacman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.volver2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ThePacMan = new System.Windows.Forms.PictureBox();
            this.RedGhost = new System.Windows.Forms.PictureBox();
            this.PinkGhost = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.chirimoya = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.panelNuevoUsuario = new System.Windows.Forms.Panel();
            this.volver1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Creacion = new System.Windows.Forms.Button();
            this.tiempocherry = new System.Windows.Forms.Timer(this.components);
            this.timerchiri = new System.Windows.Forms.Timer(this.components);
            this.aprecimientoChiri = new System.Windows.Forms.Timer(this.components);
            this.aparecimientoCherry = new System.Windows.Forms.Timer(this.components);
            this.panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThePacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chirimoya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNuevoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1258, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a Pacman Basic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(553, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre de usuario";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.Contrasena.Location = new System.Drawing.Point(553, 188);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(61, 13);
            this.Contrasena.TabIndex = 2;
            this.Contrasena.Text = "Contrasena";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(556, 165);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 20);
            this.Usuario.TabIndex = 3;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(556, 204);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(100, 20);
            this.Contra.TabIndex = 4;
            this.Contra.TextChanged += new System.EventHandler(this.Contra_TextChanged);
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(556, 231);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(100, 23);
            this.Ingresar.TabIndex = 5;
            this.Ingresar.Text = "Ingresa";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(556, 261);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(100, 23);
            this.Crear.TabIndex = 6;
            this.Crear.Text = "Crear Usuario";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelJuego.Controls.Add(this.volver2);
            this.panelJuego.Controls.Add(this.label5);
            this.panelJuego.Controls.Add(this.ThePacMan);
            this.panelJuego.Controls.Add(this.RedGhost);
            this.panelJuego.Controls.Add(this.PinkGhost);
            this.panelJuego.Controls.Add(this.Cherry);
            this.panelJuego.Controls.Add(this.chirimoya);
            this.panelJuego.Controls.Add(this.pictureBox4);
            this.panelJuego.Controls.Add(this.pictureBox3);
            this.panelJuego.Controls.Add(this.pictureBox2);
            this.panelJuego.Controls.Add(this.pictureBox1);
            this.panelJuego.Controls.Add(this.Score);
            this.panelJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJuego.Location = new System.Drawing.Point(0, 0);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(1284, 761);
            this.panelJuego.TabIndex = 7;
            this.panelJuego.Tag = "MuroSuperior";
            this.panelJuego.Visible = false;
            this.panelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panelJuego_Paint);
            // 
            // volver2
            // 
            this.volver2.Location = new System.Drawing.Point(1126, 13);
            this.volver2.Name = "volver2";
            this.volver2.Size = new System.Drawing.Size(146, 23);
            this.volver2.TabIndex = 13;
            this.volver2.Text = "Volver";
            this.volver2.UseVisualStyleBackColor = true;
            this.volver2.Click += new System.EventHandler(this.volver2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(556, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ThePacMan
            // 
            this.ThePacMan.BackColor = System.Drawing.Color.Transparent;
            this.ThePacMan.Image = global::ExamenPacman.Properties.Resources.pacman_right;
            this.ThePacMan.InitialImage = global::ExamenPacman.Properties.Resources.pacman_right;
            this.ThePacMan.Location = new System.Drawing.Point(595, 351);
            this.ThePacMan.Name = "ThePacMan";
            this.ThePacMan.Size = new System.Drawing.Size(20, 20);
            this.ThePacMan.TabIndex = 9;
            this.ThePacMan.TabStop = false;
            this.ThePacMan.Tag = "TPM";
            // 
            // RedGhost
            // 
            this.RedGhost.BackColor = System.Drawing.Color.Transparent;
            this.RedGhost.Image = ((System.Drawing.Image)(resources.GetObject("RedGhost.Image")));
            this.RedGhost.InitialImage = ((System.Drawing.Image)(resources.GetObject("RedGhost.InitialImage")));
            this.RedGhost.Location = new System.Drawing.Point(240, 468);
            this.RedGhost.Name = "RedGhost";
            this.RedGhost.Size = new System.Drawing.Size(20, 20);
            this.RedGhost.TabIndex = 8;
            this.RedGhost.TabStop = false;
            this.RedGhost.Tag = "RedGhost";
            // 
            // PinkGhost
            // 
            this.PinkGhost.BackColor = System.Drawing.Color.Transparent;
            this.PinkGhost.Image = global::ExamenPacman.Properties.Resources.pink_left1;
            this.PinkGhost.InitialImage = ((System.Drawing.Image)(resources.GetObject("PinkGhost.InitialImage")));
            this.PinkGhost.Location = new System.Drawing.Point(194, 367);
            this.PinkGhost.Name = "PinkGhost";
            this.PinkGhost.Size = new System.Drawing.Size(20, 20);
            this.PinkGhost.TabIndex = 7;
            this.PinkGhost.TabStop = false;
            this.PinkGhost.Tag = "PinkGhost";
            // 
            // Cherry
            // 
            this.Cherry.BackColor = System.Drawing.Color.Transparent;
            this.Cherry.Image = ((System.Drawing.Image)(resources.GetObject("Cherry.Image")));
            this.Cherry.InitialImage = ((System.Drawing.Image)(resources.GetObject("Cherry.InitialImage")));
            this.Cherry.Location = new System.Drawing.Point(180, 261);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(20, 21);
            this.Cherry.TabIndex = 6;
            this.Cherry.TabStop = false;
            this.Cherry.Tag = "Cher";
            // 
            // chirimoya
            // 
            this.chirimoya.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chirimoya.BackColor = System.Drawing.Color.Transparent;
            this.chirimoya.Image = ((System.Drawing.Image)(resources.GetObject("chirimoya.Image")));
            this.chirimoya.InitialImage = ((System.Drawing.Image)(resources.GetObject("chirimoya.InitialImage")));
            this.chirimoya.Location = new System.Drawing.Point(155, 141);
            this.chirimoya.Name = "chirimoya";
            this.chirimoya.Size = new System.Drawing.Size(13, 30);
            this.chirimoya.TabIndex = 5;
            this.chirimoya.TabStop = false;
            this.chirimoya.Tag = "chiri";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(34, 723);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1236, 16);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Muro";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(34, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1236, 16);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Muro";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(1253, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 687);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Muro";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(34, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 687);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Muro";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(30, 29);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(55, 20);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score:";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // temporizador
            // 
            this.temporizador.Interval = 20;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // panelNuevoUsuario
            // 
            this.panelNuevoUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNuevoUsuario.Controls.Add(this.volver1);
            this.panelNuevoUsuario.Controls.Add(this.label4);
            this.panelNuevoUsuario.Controls.Add(this.label3);
            this.panelNuevoUsuario.Controls.Add(this.textBox2);
            this.panelNuevoUsuario.Controls.Add(this.textBox1);
            this.panelNuevoUsuario.Controls.Add(this.Creacion);
            this.panelNuevoUsuario.Location = new System.Drawing.Point(530, 137);
            this.panelNuevoUsuario.Name = "panelNuevoUsuario";
            this.panelNuevoUsuario.Size = new System.Drawing.Size(200, 220);
            this.panelNuevoUsuario.TabIndex = 10;
            this.panelNuevoUsuario.Visible = false;
            this.panelNuevoUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNuevoUsuario_Paint);
            // 
            // volver1
            // 
            this.volver1.Location = new System.Drawing.Point(119, 105);
            this.volver1.Name = "volver1";
            this.volver1.Size = new System.Drawing.Size(76, 95);
            this.volver1.TabIndex = 5;
            this.volver1.Text = "Volver";
            this.volver1.UseVisualStyleBackColor = true;
            this.volver1.Click += new System.EventHandler(this.volver1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contrasena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del nuevo Usuario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Creacion
            // 
            this.Creacion.Location = new System.Drawing.Point(13, 105);
            this.Creacion.Name = "Creacion";
            this.Creacion.Size = new System.Drawing.Size(100, 95);
            this.Creacion.TabIndex = 0;
            this.Creacion.Text = "Crealo";
            this.Creacion.UseVisualStyleBackColor = true;
            this.Creacion.Click += new System.EventHandler(this.Creacion_Click);
            // 
            // tiempocherry
            // 
            this.tiempocherry.Interval = 10000;
            this.tiempocherry.Tick += new System.EventHandler(this.tiempocherry_Tick);
            // 
            // timerchiri
            // 
            this.timerchiri.Interval = 10000;
            this.timerchiri.Tick += new System.EventHandler(this.timerchiri_Tick);
            // 
            // aprecimientoChiri
            // 
            this.aprecimientoChiri.Interval = 30000;
            this.aprecimientoChiri.Tick += new System.EventHandler(this.aprecimientoChiri_Tick);
            // 
            // aparecimientoCherry
            // 
            this.aparecimientoCherry.Interval = 30000;
            this.aparecimientoCherry.Tick += new System.EventHandler(this.aparecimientoCherry_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenPacman.Properties.Resources.Pac_man__Official_Image_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNuevoUsuario);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyAbajo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyArriba);
            this.panelJuego.ResumeLayout(false);
            this.panelJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThePacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chirimoya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNuevoUsuario.ResumeLayout(false);
            this.panelNuevoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox ThePacMan;
        private System.Windows.Forms.PictureBox RedGhost;
        private System.Windows.Forms.PictureBox PinkGhost;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer temporizador;
        public System.Windows.Forms.Panel panelNuevoUsuario;
        private System.Windows.Forms.Button Creacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox Cherry;
        public System.Windows.Forms.PictureBox chirimoya;
        private System.Windows.Forms.Timer tiempocherry;
        private System.Windows.Forms.Timer timerchiri;
        private System.Windows.Forms.Timer aprecimientoChiri;
        private System.Windows.Forms.Timer aparecimientoCherry;
        private System.Windows.Forms.Button volver1;
        private System.Windows.Forms.Button volver2;
        public System.Windows.Forms.Panel panelJuego;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Contrasena;
        public System.Windows.Forms.TextBox Usuario;
        public System.Windows.Forms.TextBox Contra;
        public System.Windows.Forms.Button Ingresar;
        public System.Windows.Forms.Button Crear;
    }
}

