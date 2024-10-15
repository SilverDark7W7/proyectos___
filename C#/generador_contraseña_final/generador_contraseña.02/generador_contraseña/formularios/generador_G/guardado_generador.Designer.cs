
namespace generador_contraseña
{
    partial class guardado_generador
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
            this.checkBox_generador_guardado_generador = new System.Windows.Forms.CheckBox();
            this.lb_nombre_contrasena_guardado_generador = new System.Windows.Forms.Label();
            this.lb_contraseña_nueva_guardado_generador = new System.Windows.Forms.Label();
            this.lb_cantidad_guardado_generador = new System.Windows.Forms.Label();
            this.num_cifras = new System.Windows.Forms.TextBox();
            this.lb_fuerte_debil_guardado_generador = new System.Windows.Forms.Label();
            this.txt_nombre_contrasena = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.dtg_imprime_datos_tabla_guardado_generador = new System.Windows.Forms.DataGridView();
            this.Error_datos_insufucientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.check_fecha_guardado_generador = new System.Windows.Forms.CheckBox();
            this.panel_boton_guardar_guardado_generador = new System.Windows.Forms.Panel();
            this.picture_boton_guardar = new System.Windows.Forms.PictureBox();
            this.panel_boton_generar = new System.Windows.Forms.Panel();
            this.picture_boton_generar = new System.Windows.Forms.PictureBox();
            this.panel_modificar_guardado_generador = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_central_guardado_generar = new System.Windows.Forms.Panel();
            this.panel_nuevo_nombre_guardado_generador = new System.Windows.Forms.Panel();
            this.panel_nueva_contra_guardado_generador = new System.Windows.Forms.Panel();
            this.panel_cifras_guardado_generador = new System.Windows.Forms.Panel();
            this.picture_linea_generar = new System.Windows.Forms.PictureBox();
            this.panel_superior_guardado_generar = new System.Windows.Forms.Panel();
            this.picture_salida = new System.Windows.Forms.PictureBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.picture_regresar = new System.Windows.Forms.PictureBox();
            this.progress_guardado_generador = new System.Windows.Forms.ProgressBar();
            this.btn_modificar = new generador_contraseña.Class_new_buttons();
            this.btn_guardar_modificacion = new generador_contraseña.Class_new_buttons();
            this.Generar_contraseña_modificada = new generador_contraseña.Class_new_buttons();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_imprime_datos_tabla_guardado_generador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_datos_insufucientes)).BeginInit();
            this.panel_boton_guardar_guardado_generador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_guardar)).BeginInit();
            this.panel_boton_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_generar)).BeginInit();
            this.panel_modificar_guardado_generador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_central_guardado_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_generar)).BeginInit();
            this.panel_superior_guardado_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_generador_guardado_generador
            // 
            this.checkBox_generador_guardado_generador.AutoSize = true;
            this.checkBox_generador_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_generador_guardado_generador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_generador_guardado_generador.Location = new System.Drawing.Point(39, 215);
            this.checkBox_generador_guardado_generador.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_generador_guardado_generador.Name = "checkBox_generador_guardado_generador";
            this.checkBox_generador_guardado_generador.Size = new System.Drawing.Size(180, 21);
            this.checkBox_generador_guardado_generador.TabIndex = 47;
            this.checkBox_generador_guardado_generador.Text = "Generar contraseña nueva";
            this.checkBox_generador_guardado_generador.UseVisualStyleBackColor = true;
            this.checkBox_generador_guardado_generador.Visible = false;
            this.checkBox_generador_guardado_generador.CheckedChanged += new System.EventHandler(this.checkBox_generador_CheckedChanged_1);
            // 
            // lb_nombre_contrasena_guardado_generador
            // 
            this.lb_nombre_contrasena_guardado_generador.AutoSize = true;
            this.lb_nombre_contrasena_guardado_generador.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre_contrasena_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_contrasena_guardado_generador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_nombre_contrasena_guardado_generador.Location = new System.Drawing.Point(84, 167);
            this.lb_nombre_contrasena_guardado_generador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nombre_contrasena_guardado_generador.Name = "lb_nombre_contrasena_guardado_generador";
            this.lb_nombre_contrasena_guardado_generador.Size = new System.Drawing.Size(96, 17);
            this.lb_nombre_contrasena_guardado_generador.TabIndex = 46;
            this.lb_nombre_contrasena_guardado_generador.Text = "Nuevo nombre";
            this.lb_nombre_contrasena_guardado_generador.Visible = false;
            // 
            // lb_contraseña_nueva_guardado_generador
            // 
            this.lb_contraseña_nueva_guardado_generador.AutoSize = true;
            this.lb_contraseña_nueva_guardado_generador.BackColor = System.Drawing.Color.Transparent;
            this.lb_contraseña_nueva_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña_nueva_guardado_generador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_contraseña_nueva_guardado_generador.Location = new System.Drawing.Point(322, 167);
            this.lb_contraseña_nueva_guardado_generador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_contraseña_nueva_guardado_generador.Name = "lb_contraseña_nueva_guardado_generador";
            this.lb_contraseña_nueva_guardado_generador.Size = new System.Drawing.Size(113, 17);
            this.lb_contraseña_nueva_guardado_generador.TabIndex = 45;
            this.lb_contraseña_nueva_guardado_generador.Text = "Nueva contraseña";
            this.lb_contraseña_nueva_guardado_generador.Visible = false;
            // 
            // lb_cantidad_guardado_generador
            // 
            this.lb_cantidad_guardado_generador.AutoSize = true;
            this.lb_cantidad_guardado_generador.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantidad_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad_guardado_generador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_cantidad_guardado_generador.Location = new System.Drawing.Point(211, 133);
            this.lb_cantidad_guardado_generador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cantidad_guardado_generador.Name = "lb_cantidad_guardado_generador";
            this.lb_cantidad_guardado_generador.Size = new System.Drawing.Size(114, 17);
            this.lb_cantidad_guardado_generador.TabIndex = 44;
            this.lb_cantidad_guardado_generador.Text = "Cantidad de cifras";
            this.lb_cantidad_guardado_generador.Visible = false;
            // 
            // num_cifras
            // 
            this.num_cifras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_cifras.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cifras.ForeColor = System.Drawing.SystemColors.Window;
            this.num_cifras.Location = new System.Drawing.Point(244, 152);
            this.num_cifras.Margin = new System.Windows.Forms.Padding(2);
            this.num_cifras.Name = "num_cifras";
            this.num_cifras.Size = new System.Drawing.Size(37, 16);
            this.num_cifras.TabIndex = 43;
            this.num_cifras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_cifras.Visible = false;
            // 
            // lb_fuerte_debil_guardado_generador
            // 
            this.lb_fuerte_debil_guardado_generador.AutoSize = true;
            this.lb_fuerte_debil_guardado_generador.BackColor = System.Drawing.Color.Transparent;
            this.lb_fuerte_debil_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fuerte_debil_guardado_generador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_fuerte_debil_guardado_generador.Location = new System.Drawing.Point(353, 241);
            this.lb_fuerte_debil_guardado_generador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fuerte_debil_guardado_generador.Name = "lb_fuerte_debil_guardado_generador";
            this.lb_fuerte_debil_guardado_generador.Size = new System.Drawing.Size(0, 20);
            this.lb_fuerte_debil_guardado_generador.TabIndex = 42;
            // 
            // txt_nombre_contrasena
            // 
            this.txt_nombre_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_contrasena.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_contrasena.Location = new System.Drawing.Point(63, 191);
            this.txt_nombre_contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_contrasena.Name = "txt_nombre_contrasena";
            this.txt_nombre_contrasena.Size = new System.Drawing.Size(147, 16);
            this.txt_nombre_contrasena.TabIndex = 40;
            this.txt_nombre_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre_contrasena.Visible = false;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_contraseña.Location = new System.Drawing.Point(305, 191);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(147, 16);
            this.txt_contraseña.TabIndex = 39;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contraseña.Visible = false;
            // 
            // dtg_imprime_datos_tabla_guardado_generador
            // 
            this.dtg_imprime_datos_tabla_guardado_generador.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtg_imprime_datos_tabla_guardado_generador.AllowUserToAddRows = false;
            this.dtg_imprime_datos_tabla_guardado_generador.AllowUserToDeleteRows = false;
            this.dtg_imprime_datos_tabla_guardado_generador.AllowUserToResizeColumns = false;
            this.dtg_imprime_datos_tabla_guardado_generador.AllowUserToResizeRows = false;
            this.dtg_imprime_datos_tabla_guardado_generador.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_imprime_datos_tabla_guardado_generador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_imprime_datos_tabla_guardado_generador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_imprime_datos_tabla_guardado_generador.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_imprime_datos_tabla_guardado_generador.Location = new System.Drawing.Point(540, 65);
            this.dtg_imprime_datos_tabla_guardado_generador.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_imprime_datos_tabla_guardado_generador.Name = "dtg_imprime_datos_tabla_guardado_generador";
            this.dtg_imprime_datos_tabla_guardado_generador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtg_imprime_datos_tabla_guardado_generador.RowHeadersWidth = 62;
            this.dtg_imprime_datos_tabla_guardado_generador.RowTemplate.Height = 28;
            this.dtg_imprime_datos_tabla_guardado_generador.Size = new System.Drawing.Size(360, 344);
            this.dtg_imprime_datos_tabla_guardado_generador.TabIndex = 34;
            this.dtg_imprime_datos_tabla_guardado_generador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_imprime_datos_tabla_CellClick);
            this.dtg_imprime_datos_tabla_guardado_generador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_imprime_datos_tabla_CellContentClick);
            this.dtg_imprime_datos_tabla_guardado_generador.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_imprime_datos_tabla_CellContentDoubleClick);
            // 
            // Error_datos_insufucientes
            // 
            this.Error_datos_insufucientes.BlinkRate = 100;
            this.Error_datos_insufucientes.ContainerControl = this;
            // 
            // check_fecha_guardado_generador
            // 
            this.check_fecha_guardado_generador.AutoSize = true;
            this.check_fecha_guardado_generador.Checked = true;
            this.check_fecha_guardado_generador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_fecha_guardado_generador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_fecha_guardado_generador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_fecha_guardado_generador.Location = new System.Drawing.Point(703, 473);
            this.check_fecha_guardado_generador.Margin = new System.Windows.Forms.Padding(2);
            this.check_fecha_guardado_generador.Name = "check_fecha_guardado_generador";
            this.check_fecha_guardado_generador.Size = new System.Drawing.Size(197, 21);
            this.check_fecha_guardado_generador.TabIndex = 49;
            this.check_fecha_guardado_generador.Text = "Añadir fecha de modificación";
            this.check_fecha_guardado_generador.UseVisualStyleBackColor = true;
            this.check_fecha_guardado_generador.Visible = false;
            // 
            // panel_boton_guardar_guardado_generador
            // 
            this.panel_boton_guardar_guardado_generador.Controls.Add(this.picture_boton_guardar);
            this.panel_boton_guardar_guardado_generador.Location = new System.Drawing.Point(192, 362);
            this.panel_boton_guardar_guardado_generador.Name = "panel_boton_guardar_guardado_generador";
            this.panel_boton_guardar_guardado_generador.Size = new System.Drawing.Size(49, 42);
            this.panel_boton_guardar_guardado_generador.TabIndex = 55;
            this.panel_boton_guardar_guardado_generador.Visible = false;
            // 
            // picture_boton_guardar
            // 
            this.picture_boton_guardar.BackgroundImage = global::generador_contraseña.Properties.Resources.disquete;
            this.picture_boton_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_boton_guardar.Location = new System.Drawing.Point(13, 10);
            this.picture_boton_guardar.Name = "picture_boton_guardar";
            this.picture_boton_guardar.Size = new System.Drawing.Size(23, 23);
            this.picture_boton_guardar.TabIndex = 40;
            this.picture_boton_guardar.TabStop = false;
            // 
            // panel_boton_generar
            // 
            this.panel_boton_generar.Controls.Add(this.picture_boton_generar);
            this.panel_boton_generar.Location = new System.Drawing.Point(191, 296);
            this.panel_boton_generar.Name = "panel_boton_generar";
            this.panel_boton_generar.Size = new System.Drawing.Size(43, 42);
            this.panel_boton_generar.TabIndex = 54;
            this.panel_boton_generar.Visible = false;
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
            // panel_modificar_guardado_generador
            // 
            this.panel_modificar_guardado_generador.Controls.Add(this.pictureBox2);
            this.panel_modificar_guardado_generador.Location = new System.Drawing.Point(757, 426);
            this.panel_modificar_guardado_generador.Name = "panel_modificar_guardado_generador";
            this.panel_modificar_guardado_generador.Size = new System.Drawing.Size(43, 42);
            this.panel_modificar_guardado_generador.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::generador_contraseña.Properties.Resources.lapiz;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // panel_central_guardado_generar
            // 
            this.panel_central_guardado_generar.Controls.Add(this.check_fecha_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.panel_boton_guardar_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.panel_boton_generar);
            this.panel_central_guardado_generar.Controls.Add(this.panel_modificar_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.progress_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.btn_modificar);
            this.panel_central_guardado_generar.Controls.Add(this.panel_nuevo_nombre_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.panel_nueva_contra_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.panel_cifras_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.picture_linea_generar);
            this.panel_central_guardado_generar.Controls.Add(this.panel_superior_guardado_generar);
            this.panel_central_guardado_generar.Controls.Add(this.btn_guardar_modificacion);
            this.panel_central_guardado_generar.Controls.Add(this.Generar_contraseña_modificada);
            this.panel_central_guardado_generar.Controls.Add(this.checkBox_generador_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.lb_nombre_contrasena_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.lb_contraseña_nueva_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.lb_cantidad_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.num_cifras);
            this.panel_central_guardado_generar.Controls.Add(this.lb_fuerte_debil_guardado_generador);
            this.panel_central_guardado_generar.Controls.Add(this.txt_nombre_contrasena);
            this.panel_central_guardado_generar.Controls.Add(this.txt_contraseña);
            this.panel_central_guardado_generar.Controls.Add(this.dtg_imprime_datos_tabla_guardado_generador);
            this.panel_central_guardado_generar.Location = new System.Drawing.Point(-3, 0);
            this.panel_central_guardado_generar.Name = "panel_central_guardado_generar";
            this.panel_central_guardado_generar.Size = new System.Drawing.Size(933, 516);
            this.panel_central_guardado_generar.TabIndex = 58;
            // 
            // panel_nuevo_nombre_guardado_generador
            // 
            this.panel_nuevo_nombre_guardado_generador.Location = new System.Drawing.Point(63, 206);
            this.panel_nuevo_nombre_guardado_generador.Name = "panel_nuevo_nombre_guardado_generador";
            this.panel_nuevo_nombre_guardado_generador.Size = new System.Drawing.Size(147, 3);
            this.panel_nuevo_nombre_guardado_generador.TabIndex = 60;
            this.panel_nuevo_nombre_guardado_generador.Visible = false;
            // 
            // panel_nueva_contra_guardado_generador
            // 
            this.panel_nueva_contra_guardado_generador.Location = new System.Drawing.Point(305, 206);
            this.panel_nueva_contra_guardado_generador.Name = "panel_nueva_contra_guardado_generador";
            this.panel_nueva_contra_guardado_generador.Size = new System.Drawing.Size(147, 3);
            this.panel_nueva_contra_guardado_generador.TabIndex = 59;
            this.panel_nueva_contra_guardado_generador.Visible = false;
            // 
            // panel_cifras_guardado_generador
            // 
            this.panel_cifras_guardado_generador.Location = new System.Drawing.Point(244, 167);
            this.panel_cifras_guardado_generador.Name = "panel_cifras_guardado_generador";
            this.panel_cifras_guardado_generador.Size = new System.Drawing.Size(37, 3);
            this.panel_cifras_guardado_generador.TabIndex = 58;
            this.panel_cifras_guardado_generador.Visible = false;
            // 
            // picture_linea_generar
            // 
            this.picture_linea_generar.BackgroundImage = global::generador_contraseña.Properties.Resources.menos_linea_recta_horizontal1;
            this.picture_linea_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_linea_generar.Location = new System.Drawing.Point(3, 34);
            this.picture_linea_generar.Name = "picture_linea_generar";
            this.picture_linea_generar.Size = new System.Drawing.Size(915, 10);
            this.picture_linea_generar.TabIndex = 57;
            this.picture_linea_generar.TabStop = false;
            // 
            // panel_superior_guardado_generar
            // 
            this.panel_superior_guardado_generar.Controls.Add(this.picture_salida);
            this.panel_superior_guardado_generar.Controls.Add(this.label_menu);
            this.panel_superior_guardado_generar.Controls.Add(this.picture_regresar);
            this.panel_superior_guardado_generar.Location = new System.Drawing.Point(3, 0);
            this.panel_superior_guardado_generar.Name = "panel_superior_guardado_generar";
            this.panel_superior_guardado_generar.Size = new System.Drawing.Size(915, 28);
            this.panel_superior_guardado_generar.TabIndex = 56;
            // 
            // picture_salida
            // 
            this.picture_salida.BackgroundImage = global::generador_contraseña.Properties.Resources.cerrar;
            this.picture_salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_salida.Location = new System.Drawing.Point(882, 7);
            this.picture_salida.Name = "picture_salida";
            this.picture_salida.Size = new System.Drawing.Size(15, 15);
            this.picture_salida.TabIndex = 37;
            this.picture_salida.TabStop = false;
            this.picture_salida.Click += new System.EventHandler(this.picture_salida_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_menu.Location = new System.Drawing.Point(12, 3);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(198, 23);
            this.label_menu.TabIndex = 36;
            this.label_menu.Text = "Contraseñas Guardadas";
            // 
            // picture_regresar
            // 
            this.picture_regresar.BackgroundImage = global::generador_contraseña.Properties.Resources.volver;
            this.picture_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_regresar.Location = new System.Drawing.Point(856, 5);
            this.picture_regresar.Name = "picture_regresar";
            this.picture_regresar.Size = new System.Drawing.Size(17, 17);
            this.picture_regresar.TabIndex = 35;
            this.picture_regresar.TabStop = false;
            this.picture_regresar.Click += new System.EventHandler(this.picture_regresar_Click_1);
            // 
            // progress_guardado_generador
            // 
            this.progress_guardado_generador.Location = new System.Drawing.Point(305, 215);
            this.progress_guardado_generador.Name = "progress_guardado_generador";
            this.progress_guardado_generador.Size = new System.Drawing.Size(147, 13);
            this.progress_guardado_generador.TabIndex = 61;
            this.progress_guardado_generador.Visible = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_modificar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_modificar.BorderRadius = 0;
            this.btn_modificar.BorderSize = 0;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.ImageKey = "(ninguno)";
            this.btn_modificar.Location = new System.Drawing.Point(780, 426);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(120, 42);
            this.btn_modificar.TabIndex = 56;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextColor = System.Drawing.Color.White;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.boton_modificar_banco_Click);
            // 
            // btn_guardar_modificacion
            // 
            this.btn_guardar_modificacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_guardar_modificacion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_guardar_modificacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_guardar_modificacion.BorderRadius = 0;
            this.btn_guardar_modificacion.BorderSize = 0;
            this.btn_guardar_modificacion.FlatAppearance.BorderSize = 0;
            this.btn_guardar_modificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_modificacion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_modificacion.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_modificacion.ImageKey = "(ninguno)";
            this.btn_guardar_modificacion.Location = new System.Drawing.Point(208, 362);
            this.btn_guardar_modificacion.Name = "btn_guardar_modificacion";
            this.btn_guardar_modificacion.Size = new System.Drawing.Size(126, 42);
            this.btn_guardar_modificacion.TabIndex = 53;
            this.btn_guardar_modificacion.Text = "Guardar";
            this.btn_guardar_modificacion.TextColor = System.Drawing.Color.White;
            this.btn_guardar_modificacion.UseVisualStyleBackColor = false;
            this.btn_guardar_modificacion.Visible = false;
            this.btn_guardar_modificacion.Click += new System.EventHandler(this.boton_guardar_generar_Click);
            // 
            // Generar_contraseña_modificada
            // 
            this.Generar_contraseña_modificada.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Generar_contraseña_modificada.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Generar_contraseña_modificada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Generar_contraseña_modificada.BorderRadius = 0;
            this.Generar_contraseña_modificada.BorderSize = 0;
            this.Generar_contraseña_modificada.FlatAppearance.BorderSize = 0;
            this.Generar_contraseña_modificada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generar_contraseña_modificada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar_contraseña_modificada.ForeColor = System.Drawing.Color.White;
            this.Generar_contraseña_modificada.ImageKey = "(ninguno)";
            this.Generar_contraseña_modificada.Location = new System.Drawing.Point(214, 296);
            this.Generar_contraseña_modificada.Name = "Generar_contraseña_modificada";
            this.Generar_contraseña_modificada.Size = new System.Drawing.Size(120, 42);
            this.Generar_contraseña_modificada.TabIndex = 52;
            this.Generar_contraseña_modificada.Text = "Generar Contraseña";
            this.Generar_contraseña_modificada.TextColor = System.Drawing.Color.White;
            this.Generar_contraseña_modificada.UseVisualStyleBackColor = false;
            this.Generar_contraseña_modificada.Visible = false;
            this.Generar_contraseña_modificada.Click += new System.EventHandler(this.Generar_contraseña_modificadaa_Click);
            // 
            // guardado_generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 513);
            this.Controls.Add(this.panel_central_guardado_generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "guardado_generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "guardado_generador";
            this.Load += new System.EventHandler(this.guardado_generador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_imprime_datos_tabla_guardado_generador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_datos_insufucientes)).EndInit();
            this.panel_boton_guardar_guardado_generador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_guardar)).EndInit();
            this.panel_boton_generar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_boton_generar)).EndInit();
            this.panel_modificar_guardado_generador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_central_guardado_generar.ResumeLayout(false);
            this.panel_central_guardado_generar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_generar)).EndInit();
            this.panel_superior_guardado_generar.ResumeLayout(false);
            this.panel_superior_guardado_generar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_generador_guardado_generador;
        private System.Windows.Forms.Label lb_nombre_contrasena_guardado_generador;
        private System.Windows.Forms.Label lb_contraseña_nueva_guardado_generador;
        private System.Windows.Forms.Label lb_cantidad_guardado_generador;
        private System.Windows.Forms.TextBox num_cifras;
        private System.Windows.Forms.Label lb_fuerte_debil_guardado_generador;
        private System.Windows.Forms.TextBox txt_nombre_contrasena;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.DataGridView dtg_imprime_datos_tabla_guardado_generador;
        private System.Windows.Forms.ErrorProvider Error_datos_insufucientes;
        private System.Windows.Forms.CheckBox check_fecha_guardado_generador;
        private System.Windows.Forms.Panel panel_boton_guardar_guardado_generador;
        private System.Windows.Forms.PictureBox picture_boton_guardar;
        private System.Windows.Forms.Panel panel_boton_generar;
        private System.Windows.Forms.PictureBox picture_boton_generar;
        private Class_new_buttons btn_guardar_modificacion;
        private Class_new_buttons Generar_contraseña_modificada;
        private System.Windows.Forms.Panel panel_modificar_guardado_generador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Class_new_buttons btn_modificar;
        private System.Windows.Forms.Panel panel_central_guardado_generar;
        private System.Windows.Forms.PictureBox picture_linea_generar;
        private System.Windows.Forms.Panel panel_superior_guardado_generar;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.PictureBox picture_regresar;
        private System.Windows.Forms.PictureBox picture_salida;
        private System.Windows.Forms.Panel panel_cifras_guardado_generador;
        private System.Windows.Forms.Panel panel_nuevo_nombre_guardado_generador;
        private System.Windows.Forms.Panel panel_nueva_contra_guardado_generador;
        private System.Windows.Forms.ProgressBar progress_guardado_generador;
    }
}