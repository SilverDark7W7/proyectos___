
namespace generador_contraseña
{
    partial class registro_ususario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro_ususario));
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_cell = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.panel_central_registro = new System.Windows.Forms.Panel();
            this.panel_superior_registro = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picture_linea_registro = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picture_regresar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture2_mostrar = new System.Windows.Forms.PictureBox();
            this.picture2_ocultar = new System.Windows.Forms.PictureBox();
            this.picture1_mostrar = new System.Windows.Forms.PictureBox();
            this.picture1_ocultar = new System.Windows.Forms.PictureBox();
            this.panel_apellido_registro = new System.Windows.Forms.Panel();
            this.panel_telefono_registro = new System.Windows.Forms.Panel();
            this.panel_nu_registro = new System.Windows.Forms.Panel();
            this.panel_contra_registro = new System.Windows.Forms.Panel();
            this.panel_confirmar_registro = new System.Windows.Forms.Panel();
            this.btn_register = new generador_contraseña.Class_new_buttons();
            this.panel_nombre_registro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel_central_registro.SuspendLayout();
            this.panel_superior_registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_registro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1_mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1_ocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_contra
            // 
            this.txt_contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contra.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_contra.Location = new System.Drawing.Point(352, 157);
            this.txt_contra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(137, 18);
            this.txt_contra.TabIndex = 1;
            this.txt_contra.Text = "Contraseña";
            this.txt_contra.Click += new System.EventHandler(this.txt_contra_Click);
            this.txt_contra.TextChanged += new System.EventHandler(this.txt_contra_TextChanged);
            this.txt_contra.Leave += new System.EventHandler(this.txt_contra_Leave);
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_user.Location = new System.Drawing.Point(352, 115);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(137, 18);
            this.txt_user.TabIndex = 2;
            this.txt_user.Text = "Nombre Usuario";
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_confirmar.Location = new System.Drawing.Point(352, 194);
            this.txt_confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.Size = new System.Drawing.Size(137, 18);
            this.txt_confirmar.TabIndex = 5;
            this.txt_confirmar.Text = "Confirmar Contraseña";
            this.txt_confirmar.Click += new System.EventHandler(this.txt_confirmar_Click);
            this.txt_confirmar.TextChanged += new System.EventHandler(this.txt_confirmar_TextChanged);
            this.txt_confirmar.Leave += new System.EventHandler(this.txt_confirmar_Leave);
            // 
            // error
            // 
            this.error.BlinkRate = 100;
            this.error.ContainerControl = this;
            // 
            // txt_cell
            // 
            this.txt_cell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cell.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cell.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_cell.Location = new System.Drawing.Point(145, 194);
            this.txt_cell.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cell.Name = "txt_cell";
            this.txt_cell.Size = new System.Drawing.Size(129, 18);
            this.txt_cell.TabIndex = 10;
            this.txt_cell.Text = "Telefono";
            this.txt_cell.Click += new System.EventHandler(this.txt_cell_Click);
            this.txt_cell.Leave += new System.EventHandler(this.txt_cell_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_nombre.Location = new System.Drawing.Point(145, 115);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(129, 18);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.Click += new System.EventHandler(this.txt_nombre_Click);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_apellido.Location = new System.Drawing.Point(145, 158);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(129, 18);
            this.txt_apellido.TabIndex = 14;
            this.txt_apellido.Text = "Apellido";
            this.txt_apellido.Click += new System.EventHandler(this.txt_apellido_Click);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave);
            // 
            // panel_central_registro
            // 
            this.panel_central_registro.Controls.Add(this.btn_register);
            this.panel_central_registro.Controls.Add(this.panel_confirmar_registro);
            this.panel_central_registro.Controls.Add(this.panel_contra_registro);
            this.panel_central_registro.Controls.Add(this.panel_nu_registro);
            this.panel_central_registro.Controls.Add(this.panel_telefono_registro);
            this.panel_central_registro.Controls.Add(this.panel_apellido_registro);
            this.panel_central_registro.Controls.Add(this.panel_nombre_registro);
            this.panel_central_registro.Controls.Add(this.pictureBox6);
            this.panel_central_registro.Controls.Add(this.picture_linea_registro);
            this.panel_central_registro.Controls.Add(this.panel_superior_registro);
            this.panel_central_registro.Controls.Add(this.picture2_ocultar);
            this.panel_central_registro.Controls.Add(this.picture1_ocultar);
            this.panel_central_registro.Controls.Add(this.txt_apellido);
            this.panel_central_registro.Controls.Add(this.txt_nombre);
            this.panel_central_registro.Controls.Add(this.txt_cell);
            this.panel_central_registro.Controls.Add(this.txt_confirmar);
            this.panel_central_registro.Controls.Add(this.txt_user);
            this.panel_central_registro.Controls.Add(this.txt_contra);
            this.panel_central_registro.Controls.Add(this.picture2_mostrar);
            this.panel_central_registro.Controls.Add(this.picture1_mostrar);
            this.panel_central_registro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_central_registro.Location = new System.Drawing.Point(-2, -1);
            this.panel_central_registro.Name = "panel_central_registro";
            this.panel_central_registro.Size = new System.Drawing.Size(620, 380);
            this.panel_central_registro.TabIndex = 16;
            this.panel_central_registro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_central_registro_Paint);
            // 
            // panel_superior_registro
            // 
            this.panel_superior_registro.Controls.Add(this.pictureBox4);
            this.panel_superior_registro.Controls.Add(this.pictureBox5);
            this.panel_superior_registro.Controls.Add(this.pictureBox2);
            this.panel_superior_registro.Controls.Add(this.pictureBox3);
            this.panel_superior_registro.Controls.Add(this.label_menu);
            this.panel_superior_registro.Controls.Add(this.picture_regresar);
            this.panel_superior_registro.Controls.Add(this.pictureBox1);
            this.panel_superior_registro.Location = new System.Drawing.Point(0, 0);
            this.panel_superior_registro.Name = "panel_superior_registro";
            this.panel_superior_registro.Size = new System.Drawing.Size(620, 34);
            this.panel_superior_registro.TabIndex = 43;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_menu.Location = new System.Drawing.Point(17, 9);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(79, 23);
            this.label_menu.TabIndex = 36;
            this.label_menu.Text = "Registro";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::generador_contraseña.Properties.Resources.programador;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(282, 313);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 54);
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // picture_linea_registro
            // 
            this.picture_linea_registro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_linea_registro.BackgroundImage")));
            this.picture_linea_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_linea_registro.Location = new System.Drawing.Point(-54, 35);
            this.picture_linea_registro.Name = "picture_linea_registro";
            this.picture_linea_registro.Size = new System.Drawing.Size(796, 13);
            this.picture_linea_registro.TabIndex = 44;
            this.picture_linea_registro.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(559, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(582, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(740, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(763, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // picture_regresar
            // 
            this.picture_regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_regresar.BackgroundImage")));
            this.picture_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_regresar.Location = new System.Drawing.Point(931, 7);
            this.picture_regresar.Name = "picture_regresar";
            this.picture_regresar.Size = new System.Drawing.Size(17, 17);
            this.picture_regresar.TabIndex = 35;
            this.picture_regresar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(954, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // picture2_mostrar
            // 
            this.picture2_mostrar.BackgroundImage = global::generador_contraseña.Properties.Resources.esconder;
            this.picture2_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture2_mostrar.Location = new System.Drawing.Point(521, 194);
            this.picture2_mostrar.Name = "picture2_mostrar";
            this.picture2_mostrar.Size = new System.Drawing.Size(22, 23);
            this.picture2_mostrar.TabIndex = 40;
            this.picture2_mostrar.TabStop = false;
            this.picture2_mostrar.Click += new System.EventHandler(this.picture2_mostrar_Click);
            // 
            // picture2_ocultar
            // 
            this.picture2_ocultar.BackgroundImage = global::generador_contraseña.Properties.Resources.ver;
            this.picture2_ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture2_ocultar.Location = new System.Drawing.Point(521, 194);
            this.picture2_ocultar.Name = "picture2_ocultar";
            this.picture2_ocultar.Size = new System.Drawing.Size(22, 23);
            this.picture2_ocultar.TabIndex = 39;
            this.picture2_ocultar.TabStop = false;
            this.picture2_ocultar.Click += new System.EventHandler(this.picture2_ocultar_Click);
            // 
            // picture1_mostrar
            // 
            this.picture1_mostrar.BackgroundImage = global::generador_contraseña.Properties.Resources.esconder;
            this.picture1_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1_mostrar.Location = new System.Drawing.Point(521, 156);
            this.picture1_mostrar.Name = "picture1_mostrar";
            this.picture1_mostrar.Size = new System.Drawing.Size(22, 23);
            this.picture1_mostrar.TabIndex = 38;
            this.picture1_mostrar.TabStop = false;
            this.picture1_mostrar.Click += new System.EventHandler(this.picture1_mostrar_Click);
            // 
            // picture1_ocultar
            // 
            this.picture1_ocultar.BackgroundImage = global::generador_contraseña.Properties.Resources.ver;
            this.picture1_ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1_ocultar.Location = new System.Drawing.Point(521, 156);
            this.picture1_ocultar.Name = "picture1_ocultar";
            this.picture1_ocultar.Size = new System.Drawing.Size(22, 23);
            this.picture1_ocultar.TabIndex = 37;
            this.picture1_ocultar.TabStop = false;
            this.picture1_ocultar.Click += new System.EventHandler(this.picture1_ocultar_Click);
            // 
            // panel_apellido_registro
            // 
            this.panel_apellido_registro.Location = new System.Drawing.Point(145, 176);
            this.panel_apellido_registro.Name = "panel_apellido_registro";
            this.panel_apellido_registro.Size = new System.Drawing.Size(130, 3);
            this.panel_apellido_registro.TabIndex = 47;
            // 
            // panel_telefono_registro
            // 
            this.panel_telefono_registro.Location = new System.Drawing.Point(145, 214);
            this.panel_telefono_registro.Name = "panel_telefono_registro";
            this.panel_telefono_registro.Size = new System.Drawing.Size(130, 3);
            this.panel_telefono_registro.TabIndex = 48;
            // 
            // panel_nu_registro
            // 
            this.panel_nu_registro.Location = new System.Drawing.Point(352, 133);
            this.panel_nu_registro.Name = "panel_nu_registro";
            this.panel_nu_registro.Size = new System.Drawing.Size(137, 3);
            this.panel_nu_registro.TabIndex = 49;
            // 
            // panel_contra_registro
            // 
            this.panel_contra_registro.Location = new System.Drawing.Point(352, 174);
            this.panel_contra_registro.Name = "panel_contra_registro";
            this.panel_contra_registro.Size = new System.Drawing.Size(137, 3);
            this.panel_contra_registro.TabIndex = 50;
            // 
            // panel_confirmar_registro
            // 
            this.panel_confirmar_registro.Location = new System.Drawing.Point(352, 212);
            this.panel_confirmar_registro.Name = "panel_confirmar_registro";
            this.panel_confirmar_registro.Size = new System.Drawing.Size(137, 3);
            this.panel_confirmar_registro.TabIndex = 51;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_register.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_register.BorderRadius = 30;
            this.btn_register.BorderSize = 0;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(203, 246);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(216, 51);
            this.btn_register.TabIndex = 52;
            this.btn_register.Text = "Registrarse";
            this.btn_register.TextColor = System.Drawing.Color.White;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.class_new_buttons1_Click);
            // 
            // panel_nombre_registro
            // 
            this.panel_nombre_registro.Location = new System.Drawing.Point(145, 132);
            this.panel_nombre_registro.Name = "panel_nombre_registro";
            this.panel_nombre_registro.Size = new System.Drawing.Size(130, 3);
            this.panel_nombre_registro.TabIndex = 46;
            // 
            // registro_ususario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 378);
            this.Controls.Add(this.panel_central_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registro_ususario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro_ususario";
            this.Load += new System.EventHandler(this.registro_ususario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel_central_registro.ResumeLayout(false);
            this.panel_central_registro.PerformLayout();
            this.panel_superior_registro.ResumeLayout(false);
            this.panel_superior_registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_linea_registro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1_mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1_ocultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_cell;
        private System.Windows.Forms.Panel panel_central_registro;
        private System.Windows.Forms.PictureBox picture1_ocultar;
        private System.Windows.Forms.PictureBox picture1_mostrar;
        private System.Windows.Forms.PictureBox picture2_mostrar;
        private System.Windows.Forms.PictureBox picture2_ocultar;
        private System.Windows.Forms.Panel panel_superior_registro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.PictureBox picture_regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picture_linea_registro;
        private System.Windows.Forms.Panel panel_confirmar_registro;
        private System.Windows.Forms.Panel panel_contra_registro;
        private System.Windows.Forms.Panel panel_nu_registro;
        private System.Windows.Forms.Panel panel_telefono_registro;
        private System.Windows.Forms.Panel panel_apellido_registro;
        private Class_new_buttons btn_register;
        private System.Windows.Forms.Panel panel_nombre_registro;
    }
}