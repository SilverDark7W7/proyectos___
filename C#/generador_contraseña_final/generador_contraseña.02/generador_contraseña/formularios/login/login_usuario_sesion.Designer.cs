
namespace generador_contraseña
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_cerrar_login = new System.Windows.Forms.Button();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.label_registro = new System.Windows.Forms.Label();
            this.linkLabel_olvido = new System.Windows.Forms.LinkLabel();
            this.ptxt_usuario = new System.Windows.Forms.Panel();
            this.ptxt_contrasena = new System.Windows.Forms.Panel();
            this.label_user_contra_error = new System.Windows.Forms.Label();
            this.panel_central = new System.Windows.Forms.Panel();
            this.pb1 = new System.Windows.Forms.Panel();
            this.picturebox_ocultar = new System.Windows.Forms.PictureBox();
            this.picturebox_linea = new System.Windows.Forms.PictureBox();
            this.picturebox_perfil = new System.Windows.Forms.PictureBox();
            this.picturebox_mostrar = new System.Windows.Forms.PictureBox();
            this.panel_central.SuspendLayout();
            this.pb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_linea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrar.Location = new System.Drawing.Point(58, 260);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(105, 37);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "CONFIRMAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            this.btn_entrar.Enter += new System.EventHandler(this.btn_entrar_Enter);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_contrasena.Location = new System.Drawing.Point(12, 72);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '⁕';
            this.txt_contrasena.Size = new System.Drawing.Size(110, 16);
            this.txt_contrasena.TabIndex = 18;
            this.txt_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contrasena.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_contrasena.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_usuario.Location = new System.Drawing.Point(12, 19);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(110, 16);
            this.txt_usuario.TabIndex = 19;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btn_cerrar_login
            // 
            this.btn_cerrar_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar_login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar_login.Location = new System.Drawing.Point(175, 260);
            this.btn_cerrar_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar_login.Name = "btn_cerrar_login";
            this.btn_cerrar_login.Size = new System.Drawing.Size(105, 37);
            this.btn_cerrar_login.TabIndex = 20;
            this.btn_cerrar_login.Text = "CERRAR";
            this.btn_cerrar_login.UseVisualStyleBackColor = true;
            this.btn_cerrar_login.Click += new System.EventHandler(this.btn_cerrar_login_Click);
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lb_contraseña.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_contraseña.Location = new System.Drawing.Point(9, 53);
            this.lb_contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(81, 17);
            this.lb_contraseña.TabIndex = 28;
            this.lb_contraseña.Text = "Contraseña";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuario.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_usuario.Location = new System.Drawing.Point(9, 0);
            this.lb_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(57, 17);
            this.lb_usuario.TabIndex = 27;
            this.lb_usuario.Text = "Usuario";
            // 
            // label_registro
            // 
            this.label_registro.AutoSize = true;
            this.label_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_registro.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registro.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_registro.Location = new System.Drawing.Point(115, 316);
            this.label_registro.Name = "label_registro";
            this.label_registro.Size = new System.Drawing.Size(106, 17);
            this.label_registro.TabIndex = 30;
            this.label_registro.Text = "REGISTRARSE";
            this.label_registro.Click += new System.EventHandler(this.label_registro_Click);
            // 
            // linkLabel_olvido
            // 
            this.linkLabel_olvido.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_olvido.AutoSize = true;
            this.linkLabel_olvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_olvido.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.linkLabel_olvido.LinkColor = System.Drawing.SystemColors.InactiveCaption;
            this.linkLabel_olvido.Location = new System.Drawing.Point(92, 357);
            this.linkLabel_olvido.Name = "linkLabel_olvido";
            this.linkLabel_olvido.Size = new System.Drawing.Size(149, 13);
            this.linkLabel_olvido.TabIndex = 32;
            this.linkLabel_olvido.TabStop = true;
            this.linkLabel_olvido.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel_olvido.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.linkLabel_olvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_olvido_LinkClicked);
            // 
            // ptxt_usuario
            // 
            this.ptxt_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.ptxt_usuario.Location = new System.Drawing.Point(12, 33);
            this.ptxt_usuario.Name = "ptxt_usuario";
            this.ptxt_usuario.Size = new System.Drawing.Size(110, 3);
            this.ptxt_usuario.TabIndex = 33;
            // 
            // ptxt_contrasena
            // 
            this.ptxt_contrasena.BackColor = System.Drawing.SystemColors.Control;
            this.ptxt_contrasena.Location = new System.Drawing.Point(12, 85);
            this.ptxt_contrasena.Name = "ptxt_contrasena";
            this.ptxt_contrasena.Size = new System.Drawing.Size(110, 3);
            this.ptxt_contrasena.TabIndex = 34;
            // 
            // label_user_contra_error
            // 
            this.label_user_contra_error.AutoSize = true;
            this.label_user_contra_error.BackColor = System.Drawing.Color.Transparent;
            this.label_user_contra_error.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_contra_error.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_user_contra_error.Location = new System.Drawing.Point(62, 235);
            this.label_user_contra_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_user_contra_error.Name = "label_user_contra_error";
            this.label_user_contra_error.Size = new System.Drawing.Size(216, 17);
            this.label_user_contra_error.TabIndex = 35;
            this.label_user_contra_error.Text = "*Usuario o contraseña incorrectos";
            this.label_user_contra_error.Visible = false;
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.ptxt_contrasena);
            this.panel_central.Controls.Add(this.ptxt_usuario);
            this.panel_central.Controls.Add(this.lb_contraseña);
            this.panel_central.Controls.Add(this.lb_usuario);
            this.panel_central.Controls.Add(this.txt_usuario);
            this.panel_central.Controls.Add(this.txt_contrasena);
            this.panel_central.Location = new System.Drawing.Point(104, 132);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(127, 101);
            this.panel_central.TabIndex = 38;
            // 
            // pb1
            // 
            this.pb1.Controls.Add(this.panel_central);
            this.pb1.Controls.Add(this.picturebox_ocultar);
            this.pb1.Controls.Add(this.label_user_contra_error);
            this.pb1.Controls.Add(this.linkLabel_olvido);
            this.pb1.Controls.Add(this.picturebox_linea);
            this.pb1.Controls.Add(this.label_registro);
            this.pb1.Controls.Add(this.picturebox_perfil);
            this.pb1.Controls.Add(this.btn_cerrar_login);
            this.pb1.Controls.Add(this.btn_entrar);
            this.pb1.Controls.Add(this.picturebox_mostrar);
            this.pb1.Location = new System.Drawing.Point(-2, -1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(330, 394);
            this.pb1.TabIndex = 39;
            this.pb1.Paint += new System.Windows.Forms.PaintEventHandler(this.pb1_Paint);
            // 
            // picturebox_ocultar
            // 
            this.picturebox_ocultar.BackgroundImage = global::generador_contraseña.Properties.Resources.ver;
            this.picturebox_ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_ocultar.Location = new System.Drawing.Point(236, 194);
            this.picturebox_ocultar.Name = "picturebox_ocultar";
            this.picturebox_ocultar.Size = new System.Drawing.Size(22, 23);
            this.picturebox_ocultar.TabIndex = 36;
            this.picturebox_ocultar.TabStop = false;
            this.picturebox_ocultar.Click += new System.EventHandler(this.picturebox_ocultar_Click);
            // 
            // picturebox_linea
            // 
            this.picturebox_linea.BackgroundImage = global::generador_contraseña.Properties.Resources.menos_linea_recta_horizontal;
            this.picturebox_linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_linea.Location = new System.Drawing.Point(68, 336);
            this.picturebox_linea.Name = "picturebox_linea";
            this.picturebox_linea.Size = new System.Drawing.Size(201, 9);
            this.picturebox_linea.TabIndex = 31;
            this.picturebox_linea.TabStop = false;
            // 
            // picturebox_perfil
            // 
            this.picturebox_perfil.BackColor = System.Drawing.Color.Transparent;
            this.picturebox_perfil.BackgroundImage = global::generador_contraseña.Properties.Resources.usuario;
            this.picturebox_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_perfil.Location = new System.Drawing.Point(123, 19);
            this.picturebox_perfil.Name = "picturebox_perfil";
            this.picturebox_perfil.Size = new System.Drawing.Size(91, 91);
            this.picturebox_perfil.TabIndex = 29;
            this.picturebox_perfil.TabStop = false;
            // 
            // picturebox_mostrar
            // 
            this.picturebox_mostrar.BackgroundImage = global::generador_contraseña.Properties.Resources.esconder;
            this.picturebox_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_mostrar.Location = new System.Drawing.Point(236, 194);
            this.picturebox_mostrar.Name = "picturebox_mostrar";
            this.picturebox_mostrar.Size = new System.Drawing.Size(22, 23);
            this.picturebox_mostrar.TabIndex = 37;
            this.picturebox_mostrar.TabStop = false;
            this.picturebox_mostrar.Click += new System.EventHandler(this.picturebox_mostrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 393);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.pb1.ResumeLayout(false);
            this.pb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_linea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_mostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_cerrar_login;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.PictureBox picturebox_perfil;
        private System.Windows.Forms.Label label_registro;
        private System.Windows.Forms.LinkLabel linkLabel_olvido;
        private System.Windows.Forms.PictureBox picturebox_linea;
        private System.Windows.Forms.Panel ptxt_usuario;
        private System.Windows.Forms.Panel ptxt_contrasena;
        private System.Windows.Forms.Label label_user_contra_error;
        private System.Windows.Forms.PictureBox picturebox_ocultar;
        private System.Windows.Forms.PictureBox picturebox_mostrar;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Panel pb1;
    }
}