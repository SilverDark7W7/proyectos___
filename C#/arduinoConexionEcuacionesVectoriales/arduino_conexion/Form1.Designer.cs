
namespace arduino_conexion
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
            this.txt_Cx = new System.Windows.Forms.TextBox();
            this.txt_Cy = new System.Windows.Forms.TextBox();
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_y = new System.Windows.Forms.Label();
            this.lb_ecu = new System.Windows.Forms.Label();
            this.txt_ecuacion = new System.Windows.Forms.TextBox();
            this.btn_ecuacion = new System.Windows.Forms.Button();
            this.btn_vectores = new System.Windows.Forms.Button();
            this.btn_formular_ecua = new System.Windows.Forms.Button();
            this.btn_formular_x_y = new System.Windows.Forms.Button();
            this.MagnitudLabel = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.ResultadoXLabel = new System.Windows.Forms.Label();
            this.ResultadoYLabel = new System.Windows.Forms.Label();
            this.combox_menu_cord = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_vec_ecu = new System.Windows.Forms.Label();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.lb_puntos = new System.Windows.Forms.Label();
            this.erro_matriz = new System.Windows.Forms.ErrorProvider(this.components);
            this.tiempo_error = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erro_matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Cx
            // 
            this.txt_Cx.Location = new System.Drawing.Point(271, 169);
            this.txt_Cx.Name = "txt_Cx";
            this.txt_Cx.Size = new System.Drawing.Size(100, 26);
            this.txt_Cx.TabIndex = 0;
            this.txt_Cx.Visible = false;
            // 
            // txt_Cy
            // 
            this.txt_Cy.Location = new System.Drawing.Point(392, 169);
            this.txt_Cy.Name = "txt_Cy";
            this.txt_Cy.Size = new System.Drawing.Size(100, 26);
            this.txt_Cy.TabIndex = 1;
            this.txt_Cy.Visible = false;
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(267, 137);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(93, 20);
            this.lb_x.TabIndex = 2;
            this.lb_x.Text = "Vector en X";
            this.lb_x.Visible = false;
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Location = new System.Drawing.Point(399, 137);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(93, 20);
            this.lb_y.TabIndex = 3;
            this.lb_y.Text = "Vector en Y";
            this.lb_y.Visible = false;
            // 
            // lb_ecu
            // 
            this.lb_ecu.AutoSize = true;
            this.lb_ecu.Location = new System.Drawing.Point(263, 74);
            this.lb_ecu.Name = "lb_ecu";
            this.lb_ecu.Size = new System.Drawing.Size(168, 20);
            this.lb_ecu.TabIndex = 4;
            this.lb_ecu.Text = "Vector datos ecuacion";
            this.lb_ecu.Visible = false;
            this.lb_ecu.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_ecuacion
            // 
            this.txt_ecuacion.Location = new System.Drawing.Point(267, 97);
            this.txt_ecuacion.Name = "txt_ecuacion";
            this.txt_ecuacion.Size = new System.Drawing.Size(164, 26);
            this.txt_ecuacion.TabIndex = 5;
            this.txt_ecuacion.Visible = false;
            // 
            // btn_ecuacion
            // 
            this.btn_ecuacion.Location = new System.Drawing.Point(53, 73);
            this.btn_ecuacion.Name = "btn_ecuacion";
            this.btn_ecuacion.Size = new System.Drawing.Size(126, 50);
            this.btn_ecuacion.TabIndex = 6;
            this.btn_ecuacion.Text = "Ecuacion";
            this.btn_ecuacion.UseVisualStyleBackColor = true;
            this.btn_ecuacion.Click += new System.EventHandler(this.btn_ecuacion_Click);
            // 
            // btn_vectores
            // 
            this.btn_vectores.Location = new System.Drawing.Point(53, 145);
            this.btn_vectores.Name = "btn_vectores";
            this.btn_vectores.Size = new System.Drawing.Size(126, 50);
            this.btn_vectores.TabIndex = 7;
            this.btn_vectores.Text = "vectores x y";
            this.btn_vectores.UseVisualStyleBackColor = true;
            this.btn_vectores.Click += new System.EventHandler(this.btn_vectores_Click);
            // 
            // btn_formular_ecua
            // 
            this.btn_formular_ecua.Location = new System.Drawing.Point(323, 219);
            this.btn_formular_ecua.Name = "btn_formular_ecua";
            this.btn_formular_ecua.Size = new System.Drawing.Size(126, 50);
            this.btn_formular_ecua.TabIndex = 8;
            this.btn_formular_ecua.Text = "formular";
            this.btn_formular_ecua.UseVisualStyleBackColor = true;
            this.btn_formular_ecua.Visible = false;
            this.btn_formular_ecua.Click += new System.EventHandler(this.btn_formular_ecua_Click);
            // 
            // btn_formular_x_y
            // 
            this.btn_formular_x_y.Location = new System.Drawing.Point(323, 219);
            this.btn_formular_x_y.Name = "btn_formular_x_y";
            this.btn_formular_x_y.Size = new System.Drawing.Size(126, 50);
            this.btn_formular_x_y.TabIndex = 9;
            this.btn_formular_x_y.Text = "formular";
            this.btn_formular_x_y.UseVisualStyleBackColor = true;
            this.btn_formular_x_y.Visible = false;
            this.btn_formular_x_y.Click += new System.EventHandler(this.btn_formular_x_y_Click);
            // 
            // MagnitudLabel
            // 
            this.MagnitudLabel.AutoSize = true;
            this.MagnitudLabel.Location = new System.Drawing.Point(270, 348);
            this.MagnitudLabel.Name = "MagnitudLabel";
            this.MagnitudLabel.Size = new System.Drawing.Size(83, 20);
            this.MagnitudLabel.TabIndex = 10;
            this.MagnitudLabel.Text = "Magnitud: ";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Location = new System.Drawing.Point(270, 368);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(79, 20);
            this.DireccionLabel.TabIndex = 11;
            this.DireccionLabel.Text = "Dirección:";
            // 
            // ResultadoXLabel
            // 
            this.ResultadoXLabel.AutoSize = true;
            this.ResultadoXLabel.Location = new System.Drawing.Point(270, 388);
            this.ResultadoXLabel.Name = "ResultadoXLabel";
            this.ResultadoXLabel.Size = new System.Drawing.Size(127, 20);
            this.ResultadoXLabel.TabIndex = 12;
            this.ResultadoXLabel.Text = "Resultado en X: ";
            // 
            // ResultadoYLabel
            // 
            this.ResultadoYLabel.AutoSize = true;
            this.ResultadoYLabel.Location = new System.Drawing.Point(270, 408);
            this.ResultadoYLabel.Name = "ResultadoYLabel";
            this.ResultadoYLabel.Size = new System.Drawing.Size(127, 20);
            this.ResultadoYLabel.TabIndex = 13;
            this.ResultadoYLabel.Text = "Resultado en Y: ";
            // 
            // combox_menu_cord
            // 
            this.combox_menu_cord.FormattingEnabled = true;
            this.combox_menu_cord.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.combox_menu_cord.Location = new System.Drawing.Point(462, 95);
            this.combox_menu_cord.Name = "combox_menu_cord";
            this.combox_menu_cord.Size = new System.Drawing.Size(121, 28);
            this.combox_menu_cord.TabIndex = 14;
            this.combox_menu_cord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plano";
            this.label1.Visible = false;
            // 
            // lb_vec_ecu
            // 
            this.lb_vec_ecu.AutoSize = true;
            this.lb_vec_ecu.Location = new System.Drawing.Point(270, 328);
            this.lb_vec_ecu.Name = "lb_vec_ecu";
            this.lb_vec_ecu.Size = new System.Drawing.Size(83, 20);
            this.lb_vec_ecu.TabIndex = 16;
            this.lb_vec_ecu.Text = "Ecuacion: ";
            this.lb_vec_ecu.Visible = false;
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(53, 219);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(126, 50);
            this.btn_graficar.TabIndex = 17;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = true;
            this.btn_graficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_puntos
            // 
            this.lb_puntos.AutoSize = true;
            this.lb_puntos.Location = new System.Drawing.Point(270, 308);
            this.lb_puntos.Name = "lb_puntos";
            this.lb_puntos.Size = new System.Drawing.Size(67, 20);
            this.lb_puntos.TabIndex = 18;
            this.lb_puntos.Text = "Puntos: ";
            this.lb_puntos.Visible = false;
            // 
            // erro_matriz
            // 
            this.erro_matriz.ContainerControl = this;
            // 
            // tiempo_error
            // 
            this.tiempo_error.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_puntos);
            this.Controls.Add(this.btn_graficar);
            this.Controls.Add(this.lb_vec_ecu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_menu_cord);
            this.Controls.Add(this.ResultadoYLabel);
            this.Controls.Add(this.ResultadoXLabel);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.MagnitudLabel);
            this.Controls.Add(this.btn_formular_x_y);
            this.Controls.Add(this.btn_formular_ecua);
            this.Controls.Add(this.btn_vectores);
            this.Controls.Add(this.btn_ecuacion);
            this.Controls.Add(this.txt_ecuacion);
            this.Controls.Add(this.lb_ecu);
            this.Controls.Add(this.lb_y);
            this.Controls.Add(this.lb_x);
            this.Controls.Add(this.txt_Cy);
            this.Controls.Add(this.txt_Cx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erro_matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cx;
        private System.Windows.Forms.TextBox txt_Cy;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.Label lb_ecu;
        private System.Windows.Forms.TextBox txt_ecuacion;
        private System.Windows.Forms.Button btn_ecuacion;
        private System.Windows.Forms.Button btn_vectores;
        private System.Windows.Forms.Button btn_formular_ecua;
        private System.Windows.Forms.Button btn_formular_x_y;
        private System.Windows.Forms.Label MagnitudLabel;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label ResultadoXLabel;
        private System.Windows.Forms.Label ResultadoYLabel;
        private System.Windows.Forms.ComboBox combox_menu_cord;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_vec_ecu;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.Label lb_puntos;
        private System.Windows.Forms.ErrorProvider erro_matriz;
        private System.Windows.Forms.Timer tiempo_error;
    }
}

