
namespace canculadora
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
            this.menu_operaciones = new System.Windows.Forms.ComboBox();
            this.resultados_datos = new System.Windows.Forms.DataGridView();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_fila = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.txt_cifra2 = new System.Windows.Forms.TextBox();
            this.txt_ciftra1 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultado_modificar = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.id_selecionar = new System.Windows.Forms.TextBox();
            this.selecionar = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.id_modicar = new System.Windows.Forms.TextBox();
            this.menu_modificar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultados_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_operaciones
            // 
            this.menu_operaciones.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_operaciones.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.menu_operaciones.FormattingEnabled = true;
            this.menu_operaciones.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicación",
            "División"});
            this.menu_operaciones.Location = new System.Drawing.Point(239, 90);
            this.menu_operaciones.Margin = new System.Windows.Forms.Padding(2);
            this.menu_operaciones.Name = "menu_operaciones";
            this.menu_operaciones.Size = new System.Drawing.Size(124, 21);
            this.menu_operaciones.TabIndex = 0;
            this.menu_operaciones.SelectedIndexChanged += new System.EventHandler(this.menu_operaciones_SelectedIndexChanged);
            // 
            // resultados_datos
            // 
            this.resultados_datos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultados_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultados_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultados_datos.Location = new System.Drawing.Point(590, 151);
            this.resultados_datos.Margin = new System.Windows.Forms.Padding(2);
            this.resultados_datos.Name = "resultados_datos";
            this.resultados_datos.RowHeadersWidth = 62;
            this.resultados_datos.RowTemplate.Height = 28;
            this.resultados_datos.Size = new System.Drawing.Size(465, 379);
            this.resultados_datos.TabIndex = 3;
            this.resultados_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_resiltados_calculadora_CellContentClick);
            // 
            // btn_resultado
            // 
            this.btn_resultado.BackColor = System.Drawing.Color.Transparent;
            this.btn_resultado.BackgroundImage = global::canculadora.Properties.Resources.imagegris;
            this.btn_resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resultado.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_resultado.Location = new System.Drawing.Point(229, 189);
            this.btn_resultado.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(134, 36);
            this.btn_resultado.TabIndex = 4;
            this.btn_resultado.Text = "OPERAR";
            this.btn_resultado.UseVisualStyleBackColor = false;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::canculadora.Properties.Resources.imagegris;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(307, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "ELIMINAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_fila
            // 
            this.id_fila.BackColor = System.Drawing.Color.DarkCyan;
            this.id_fila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_fila.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.id_fila.Location = new System.Drawing.Point(346, 311);
            this.id_fila.Margin = new System.Windows.Forms.Padding(2);
            this.id_fila.Name = "id_fila";
            this.id_fila.Size = new System.Drawing.Size(61, 20);
            this.id_fila.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.id.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id.Location = new System.Drawing.Point(323, 343);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(104, 16);
            this.id.TabIndex = 13;
            this.id.Text = "ID Fila a eliminar";
            // 
            // txt_cifra2
            // 
            this.txt_cifra2.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_cifra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cifra2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cifra2.Location = new System.Drawing.Point(237, 121);
            this.txt_cifra2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cifra2.Name = "txt_cifra2";
            this.txt_cifra2.Size = new System.Drawing.Size(106, 20);
            this.txt_cifra2.TabIndex = 1;
            this.txt_cifra2.TextChanged += new System.EventHandler(this.txt_cifra2_TextChanged);
            // 
            // txt_ciftra1
            // 
            this.txt_ciftra1.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_ciftra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciftra1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ciftra1.Location = new System.Drawing.Point(79, 121);
            this.txt_ciftra1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ciftra1.Name = "txt_ciftra1";
            this.txt_ciftra1.Size = new System.Drawing.Size(106, 20);
            this.txt_ciftra1.TabIndex = 2;
            this.txt_ciftra1.TextChanged += new System.EventHandler(this.txt_ciftra1_TextChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resultado.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_resultado.Location = new System.Drawing.Point(388, 121);
            this.txt_resultado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(106, 20);
            this.txt_resultado.TabIndex = 5;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(93, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Primera cifra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(246, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Segunda Cifra";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(409, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(398, 573);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(268, 573);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Segunda Cifra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(82, 573);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Primera cifra";
            // 
            // resultado_modificar
            // 
            this.resultado_modificar.BackColor = System.Drawing.Color.DarkCyan;
            this.resultado_modificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado_modificar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.resultado_modificar.Location = new System.Drawing.Point(399, 538);
            this.resultado_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.resultado_modificar.Name = "resultado_modificar";
            this.resultado_modificar.Size = new System.Drawing.Size(65, 20);
            this.resultado_modificar.TabIndex = 16;
            // 
            // numero1
            // 
            this.numero1.BackColor = System.Drawing.Color.DarkCyan;
            this.numero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numero1.Location = new System.Drawing.Point(79, 537);
            this.numero1.Margin = new System.Windows.Forms.Padding(2);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(85, 20);
            this.numero1.TabIndex = 15;
            // 
            // numero2
            // 
            this.numero2.BackColor = System.Drawing.Color.DarkCyan;
            this.numero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numero2.Location = new System.Drawing.Point(271, 537);
            this.numero2.Margin = new System.Windows.Forms.Padding(2);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(85, 20);
            this.numero2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(371, 541);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "=";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::canculadora.Properties.Resources.imagegris;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(125, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "SELECCIONAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(141, 343);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID Fila a mostrar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // id_selecionar
            // 
            this.id_selecionar.BackColor = System.Drawing.Color.DarkCyan;
            this.id_selecionar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_selecionar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.id_selecionar.Location = new System.Drawing.Point(166, 311);
            this.id_selecionar.Margin = new System.Windows.Forms.Padding(2);
            this.id_selecionar.Name = "id_selecionar";
            this.id_selecionar.Size = new System.Drawing.Size(61, 20);
            this.id_selecionar.TabIndex = 23;
            this.id_selecionar.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // selecionar
            // 
            this.selecionar.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.selecionar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selecionar.Location = new System.Drawing.Point(569, 548);
            this.selecionar.Margin = new System.Windows.Forms.Padding(2);
            this.selecionar.Name = "selecionar";
            this.selecionar.RowHeadersWidth = 62;
            this.selecionar.RowTemplate.Height = 28;
            this.selecionar.Size = new System.Drawing.Size(510, 64);
            this.selecionar.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::canculadora.Properties.Resources.imagegris;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(209, 612);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 36);
            this.button3.TabIndex = 26;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(223, 475);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID Fila a modificar";
            // 
            // id_modicar
            // 
            this.id_modicar.BackColor = System.Drawing.Color.DarkCyan;
            this.id_modicar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_modicar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.id_modicar.Location = new System.Drawing.Point(242, 453);
            this.id_modicar.Margin = new System.Windows.Forms.Padding(2);
            this.id_modicar.Name = "id_modicar";
            this.id_modicar.Size = new System.Drawing.Size(79, 20);
            this.id_modicar.TabIndex = 27;
            // 
            // menu_modificar
            // 
            this.menu_modificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_modificar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.menu_modificar.FormattingEnabled = true;
            this.menu_modificar.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicación",
            "División"});
            this.menu_modificar.Location = new System.Drawing.Point(181, 537);
            this.menu_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.menu_modificar.Name = "menu_modificar";
            this.menu_modificar.Size = new System.Drawing.Size(78, 21);
            this.menu_modificar.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(236, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Tipos de Operaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(202, 505);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nuevos datos a ingresar ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(151, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "ACCIONES QUE PUEDE REALIZAR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::canculadora.Properties.Resources.a04c2ea0b5da8085bdbf720c8fbbddd1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1102, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 40);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::canculadora.Properties.Resources.borde;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 40);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::canculadora.Properties.Resources.seg_fondo;
            this.pictureBox2.Location = new System.Drawing.Point(56, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 384);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Puasa Ramadhan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 31);
            this.label14.TabIndex = 37;
            this.label14.Text = "Claculadora  J_001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::canculadora.Properties.Resources.desktop_wallpaper_navy_blue_background_solid_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 683);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menu_modificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.id_modicar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id_selecionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultado_modificar);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.id_fila);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.resultados_datos);
            this.Controls.Add(this.txt_ciftra1);
            this.Controls.Add(this.txt_cifra2);
            this.Controls.Add(this.menu_operaciones);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultados_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menu_operaciones;
        private System.Windows.Forms.DataGridView resultados_datos;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id_fila;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txt_cifra2;
        private System.Windows.Forms.TextBox txt_ciftra1;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultado_modificar;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_selecionar;
        private System.Windows.Forms.DataGridView selecionar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id_modicar;
        private System.Windows.Forms.ComboBox menu_modificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
    }
}

