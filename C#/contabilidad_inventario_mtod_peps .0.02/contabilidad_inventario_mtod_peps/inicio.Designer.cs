
namespace contabilidad_inventario_mtod_peps
{
    partial class inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.txt_venta_cantidad = new System.Windows.Forms.TextBox();
            this.btn_devolucion_sobre_venta = new System.Windows.Forms.Button();
            this.btn_devolucion_sobre_compra = new System.Windows.Forms.Button();
            this.txt_sobre_venta_cantidad = new System.Windows.Forms.TextBox();
            this.btn_saldo_inicial = new System.Windows.Forms.Button();
            this.txt_cantidad_compra = new System.Windows.Forms.TextBox();
            this.txt_compra_costo_unitario = new System.Windows.Forms.TextBox();
            this.txt_sobre_compra_cantidad = new System.Windows.Forms.TextBox();
            this.txt_saldo_costo_unitario = new System.Windows.Forms.TextBox();
            this.txt_saldo_cantidad = new System.Windows.Forms.TextBox();
            this.DTG_datos = new System.Windows.Forms.DataGridView();
            this.btn_ingresar_saldo = new System.Windows.Forms.Button();
            this.btn_ingresar_compra = new System.Windows.Forms.Button();
            this.btn_ingresar_venta = new System.Windows.Forms.Button();
            this.btn_DevoclucionSC = new System.Windows.Forms.Button();
            this.btn_DevolucionSV = new System.Windows.Forms.Button();
            this.txt_devolucion_compra = new System.Windows.Forms.TextBox();
            this.txt_devolucion_venta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.icon_exit = new System.Windows.Forms.PictureBox();
            this.panel_titulo_exis = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_datos)).BeginInit();
            this.panel_central.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_exit)).BeginInit();
            this.panel_titulo_exis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_venta.Location = new System.Drawing.Point(60, 168);
            this.btn_venta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(211, 46);
            this.btn_venta.TabIndex = 0;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compra.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_compra.Location = new System.Drawing.Point(60, 111);
            this.btn_compra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(211, 46);
            this.btn_compra.TabIndex = 1;
            this.btn_compra.Text = "Compra";
            this.btn_compra.UseVisualStyleBackColor = false;
            this.btn_compra.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_venta_cantidad
            // 
            this.txt_venta_cantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_venta_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_venta_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_venta_cantidad.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_venta_cantidad.Location = new System.Drawing.Point(99, 407);
            this.txt_venta_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_venta_cantidad.Name = "txt_venta_cantidad";
            this.txt_venta_cantidad.Size = new System.Drawing.Size(140, 21);
            this.txt_venta_cantidad.TabIndex = 3;
            this.txt_venta_cantidad.Text = "Cantidad";
            this.txt_venta_cantidad.Visible = false;
            this.txt_venta_cantidad.Click += new System.EventHandler(this.txt_venta_cantidad_Click);
            this.txt_venta_cantidad.TextChanged += new System.EventHandler(this.txt_venta_cantidad_TextChanged);
            this.txt_venta_cantidad.Leave += new System.EventHandler(this.txt_venta_cantidad_Leave);
            // 
            // btn_devolucion_sobre_venta
            // 
            this.btn_devolucion_sobre_venta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_devolucion_sobre_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion_sobre_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion_sobre_venta.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_devolucion_sobre_venta.Location = new System.Drawing.Point(60, 225);
            this.btn_devolucion_sobre_venta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_devolucion_sobre_venta.Name = "btn_devolucion_sobre_venta";
            this.btn_devolucion_sobre_venta.Size = new System.Drawing.Size(211, 52);
            this.btn_devolucion_sobre_venta.TabIndex = 4;
            this.btn_devolucion_sobre_venta.Text = "Devoluciones S/venta";
            this.btn_devolucion_sobre_venta.UseVisualStyleBackColor = false;
            this.btn_devolucion_sobre_venta.Click += new System.EventHandler(this.btn_devolucion_sobre_venta_Click);
            // 
            // btn_devolucion_sobre_compra
            // 
            this.btn_devolucion_sobre_compra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_devolucion_sobre_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion_sobre_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion_sobre_compra.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_devolucion_sobre_compra.Location = new System.Drawing.Point(60, 288);
            this.btn_devolucion_sobre_compra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_devolucion_sobre_compra.Name = "btn_devolucion_sobre_compra";
            this.btn_devolucion_sobre_compra.Size = new System.Drawing.Size(211, 52);
            this.btn_devolucion_sobre_compra.TabIndex = 5;
            this.btn_devolucion_sobre_compra.Text = "Devolciones S/compra";
            this.btn_devolucion_sobre_compra.UseVisualStyleBackColor = false;
            this.btn_devolucion_sobre_compra.Click += new System.EventHandler(this.btn_devolucion_sobre_compra_Click);
            // 
            // txt_sobre_venta_cantidad
            // 
            this.txt_sobre_venta_cantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_sobre_venta_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sobre_venta_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobre_venta_cantidad.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_sobre_venta_cantidad.Location = new System.Drawing.Point(99, 407);
            this.txt_sobre_venta_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sobre_venta_cantidad.Name = "txt_sobre_venta_cantidad";
            this.txt_sobre_venta_cantidad.Size = new System.Drawing.Size(140, 21);
            this.txt_sobre_venta_cantidad.TabIndex = 7;
            this.txt_sobre_venta_cantidad.Text = "Cantidad";
            this.txt_sobre_venta_cantidad.Visible = false;
            this.txt_sobre_venta_cantidad.Click += new System.EventHandler(this.txt_sobre_venta_cantidad_Click);
            this.txt_sobre_venta_cantidad.TextChanged += new System.EventHandler(this.txt_sobre_venta_cantidad_TextChanged);
            this.txt_sobre_venta_cantidad.Leave += new System.EventHandler(this.txt_sobre_venta_cantidad_Leave);
            // 
            // btn_saldo_inicial
            // 
            this.btn_saldo_inicial.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_saldo_inicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saldo_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saldo_inicial.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_saldo_inicial.Location = new System.Drawing.Point(60, 52);
            this.btn_saldo_inicial.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saldo_inicial.Name = "btn_saldo_inicial";
            this.btn_saldo_inicial.Size = new System.Drawing.Size(211, 46);
            this.btn_saldo_inicial.TabIndex = 9;
            this.btn_saldo_inicial.Text = "Saldo inicial ";
            this.btn_saldo_inicial.UseVisualStyleBackColor = false;
            this.btn_saldo_inicial.Click += new System.EventHandler(this.btn_saldo_inicial_Click);
            // 
            // txt_cantidad_compra
            // 
            this.txt_cantidad_compra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_cantidad_compra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_compra.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_cantidad_compra.Location = new System.Drawing.Point(31, 375);
            this.txt_cantidad_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad_compra.Name = "txt_cantidad_compra";
            this.txt_cantidad_compra.Size = new System.Drawing.Size(140, 21);
            this.txt_cantidad_compra.TabIndex = 10;
            this.txt_cantidad_compra.Text = "Cantidad";
            this.txt_cantidad_compra.Visible = false;
            this.txt_cantidad_compra.Click += new System.EventHandler(this.txt_cantidad_compra_Click);
            this.txt_cantidad_compra.TextChanged += new System.EventHandler(this.txt_cantidad_compra_TextChanged);
            this.txt_cantidad_compra.Leave += new System.EventHandler(this.txt_cantidad_compra_Leave);
            // 
            // txt_compra_costo_unitario
            // 
            this.txt_compra_costo_unitario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_compra_costo_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_compra_costo_unitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compra_costo_unitario.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_compra_costo_unitario.Location = new System.Drawing.Point(179, 375);
            this.txt_compra_costo_unitario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_compra_costo_unitario.Name = "txt_compra_costo_unitario";
            this.txt_compra_costo_unitario.Size = new System.Drawing.Size(140, 21);
            this.txt_compra_costo_unitario.TabIndex = 11;
            this.txt_compra_costo_unitario.Text = "Costo";
            this.txt_compra_costo_unitario.Visible = false;
            this.txt_compra_costo_unitario.Click += new System.EventHandler(this.txt_compra_costo_unitario_Click);
            this.txt_compra_costo_unitario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_compra_costo_unitario.Leave += new System.EventHandler(this.txt_compra_costo_unitario_Leave);
            // 
            // txt_sobre_compra_cantidad
            // 
            this.txt_sobre_compra_cantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_sobre_compra_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sobre_compra_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobre_compra_cantidad.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_sobre_compra_cantidad.Location = new System.Drawing.Point(99, 407);
            this.txt_sobre_compra_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sobre_compra_cantidad.Name = "txt_sobre_compra_cantidad";
            this.txt_sobre_compra_cantidad.Size = new System.Drawing.Size(140, 21);
            this.txt_sobre_compra_cantidad.TabIndex = 12;
            this.txt_sobre_compra_cantidad.Text = "Cantidad";
            this.txt_sobre_compra_cantidad.Visible = false;
            this.txt_sobre_compra_cantidad.Click += new System.EventHandler(this.txt_sobre_compra_cantidad_Click);
            this.txt_sobre_compra_cantidad.TextChanged += new System.EventHandler(this.txt_sobre_compra_cantidad_TextChanged);
            this.txt_sobre_compra_cantidad.Leave += new System.EventHandler(this.txt_sobre_compra_cantidad_Leave);
            // 
            // txt_saldo_costo_unitario
            // 
            this.txt_saldo_costo_unitario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_saldo_costo_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_saldo_costo_unitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo_costo_unitario.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_saldo_costo_unitario.Location = new System.Drawing.Point(179, 375);
            this.txt_saldo_costo_unitario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_saldo_costo_unitario.Name = "txt_saldo_costo_unitario";
            this.txt_saldo_costo_unitario.Size = new System.Drawing.Size(140, 21);
            this.txt_saldo_costo_unitario.TabIndex = 16;
            this.txt_saldo_costo_unitario.Text = "Costo";
            this.txt_saldo_costo_unitario.Visible = false;
            this.txt_saldo_costo_unitario.Click += new System.EventHandler(this.txt_saldo_costo_unitario_Click);
            this.txt_saldo_costo_unitario.TextChanged += new System.EventHandler(this.txt_saldo_costo_unitario_TextChanged);
            this.txt_saldo_costo_unitario.Leave += new System.EventHandler(this.txt_saldo_costo_unitario_Leave);
            // 
            // txt_saldo_cantidad
            // 
            this.txt_saldo_cantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_saldo_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_saldo_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo_cantidad.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_saldo_cantidad.Location = new System.Drawing.Point(31, 375);
            this.txt_saldo_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_saldo_cantidad.Name = "txt_saldo_cantidad";
            this.txt_saldo_cantidad.Size = new System.Drawing.Size(140, 21);
            this.txt_saldo_cantidad.TabIndex = 15;
            this.txt_saldo_cantidad.Text = "Cantidad";
            this.txt_saldo_cantidad.Visible = false;
            this.txt_saldo_cantidad.Click += new System.EventHandler(this.txt_saldo_cantidad_Click);
            this.txt_saldo_cantidad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_saldo_cantidad.Leave += new System.EventHandler(this.txt_saldo_cantidad_Leave);
            // 
            // DTG_datos
            // 
            this.DTG_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTG_datos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DTG_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTG_datos.ColumnHeadersHeight = 37;
            this.DTG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_datos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTG_datos.EnableHeadersVisualStyles = false;
            this.DTG_datos.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DTG_datos.Location = new System.Drawing.Point(25, 129);
            this.DTG_datos.Margin = new System.Windows.Forms.Padding(2);
            this.DTG_datos.Name = "DTG_datos";
            this.DTG_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTG_datos.RowHeadersVisible = false;
            this.DTG_datos.RowHeadersWidth = 62;
            this.DTG_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DTG_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DTG_datos.RowTemplate.Height = 28;
            this.DTG_datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DTG_datos.Size = new System.Drawing.Size(670, 313);
            this.DTG_datos.TabIndex = 13;
            // 
            // btn_ingresar_saldo
            // 
            this.btn_ingresar_saldo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ingresar_saldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_saldo.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_ingresar_saldo.Location = new System.Drawing.Point(497, 450);
            this.btn_ingresar_saldo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar_saldo.Name = "btn_ingresar_saldo";
            this.btn_ingresar_saldo.Size = new System.Drawing.Size(186, 26);
            this.btn_ingresar_saldo.TabIndex = 17;
            this.btn_ingresar_saldo.Text = "Ingresar saldo";
            this.btn_ingresar_saldo.UseVisualStyleBackColor = false;
            this.btn_ingresar_saldo.Visible = false;
            this.btn_ingresar_saldo.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_ingresar_compra
            // 
            this.btn_ingresar_compra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ingresar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_compra.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_ingresar_compra.Location = new System.Drawing.Point(497, 450);
            this.btn_ingresar_compra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar_compra.Name = "btn_ingresar_compra";
            this.btn_ingresar_compra.Size = new System.Drawing.Size(186, 26);
            this.btn_ingresar_compra.TabIndex = 18;
            this.btn_ingresar_compra.Text = "Ingresar compra";
            this.btn_ingresar_compra.UseVisualStyleBackColor = false;
            this.btn_ingresar_compra.Visible = false;
            this.btn_ingresar_compra.Click += new System.EventHandler(this.btn_ingresar_compra_Click);
            // 
            // btn_ingresar_venta
            // 
            this.btn_ingresar_venta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ingresar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_venta.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_ingresar_venta.Location = new System.Drawing.Point(497, 450);
            this.btn_ingresar_venta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar_venta.Name = "btn_ingresar_venta";
            this.btn_ingresar_venta.Size = new System.Drawing.Size(186, 26);
            this.btn_ingresar_venta.TabIndex = 19;
            this.btn_ingresar_venta.Text = "Ingresar venta";
            this.btn_ingresar_venta.UseVisualStyleBackColor = false;
            this.btn_ingresar_venta.Visible = false;
            this.btn_ingresar_venta.Click += new System.EventHandler(this.btn_ingresar_venta_Click);
            // 
            // btn_DevoclucionSC
            // 
            this.btn_DevoclucionSC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DevoclucionSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DevoclucionSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DevoclucionSC.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_DevoclucionSC.Location = new System.Drawing.Point(497, 450);
            this.btn_DevoclucionSC.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DevoclucionSC.Name = "btn_DevoclucionSC";
            this.btn_DevoclucionSC.Size = new System.Drawing.Size(186, 26);
            this.btn_DevoclucionSC.TabIndex = 20;
            this.btn_DevoclucionSC.Text = "Ingresar Devolución S/C";
            this.btn_DevoclucionSC.UseVisualStyleBackColor = false;
            this.btn_DevoclucionSC.Visible = false;
            this.btn_DevoclucionSC.Click += new System.EventHandler(this.btn_DevoclucionSC_Click);
            // 
            // btn_DevolucionSV
            // 
            this.btn_DevolucionSV.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DevolucionSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DevolucionSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DevolucionSV.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_DevolucionSV.Location = new System.Drawing.Point(497, 450);
            this.btn_DevolucionSV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DevolucionSV.Name = "btn_DevolucionSV";
            this.btn_DevolucionSV.Size = new System.Drawing.Size(186, 26);
            this.btn_DevolucionSV.TabIndex = 21;
            this.btn_DevolucionSV.Text = "Ingresar Devolución S/V";
            this.btn_DevolucionSV.UseVisualStyleBackColor = false;
            this.btn_DevolucionSV.Visible = false;
            this.btn_DevolucionSV.Click += new System.EventHandler(this.btn_DevolucionSV_Click);
            // 
            // txt_devolucion_compra
            // 
            this.txt_devolucion_compra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_devolucion_compra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_devolucion_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devolucion_compra.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_devolucion_compra.Location = new System.Drawing.Point(99, 407);
            this.txt_devolucion_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_devolucion_compra.Name = "txt_devolucion_compra";
            this.txt_devolucion_compra.Size = new System.Drawing.Size(140, 21);
            this.txt_devolucion_compra.TabIndex = 22;
            this.txt_devolucion_compra.Text = "Cantidad";
            this.txt_devolucion_compra.Visible = false;
            this.txt_devolucion_compra.Click += new System.EventHandler(this.txt_devolucion_compra_Click);
            this.txt_devolucion_compra.TextChanged += new System.EventHandler(this.txt_devolucion_compra_TextChanged);
            this.txt_devolucion_compra.Leave += new System.EventHandler(this.txt_devolucion_compra_Leave);
            // 
            // txt_devolucion_venta
            // 
            this.txt_devolucion_venta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_devolucion_venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_devolucion_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devolucion_venta.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_devolucion_venta.Location = new System.Drawing.Point(99, 407);
            this.txt_devolucion_venta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_devolucion_venta.Name = "txt_devolucion_venta";
            this.txt_devolucion_venta.Size = new System.Drawing.Size(140, 21);
            this.txt_devolucion_venta.TabIndex = 23;
            this.txt_devolucion_venta.Text = "Cantidad";
            this.txt_devolucion_venta.Visible = false;
            this.txt_devolucion_venta.Click += new System.EventHandler(this.txt_devolucion_venta_Click);
            this.txt_devolucion_venta.TextChanged += new System.EventHandler(this.txt_devolucion_venta_TextChanged);
            this.txt_devolucion_venta.Leave += new System.EventHandler(this.txt_devolucion_venta_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(25, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Resultado total actualizado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Honeydew;
            this.button2.Location = new System.Drawing.Point(121, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 26);
            this.button2.TabIndex = 25;
            this.button2.Text = "Mostrar datos completos ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_central.Controls.Add(this.panel1);
            this.panel_central.Controls.Add(this.panel_titulo_exis);
            this.panel_central.Controls.Add(this.label2);
            this.panel_central.Controls.Add(this.label1);
            this.panel_central.Controls.Add(this.button1);
            this.panel_central.Controls.Add(this.btn_DevolucionSV);
            this.panel_central.Controls.Add(this.btn_DevoclucionSC);
            this.panel_central.Controls.Add(this.btn_ingresar_venta);
            this.panel_central.Controls.Add(this.btn_ingresar_compra);
            this.panel_central.Controls.Add(this.btn_ingresar_saldo);
            this.panel_central.Controls.Add(this.DTG_datos);
            this.panel_central.Location = new System.Drawing.Point(-2, -2);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1081, 529);
            this.panel_central.TabIndex = 26;
            this.panel_central.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_central_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txt_saldo_costo_unitario);
            this.panel1.Controls.Add(this.icon_exit);
            this.panel1.Controls.Add(this.btn_venta);
            this.panel1.Controls.Add(this.btn_compra);
            this.panel1.Controls.Add(this.btn_devolucion_sobre_venta);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_devolucion_venta);
            this.panel1.Controls.Add(this.btn_devolucion_sobre_compra);
            this.panel1.Controls.Add(this.txt_devolucion_compra);
            this.panel1.Controls.Add(this.btn_saldo_inicial);
            this.panel1.Controls.Add(this.txt_saldo_cantidad);
            this.panel1.Controls.Add(this.txt_venta_cantidad);
            this.panel1.Controls.Add(this.txt_sobre_venta_cantidad);
            this.panel1.Controls.Add(this.txt_cantidad_compra);
            this.panel1.Controls.Add(this.txt_compra_costo_unitario);
            this.panel1.Controls.Add(this.txt_sobre_compra_cantidad);
            this.panel1.Location = new System.Drawing.Point(746, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 510);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Honeydew;
            this.button3.Location = new System.Drawing.Point(29, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 26);
            this.button3.TabIndex = 27;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // icon_exit
            // 
            this.icon_exit.BackgroundImage = global::contabilidad_inventario_mtod_peps.Properties.Resources.circulo_marca_x;
            this.icon_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_exit.Location = new System.Drawing.Point(293, 9);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(25, 25);
            this.icon_exit.TabIndex = 26;
            this.icon_exit.TabStop = false;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // panel_titulo_exis
            // 
            this.panel_titulo_exis.BackColor = System.Drawing.Color.Teal;
            this.panel_titulo_exis.Controls.Add(this.label4);
            this.panel_titulo_exis.Location = new System.Drawing.Point(25, 91);
            this.panel_titulo_exis.Name = "panel_titulo_exis";
            this.panel_titulo_exis.Size = new System.Drawing.Size(670, 37);
            this.panel_titulo_exis.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(262, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "En existencia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(475, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "PEPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Evaluación de Inventario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 508);
            this.Controls.Add(this.panel_central);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_datos)).EndInit();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_exit)).EndInit();
            this.panel_titulo_exis.ResumeLayout(false);
            this.panel_titulo_exis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.TextBox txt_venta_cantidad;
        private System.Windows.Forms.Button btn_devolucion_sobre_venta;
        private System.Windows.Forms.Button btn_devolucion_sobre_compra;
        private System.Windows.Forms.TextBox txt_sobre_venta_cantidad;
        private System.Windows.Forms.Button btn_saldo_inicial;
        private System.Windows.Forms.TextBox txt_cantidad_compra;
        private System.Windows.Forms.TextBox txt_compra_costo_unitario;
        private System.Windows.Forms.TextBox txt_sobre_compra_cantidad;
        private System.Windows.Forms.TextBox txt_saldo_costo_unitario;
        private System.Windows.Forms.TextBox txt_saldo_cantidad;
        private System.Windows.Forms.DataGridView DTG_datos;
        private System.Windows.Forms.Button btn_ingresar_saldo;
        private System.Windows.Forms.Button btn_ingresar_compra;
        private System.Windows.Forms.Button btn_ingresar_venta;
        private System.Windows.Forms.Button btn_DevoclucionSC;
        private System.Windows.Forms.Button btn_DevolucionSV;
        private System.Windows.Forms.TextBox txt_devolucion_compra;
        private System.Windows.Forms.TextBox txt_devolucion_venta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_titulo_exis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox icon_exit;
        private System.Windows.Forms.Button button3;
    }
}

