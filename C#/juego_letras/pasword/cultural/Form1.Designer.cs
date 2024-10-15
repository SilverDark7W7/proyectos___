
namespace cultural
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
            this.btnabrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.control = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.l_segundos = new System.Windows.Forms.Label();
            this.l_minutos = new System.Windows.Forms.Label();
            this.down1 = new System.Windows.Forms.PictureBox();
            this.down2 = new System.Windows.Forms.PictureBox();
            this.up1 = new System.Windows.Forms.PictureBox();
            this.up2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_iniciar_tiempo = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_pausartm = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.Progreso = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.down1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.BackColor = System.Drawing.Color.Black;
            this.btnabrir.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.ForeColor = System.Drawing.Color.DarkGray;
            this.btnabrir.Location = new System.Drawing.Point(12, 12);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(152, 47);
            this.btnabrir.TabIndex = 0;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.Black;
            this.btnsiguiente.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.Color.DarkGray;
            this.btnsiguiente.Location = new System.Drawing.Point(1663, 886);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(198, 62);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = "Siguiente ";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 85F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 208);
            this.label1.TabIndex = 3;
            this.label1.Text = "---";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // control
            // 
            this.control.Enabled = true;
            this.control.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1509, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 117);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tiempo";
            // 
            // l_segundos
            // 
            this.l_segundos.AutoSize = true;
            this.l_segundos.BackColor = System.Drawing.Color.Black;
            this.l_segundos.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.l_segundos.ForeColor = System.Drawing.Color.White;
            this.l_segundos.Location = new System.Drawing.Point(1726, 287);
            this.l_segundos.Name = "l_segundos";
            this.l_segundos.Size = new System.Drawing.Size(154, 122);
            this.l_segundos.TabIndex = 18;
            this.l_segundos.Text = "00";
            this.l_segundos.Click += new System.EventHandler(this.lb1Numero_Click);
            // 
            // l_minutos
            // 
            this.l_minutos.AutoSize = true;
            this.l_minutos.BackColor = System.Drawing.Color.Transparent;
            this.l_minutos.Font = new System.Drawing.Font("Calibri", 75F, System.Drawing.FontStyle.Bold);
            this.l_minutos.ForeColor = System.Drawing.Color.White;
            this.l_minutos.Location = new System.Drawing.Point(1458, 239);
            this.l_minutos.Name = "l_minutos";
            this.l_minutos.Size = new System.Drawing.Size(229, 183);
            this.l_minutos.TabIndex = 19;
            this.l_minutos.Text = "00";
            this.l_minutos.Click += new System.EventHandler(this.l_minutos_Click);
            // 
            // down1
            // 
            this.down1.Image = ((System.Drawing.Image)(resources.GetObject("down1.Image")));
            this.down1.Location = new System.Drawing.Point(1538, 457);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(40, 40);
            this.down1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.down1.TabIndex = 20;
            this.down1.TabStop = false;
            this.down1.Click += new System.EventHandler(this.down1_Click);
            // 
            // down2
            // 
            this.down2.Image = ((System.Drawing.Image)(resources.GetObject("down2.Image")));
            this.down2.Location = new System.Drawing.Point(1784, 457);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(40, 40);
            this.down2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.down2.TabIndex = 21;
            this.down2.TabStop = false;
            this.down2.Click += new System.EventHandler(this.down2_Click);
            // 
            // up1
            // 
            this.up1.Image = ((System.Drawing.Image)(resources.GetObject("up1.Image")));
            this.up1.Location = new System.Drawing.Point(1538, 196);
            this.up1.Name = "up1";
            this.up1.Size = new System.Drawing.Size(40, 40);
            this.up1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.up1.TabIndex = 22;
            this.up1.TabStop = false;
            this.up1.Click += new System.EventHandler(this.up1_Click);
            // 
            // up2
            // 
            this.up2.BackColor = System.Drawing.Color.Transparent;
            this.up2.Image = ((System.Drawing.Image)(resources.GetObject("up2.Image")));
            this.up2.Location = new System.Drawing.Point(1784, 196);
            this.up2.Name = "up2";
            this.up2.Size = new System.Drawing.Size(40, 40);
            this.up2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.up2.TabIndex = 23;
            this.up2.TabStop = false;
            this.up2.Click += new System.EventHandler(this.up2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1662, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 88);
            this.label2.TabIndex = 25;
            this.label2.Text = ":";
            // 
            // btn_iniciar_tiempo
            // 
            this.btn_iniciar_tiempo.BackColor = System.Drawing.Color.Black;
            this.btn_iniciar_tiempo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_tiempo.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_iniciar_tiempo.Location = new System.Drawing.Point(1522, 556);
            this.btn_iniciar_tiempo.Name = "btn_iniciar_tiempo";
            this.btn_iniciar_tiempo.Size = new System.Drawing.Size(152, 47);
            this.btn_iniciar_tiempo.TabIndex = 26;
            this.btn_iniciar_tiempo.Text = "Iniciar";
            this.btn_iniciar_tiempo.UseVisualStyleBackColor = false;
            this.btn_iniciar_tiempo.Click += new System.EventHandler(this.btn_iniciar_tiempo_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Black;
            this.btn_nuevo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.Location = new System.Drawing.Point(1692, 556);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(169, 47);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.Text = "Restablecer";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_pausartm
            // 
            this.btn_pausartm.BackColor = System.Drawing.Color.Black;
            this.btn_pausartm.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pausartm.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_pausartm.Location = new System.Drawing.Point(1522, 555);
            this.btn_pausartm.Name = "btn_pausartm";
            this.btn_pausartm.Size = new System.Drawing.Size(152, 48);
            this.btn_pausartm.TabIndex = 28;
            this.btn_pausartm.Text = "Pausar";
            this.btn_pausartm.UseVisualStyleBackColor = false;
            this.btn_pausartm.Click += new System.EventHandler(this.btn_pausartm_Click);
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // Progreso
            // 
            this.Progreso.Interval = 1000;
            this.Progreso.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(-738, 958);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1041, 56);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(1766, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(1525, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(764, 945);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Promocion 2024 Guzman del cid Jordy Rene ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 100F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(768, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 252);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "00";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(779, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 62);
            this.button1.TabIndex = 36;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(881, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 62);
            this.button2.TabIndex = 37;
            this.button2.Text = "Pausar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(677, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 62);
            this.button3.TabIndex = 38;
            this.button3.Text = "Restablecer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 992);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_iniciar_tiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.up2);
            this.Controls.Add(this.up1);
            this.Controls.Add(this.down2);
            this.Controls.Add(this.down1);
            this.Controls.Add(this.l_minutos);
            this.Controls.Add(this.l_segundos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.btn_pausartm);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pasword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.down1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer control;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_segundos;
        private System.Windows.Forms.Label l_minutos;
        private System.Windows.Forms.PictureBox down1;
        private System.Windows.Forms.PictureBox down2;
        private System.Windows.Forms.PictureBox up1;
        private System.Windows.Forms.PictureBox up2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_iniciar_tiempo;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_pausartm;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Timer Progreso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

