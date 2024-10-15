
namespace generador_contraseña
{
    partial class usuario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.num_cifras = new System.Windows.Forms.TextBox();
            this.label_cantidad_cifras = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressbar_contra = new System.Windows.Forms.ProgressBar();
            this.lb_imprime_f_d_m = new System.Windows.Forms.Label();
            this.Nombre_contrasena = new System.Windows.Forms.TextBox();
            this.label_nombre_contra = new System.Windows.Forms.Label();
            this.datos_incompletos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_error_guardado = new System.Windows.Forms.Label();
            this.check_fecha = new System.Windows.Forms.CheckBox();
            this.panel_central_generar_c = new System.Windows.Forms.Panel();
            this.panel_boton_guardar_banco = new System.Windows.Forms.Panel();
            this.picture_boton_guardar = new System.Windows.Forms.PictureBox();
            this.panel_boton_generar = new System.Windows.Forms.Panel();
            this.picture_boton_generar = new System.Windows.Forms.PictureBox();
            this.panel_nombre_contra = new System.Windows.Forms.Panel();
            this.panel_longitud_contra = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_contra_generada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_linea_generar = new System.Windows.Forms.PictureBox();
            this.panel_superior_generar = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.picture_regresar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control_txt1 = new System.Windows.Forms.TextBox();
            this.errores_generador = new System.Windows.Forms.ErrorProvider(this.components);
            this.boton_guardar_generar = new generador_contraseña.Class_new_buttons();
            this.boton_generar_contra_generar = new generador_contraseña.Class_new_buttons();
            ((System.ComponentModel.ISupportInitialize)(this.datos_incompletos)).BeginInit();
            this.panel_central_generar_c.SuspendLayout();
            this.panel_boton_guardar_banco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_guardar)).BeginInit();
            this.panel_boton_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_generar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_generar)).BeginInit();
            this.panel_superior_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores_generador)).BeginInit();
            this.SuspendLayout();
            // 
            // num_cifras
            // 
            this.num_cifras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_cifras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cifras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num_cifras.Location = new System.Drawing.Point(151, 126);
            this.num_cifras.Margin = new System.Windows.Forms.Padding(2);
            this.num_cifras.Name = "num_cifras";
            this.num_cifras.Size = new System.Drawing.Size(37, 14);
            this.num_cifras.TabIndex = 4;
            this.num_cifras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_cantidad_cifras
            // 
            this.label_cantidad_cifras.AutoSize = true;
            this.label_cantidad_cifras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cantidad_cifras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cantidad_cifras.Location = new System.Drawing.Point(131, 77);
            this.label_cantidad_cifras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cantidad_cifras.Name = "label_cantidad_cifras";
            this.label_cantidad_cifras.Size = new System.Drawing.Size(79, 21);
            this.label_cantidad_cifras.TabIndex = 5;
            this.label_cantidad_cifras.Text = "Longitud";
            this.label_cantidad_cifras.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressbar_contra
            // 
            this.progressbar_contra.Location = new System.Drawing.Point(236, 234);
            this.progressbar_contra.Margin = new System.Windows.Forms.Padding(2);
            this.progressbar_contra.Name = "progressbar_contra";
            this.progressbar_contra.Size = new System.Drawing.Size(146, 6);
            this.progressbar_contra.TabIndex = 13;
            // 
            // lb_imprime_f_d_m
            // 
            this.lb_imprime_f_d_m.AutoSize = true;
            this.lb_imprime_f_d_m.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_imprime_f_d_m.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_imprime_f_d_m.Location = new System.Drawing.Point(295, 242);
            this.lb_imprime_f_d_m.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_imprime_f_d_m.Name = "lb_imprime_f_d_m";
            this.lb_imprime_f_d_m.Size = new System.Drawing.Size(19, 13);
            this.lb_imprime_f_d_m.TabIndex = 14;
            this.lb_imprime_f_d_m.Text = "00";
            this.lb_imprime_f_d_m.Visible = false;
            this.lb_imprime_f_d_m.Click += new System.EventHandler(this.lb_imprime_f_d_m_Click);
            // 
            // Nombre_contrasena
            // 
            this.Nombre_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_contrasena.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_contrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nombre_contrasena.Location = new System.Drawing.Point(389, 106);
            this.Nombre_contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.Nombre_contrasena.Name = "Nombre_contrasena";
            this.Nombre_contrasena.Size = new System.Drawing.Size(147, 16);
            this.Nombre_contrasena.TabIndex = 17;
            this.Nombre_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre_contrasena.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_nombre_contra
            // 
            this.label_nombre_contra.AutoSize = true;
            this.label_nombre_contra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_contra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nombre_contra.Location = new System.Drawing.Point(372, 77);
            this.label_nombre_contra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre_contra.Name = "label_nombre_contra";
            this.label_nombre_contra.Size = new System.Drawing.Size(185, 21);
            this.label_nombre_contra.TabIndex = 22;
            this.label_nombre_contra.Text = "Nombre de la contraseña";
            // 
            // datos_incompletos
            // 
            this.datos_incompletos.BlinkRate = 100;
            this.datos_incompletos.ContainerControl = this;
            // 
            // lb_error_guardado
            // 
            this.lb_error_guardado.AutoSize = true;
            this.lb_error_guardado.ForeColor = System.Drawing.Color.Red;
            this.lb_error_guardado.Location = new System.Drawing.Point(190, 163);
            this.lb_error_guardado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_error_guardado.Name = "lb_error_guardado";
            this.lb_error_guardado.Size = new System.Drawing.Size(0, 13);
            this.lb_error_guardado.TabIndex = 23;
            this.lb_error_guardado.Visible = false;
            // 
            // check_fecha
            // 
            this.check_fecha.AutoSize = true;
            this.check_fecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_fecha.Location = new System.Drawing.Point(358, 126);
            this.check_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.check_fecha.Name = "check_fecha";
            this.check_fecha.Size = new System.Drawing.Size(213, 25);
            this.check_fecha.TabIndex = 25;
            this.check_fecha.Text = "Incluir fecha de guaradado";
            this.check_fecha.UseVisualStyleBackColor = true;
            this.check_fecha.Visible = false;
            // 
            // panel_central_generar_c
            // 
            this.panel_central_generar_c.Controls.Add(this.panel_boton_guardar_banco);
            this.panel_central_generar_c.Controls.Add(this.panel_boton_generar);
            this.panel_central_generar_c.Controls.Add(this.boton_guardar_generar);
            this.panel_central_generar_c.Controls.Add(this.boton_generar_contra_generar);
            this.panel_central_generar_c.Controls.Add(this.panel_nombre_contra);
            this.panel_central_generar_c.Controls.Add(this.panel_longitud_contra);
            this.panel_central_generar_c.Controls.Add(this.label2);
            this.panel_central_generar_c.Controls.Add(this.panel_contra_generada);
            this.panel_central_generar_c.Controls.Add(this.label1);
            this.panel_central_generar_c.Controls.Add(this.picture_linea_generar);
            this.panel_central_generar_c.Controls.Add(this.panel_superior_generar);
            this.panel_central_generar_c.Controls.Add(this.check_fecha);
            this.panel_central_generar_c.Controls.Add(this.lb_error_guardado);
            this.panel_central_generar_c.Controls.Add(this.label_nombre_contra);
            this.panel_central_generar_c.Controls.Add(this.Nombre_contrasena);
            this.panel_central_generar_c.Controls.Add(this.lb_imprime_f_d_m);
            this.panel_central_generar_c.Controls.Add(this.progressbar_contra);
            this.panel_central_generar_c.Controls.Add(this.label_cantidad_cifras);
            this.panel_central_generar_c.Controls.Add(this.num_cifras);
            this.panel_central_generar_c.Controls.Add(this.control_txt1);
            this.panel_central_generar_c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_central_generar_c.Location = new System.Drawing.Point(-1, -2);
            this.panel_central_generar_c.Name = "panel_central_generar_c";
            this.panel_central_generar_c.Size = new System.Drawing.Size(637, 361);
            this.panel_central_generar_c.TabIndex = 26;
            this.panel_central_generar_c.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_central_generar_c_Paint);
            // 
            // panel_boton_guardar_banco
            // 
            this.panel_boton_guardar_banco.Controls.Add(this.picture_boton_guardar);
            this.panel_boton_guardar_banco.Location = new System.Drawing.Point(329, 289);
            this.panel_boton_guardar_banco.Name = "panel_boton_guardar_banco";
            this.panel_boton_guardar_banco.Size = new System.Drawing.Size(43, 42);
            this.panel_boton_guardar_banco.TabIndex = 41;
            // 
            // picture_boton_guardar
            // 
            this.picture_boton_guardar.BackgroundImage = global::generador_contraseña.Properties.Resources.disquete;
            this.picture_boton_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_boton_guardar.Location = new System.Drawing.Point(10, 10);
            this.picture_boton_guardar.Name = "picture_boton_guardar";
            this.picture_boton_guardar.Size = new System.Drawing.Size(23, 23);
            this.picture_boton_guardar.TabIndex = 40;
            this.picture_boton_guardar.TabStop = false;
            // 
            // panel_boton_generar
            // 
            this.panel_boton_generar.Controls.Add(this.picture_boton_generar);
            this.panel_boton_generar.Location = new System.Drawing.Point(145, 289);
            this.panel_boton_generar.Name = "panel_boton_generar";
            this.panel_boton_generar.Size = new System.Drawing.Size(43, 42);
            this.panel_boton_generar.TabIndex = 40;
            // 
            // picture_boton_generar
            // 
            this.picture_boton_generar.BackgroundImage = global::generador_contraseña.Properties.Resources.bloquear1;
            this.picture_boton_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_boton_generar.Location = new System.Drawing.Point(10, 10);
            this.picture_boton_generar.Name = "picture_boton_generar";
            this.picture_boton_generar.Size = new System.Drawing.Size(23, 23);
            this.picture_boton_generar.TabIndex = 40;
            this.picture_boton_generar.TabStop = false;
            // 
            // panel_nombre_contra
            // 
            this.panel_nombre_contra.Location = new System.Drawing.Point(389, 119);
            this.panel_nombre_contra.Name = "panel_nombre_contra";
            this.panel_nombre_contra.Size = new System.Drawing.Size(147, 3);
            this.panel_nombre_contra.TabIndex = 37;
            // 
            // panel_longitud_contra
            // 
            this.panel_longitud_contra.Location = new System.Drawing.Point(151, 139);
            this.panel_longitud_contra.Name = "panel_longitud_contra";
            this.panel_longitud_contra.Size = new System.Drawing.Size(37, 3);
            this.panel_longitud_contra.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(106, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Escoja el n° de caracteres";
            // 
            // panel_contra_generada
            // 
            this.panel_contra_generada.Location = new System.Drawing.Point(236, 226);
            this.panel_contra_generada.Name = "panel_contra_generada";
            this.panel_contra_generada.Size = new System.Drawing.Size(147, 3);
            this.panel_contra_generada.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(232, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Contraseña Generada";
            // 
            // picture_linea_generar
            // 
            this.picture_linea_generar.BackgroundImage = global::generador_contraseña.Properties.Resources.menos_linea_recta_horizontal1;
            this.picture_linea_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_linea_generar.Location = new System.Drawing.Point(-13, 30);
            this.picture_linea_generar.Name = "picture_linea_generar";
            this.picture_linea_generar.Size = new System.Drawing.Size(648, 10);
            this.picture_linea_generar.TabIndex = 34;
            this.picture_linea_generar.TabStop = false;
            // 
            // panel_superior_generar
            // 
            this.panel_superior_generar.Controls.Add(this.label_menu);
            this.panel_superior_generar.Controls.Add(this.picture_regresar);
            this.panel_superior_generar.Controls.Add(this.pictureBox2);
            this.panel_superior_generar.Controls.Add(this.pictureBox1);
            this.panel_superior_generar.Location = new System.Drawing.Point(0, 0);
            this.panel_superior_generar.Name = "panel_superior_generar";
            this.panel_superior_generar.Size = new System.Drawing.Size(635, 30);
            this.panel_superior_generar.TabIndex = 33;
            this.panel_superior_generar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_superior_menu_Paint);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_menu.Location = new System.Drawing.Point(9, 7);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(224, 23);
            this.label_menu.TabIndex = 36;
            this.label_menu.Text = "Generador de Contraseñas";
            // 
            // picture_regresar
            // 
            this.picture_regresar.BackgroundImage = global::generador_contraseña.Properties.Resources.volver;
            this.picture_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_regresar.Location = new System.Drawing.Point(552, 7);
            this.picture_regresar.Name = "picture_regresar";
            this.picture_regresar.Size = new System.Drawing.Size(17, 17);
            this.picture_regresar.TabIndex = 35;
            this.picture_regresar.TabStop = false;
            this.picture_regresar.Click += new System.EventHandler(this.picture_regresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::generador_contraseña.Properties.Resources.apagar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(575, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::generador_contraseña.Properties.Resources.cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(598, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // control_txt1
            // 
            this.control_txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.control_txt1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_txt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.control_txt1.Location = new System.Drawing.Point(236, 211);
            this.control_txt1.Margin = new System.Windows.Forms.Padding(2);
            this.control_txt1.Name = "control_txt1";
            this.control_txt1.Size = new System.Drawing.Size(147, 16);
            this.control_txt1.TabIndex = 3;
            this.control_txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errores_generador
            // 
            this.errores_generador.ContainerControl = this;
            // 
            // boton_guardar_generar
            // 
            this.boton_guardar_generar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_guardar_generar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_guardar_generar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_guardar_generar.BorderRadius = 0;
            this.boton_guardar_generar.BorderSize = 0;
            this.boton_guardar_generar.FlatAppearance.BorderSize = 0;
            this.boton_guardar_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_guardar_generar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_guardar_generar.ForeColor = System.Drawing.Color.White;
            this.boton_guardar_generar.ImageKey = "(ninguno)";
            this.boton_guardar_generar.Location = new System.Drawing.Point(345, 289);
            this.boton_guardar_generar.Name = "boton_guardar_generar";
            this.boton_guardar_generar.Size = new System.Drawing.Size(120, 42);
            this.boton_guardar_generar.TabIndex = 39;
            this.boton_guardar_generar.Text = "Guardar";
            this.boton_guardar_generar.TextColor = System.Drawing.Color.White;
            this.boton_guardar_generar.UseVisualStyleBackColor = false;
            this.boton_guardar_generar.Click += new System.EventHandler(this.boton_guardar_generar_Click);
            // 
            // boton_generar_contra_generar
            // 
            this.boton_generar_contra_generar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_generar_contra_generar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_generar_contra_generar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_generar_contra_generar.BorderRadius = 0;
            this.boton_generar_contra_generar.BorderSize = 0;
            this.boton_generar_contra_generar.FlatAppearance.BorderSize = 0;
            this.boton_generar_contra_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_generar_contra_generar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_generar_contra_generar.ForeColor = System.Drawing.Color.White;
            this.boton_generar_contra_generar.ImageKey = "(ninguno)";
            this.boton_generar_contra_generar.Location = new System.Drawing.Point(168, 289);
            this.boton_generar_contra_generar.Name = "boton_generar_contra_generar";
            this.boton_generar_contra_generar.Size = new System.Drawing.Size(120, 42);
            this.boton_generar_contra_generar.TabIndex = 38;
            this.boton_generar_contra_generar.Text = "Generar Contraseña";
            this.boton_generar_contra_generar.TextColor = System.Drawing.Color.White;
            this.boton_generar_contra_generar.UseVisualStyleBackColor = false;
            this.boton_generar_contra_generar.Click += new System.EventHandler(this.boton_generar_contra_generar_Click);
            // 
            // usuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(635, 358);
            this.Controls.Add(this.panel_central_generar_c);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "usuario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de contraseñas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_incompletos)).EndInit();
            this.panel_central_generar_c.ResumeLayout(false);
            this.panel_central_generar_c.PerformLayout();
            this.panel_boton_guardar_banco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_guardar)).EndInit();
            this.panel_boton_generar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_generar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_generar)).EndInit();
            this.panel_superior_generar.ResumeLayout(false);
            this.panel_superior_generar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores_generador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox num_cifras;
        private System.Windows.Forms.Label label_cantidad_cifras;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressbar_contra;
        private System.Windows.Forms.Label lb_imprime_f_d_m;
        private System.Windows.Forms.TextBox Nombre_contrasena;
        private System.Windows.Forms.Label label_nombre_contra;
        private System.Windows.Forms.ErrorProvider datos_incompletos;
        private System.Windows.Forms.Label lb_error_guardado;
        private System.Windows.Forms.CheckBox check_fecha;
        private System.Windows.Forms.Panel panel_central_generar_c;
        private System.Windows.Forms.Panel panel_superior_generar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picture_linea_generar;
        private System.Windows.Forms.PictureBox picture_regresar;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.TextBox control_txt1;
        private System.Windows.Forms.Panel panel_contra_generada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_nombre_contra;
        private System.Windows.Forms.Panel panel_longitud_contra;
        private Class_new_buttons boton_generar_contra_generar;
        private Class_new_buttons boton_guardar_generar;
        private System.Windows.Forms.PictureBox picture_boton_generar;
        private System.Windows.Forms.Panel panel_boton_generar;
        private System.Windows.Forms.Panel panel_boton_guardar_banco;
        private System.Windows.Forms.PictureBox picture_boton_guardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errores_generador;
    }
}

