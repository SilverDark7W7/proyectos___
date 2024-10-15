
namespace contabilidad_inventario_mtod_peps
{
    partial class Datos_completos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTodosDatos = new System.Windows.Forms.DataGridView();
            this.btn_actua = new System.Windows.Forms.Button();
            this.icon_exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTodosDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTodosDatos
            // 
            this.dataTodosDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTodosDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTodosDatos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataTodosDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTodosDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTodosDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTodosDatos.ColumnHeadersHeight = 37;
            this.dataTodosDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTodosDatos.EnableHeadersVisualStyles = false;
            this.dataTodosDatos.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataTodosDatos.Location = new System.Drawing.Point(22, 70);
            this.dataTodosDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTodosDatos.Name = "dataTodosDatos";
            this.dataTodosDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTodosDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTodosDatos.RowHeadersVisible = false;
            this.dataTodosDatos.RowHeadersWidth = 62;
            this.dataTodosDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataTodosDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTodosDatos.RowTemplate.Height = 28;
            this.dataTodosDatos.Size = new System.Drawing.Size(1131, 429);
            this.dataTodosDatos.TabIndex = 10;
            this.dataTodosDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTodosDatos_CellContentClick);
            // 
            // btn_actua
            // 
            this.btn_actua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actua.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actua.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_actua.Location = new System.Drawing.Point(23, 10);
            this.btn_actua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_actua.Name = "btn_actua";
            this.btn_actua.Size = new System.Drawing.Size(150, 31);
            this.btn_actua.TabIndex = 26;
            this.btn_actua.Text = "Actualizar";
            this.btn_actua.UseVisualStyleBackColor = true;
            this.btn_actua.Click += new System.EventHandler(this.btn_actua_Click);
            // 
            // icon_exit
            // 
            this.icon_exit.BackgroundImage = global::contabilidad_inventario_mtod_peps.Properties.Resources.circulo_marca_x;
            this.icon_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_exit.Location = new System.Drawing.Point(1140, 10);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(25, 25);
            this.icon_exit.TabIndex = 27;
            this.icon_exit.TabStop = false;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.icon_exit);
            this.panel1.Controls.Add(this.btn_actua);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 49);
            this.panel1.TabIndex = 29;
            // 
            // Datos_completos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1174, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataTodosDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Datos_completos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos_completos";
            this.Load += new System.EventHandler(this.Datos_completos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTodosDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTodosDatos;
        private System.Windows.Forms.Button btn_actua;
        private System.Windows.Forms.PictureBox icon_exit;
        private System.Windows.Forms.Panel panel1;
    }
}